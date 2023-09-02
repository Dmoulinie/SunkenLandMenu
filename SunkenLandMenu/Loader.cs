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

        public static void Unload()
        {
            _Unload();
        }

        private static void _Unload()
        {
            GameObject.Destroy(Load);
        }
        private static GameObject Load;

    }
}
