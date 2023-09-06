
using UnityEngine;
using UnityEngine.TextCore.Text;

namespace SunkenLandMenu
{
    internal class Style
    {
        public Color textColor = new Color(0.96f, 0.96f, 0.96f);
        public Color mainBoxBackground = new Color(0.207f, 0.184f, 0.26f, 0.7f);
        public Color buttonColor = new Color();
        public Color subCategory = new Color(0, 0, 0, 0.8f);

        // Color(0.62f,0.51f,0.90f);
        public GUIStyle mainBox()
        {
            GUIStyle mainBoxStyle = new GUIStyle(GUI.skin.box);
            mainBoxStyle.normal.background = MakeTex(2, 2, mainBoxBackground); // #352F44
            mainBoxStyle.normal.textColor = textColor; // Texte blanc
            mainBoxStyle.alignment = TextAnchor.UpperCenter; // Centre le texte
            mainBoxStyle.fontSize = 16; // Taille de la police
            return mainBoxStyle;
        }

        


        public GUIStyle checkboxStyle()
        {
            GUIStyle checkboxStyle = new GUIStyle();
            checkboxStyle.normal.background = MakeTex(2, 2, new Color(0.81f, 0.29f, 0.23f)); // Change the background color to blue
            checkboxStyle.fontSize = 16;
            checkboxStyle.normal.textColor = textColor;
            //checkboxStyle.fontStyle = FontStyle.Bold;
            checkboxStyle.alignment = TextAnchor.MiddleCenter;

            return checkboxStyle;
        }


        public GUIStyle tabButtonStyle()
        {
            GUIStyle tabButtonStyle = new GUIStyle();
            return tabButtonStyle;
        }


        public GUIStyle subCategoryStyle()
        {
            GUIStyle subCategoryStyle = new GUIStyle();
            subCategoryStyle.fontSize = 16;
            subCategoryStyle.normal.textColor = textColor;
            subCategoryStyle.alignment = TextAnchor.MiddleCenter;
            subCategoryStyle.normal.background = MakeTex(2, 2, Color.black);
            return subCategoryStyle;
        }

        public GUIStyle bar()
        {
            GUIStyle barStyle = new GUIStyle();
            barStyle.normal.background = MakeTex(2, 2, Color.black);
            return barStyle;
        }


        public void changebackgroundColor(GUIStyle style, Color color )
        {
            style.normal.background = MakeTex(2,2, color);
        }


        public void changeBackgroundColorToGreen(GUIStyle style)
        {
            style.normal.background = MakeTex(2, 2, new Color(0.63f, 0.77f, 0.47f)); // #A2C579
        }

        public void changeBackgroundColorToRed(GUIStyle style)
        {
            style.normal.background = MakeTex(2, 2, new Color(0.81f, 0.29f, 0.23f)); // #A2C579
        }




        private Texture2D MakeTex(int width, int height, Color color)
        {
            Color[] pix = new Color[width * height];
            for (int i = 0; i < pix.Length; i++)
            {
                pix[i] = color;
            }
            Texture2D result = new Texture2D(width, height);
            result.SetPixels(pix);
            result.Apply();
            return result;
        }
    }
}
