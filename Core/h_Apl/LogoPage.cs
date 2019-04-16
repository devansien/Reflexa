using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using System.Collections.Generic;

namespace StreamCast
{
    class LogoPage
    {
        public APLComponent GetLogo()
        {
            Container container = new Container()
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight()
            };

            Image background = new Image(AplStyle.WhiteBackground)
            {
                Scale = ImageScale.Fill,
                Position = AplStyle.Absolute,
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight()
            };

            Image logo = new Image()
            {
                AlignSelf = AplStyle.Center,
                Width = DisplayHelper.GetWidth(0.5f),
                Height = DisplayHelper.GetMaxHeight()
            };

            container.Items = new List<APLComponent>() { background, logo };
            return container;
        }
    }
}
