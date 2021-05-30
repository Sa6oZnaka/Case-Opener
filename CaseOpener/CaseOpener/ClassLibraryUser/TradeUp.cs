using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyFirm.CaseOpener.ClassLibraryUser
{
    public class TradeUp
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
            int itemID = rnd.Next(0, 10); 

            GameItem selectedItem = _items[itemID];

            List<GameItem> outputs = ItemFactory.ItemCollection.FindAll(i => (int)i.Rarity == (int)selectedItem.Rarity + 1);
            
            if (outputs.Count == 0)
                return null;

            itemID = rnd.Next(0, outputs.Count);
            GameItem output = outputs[itemID];
            output.Wear = (double)(output.MinWear + (_items.Average(i => i.Wear)) * (output.MaxWear - output.MinWear));
            return output;
        }

    }
}
