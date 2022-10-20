using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Border<T>(this T visualElement, float borderWidth) where T : VisualElement
        {
            return BorderWidth(visualElement, borderWidth);
        }

        public static T Border<T>(this T visualElement, float borderWidth, float borderRadius) where T : VisualElement
        {
            return BorderWidth(visualElement, borderWidth).BorderRadius(borderRadius);
        }

        public static T Border<T>(this T visualElement, float borderWidth, Color borderColor) where T : VisualElement
        {
            return BorderWidth(visualElement, borderWidth).BorderColor(borderColor);
        }

        public static T Border<T>(this T visualElement, float borderWidth, string borderColor) where T : VisualElement
        {
            return BorderWidth(visualElement, borderWidth).BorderColor(borderColor);
        }

        public static T Border<T>(this T visualElement, float borderWidth, float borderRadius, Color borderColor) where T : VisualElement
        {
            return Border(visualElement, borderWidth, borderColor).BorderRadius(borderRadius);
        }

        public static T Border<T>(this T visualElement, float borderWidth, float borderRadius, string borderColor) where T : VisualElement
        {
            return Border(visualElement, borderWidth, borderColor).BorderRadius(borderRadius);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, borderWidth);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth, float borderRadius) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, borderWidth).BorderRadiusPercent(borderRadius);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth, Color borderColor) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, borderWidth).BorderColor(borderColor);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth, string borderColor) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, borderWidth).BorderColor(borderColor);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth, float borderRadius, Color borderColor) where T : VisualElement
        {
            return Border(visualElement, borderWidth, borderColor).BorderRadiusPercent(borderRadius);
        }

        public static T BorderPercent<T>(this T visualElement, float borderWidth, float borderRadius, string borderColor) where T : VisualElement
        {
            return Border(visualElement, borderWidth, borderColor).BorderRadiusPercent(borderRadius);
        }

        #region BorderWidth

        public static T BorderWidth<T>(this T visualElement, float border) where T : VisualElement
        {
            return BorderWidth(visualElement, border, border);
        }

        public static T BorderWidth<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return BorderWidth(visualElement, topBottom, leftRight, topBottom);
        }

        public static T BorderWidth<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return BorderWidth(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T BorderWidth<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.borderTopWidth = top;
            visualElement.style.borderBottomWidth = bottom;
            visualElement.style.borderLeftWidth = left;
            visualElement.style.borderRightWidth = right;

            return visualElement;
        }

        public static T BorderWidthPercent<T>(this T visualElement, float border) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, border, border);
        }

        public static T BorderWidthPercent<T>(this T visualElement, float topBottom, float leftRight) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, topBottom, leftRight, topBottom);
        }

        public static T BorderWidthPercent<T>(this T visualElement, float top, float leftRight, float bottom) where T : VisualElement
        {
            return BorderWidthPercent(visualElement, top, leftRight, bottom, leftRight);
        }

        public static T BorderWidthPercent<T>(this T visualElement, float top, float right, float bottom, float left) where T : VisualElement
        {
            visualElement.style.borderTopWidth = top;
            visualElement.style.borderBottomWidth = bottom;
            visualElement.style.borderLeftWidth = left;
            visualElement.style.borderRightWidth = right;

            return visualElement;
        }

        #endregion

        #region BorderRadius

        public static T BorderRadius<T>(this T visualElement, float radius) where T : VisualElement
        {
            return BorderRadius(visualElement, radius, radius, radius, radius);
        }

        public static T BorderRadiusPercent<T>(this T visualElement, float radius) where T : VisualElement
        {
            return BorderRadiusPercent(visualElement, radius, radius, radius, radius);
        }

        public static T BorderRadius<T>(this T visualElement, float topLeft, float topRight, float bottomLeft, float bottomRight) where T : VisualElement
        {
            visualElement.style.borderTopLeftRadius = new Length(topLeft, LengthUnit.Pixel);
            visualElement.style.borderTopRightRadius = new Length(bottomLeft, LengthUnit.Pixel);
            visualElement.style.borderBottomLeftRadius = new Length(bottomRight, LengthUnit.Pixel);
            visualElement.style.borderBottomRightRadius = new Length(topRight, LengthUnit.Pixel);

            return visualElement;
        }

        public static T BorderRadiusPercent<T>(this T visualElement, float topLeft, float topRight, float bottomLeft, float bottomRight) where T : VisualElement
        {
            visualElement.style.borderTopLeftRadius = new Length(topLeft, LengthUnit.Percent);
            visualElement.style.borderTopRightRadius = new Length(bottomLeft, LengthUnit.Percent);
            visualElement.style.borderBottomLeftRadius = new Length(bottomRight, LengthUnit.Percent);
            visualElement.style.borderBottomRightRadius = new Length(topRight, LengthUnit.Percent);

            return visualElement;
        }

        #endregion

        #region BorderColor

        public static T BorderColor<T>(this T visualElement, Color color) where T : VisualElement
        {
            return BorderColor(visualElement, color, color, color, color);
        }

        public static T BorderColor<T>(this T visualElement, string color) where T : VisualElement
        {
            return BorderColor(visualElement, color, color, color, color);
        }

        public static T BorderColor<T>(this T visualElement, string top, string right, string bottom, string left) where T : VisualElement
        {
            visualElement.style.borderTopColor = HexToColor(top);
            visualElement.style.borderBottomColor = HexToColor(bottom);
            visualElement.style.borderLeftColor = HexToColor(left);
            visualElement.style.borderRightColor = HexToColor(right);

            return visualElement;
        }

        public static T BorderColor<T>(this T visualElement, Color top, Color right, Color bottom, Color left) where T : VisualElement
        {
            visualElement.style.borderTopColor = top;
            visualElement.style.borderBottomColor = bottom;
            visualElement.style.borderLeftColor = left;
            visualElement.style.borderRightColor = right;

            return visualElement;
        }

        #endregion
    }
}