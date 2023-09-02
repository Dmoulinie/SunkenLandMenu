using UnityEngine;
using UnityEngine.TextCore.Text;

namespace SunkenLandMenu
{

    public class Hack : MonoBehaviour
    {

        public bool infiniteStamina = false;
        public bool infiniteHealth = false;
        public bool infiniteFoodAndWater = false;
        public bool infiniteOxigen = false;

        public bool menu = false;
        PlayerCharacter character = FindObjectOfType<PlayerCharacter>();
        

        public void OnGUI()
        {
            if (menu)
            {
                GUI.Box(new Rect(150f, 150f, 150f, 150f),"Menu");
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

            if (Input.GetKeyDown(KeyCode.F7))
            {
                Boat boat = Global.code.Player.drivingObject;
                boat.PushBoat(new Vector3(10f, 10f, 0f));
            }

            if (Input.GetKeyDown(KeyCode.Insert))
            {
                menu = !menu;
            }

            if (Input.GetKeyDown(KeyCode.F1))
            {
                infiniteStamina = !infiniteStamina;
            }

            if (Input.GetKeyDown(KeyCode.F2))
            {
                infiniteFoodAndWater = !infiniteFoodAndWater;
            }

            if (Input.GetKey(KeyCode.F3))
            {
                infiniteHealth = !infiniteHealth;
            }

            if (Input.GetKey(KeyCode.F4))
            {
                infiniteOxigen = !infiniteOxigen;
            }





            if (infiniteStamina)
            {
                Stats.InfiniteStamina(character);
            }

            if (infiniteFoodAndWater)
            {
                Stats.InfiniteFoodAndWater(character);
            }

            if (infiniteHealth)
            {
                Stats.InfiniteHealth(character);
            }

            if (infiniteOxigen)
            {
                Stats.InfiniteAir(character);
            }



            if (Input.GetKeyDown(KeyCode.Delete))
            {
                Loader.Unload();
            }
        }


    }
}
