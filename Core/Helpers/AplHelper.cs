using Alexa.NET.APL.Components;

namespace Reflexa
{
    class AplHelper
    {
        public static void SetMainPage(string utterance)
        {
            if (Core.echo.IsRound)
            {
                SpotMainPage spotMainPage = new SpotMainPage();
                Core.response.SetDirective(false,
                    DisplayHelper.GetRenderDirective(SessionKey.SpotAplToken, spotMainPage.GetSpotMainPage(utterance)));
            }
            else
            {
                ShowMainPage showMainPage = new ShowMainPage();
                Core.response.SetDirective(false,
                    DisplayHelper.GetRenderDirective(SessionKey.ShowAplToken, showMainPage.GetShowMainPage(utterance)));
            }
        }

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
