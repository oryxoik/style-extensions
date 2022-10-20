using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T AbsolutePosition<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.position = UnityEngine.UIElements.Position.Absolute;
            return visualElement;
        }

        public static T RelativePosition<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.position = UnityEngine.UIElements.Position.Absolute;
            return visualElement;
        }

        public static T Position<T>(this T visualElement, float position) where T : VisualElement
        {
            return Position(visualElement, position, position);
        }

        public static T Position<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return Position(visualElement, topBottom, leftRight, topBottom);
        }

        public static T Position<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return Position(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T Position<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.top = new Length(top, LengthUnit.Pixel);
            visualElement.style.bottom = new Length(bottom, LengthUnit.Pixel);
            visualElement.style.left = new Length(left, LengthUnit.Pixel);
            visualElement.style.right = new Length(right, LengthUnit.Pixel);

            return visualElement;
        }

        public static T PositionPercent<T>(this T visualElement, float position) where T : VisualElement
        {
            return PositionPercent(visualElement, position, position);
        }

        public static T PositionPercent<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return PositionPercent(visualElement, topBottom, leftRight, topBottom);
        }

        public static T PositionPercent<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return PositionPercent(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T PositionPercent<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.top = new Length(top, LengthUnit.Percent);
            visualElement.style.bottom = new Length(bottom, LengthUnit.Percent);
            visualElement.style.left = new Length(left, LengthUnit.Percent);
            visualElement.style.right = new Length(right, LengthUnit.Percent);

            return visualElement;
        }
    }
}