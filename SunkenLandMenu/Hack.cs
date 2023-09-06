using System;
using System.Collections.Generic;
using UnityEngine;


namespace SunkenLandMenu
{

    public class Hack : MonoBehaviour
    {


        // Style Import
        Style styles = new Style();

        public bool freeBuildPrev = false;
        public bool unlockAllResearchPrev = false;

        // Fly
        public bool flyHack = false;
        public float currentPosY;



        // Buttons  | Red = false / Green = true
        public bool infiniteStaminaButtonColor = false;
        public bool infiniteHealthButtonColor = false;
        public bool infiniteFoodAndWaterButtonColor = false;
        public bool infiniteAirButtonColor = false;
        public bool perfectbodyTempButtonColor = false;
        public bool freeBuildButtonColor = false;
        public bool unlockAllResearchButtonColor = false;
        public bool millionDamageButtonColor = false;


        public bool espButtonColor = false;
        public bool linesButtonColor = false;
        public bool ennemiesButtonColor = false;

        // Buttons styles
        GUIStyle infiniteStaminaStyle = new GUIStyle();
        GUIStyle infiniteFoodAndWaterStyle = new GUIStyle();
        GUIStyle infiniteAirStyle = new GUIStyle();
        GUIStyle infiniteHealthStyle = new GUIStyle();
        GUIStyle perfectBodyTempStyle = new GUIStyle();
        GUIStyle freeBuildStyle = new GUIStyle();
        GUIStyle unlockAllResearchStyle = new GUIStyle();
        GUIStyle subCategoryStyle = new GUIStyle();
        GUIStyle bar = new GUIStyle();
        GUIStyle millionDamageStyle = new GUIStyle();
        GUIStyle ennemiesStyle = new GUIStyle();

        GUIStyle espActivateStyle = new GUIStyle();
        GUIStyle linesStyle = new GUIStyle();


        // Settings
        Settings Settings = new Settings();

        // References to tabs
        PlayerCharacter character = FindObjectOfType<PlayerCharacter>();
        UIGameMenu cheats = new UIGameMenu();



        // Teleport
        Vector3 savedCoordinates = Vector3.zero;


        // Tabs
        bool hacksTab = true;
        bool teleportTab = false;

        public void Start()
        {
            infiniteStaminaStyle = styles.checkboxStyle();
            infiniteFoodAndWaterStyle = styles.checkboxStyle();
            infiniteAirStyle = styles.checkboxStyle();
            infiniteHealthStyle = styles.checkboxStyle();
            perfectBodyTempStyle = styles.checkboxStyle();
            freeBuildStyle = styles.checkboxStyle();
            unlockAllResearchStyle = styles.checkboxStyle();
            millionDamageStyle = styles.checkboxStyle();
            subCategoryStyle = styles.subCategoryStyle();
            bar = styles.bar();
            //esp
            espActivateStyle = styles.checkboxStyle();
            linesStyle = styles.checkboxStyle();
            ennemiesStyle = styles.checkboxStyle();

            //noclip
        }

