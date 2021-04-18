using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener
{
    static class GameItemCollection
    {

        public static List<GameItem> ItemCollection = new List<GameItem>
        {
            new GameItem("AWP | Asiimov", null, Color.Red, RarityEnum.Rarity.COVERT),
            new GameItem("AUG | Chameleon", null, Color.Red, RarityEnum.Rarity.COVERT),
            new GameItem("AK-47 | Redline", null, Color.Pink, RarityEnum.Rarity.CLASSIFIED),
            // TODO add more items
        };


        public static Case regullarCase = new Case("Regular case", null, Color.Orange, ItemCollection);

    }
}
