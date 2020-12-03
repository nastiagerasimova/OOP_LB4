using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace OOP_LB4._3rd
{
    class Enemy : Unit
    {
        public Enemy() { }
        public Enemy(string Name, string Location, double HP, string Weapon,int Level)
            : base(Name, Location)
        {
            this.HP = HP;
            this.Weapon = Weapon;
            this.Level = Level;
        }
        public double HP { get; set; }
        public string Weapon { get; set; }
        public int Level { get; set; }

        public override void ShowInfo()
        {
            Debug.WriteLine(
                $"This is class Enemy:\n" +
                $"Name: {Name}\n" +
                $"Location: {Location}\n" +
                $"HP: {HP}\n" +
                $"Weapon: {Weapon}\n" +
                $"Level: {Level}\n");
        }
    }
}
