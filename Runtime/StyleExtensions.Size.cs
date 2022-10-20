using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        /// <summary>
        /// Sets the element's width to 100%
        /// </summary>
        public static T FullWidth<T>(this T visualElement) where T : VisualElement
        {
            return WidthPercent(visualElement, 100);
        }

        /// <summary>
        /// Sets the element's height to 100%
        /// </summary>
        public static T FullHeight<T>(this T visualElement) where T : VisualElement
        {
            return HeightPercent(visualElement, 100);
        }

        public static T Width<T>(this T visualElement, float width) where T : VisualElement
        {
            visualElement.style.width = new Length(width, LengthUnit.Pixel);
            return visualElement;
        }

        public static T Height<T>(this T visualElement, float height) where T : VisualElement
        {
            visualElement.style.height = new Length(height, LengthUnit.Pixel);
            return visualElement;
        }

        public static T MinWidth<T>(this T visualElement, float minWidth) where T : VisualElement
        {
            visualElement.style.minWidth = new Length(minWidth, LengthUnit.Pixel);
            return visualElement;
        }

        public static T MinHeight<T>(this T visualElement, float minHeight) where T : VisualElement
        {
            visualElement.style.minHeight = new Length(minHeight, LengthUnit.Pixel);
            return visualElement;
        }

        public static T MaxWidth<T>(this T visualElement, float maxWidth) where T : VisualElement
        {
            visualElement.style.maxWidth = new Length(maxWidth, LengthUnit.Pixel);
            return visualElement;
        }

        public static T MaxHeight<T>(this T visualElement, float maxHeight) where T : VisualElement
        {
            visualElement.style.maxHeight = new Length(maxHeight, LengthUnit.Pixel);
            return visualElement;
        }

        public static T Width<T>(this T visualElement, StyleKeyword width) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.width, width);
            return visualElement;
        }

        public static T Height<T>(this T visualElement, StyleKeyword height) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.height, height);
            return visualElement;
        }

        public static T MinWidth<T>(this T visualElement, StyleKeyword minWidth) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.minWidth, minWidth);
            return visualElement;
        }

        public static T MinHeight<T>(this T visualElement, StyleKeyword minHeight) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.minHeight, minHeight);
            return visualElement;
        }

        public static T MaxWidth<T>(this T visualElement, StyleKeyword maxWidth) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.maxWidth, maxWidth);
            return visualElement;
        }

        public static T MaxHeight<T>(this T visualElement, StyleKeyword maxHeight) where T : VisualElement
        {
            SetWithStyleKeyword(visualElement.style.maxHeight, maxHeight);
            return visualElement;
        }

        public static T WidthPercent<T>(this T visualElement, float width) where T : VisualElement
        {
            visualElement.style.width = new Length(width, LengthUnit.Percent);
            return visualElement;
        }

        public static T HeightPercent<T>(this T visualElement, float height) where T : VisualElement
        {
            visualElement.style.height = new Length(height, LengthUnit.Percent);
            return visualElement;
        }

        public static T MinWidthPercent<T>(this T visualElement, float minWidth) where T : VisualElement
        {
            visualElement.style.minWidth = new Length(minWidth, LengthUnit.Percent);
            return visualElement;
        }

        public static T MinHeighPercent<T>(this T visualElement, float minHeight) where T : VisualElement
        {
            visualElement.style.minHeight = new Length(minHeight, LengthUnit.Percent);
            return visualElement;
        }

        public static T MaxWidthPercent<T>(this T visualElement, float maxWidth) where T : VisualElement
        {
            visualElement.style.maxWidth = new Length(maxWidth, LengthUnit.Percent);
            return visualElement;
        }

        public static T MaxHeightPercent<T>(this T visualElement, float maxHeight) where T : VisualElement
        {
            visualElement.style.maxHeight = new Length(maxHeight, LengthUnit.Percent);
            return visualElement;
        }
    }
}