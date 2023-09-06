using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunkenLandMenu
{
    internal class Settings
    {

        //Main menu
        public bool menu;

        //ESP
        public bool esp;
        public bool lines;
        public bool ennemies;
        public float maxDistance;

        //NOCLIP
        public bool noClip;

        //STATS
        public bool stamina;
        public bool foodAndWater;
        public bool air;
        public bool health;
        public bool bodyTemp;
        public bool freeBuild;
        public bool allResearch;
        public bool millionDamage;

        //WEAPONS
        public bool noRecoil;
        public bool noSpread; // TODO
        public bool noReload; // TODO
        public Settings() 
        {
            //MAIN MENU
            menu = false;


            //ESP
            esp = false;
            lines = false;
            ennemies = false;
            maxDistance = 100f;

            //NOCLIP
            noClip = false;

            //STATS
            stamina = false;
            foodAndWater = false;
            air = false;
            health = false;
            bodyTemp = false;
            freeBuild = false;
            allResearch = false;
            millionDamage = false;

            //WEAPONS
            noRecoil = false;
            noSpread = false;
            noReload = false;
        }

        
    }
}
