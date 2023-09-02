using UnityEngine;

namespace SunkenLandMenu
{

    public class Hack : MonoBehaviour
    {

        public bool infiniteStamina = false;
        public bool InfiniteHealth = false;
        public bool infiniteFoodAndWater = false;
        public bool infiniteOxigen = false;
        public bool godMode = false;
        public bool perfectBodyTemp = false;

        public bool menu = false;
        PlayerCharacter character = FindObjectOfType<PlayerCharacter>();
        UIGameMenu cheats = new UIGameMenu();


        // ESP toggles

        bool espMain = false;



        public void OnGUI()
        {
            if (menu)
            {
                GUI.BeginGroup(new Rect(200f, 200f, 400, 600));
                GUI.Box(new Rect(0, 0, 400, 600), "Sunkenland Menu Alpha 0.12");

                if(GUI.Button(new Rect(50f, 40f, 200f, 30f),"Infinite Stamina : " + infiniteStamina.ToString()))
                {
                    infiniteStamina = !infiniteStamina;
                }

                if (GUI.Button(new Rect(50f, 80f, 200f, 30f), "Infinite Food / Water : " + infiniteFoodAndWater.ToString()))
                {
                    infiniteFoodAndWater = !infiniteFoodAndWater;
                }

                if (GUI.Button(new Rect(50f, 120f, 200f, 30f), "Infinite Air : " + infiniteOxigen.ToString()))
                {
                    infiniteOxigen = !infiniteOxigen;
                }
                
                if (GUI.Button(new Rect(50f, 160f, 200f, 30f), "Infinite Health : " + InfiniteHealth.ToString()))
                {
                    InfiniteHealth = !InfiniteHealth;
                }
                if (GUI.Button(new Rect(50f, 200f, 200f, 30f), "Perfect Body Temp : " + perfectBodyTemp.ToString()))
                {
                    perfectBodyTemp = !perfectBodyTemp;
                }

                if (GUI.Button(new Rect(50f, 240f, 200f, 30f), "All Cheats : " + godMode.ToString()))
                {
                    godMode = !godMode;
                }


                if (GUI.Button(new Rect(50f, 280f, 200f, 30f), "Free Build : " + Global.code.FreeBuild.ToString()))
                {
                    cheats.CheatFreeBuilding();
                }


                if (GUI.Button(new Rect(50f, 320f, 200f, 30f), "Unlock All Research"))
                {
                    cheats.CheatFreeResearch();
                }

                if (GUI.Button(new Rect(50f, 360f, 200f, 30f), "One shot Damages"))
                {
                    cheats.MillionDamage();
                }

                //if (GUI.Button(new Rect(50f, 400f, 200f, 30f), "Cinematic Camera"))
                //{
                //    cheats.CinematicMode();
                //} Pas moyen de désactiver




                GUI.EndGroup();
            }

            if (espMain)
            {
                Character[] allCharacters = FindObjectsOfType<Character>();
                foreach (Character character in allCharacters)
                {
                    if (character == null) continue;
                    Esp.DrawESP(character);
                }
            }

        }

        public void Start()
        {

            //Do stuff here once for initialization
        }

        public void Update()
        {
            if (character == null)
            {
                return;
            }

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                 
                menu = !menu;

            }

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(0f, 0f, 3f));
            }

            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(0f, 0f, -3f));
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(-3f, 0f, 0f));
            }

            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(3f, 0f, 0f));
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(0f, 3f, 0f));
            }

            if (Input.GetKeyDown(KeyCode.RightControl))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.PushBoat(new Vector3(0f, -3f, 0f));
            }






            if (infiniteStamina)
            {
                Stats.InfiniteStamina();
            }

            if (infiniteFoodAndWater)
            {
                Stats.InfiniteFoodAndWater();
            }

            if (infiniteOxigen)
            {
                Stats.InfiniteAir();
            }

            if (InfiniteHealth)
            {
                Stats.InfiniteHealth();
            }

            if (godMode)
            {
                Stats.GodMode();
            }

            if (perfectBodyTemp)
            {
                Stats.PerfectBodyTemperature();
            }

            



            //ESP

            if (Input.GetKeyDown(KeyCode.F1))
            {
                espMain = !espMain;
            }


        }


    }
}