        public void OnGUI()
        {   
            if (Settings.noClip)
            {
                GUI.Label(new Rect(0, 0, 100, 100), "Fly hack enabled");
            }

            if (Settings.menu)
            {
                GUI.BeginGroup(new Rect(200f, 200f, 500, 600));

                GUI.Box(new Rect(0, 0, 500, 600), "Sunkenland Menu Alpha v0.20", styles.mainBox());

                if (GUI.Button(new Rect(0, 30f, 250, 30), "Hacks"/*,tabButtonStyle*/))
                {

                }

                if (GUI.Button(new Rect(250f, 30f, 250, 30), "Hotkeys"/*,tabButtonStyle*/))
                {

                }


                if (hacksTab)
                {

                    //Hacks
                    GUI.Label(new Rect(0, 60, 250, 30), "Main hacks", subCategoryStyle);
                    GUI.Label(new Rect(249, 90, 3, 360), "", bar);
                    Settings.stamina = GUI.Toggle(new Rect(35f, 100f, 180f, 30f), Settings.stamina, "Infinite stamina", infiniteStaminaStyle);
                    Settings.foodAndWater = GUI.Toggle(new Rect(35f, 140f, 180f, 30f), Settings.foodAndWater, "Infinite food/water", infiniteFoodAndWaterStyle);
                    Settings.air = GUI.Toggle(new Rect(35f, 180f, 180f, 30f), Settings.air, "Infinite Air", infiniteAirStyle);
                    Settings.health = GUI.Toggle(new Rect(35f, 220f, 180f, 30f), Settings.health, "Infinite Health", infiniteHealthStyle);
                    Settings.bodyTemp = GUI.Toggle(new Rect(35f, 260f, 180f, 30f), Settings.bodyTemp, "Perfect Body Temp", perfectBodyTempStyle);
                    Settings.freeBuild = GUI.Toggle(new Rect(35f, 300f, 180f, 30f), Settings.freeBuild, "Free Build", freeBuildStyle);
                    Settings.allResearch = GUI.Toggle(new Rect(35f, 340f, 180f, 30f), Settings.allResearch, "All Research", unlockAllResearchStyle);
                    Settings.millionDamage = GUI.Toggle(new Rect(35f, 380f, 180, 30f), Settings.millionDamage, "Million Damage", millionDamageStyle);

                    // Esp
                    GUI.Label(new Rect(250, 60, 250, 30), "ESP (Wallhack)", subCategoryStyle);

                    Settings.esp = GUI.Toggle(new Rect(265, 100, 180f, 30f), Settings.esp, "Activate", espActivateStyle);
                    Settings.lines = GUI.Toggle(new Rect(265, 140, 180f, 30f), Settings.lines, "Lines", linesStyle);
                    //GUIStyle slider = new GUIStyle();
                    //GUIStyle sliderThumb = new GUIStyle();
                    Settings.ennemies = GUI.Toggle(new Rect(265, 180, 180, 30), Settings.ennemies, "Ennemies ["+ Math.Ceiling(Settings.maxDistance).ToString()+"m]", ennemiesStyle);
                    Settings.maxDistance = GUI.HorizontalSlider(new Rect(265, 220, 180, 30), Settings.maxDistance, 0f, 500f);


                    //Teleport
                    GUI.Label(new Rect(0, 420, 500, 30), "Teleport", subCategoryStyle);

                }



                if (teleportTab)
                {
                    if (GUI.Button(new Rect(30f, 400f, 200f, 30f), "Save"))
                    {
                        savedCoordinates = FPSPlayer.code.transform.position;
                    }

                    if (GUI.Button(new Rect(30f, 440f, 200f, 30f), "Teleport"))
                    {
                        FPSPlayer.code.transform.position = savedCoordinates;
                    }
                }




                //if (GUI.Button(new Rect(30f, 400f, 200f, 30f), "Cinematic Camera"))
                //{
                //    cheats.CinematicMode();
                //} Pas moyen de désactiver




                GUI.EndGroup();
            }


            if (Settings.esp)
            {
                if (Settings.ennemies)
                {
                    foreach (Transform Enemies in WorldScene.code.allCharacters.items)
                    {
                        if (!Enemies) continue;
                        Character characterComponent = Enemies.GetComponent<Character>();
                        if (characterComponent != null)
                        {
                            Esp.DrawESP(characterComponent, Settings.lines, Settings.maxDistance);
                        }
                    }
                }
            }

        }                //foreach (Transform player in WorldScene.code.allPlayerDummies.items)
                         //{
                         //    if (!player) continue;
                         //      allPlayerDummies
                         //}



