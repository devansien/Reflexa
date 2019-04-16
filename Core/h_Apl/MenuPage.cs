using Alexa.NET.APL.Components;
using Alexa.NET.Response.APL;
using System;
using System.Collections.Generic;

namespace StreamCast
{
    class MenuPage
    {
        private static AplConfig Config;
        private static List<Item> Items;


        protected Container GetMenu(AplConfig config)
        {
            Config = config;
            Items = Core.skill.Items.GetAll();

            Image overlay = GetOverlayImage();
            Image background = GetBackgroundImage();
            Text title = AplHelper.GetTitle(config);
            Sequence sequence = GetMenuSequence();
            Container container = AplHelper.GetMaxSizeContainer();
            container.Items = new List<APLComponent> { background, overlay, title, sequence };

            return container;
        }

        private Sequence GetMenuSequence()
        {
            int containerSize = GetContainerSize();
            Container[] containers = new Container[containerSize];

            for (int i = 0; i < containerSize; i++)
            {
                containers[i] = AplHelper.GetOuterContainer(Config);
                List<APLComponent> containerItems = new List<APLComponent>();

                for (int j = 0; j < Config.itemPerContainer; j++)
                {
                    int index = j == 0 ? j + i : i + containerSize * j;
                    if (index < Items.Count)
                    {
                        var wrappedItem = GetTouchWrappedItem(Items[index]);
                        containerItems.Add(wrappedItem);
                    }
                }

                containers[i].Items = containerItems;
            }

            Sequence sequence = AplHelper.GetMaxSizeSequence();
            List<APLComponent> sequenceItems = new List<APLComponent>();
            foreach (Container container in containers)
                sequenceItems.Add(container);
            sequence.Items = sequenceItems;

            return sequence;
        }

        private APLComponent GetTouchWrappedItem(Item item)
        {
            Text label;
            Text indexLabel = new Text();
            Image thumbnail = AplHelper.GetThumbnail(Config, item);

            if (Core.echo.IsRound == true)
            {
                label = AplHelper.GetLabel(Config, $"{item.Title}");
                indexLabel = AplHelper.GetLabel(Config, $"{item.Index + 1} of {Items.Count}");
                indexLabel.FontSize = "26dp";
            }
            else
                label = AplHelper.GetLabel(Config, $"{item.Index + 1}. {item.Title}");

            TouchWrapper touchWrapper = AplHelper.GetTouchWrapper(item.Index.ToString());
            Container container = AplHelper.GetInnerContainer(Config);

            touchWrapper.Item = new List<APLComponent> { thumbnail };
            if (Core.echo.IsRound == true)
                container.Items = new List<APLComponent> { touchWrapper, label, indexLabel };
            else
                container.Items = new List<APLComponent> { touchWrapper, label };

            return container;
        }

        private Image GetBackgroundImage()
        {
            Random random = new Random();
            string image = Items[random.Next(Core.skill.Items.GetCount())].Background;
            if (string.IsNullOrEmpty(image))
                image = Core.skill.BackgroundImage;

            return AplHelper.GetBackground(image);
        }

        private Image GetOverlayImage()
        {
            string image = Core.skill.OverlayImage;
            return AplHelper.GetOverlay(image);
        }

        private int GetContainerSize()
        {
            int numItems = Items.Count;
            int itemsPerContainer = Config.itemPerContainer;
            int containerSize = numItems % itemsPerContainer == 0 ? numItems / itemsPerContainer : (numItems / itemsPerContainer) + 1;

            return containerSize;
        }
    }
}
