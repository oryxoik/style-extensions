using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Margin<T>(this T visualElement, float margin) where T : VisualElement
        {
            return Margin(visualElement, margin, margin);
        }

        public static T Margin<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return Margin(visualElement, topBottom, leftRight, topBottom);
        }

        public static T Margin<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return Margin(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T Margin<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.marginTop = new Length(top, LengthUnit.Pixel);
            visualElement.style.marginBottom = new Length(bottom, LengthUnit.Pixel);
            visualElement.style.marginLeft = new Length(left, LengthUnit.Pixel);
            visualElement.style.marginRight = new Length(right, LengthUnit.Pixel);

            return visualElement;
        }

        public static T MarginPercent<T>(this T visualElement, float margin) where T : VisualElement
        {
            return MarginPercent(visualElement, margin, margin);
        }

        public static T MarginPercent<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return MarginPercent(visualElement, topBottom, leftRight, topBottom);
        }

        public static T MarginPercent<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return MarginPercent(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T MarginPercent<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.marginTop = new Length(top, LengthUnit.Percent);
            visualElement.style.marginBottom = new Length(bottom, LengthUnit.Percent);
            visualElement.style.marginLeft = new Length(left, LengthUnit.Percent);
            visualElement.style.marginRight = new Length(right, LengthUnit.Percent);

            return visualElement;
        }
    }
}