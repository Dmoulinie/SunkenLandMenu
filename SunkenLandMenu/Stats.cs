using UnityEngine;

namespace SunkenLandMenu
{

    public class Stats : MonoBehaviour
    {
        public static void InfiniteStamina()
        {
            Global.code.Player.Stamina = 100f;
            Global.code.Player.Energy = 100f;
        }

        public static void InfiniteHealth()
        {
            Global.code.Player.Health = 1000000f;
            Global.code.Player.MaxHealth = 1000000f;
        }

        public static void InfiniteFoodAndWater()
        {
            Global.code.Player.Hunger = 100f;
            Global.code.Player.Thirst = 100f;
        }

        public static void InfiniteAir()
        {
            Global.code.Player.Air = 1000000f;
            Global.code.Player.MaxAir = 1000000f;
        }

        public static void GodMode()
        {
            Global.code.Player.Health = 1000000f;
            Global.code.Player.MaxHealth = 1000000f;
            Global.code.Player.Energy = 100f;
            Global.code.Player.Stamina = 100f;
            Global.code.Player.Hunger = 100f;
            Global.code.Player.Thirst = 100f;
            Global.code.Player.Bleeding = 0f;
        }

        public static void PerfectBodyTemperature()
        {
            Global.code.Player.BodyTemperature = 100f;
        }
    }
}
