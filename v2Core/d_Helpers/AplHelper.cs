using Alexa.NET.APL.Components;

namespace Reflexa
{
    class AplHelper
    {
        public static Text GetCenteredText(AplConfig config, string text)
        {
            Text centertedText = new Text(text)
            {
                Color = config.textColor,
                Width = config.textWidth,
                Height = config.textHeight,
                AlignSelf = AplStyle.Center,
                TextAlign = AplStyle.Center,
                TextAlignVertical = AplStyle.Center,
                FontSize = config.textFontSize,
                FontWeight = AplStyle.FontWeightLight
            };

            return centertedText;
        }

        public static Image GetOverlay(string source)
        {
            Image overlay = new Image()
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight(),
                Position = AplStyle.Absolute,
                Scale = ImageScale.BestFill,
                Source = source
            };

            return overlay;
        }

        public static Image GetBackground(string source)
        {
            Image background = new Image
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight(),
                Position = AplStyle.Absolute,
                Scale = ImageScale.BestFill,
                Source = source
            };

            return background;
        }

        public static Container GetMaxSizeContainer()
        {
            Container container = new Container
            {
                AlignSelf = AplStyle.Center,
                AlignItems = AplStyle.Center,
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight()
            };

            return container;
        }
    }
}
