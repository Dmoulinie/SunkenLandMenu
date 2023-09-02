using UnityEngine;
namespace SunkenLandMenu
{
    class Loader
    {
        public static void Init()
        {

            Loader.Load = new GameObject();
            Loader.Load.AddComponent<Hack>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }

        private static GameObject Load;
    }
}
