using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    [Serializable]
    public class Case : Item
    {

        private List<GameItem> _items;

        public Case(string name, Image image, Color color, List<GameItem> gameItems) : base(name, image, color)
        {
            _items = gameItems;
        }

        public GameItem open()
        {
            Random random = new Random();

            int maxQuality = (int)_items.OrderByDescending(t => t.Rarity).First().Rarity;
            int minQuality = (int)_items.OrderBy(t => t.Rarity).First().Rarity;
            int range = maxQuality - minQuality;

            int max = 1;
            for (int i = 0; i < range; i++)
                max *= 10;

            Random rnd = new Random();
            int num = rnd.Next(1, max);

            int quality = maxQuality;

            int n = 1;
            for (int i = 0; i < range; i++)
            {
                if (num <= n)
                    break;

                n *= 10;
                quality--;
            }

            List<GameItem> availableOptions = _items.FindAll(i => (int)i.Rarity == quality);

            int itemId = random.Next(0, availableOptions.Count);
            GameItem item = new GameItem(availableOptions[itemId]);

            return item;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
