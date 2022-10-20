using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Padding<T>(this T visualElement, float padding) where T : VisualElement
        {
            return Padding(visualElement, padding, padding);
        }

        public static T Padding<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return Padding(visualElement, topBottom, leftRight, topBottom);
        }

        public static T Padding<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return Padding(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T Padding<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.paddingTop = new Length(top, LengthUnit.Pixel);
            visualElement.style.paddingBottom = new Length(bottom, LengthUnit.Pixel);
            visualElement.style.paddingLeft = new Length(left, LengthUnit.Pixel);
            visualElement.style.paddingRight = new Length(right, LengthUnit.Pixel);

            return visualElement;
        }

        public static T PaddingPercent<T>(this T visualElement, float padding) where T : VisualElement
        {
            return PaddingPercent(visualElement, padding, padding);
        }

        public static T PaddingPercent<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return PaddingPercent(visualElement, topBottom, leftRight, topBottom);
        }

        public static T PaddingPercent<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return PaddingPercent(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T PaddingPercent<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.paddingTop = new Length(top, LengthUnit.Percent);
            visualElement.style.paddingBottom = new Length(bottom, LengthUnit.Percent);
            visualElement.style.paddingLeft = new Length(left, LengthUnit.Percent);
            visualElement.style.paddingRight = new Length(right, LengthUnit.Percent);

            return visualElement;
        }
    }
}