using Alexa.NET.APL;
using Alexa.NET.APL.Commands;
using Alexa.NET.APL.Components;
using Alexa.NET.Response;
using Alexa.NET.Response.APL;
using System.Collections.Generic;

namespace Reflexa
{
    class AplHelper
    {
        public static void SetLogo()
        {
            Pager pager = GetPager(SessionKey.MainToken);
            List<APLComponent> pages = new List<APLComponent>
            {
                new LogoPage().GetLogo()
            };

            if (Core.echo.IsRound)
            {
                SpotMenuPage spotMenuPage = new SpotMenuPage();
                pages.Add(spotMenuPage.GetSpotMenu());
            }
            else
            {
                ShowMenuPage showMenuPage = new ShowMenuPage();
                pages.Add(showMenuPage.GetShowMenu());
            }
            pager.Items = pages;

            SetPage setPageCommand = new SetPage() { ComponentId = SessionKey.MainToken, Value = 1 };
            ExecuteCommandsDirective executeCommandDirective = new ExecuteCommandsDirective(SessionKey.MainToken)
            {
                Commands = new List<APLCommand>()
            };
            executeCommandDirective.Commands.Add(setPageCommand);

            var directive = DisplayHelper.GetRenderDirective(SessionKey.MainToken, pager);
            Core.response.SetDirective(directive, executeCommandDirective);
        }

        public static void SetMenu()
        {
            bool isMenuShown = !Core.input.GetRequest().Session.New;
            if (!isMenuShown || Core.state.UserState.PlaybackPaused)
            {
                Core.state.UserState.PlaybackPaused = false;
                if (Core.echo.IsRound)
                {
                    SpotMenuPage spotMenuPage = new SpotMenuPage();
                    Core.response.SetDirective(false, DisplayHelper.GetRenderDirective(SessionKey.SpotAplToken, spotMenuPage.GetSpotMenu()));
                }
                else
                {
                    ShowMenuPage showMenuPage = new ShowMenuPage();
                    Core.response.SetDirective(false, DisplayHelper.GetRenderDirective(SessionKey.ShowAplToken, showMenuPage.GetShowMenu()));
                }
            }
        }

        public static Pager GetPager(string id)
        {
            Pager pager = new Pager()
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight(),
                Navigation = AplStyle.None,
                Id = id
            };

            return pager;
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

        public static Text GetTitle(AplConfig config)
        {
            Text title = new Text(config.titleText)
            {
                Width = config.titleWidth,
                Height = config.titleHeihgt,
                Spacing = config.titleSpacing,
                MaxLines = config.titleMaxLines,
                TextAlign = AplStyle.Center,
                AlignSelf = AplStyle.Center,
                Color = config.titleTextColor,
                FontSize = config.titleFontSize,
                FontWeight = AplStyle.FontWeightLight
            };

            return title;
        }

        public static Text GetLabel(AplConfig config, string text)
        {
            Text label = new Text(text)
            {
                Width = config.labelWidth,
                Height = config.labelHeight,
                Spacing = config.labelSpacing,
                MaxLines = 2,
                TextAlign = config.labelTextAlign,
                Color = config.titleTextColor,
                FontSize = config.labelFontSize,
                FontWeight = AplStyle.FontWeightLight
            };

            return label;
        }

        public static Image GetThumbnail(AplConfig config, Item item)
        {
            Image thumbnail = new Image(item.Thumbnail)
            {
                Width = config.thumbnailWidth,
                Height = config.thumbnailHeight,
                Spacing = config.thumbnailSpacing,
                BorderRadius = new APLDimensionValue(config.thumbnailRadius),
                AlignSelf = AplStyle.Center
            };

            return thumbnail;
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

        public static TouchWrapper GetTouchWrapper(string argument)
        {
            TouchWrapper touchWrapper = new TouchWrapper()
            {
                OnPress = new SendEvent
                {
                    Arguments = new List<string> { argument }
                }
            };

            return touchWrapper;
        }

        public static Container GetInnerContainer(AplConfig config)
        {
            Container container = new Container
            {
                Width = config.innerContainerWidth,
                Height = config.innerContainerHeight,
                Spacing = config.innerContainerSpacing,
                Direction = AplStyle.Column,
                AlignSelf = AplStyle.Center,
                AlignItems = AplStyle.Center
            };

            return container;
        }

        public static Container GetOuterContainer(AplConfig config)
        {
            Container container = new Container
            {
                Width = config.outerContainerWidth,
                Height = config.outerContainerHeight,
                AlignSelf = AplStyle.Center,
                AlignItems = AplStyle.Center,
                JustifyContent = AplStyle.SpaceBetween
            };

            return container;
        }

        public static Container GetMaxSizeContainer()
        {
            Container container = new Container
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight(),
                Direction = AplStyle.Column
            };

            return container;
        }

        public static Sequence GetMaxSizeSequence()
        {
            Sequence sequence = new Sequence
            {
                Width = DisplayHelper.GetMaxWidth(),
                Height = DisplayHelper.GetMaxHeight(),
                ScrollDirection = AplStyle.Horizontal
            };

            return sequence;
        }

        public static Frame GetFrame(string borderColor)
        {
            Frame frame = new Frame
            {
                BorderWidth = 10,
                BorderRadius = 25,
                BorderColor = borderColor,
                BackgroundColor = AplStyle.White
            };

            return frame;
        }
    }
}