        public void Update()
        {
            if (character == null)
            {
                return;
            }

            checkButtonsColors();

            if (Input.GetKeyDown(KeyCode.F4))
            {
                Settings.noClip = !Settings.noClip;
            }


            if (Input.GetKeyDown(KeyCode.F2))
            {
                Settings.noRecoil = !Settings.noRecoil;
            }



            if (Input.GetKeyDown(KeyCode.Insert))
            {
                Settings.menu = !Settings.menu;
            }


            if (Input.GetKey(KeyCode.F3))
            {
                List<Boat> Allboats = Global.code.AllBoat;
                foreach (Boat boat in Allboats)
                {
                    if (Global.code.Player.drivingObject == boat) { continue; }
                    boat.RPC_PushBoat(new Vector3(0f, 1000f, 0f));
                }
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(0f, 0f, 500f));
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(0f, 0f, -500f));
            }

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(-500f, 0f, 0f));
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(500f, 0f, 0f));
            }

            if (Input.GetKey(KeyCode.RightShift))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(0f, 500f, 0f));
            }

            if (Input.GetKey(KeyCode.RightControl))
            {
                Boat boat = Global.code.Player.drivingObject;
                if (boat == null) { return; }
                boat.RPC_PushBoat(new Vector3(0f, -500f, 0f));
            }



            if (Settings.noClip)
            {
                if (FPSPlayer.code is null)
                {
                    return;
                }
                if (!Input.anyKey) return;

                Transform player = FPSPlayer.code.transform;
                Transform camera = FPSPlayer.code.CameraControlComponent.transform;

                float forwardMultiplier = GetKey(KeyCode.Z) - GetKey(KeyCode.S);
                float rightMultiplier = GetKey(KeyCode.D) - GetKey(KeyCode.Q);
                float upMultiplier = GetKey(KeyCode.Space) - GetKey(KeyCode.LeftControl);
                float speed = 25f + (25f * GetKey(KeyCode.LeftShift));

                var direction = (player.up * upMultiplier) + (camera.forward * forwardMultiplier) + (camera.right * rightMultiplier);

                var displacement = direction.normalized * speed * Time.deltaTime;

                player.position += displacement;
                var PlayerController = FPSPlayer.code.GetComponent<FPSRigidBodyWalker>();
                if (PlayerController != null)
                {
                    PlayerController.enabled = false;
                }
            } else
            {
                var PlayerController = FPSPlayer.code.GetComponent<FPSRigidBodyWalker>();
                {
                    PlayerController.enabled = true;
                }
            }

            if (Settings.stamina)
            {
                Stats.InfiniteStamina();
            }

            if (Settings.foodAndWater)
            {
                Stats.InfiniteFoodAndWater();
            }

            if (Settings.air)
            {
                Stats.InfiniteAir();
            }

            if (Settings.health)
            {
                Stats.InfiniteHealth();
            }


            if (Settings.bodyTemp)
            {
                Stats.PerfectBodyTemperature();
            }

            //Weapons
            if (Settings.noRecoil)
            {
                Stats.NoRecoil();
            } else
            {
                Stats.RecoilEnable();
            }
             


            if (Settings.freeBuild != freeBuildPrev)
            {
                if (Settings.freeBuild)
                {
                    Global.code.FreeBuild = true;
                    styles.changeBackgroundColorToGreen(freeBuildStyle);
                }
                else
                {
                    Global.code.FreeBuild = false;
                    styles.changeBackgroundColorToRed(freeBuildStyle);
                }
                freeBuildPrev = Settings.freeBuild;
            }

            if (Settings.allResearch != unlockAllResearchPrev)
            {
                if (Settings.allResearch)
                {
                    Global.code.UnLockAllResearch = true;
                    freeBuildButtonColor = true;
                    styles.changeBackgroundColorToGreen(unlockAllResearchStyle);


                }
                else
                {
                    Global.code.UnLockAllResearch = false;
                    freeBuildButtonColor = false;
                    styles.changeBackgroundColorToRed(unlockAllResearchStyle);

                }
                unlockAllResearchPrev = Settings.allResearch;
            }

            if (Settings.millionDamage)
            {
                Stats.MillionDamage();
            }

        }

        public void checkButtonsColors()
        {
            
            if (Settings.stamina)
            {
                if (infiniteStaminaButtonColor == false)
                {
                    infiniteStaminaButtonColor = true;
                    styles.changeBackgroundColorToGreen(infiniteStaminaStyle);

                }
            }
            else
            {
                if (infiniteStaminaButtonColor)
                {
                    infiniteStaminaButtonColor = false;
                    styles.changeBackgroundColorToRed(infiniteStaminaStyle);

                }
            }

            if (Settings.foodAndWater)
            {
                if (infiniteFoodAndWaterButtonColor == false)
                {
                    infiniteFoodAndWaterButtonColor = true;
                    styles.changeBackgroundColorToGreen(infiniteFoodAndWaterStyle);

                }
            }
            else
            {
                if (infiniteFoodAndWaterButtonColor)
                {
                    infiniteFoodAndWaterButtonColor = false;
                    styles.changeBackgroundColorToRed(infiniteFoodAndWaterStyle);

                }
            }

            if (Settings.air)
            {
                if (infiniteAirButtonColor == false)
                {
                    infiniteAirButtonColor = true;
                    styles.changeBackgroundColorToGreen(infiniteAirStyle);

                }
            }
            else
            {
                if (infiniteAirButtonColor)
                {
                    infiniteAirButtonColor = false;
                    styles.changeBackgroundColorToRed(infiniteAirStyle);


                }
            }

            if (Settings.health)
            {
                if (infiniteHealthButtonColor == false)
                {
                    infiniteHealthButtonColor = true;
                    styles.changeBackgroundColorToGreen(infiniteHealthStyle);

                }
            }
            else
            {
                if (infiniteHealthButtonColor)
                {
                    infiniteHealthButtonColor = false;
                    styles.changeBackgroundColorToRed(infiniteHealthStyle);


                }
            }

            if (Settings.bodyTemp)
            {
                if (perfectbodyTempButtonColor == false)
                {
                    perfectbodyTempButtonColor = true;
                    styles.changeBackgroundColorToGreen(perfectBodyTempStyle);

                }
            }
            else
            {
                if (perfectbodyTempButtonColor)
                {
                    perfectbodyTempButtonColor = false;
                    styles.changeBackgroundColorToRed(perfectBodyTempStyle);


                }
            }

            if (Settings.esp)
            {
                if (espButtonColor == false)
                {
                    espButtonColor = true;
                    styles.changeBackgroundColorToGreen(espActivateStyle);

                }
            }
            else
            {
                if (espButtonColor)
                {
                    espButtonColor = false;
                    styles.changeBackgroundColorToRed(espActivateStyle);
                }
            }

            if (Settings.lines)
            {
                if (linesButtonColor == false)
                {
                    linesButtonColor = true;
                    styles.changeBackgroundColorToGreen(linesStyle);

                }
            }
            else
            {
                if (linesButtonColor)
                {
                    linesButtonColor = false;
                    styles.changeBackgroundColorToRed(linesStyle);
                }
            }

            if (Settings.ennemies)
            {
                if (ennemiesButtonColor == false)
                {
                    ennemiesButtonColor = true;
                    styles.changeBackgroundColorToGreen(ennemiesStyle);

                }
            }
            else
            {
                if (ennemiesButtonColor)
                {
                    ennemiesButtonColor = false;
                    styles.changeBackgroundColorToRed(ennemiesStyle);
                }
            }

            if (Settings.millionDamage)
            {
                if (millionDamageButtonColor == false)
                {
                    millionDamageButtonColor= true;
                    styles.changeBackgroundColorToGreen(millionDamageStyle);

                }
            }
            else
            {
                if (millionDamageButtonColor)
                {
                    millionDamageButtonColor = false;
                    styles.changeBackgroundColorToRed(millionDamageStyle);
                }
            }

            

        }
        private static float GetKey(KeyCode key) => Input.GetKey(key) ? 1f : 0f;
    }

}
