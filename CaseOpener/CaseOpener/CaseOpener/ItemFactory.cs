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
            new GameItem("AWP | Asiimov", null, Color.Red, RarityEnum.Rarity.COVERT, 0.18 , 1),
            new GameItem("AUG | Chameleon", null, Color.Red, RarityEnum.Rarity.COVERT, 0, 0.5),
            new GameItem("AK-47 | Redline", null, Color.Magenta , RarityEnum.Rarity.CLASSIFIED, 0.1, 0.7),
            new GameItem("Nova | Antique", null, Color.Magenta, RarityEnum.Rarity.CLASSIFIED, 0, 0.3),
            new GameItem("P90 | Trigon", null, Color.Magenta, RarityEnum.Rarity.CLASSIFIED, 0.08, 0.75),
            new GameItem("USP-S | Guardian", null, Color.Purple, RarityEnum.Rarity.RESTRICTED, 0, 0.38),
            new GameItem("MAC-10 | Heat", null, Color.Purple, RarityEnum.Rarity.RESTRICTED, 0, 1),
            new GameItem("SG 553 | Pulse", null, Color.Purple, RarityEnum.Rarity.RESTRICTED, 0.1, 0.6),
            new GameItem("FAMAS | Sergeant", null, Color.Purple, RarityEnum.Rarity.RESTRICTED, 0.1, 1),
            new GameItem("Tec-9 | Sandstorm", null, Color.Blue, RarityEnum.Rarity.MIL_SPEC, 0.1, 0.7),
            new GameItem("Negev | Terrain", null, Color.Blue, RarityEnum.Rarity.MIL_SPEC, 0, 0.45),
            new GameItem("MAG-7 | Heaven Guard", null, Color.Blue, RarityEnum.Rarity.MIL_SPEC, 0, 0.4),
            new GameItem("UMP-45 | Corporal", null, Color.Blue, RarityEnum.Rarity.MIL_SPEC, 0.05, 0.75)
        };


        public static Case regullarCase = new Case("Regular case", null, Color.Orange, ItemCollection);

    }
}
