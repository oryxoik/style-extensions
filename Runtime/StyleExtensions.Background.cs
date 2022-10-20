using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Background<T>(this T visualElement, Color color) where T : VisualElement
        {
            visualElement.style.backgroundColor = color;
            return visualElement;
        }

        public static T Background<T>(this T visualElement, string color) where T : VisualElement
        {
            visualElement.style.backgroundColor = HexToColor(color);
            return visualElement;
        }

        public static T Background<T>(this T visualElement, Sprite image) where T : VisualElement
        {
            visualElement.style.backgroundImage = new StyleBackground(image);
            return visualElement;
        }

        public static T Background<T>(this T visualElement, Texture2D image) where T : VisualElement
        {
            visualElement.style.backgroundImage = new StyleBackground(image);
            return visualElement;
        }

        public static T Background<T>(this T visualElement, Color color, Sprite image) where T : VisualElement
        {
            return visualElement.Background(color).Background(image);
        }

        public static T Background<T>(this T visualElement, string color, Sprite image) where T : VisualElement
        {
            return visualElement.Background(color).Background(image);
        }

        public static T Background<T>(this T visualElement, Color color, Texture2D image) where T : VisualElement
        {
            return visualElement.Background(color).Background(image);
        }

        public static T Background<T>(this T visualElement, string color, Texture2D image) where T : VisualElement
        {
            return visualElement.Background(color).Background(image);
        }

        public static T BackgroundImageTint<T>(this T visualElement, Color color) where T : VisualElement
        {
            visualElement.style.unityBackgroundImageTintColor = color;
            return visualElement;
        }

        public static T BackgroundImageTint<T>(this T visualElement, string color) where T : VisualElement
        {
            visualElement.style.unityBackgroundImageTintColor = HexToColor(color);
            return visualElement;
        }

        public static T BackgroundScaleMode<T>(this T visualElement, ScaleMode scaleMode) where T : VisualElement
        {
            visualElement.style.unityBackgroundScaleMode = scaleMode;
            return visualElement;
        }
    }
}