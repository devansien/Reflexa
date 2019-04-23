using Alexa.NET.APL.Components;

namespace Reflexa
{
    class SpotMainPage : MainPage
    {
        public Container GetSpotMainPage(string utterance)
        {
            AplConfig config = new AplConfig
            {
                textColor = AplStyle.White,
                textWidth = DisplayHelper.GetWidth(0.95f),
                textHeight = DisplayHelper.GetHeight(0.95f),
                textFontSize = "30dp",
            };

            return GetMainPage(config, utterance);
        }
    }
}
