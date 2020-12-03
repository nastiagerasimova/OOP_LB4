using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOP_LB4._3rd
{
    class Unit
    {
        public Unit() { }
        public Unit(string Name,string Location)
        {
            this.Name = Name;
            this.Location = Location;
        }

        public string Name { get; set; }
        public string Location { get; set; }

        public virtual void ShowInfo()
        {
            Debug.WriteLine(
                $"This is Class Unit:\n" +
                $"Name: {Name}\n" +
                $"Location: {Location}\n");
        }
    }
}
