using UnityEngine;

namespace SunkenLandMenu
{
    class Esp : MonoBehaviour
    {
        public Character[] GetAllCharacters()
        {
            Character[] allCharacters = FindObjectsOfType<Character>();
            return allCharacters;
        }

        public float GetCharacterHealth(Character character) 
        {
            return character.health;
        }


        public static void DrawESP(Character character, bool lines = false)
        {
            Vector3 lastPosition = Vector3.zero;

            Vector3 pivotPos = character.transform.position;
            int distanceToMob = (int)Vector3.Distance(pivotPos, Global.code.Player.transform.position);
            if (distanceToMob > 100 && lastPosition != pivotPos) {
                return;
            }

            Vector3 playerFootPos;
            playerFootPos.x = pivotPos.x;
            playerFootPos.y = pivotPos.y;
            playerFootPos.z = pivotPos.z;

            Vector3 playerHeadPos;
            playerHeadPos.x = pivotPos.x;
            playerHeadPos.y = pivotPos.y + 1.8f;
            playerHeadPos.z = pivotPos.z;
            
            //World to screen
            Vector3 w2s_footPos = Camera.main.WorldToScreenPoint(playerFootPos);
            Vector3 w2s_headPos = Camera.main.WorldToScreenPoint(playerHeadPos);

            float height = w2s_headPos.y - w2s_footPos.y;
            float widthOffset = 2f;
            float width = height / widthOffset;

            if (w2s_footPos.z > 2f )
            {
                Render.DrawBox(w2s_footPos.x - (width / 2), (float)Screen.height - w2s_footPos.y - height, width, height, Color.red, 2f);
                Vector2 centerScreen = new Vector2((float)Screen.width / 2, (float)Screen.height / 2);
                if (lines)
                {
                    Render.DrawLine(centerScreen, w2s_headPos,Color.red,1f) ;
                }
                lastPosition = pivotPos;

            }
        }



    }
}
