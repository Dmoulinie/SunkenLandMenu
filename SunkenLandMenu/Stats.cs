using Photon.Realtime;
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

        public static void MillionDamage()
        {
            if (Global.code.Player.weaponInHand == null)
            {
                return;
            }
            Global.code.Player.weaponInHand.damage = 1000000f;
        }

        public static void NoRecoil()
        {

            PlayerCharacter player = Global.code.Player;
            if (Global.code.Player.weaponInHand == null)
            {
                return;
            }
            player.weaponInHand.verticalKick = 0f;
            player.weaponInHand.viewClimbSide = 0f;
            player.weaponInHand.viewClimbUp = 0f;
            player.weaponInHand.horizontalKick = 0f;
            player.weaponInHand.recoil = 0f;
            player.weaponInHand.canFireUnderwater = true;
            //player.weaponInHand.curMag = player.weaponInHand.magSize;
        }
    
        public static void RecoilEnable()
        {
            PlayerCharacter player = Global.code.Player;
            if (Global.code.Player.weaponInHand == null)
            {
                return;
            }
            player.weaponInHand.horizontalKick = 2f;
            player.weaponInHand.verticalKick = 3f;
            player.weaponInHand.viewClimbSide = 0.5f;
            player.weaponInHand.viewClimbUp = 1f;
            player.weaponInHand.recoil = 0.5f;
            player.weaponInHand.canFireUnderwater = false;
        }
    }

}
