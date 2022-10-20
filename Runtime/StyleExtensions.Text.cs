using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T Bold<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.unityFontStyleAndWeight = FontStyle.Bold;
            return visualElement;
        }

        public static T Italic<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.unityFontStyleAndWeight = FontStyle.Italic;
            return visualElement;
        }

        public static T BoldAndItalic<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.unityFontStyleAndWeight = FontStyle.BoldAndItalic;
            return visualElement;
        }

        public static T FontSize<T>(this T visualElement, float fontSize) where T : VisualElement
        {
            visualElement.style.fontSize = new Length(fontSize, LengthUnit.Pixel);
            return visualElement;
        }

        public static T FontSizePercent<T>(this T visualElement, float fontSize) where T : VisualElement
        {
            visualElement.style.fontSize = new Length(fontSize, LengthUnit.Percent);
            return visualElement;
        }

        public static T Color<T>(this T visualElement, Color color) where T : VisualElement
        {
            visualElement.style.color = color;
            return visualElement;
        }

        public static T Color<T>(this T visualElement, string color) where T : VisualElement
        {
            visualElement.style.color = HexToColor(color);
            return visualElement;
        }

        public static T TextWrap<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.whiteSpace = WhiteSpace.Normal;
            return visualElement;
        }

        public static T OutlineWidth<T>(this T visualElement, float outlineWidth) where T : VisualElement
        {
            visualElement.style.unityTextOutlineWidth = outlineWidth;
            return visualElement;
        }

        public static T OutlineColor<T>(this T visualElement, Color color) where T : VisualElement
        {
            visualElement.style.unityTextOutlineColor = color;
            return visualElement;
        }

        public static T OutlineColor<T>(this T visualElement, string color) where T : VisualElement
        {
            visualElement.style.unityTextOutlineColor = HexToColor(color);
            return visualElement;
        }

        public static T ShadowOffset<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            visualElement.style.textShadow = ModifyTextShadowStyle(visualElement, offset: new Vector2(x, y));
            return visualElement;
        }

        public static T ShadowBlurRadius<T>(this T visualElement, float blurRadius) where T : VisualElement
        {
            visualElement.style.textShadow = ModifyTextShadowStyle(visualElement, blurRadius: blurRadius);
            return visualElement;
        }

        public static T ShadowColor<T>(this T visualElement, Color color) where T : VisualElement
        {
            visualElement.style.textShadow = ModifyTextShadowStyle(visualElement, color: color);
            return visualElement;
        }

        public static T ShadowColor<T>(this T visualElement, string color) where T : VisualElement
        {
            visualElement.style.textShadow = ModifyTextShadowStyle(visualElement, color: HexToColor(color));
            return visualElement;
        }

        public static T LetterSpacing<T>(this T visualElement, float spacing) where T : VisualElement
        {
            visualElement.style.letterSpacing = spacing;
            return visualElement;
        }

        public static T WordSpacing<T>(this T visualElement, float wordSpacing) where T : VisualElement
        {
            visualElement.style.wordSpacing = wordSpacing;
            return visualElement;
        }

        public static T ParagraphSpacing<T>(this T visualElement, float paragraphSpacing) where T : VisualElement
        {
            visualElement.style.unityParagraphSpacing = paragraphSpacing;
            return visualElement;
        }

        public static T AlignTextUpperLeft<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.UpperLeft);

        public static T AlignTextUpperCenter<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.UpperCenter);

        public static T AlignTextUpperRight<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.UpperRight);

        public static T AlignTextMiddleLeft<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.MiddleLeft);

        public static T AlignTextMiddleCenter<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.MiddleCenter);

        public static T AlignTextMiddleRight<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.MiddleRight);

        public static T AlignTextLowerLeft<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.LowerLeft);

        public static T AlignTextLowerCenter<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.LowerCenter);

        public static T AlignTextLowerRight<T>(this T visualElement) where T : VisualElement
            => AlignText(visualElement, TextAnchor.LowerRight);

        private static T AlignText<T>(this T visualElement, TextAnchor anchor) where T : VisualElement
        {
            visualElement.style.unityTextAlign = anchor;
            return visualElement;
        }

        private static TextShadow ModifyTextShadowStyle(VisualElement visualElement, Color? color = null, float? blurRadius = null, Vector2? offset = null)
        {
            var shadowStyle = new TextShadow();
            shadowStyle.blurRadius = blurRadius ?? visualElement.style.textShadow.value.blurRadius;
            shadowStyle.color = color ?? visualElement.style.textShadow.value.color;
            shadowStyle.offset = offset ?? visualElement.style.textShadow.value.offset;

            return shadowStyle;
        }
    }
}