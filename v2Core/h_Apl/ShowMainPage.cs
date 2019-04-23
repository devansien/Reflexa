using Alexa.NET.APL.Components;

namespace Reflexa
{
    class ShowMainPage : MainPage
    {
        public Container GetShowMainPage(string utterance)
        {
            AplConfig config = new AplConfig
            {
                textColor = AplStyle.White,
                textWidth = DisplayHelper.GetWidth(0.95f),
                textHeight = DisplayHelper.GetHeight(0.85f),
                textFontSize = "30dp",
            };

            return GetMainPage(config, utterance);
        }
    }
}
