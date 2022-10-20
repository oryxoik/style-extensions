using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        private static Color HexToColor(string hex)
        {
            if (!hex.StartsWith("#") && !hex.StartsWith("0x"))
                hex = hex.Insert(0, "#");

            hex = hex.Replace("0x", "#"); //in case the string is formatted 0xFFFFFF

            if (ColorUtility.TryParseHtmlString(hex, out var color))
                return color;

            return UnityEngine.Color.white;
        }

        private static void SetWithStyleKeyword(StyleLength style, StyleKeyword value)
        {
            var v = value == StyleKeyword.Auto
                ? UnityEngine.UIElements.StyleKeyword.Auto
                : UnityEngine.UIElements.StyleKeyword.Initial;

            style = new StyleLength(v);
        }
    }

    public enum StyleKeyword { Auto, Initial }
}