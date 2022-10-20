using UnityEngine.UIElements;

namespace O.StyleExtensions
{
    public static partial class StyleExtensions
    {
        public static T OpacityMin<T>(this T visualElement) where T : VisualElement
        {
            return Opacity(visualElement, 0);
        }

        public static T OpacityMax<T>(this T visualElement) where T : VisualElement
        {
            return Opacity(visualElement, 1);
        }

        public static T Opacity<T>(this T visualElement, float opacity) where T : VisualElement
        {
            visualElement.style.opacity = opacity;
            return visualElement;
        }

        public static T DisplayNone<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.display = DisplayStyle.None;
            return visualElement;
        }

        public static T DisplayFlex<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.display = DisplayStyle.Flex;
            return visualElement;
        }

        public static T Hidden<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.visibility = Visibility.Hidden;
            return visualElement;
        }

        public static T Visible<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.visibility = Visibility.Visible;
            return visualElement;
        }

        public static T OverflowHidden<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.overflow = Overflow.Hidden;
            return visualElement;
        }

        public static T OverflowVisible<T>(this T visualElement) where T : VisualElement
        {
            visualElement.style.overflow = Overflow.Visible;
            return visualElement;
        }
    }
}