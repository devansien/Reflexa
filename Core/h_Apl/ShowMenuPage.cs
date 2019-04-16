using Alexa.NET.APL.Components;

namespace StreamCast
{
    class ShowMenuPage : MenuPage
    {
        public Container GetShowMenu()
        {
            AplConfig config = new AplConfig
            {
                titleWidth = DisplayHelper.GetMaxWidth(),
                titleHeihgt = DisplayHelper.GetHeight(0.15f),
                titleSpacing = DisplayHelper.GetHeight(0.1f),
                titleMaxLines = 3,

                titleText = Core.skill.Subtitle,
                titleFontSize = "55dp",
                titleTextColor = AplStyle.White,

                labelWidth = DisplayHelper.GetWidth(0.22f),
                labelHeight = DisplayHelper.GetHeight(0.1f),
                labelSpacing = DisplayHelper.GetHeight(0.022f),

                labelFontSize = "25dp",
                labelTextAlign = AplStyle.Left,

                thumbnailWidth = DisplayHelper.GetWidth(0.25f),
                thumbnailHeight = DisplayHelper.GetHeight(0.2f),
                thumbnailSpacing = DisplayHelper.GetHeight(0),
                thumbnailRadius = "10px",

                innerContainerWidth = DisplayHelper.GetWidth(0.3f),
                innerContainerHeight = DisplayHelper.GetHeight(0.35f),
                innerContainerSpacing = DisplayHelper.GetHeight(0),

                itemPerContainer = 2,
                outerContainerWidth = DisplayHelper.GetWidth(0.33f),
                outerContainerHeight = DisplayHelper.GetHeight(0.75f)
            };

            return GetMenu(config);
        }
    }
}
