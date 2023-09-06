using System.Security.Permissions;
using UnityEngine;

namespace SunkenLandMenu
{
    internal class Teleport
    {
        Vector3 savedPosition;
        public void SaveCoordinates()
        {
            savedPosition = FPSPlayer.code.transform.position;
        }

        public void TeleportToSavedCoordinates()
        {
            FPSPlayer.code.transform.position = savedPosition;
        }
    }
}
