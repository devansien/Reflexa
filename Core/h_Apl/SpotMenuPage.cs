using Alexa.NET.APL.Components;

namespace StreamCast
{
    class SpotMenuPage : MenuPage
    {
        public Container GetSpotMenu()
        {
            AplConfig config = new AplConfig
            {
                titleWidth = DisplayHelper.GetWidth(0.8f),
                titleHeihgt = DisplayHelper.GetHeight(0.2f),
                titleSpacing = DisplayHelper.GetHeight(0.15f),
                titleMaxLines = 2,

                titleText = Core.skill.Subtitle,
                titleFontSize = "38dp",
                titleTextColor = AplStyle.White,

                labelWidth = DisplayHelper.GetWidth(0.9f),
                labelHeight = DisplayHelper.GetHeight(0.15f),
                labelSpacing = DisplayHelper.GetHeight(0.02f),

                labelFontSize = "28dp",
                labelTextAlign = AplStyle.Center,

                thumbnailWidth = DisplayHelper.GetWidth(0.7f),
                thumbnailHeight = DisplayHelper.GetHeight(0.4f),
                thumbnailSpacing = DisplayHelper.GetHeight(0.03f),
                thumbnailRadius = "25px",

                innerContainerWidth = DisplayHelper.GetMaxWidth(),
                innerContainerHeight = DisplayHelper.GetHeight(0.8f),
                innerContainerSpacing = DisplayHelper.GetHeight(0),

                itemPerContainer = 1,
                outerContainerWidth = DisplayHelper.GetMaxWidth(),
                outerContainerHeight = DisplayHelper.GetMaxHeight()
            };

            return GetMenu(config);
        }
    }
}
