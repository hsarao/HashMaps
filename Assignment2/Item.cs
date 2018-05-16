using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2
{
    public class Item : IComparable<Item>
    {
        public string Name;
        public int GoldPieces;
        public double Weight;

        public Item(String name, int goldPieces, double weight)
        {
            Name = name;
            GoldPieces = goldPieces;
            Weight = weight;
        }

        public int CompareTo(Item obj)
        {
            return string.Compare(Name, obj.Name);
        }

        public override bool Equals(Object o)
        {          

            if (o == null)
            {
                return false;
            }

            Item item = o as Item;

            return (item != null)
                && (Name == item.Name)
                && (GoldPieces == item.GoldPieces)
                && (Weight == item.Weight);
        }
                
        public override String ToString()
        {
            String result = Name + " is worth " + GoldPieces + "gp and weighs " + Weight + "kg";
             return result;
        }

        public String GetName()
        {
            return this.Name;
        }

        public int GetGoldPieces()
        {
            return this.GoldPieces;
        }

        public double GetWeight()
        {
            return this.Weight;
        }

    }
}