using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaseOpener
{
    class TradeUp
    {
        private List<GameItem> _items;

        public TradeUp(List<GameItem> items)
        {
            _items = items;
        }

        public List<GameItem> Items {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        public GameItem Compleate()
        {
            Random rnd = new Random();
            int itemID = rnd.Next(1, 10);

            GameItem selectedItem = _items[itemID];
            List<GameItem> outputs = (List<GameItem>)GameItemCollection.ItemCollection.Select(i => i.Rarity = selectedItem.Rarity + 1);

            if (outputs.Count == 0)
                return null;

            itemID = rnd.Next(1, outputs.Count);
            return outputs[itemID];
        }

    }
}
