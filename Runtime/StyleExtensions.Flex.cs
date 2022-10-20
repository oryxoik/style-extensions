using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T FlexBasis<T>(this T visualElement, float flexBasis) where T : VisualElement
        {
            visualElement.style.flexBasis = new Length(flexBasis, LengthUnit.Pixel);
            return visualElement;
        }

        public static T FlexBasisPercent<T>(this T visualElement, float flexBasis) where T : VisualElement
        {
            visualElement.style.flexBasis = new Length(flexBasis, LengthUnit.Percent);
            return visualElement;
        }

        public static T FlexShrink<T>(this T visualElement, float shrink) where T : VisualElement
        {
            visualElement.style.flexShrink = shrink;
            return visualElement;
        }

        public static T FlexGrow<T>(this T visualElement, float grow) where T : VisualElement
        {
            visualElement.style.flexGrow = grow;
            return visualElement;
        }

        public static T FlexDirectionColumn<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexDirection = FlexDirection.Column;
            return visualElement;
        }

        public static T FlexDirectionColumnReverse<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexDirection = FlexDirection.ColumnReverse;
            return visualElement;
        }

        public static T FlexDirectionRow<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexDirection = FlexDirection.Row;
            return visualElement;
        }

        public static T FlexDirectionRowReverse<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexDirection = FlexDirection.RowReverse;
            return visualElement;
        }

        public static T FlexWrap<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexWrap = Wrap.Wrap;
            return visualElement;
        }

        public static T FlexWrapReverse<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.flexWrap = Wrap.WrapReverse;
            return visualElement;
        }
    }
}