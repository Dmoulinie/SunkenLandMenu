using System.Security.Permissions;
using UnityEngine;

namespace SunkenLandMenu
{
    internal class Teleport
    {
        Vector3 savedPosition;
        public void SaveCoordinates()
        {
            savedPosition = Global.code.Player.transform.position;
            Debug.Log(savedPosition);
        }

        public void TeleportToSavedCoordinates()
        {
            Global.code.Player.transform.position = savedPosition;
        }
    }
}
