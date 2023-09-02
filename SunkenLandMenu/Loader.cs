using UnityEngine;

namespace SunkenLandMenu
{
    class Loader
    {
        static void Init()
        {

            Loader.Load = new GameObject();
            Loader.Load.AddComponent<Hack>();
            UnityEngine.Object.DontDestroyOnLoad(Loader.Load);
        }

        static void Unload()
        {
            GameObject.Destroy(Load);
        }

        private static GameObject Load;

    }
}
