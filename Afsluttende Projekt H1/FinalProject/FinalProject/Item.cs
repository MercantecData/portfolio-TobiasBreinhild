using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Item
    {
        public string name;
        public string rarity;
        public int price;
        public int sellValue;

        public string weapon;
        public int damage;

        public Item(string name, string rarity, int price, int sellValue, string weapon, int damage)
        {
            this.name = name;
            this.rarity = rarity;
            this.price = price;
            this.sellValue = sellValue;
            this.weapon = weapon;
            this.damage = damage;
        }
    }
}
