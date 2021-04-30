using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CaseOpener
{

    //public delegate void GetItemCollection(GameItem item);


    static class ItemFactory
    {

        private static readonly Random getrandom = new Random();

        public static double GetRandomNumber()
        {
            lock (getrandom) // synchronize
            {
                return getrandom.NextDouble();
            }
        }


        public static GameItem GetCollection(GameItem item)
        {
            //Delegate del = 
            return null;
        }


        public static List<GameItem> ItemCollection = new List<GameItem>
        {
            new GameItem("AWP | Asiimov", null, Color.Red, RarityEnum.Rarity.COVERT, 0, 1),
            new GameItem("AUG | Chameleon", null, Color.Red, RarityEnum.Rarity.COVERT, 0, 1),
            new GameItem("AK-47 | Redline", null, Color.Pink, RarityEnum.Rarity.CLASSIFIED, 0, 1),
            // TODO add more items
        };


        public static Case regullarCase = new Case("Regular case", null, Color.Orange, ItemCollection);

    }
}
