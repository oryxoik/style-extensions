using UnityEngine;
using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T OriginTop<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 50, 0);
        public static T OriginTopLeft<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 0, 0);
        public static T OriginTopRight<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 100, 0);
        public static T OriginCenter<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 50, 50);
        public static T OriginLeft<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 0, 50);
        public static T OriginRight<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 100, 50);
        public static T OriginBottom<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 50, 100);
        public static T OriginBottomLeft<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 0, 100);
        public static T OriginBottomRight<T>(this T visualElement) where T : VisualElement => OriginPercent(visualElement, 100, 100);

        public static T Origin<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            var xLength = new Length(x, LengthUnit.Pixel);
            var yLength = new Length(y, LengthUnit.Pixel);
            visualElement.style.transformOrigin = new TransformOrigin(xLength, yLength, 0);
            return visualElement;
        }

        public static T OriginPercent<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            var xLength = new Length(x, LengthUnit.Percent);
            var yLength = new Length(y, LengthUnit.Percent);
            visualElement.style.transformOrigin = new TransformOrigin(xLength, yLength, 0);
            return visualElement;
        }

        public static T Translate<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            var xLength = new Length(x, LengthUnit.Pixel);
            var yLength = new Length(y, LengthUnit.Pixel);
            visualElement.style.translate = new Translate(xLength, yLength, 0);
            return visualElement;
        }

        public static T TranslatePercent<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            var xLength = new Length(x, LengthUnit.Percent);
            var yLength = new Length(y, LengthUnit.Percent);
            visualElement.style.translate = new Translate(xLength, yLength, 0);
            return visualElement;
        }

        public static T Scale<T>(this T visualElement, float x, float y) where T : VisualElement
        {
            visualElement.style.scale = new Scale(new Vector2(x, y));
            return visualElement;
        }

        private static T RotateDegree<T>(this T visualElement, float rotation) where T : VisualElement => Rotate(visualElement, rotation, AngleUnit.Degree);
        private static T RotateRadian<T>(this T visualElement, float rotation) where T : VisualElement => Rotate(visualElement, rotation, AngleUnit.Radian);
        private static T RotateGradian<T>(this T visualElement, float rotation) where T : VisualElement => Rotate(visualElement, rotation, AngleUnit.Gradian);
        private static T RotateTurn<T>(this T visualElement, float rotation) where T : VisualElement => Rotate(visualElement, rotation, AngleUnit.Turn);

        private static T Rotate<T>(this T visualElement, float rotation, AngleUnit unit) where T : VisualElement
        {
            visualElement.style.rotate = new StyleRotate(new Rotate(new Angle(rotation, unit)));
            return visualElement;
        }
    }
}