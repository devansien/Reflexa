using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using System.Collections.Generic;

namespace Reflexa
{
    class MainPage
    {
        private static AplConfig Config;


        protected Container GetMainPage(AplConfig config, string utterance)
        {
            Config = config;

            Text text = GetText(utterance);
            Image overlay = GetOverlayImage();
            Image background = GetBackgroundImage();
            Container container = AplHelper.GetMaxSizeContainer();
            container.Items = new List<APLComponent> { background, overlay, text };

            return container;
        }

        private Image GetBackgroundImage()
        {
            string image = SkillSettings.BackgroundImage;
            return AplHelper.GetBackground(image);
        }

        private Image GetOverlayImage()
        {
            string image = SkillSettings.OverlayImage;
            return AplHelper.GetOverlay(image);
        }

        private Text GetText(string utterance)
        {
            return AplHelper.GetCenteredText(Config, utterance);
        }
    }
}
