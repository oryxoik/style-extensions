using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Cursor<T>(this T visualElement, Texture2D cursor) where T : VisualElement
        {
            var cursorStyle = new UnityEngine.UIElements.Cursor();
            cursorStyle.hotspot = visualElement.style.cursor.value.hotspot;
            cursorStyle.texture = cursor;
            visualElement.style.cursor = cursorStyle;
            return visualElement;
        }
    }
}