using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T AlignItemsFlexStart<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.alignItems = Align.FlexStart;
            return visualElement;
        }

        public static T AlignItemsFlexEnd<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.alignItems = Align.FlexEnd;
            return visualElement;
        }

        public static T AlignItemsCenter<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.alignItems = Align.Center;
            return visualElement;
        }

        public static T AlignItemsStretch<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.alignItems = Align.Stretch;
            return visualElement;
        }

        public static T AlignItemsAuto<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.alignItems = Align.Auto;
            return visualElement;
        }

        public static T JustifyContentFlexStart<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.justifyContent = Justify.FlexStart;
            return visualElement;
        }

        public static T JustifyContentFlexEnd<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.justifyContent = Justify.FlexEnd;
            return visualElement;
        }

        public static T JustifyContentCenter<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.justifyContent = Justify.Center;
            return visualElement;
        }

        public static T JustifyContentSpaceAround<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.justifyContent = Justify.SpaceAround;
            return visualElement;
        }

        public static T JustifyContentSpaceBetween<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.justifyContent = Justify.SpaceBetween;
            return visualElement;
        }
    }
}