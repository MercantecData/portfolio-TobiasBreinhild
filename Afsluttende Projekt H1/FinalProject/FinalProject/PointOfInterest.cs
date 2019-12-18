using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class PointOfInterest
    {
        public string name;
        public int amountOfCitizens;
        public string shop;

        public PointOfInterest(string name, int amountOfCitizens, string shop)
        {
            this.name = name;
            this.amountOfCitizens = amountOfCitizens;
            this.shop = shop;
        }
    }
}
