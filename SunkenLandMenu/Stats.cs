using UnityEngine;

namespace SunkenLandMenu
{

    public class Stats : MonoBehaviour
    {
        public static void InfiniteStamina(PlayerCharacter character)
        {
            character.Stamina = 100f;
            character.MaxEnergy = 100f;
        }

        public static void InfiniteHealth(PlayerCharacter character)
        {
            character.Health = 1000f;
        }

        public static void InfiniteFoodAndWater(PlayerCharacter character)
        {
            character.Hunger = 100f;
            character.Thirst = 100f;
        }

        public static void InfiniteAir(PlayerCharacter character)
        {
            character.Air = character.MaxAir;
        }

    }
}
