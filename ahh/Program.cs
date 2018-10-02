using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a sith");
            Sith Vadar = new Sith();
            Vadar.PrintSithDetails();
            Vadar.CombinationAttack();
            Console.WriteLine("Creating a sith lord");
            SithLord Sidus = new SithLord();
            Sidus.ForcePowerLevel = 20;
            Sidus.DamageMultiplier = 10;
            Sidus.PrintSithDetails();
            Sidus.CombinationAttack();
            Sidus.SeeFuture();
            Sidus.SaveApprentice();
            Sidus.Apprentice = Vadar;

            Console.ReadKey();
        }
    }
    class Sith
    {
        public int Damage;
        public string title;
        public string name;
        public int ForcePowerLevel;
        public string LightSaberColour;
        public  Sith(string Name)
        {
            Damage = 10;
            ForcePowerLevel = 5;
            title = "Darth";
            name = Name;
            LightSaberColour = "Red";
        }

        public Sith()
        {
        }

        public void TelekineticThrow()
        {
            Console.WriteLine("Telekinetic Throw Attack inflicts " + Damage + " DamagePoints");
        }
        public void ForcePush() { }
        public void LightSaberAttack() { }
        public void CombinationAttack() { TelekineticThrow(); ForcePush(); LightSaberAttack(); }
        public void PrintSithDetails() { }
    }
    class SithLord : Sith
    {
        public int DamageMultiplier;
        public Sith Apprentice;

        public SithLord(string Name, int damageMultiplier, int PowerLevel) : base(Name)
        {
            DamageMultiplier = damageMultiplier;
            ForcePowerLevel = PowerLevel;
            LightSaberColour = "Purple";
        }
        public void LightningAttack() { }
        public void SeeFuture() { }
        public void SaveApprentice() { }
        public void SpecialCombinationAttack() { CombinationAttack(); LightningAttack(); }
        public void setApprentice(Sith a)
        {
            Apprentice = a;
        }
        public void PrintApprenticeDetails()
        {
            Console.WriteLine("I am " + title + " " + name + ": My apprentice has the following 	details: ");
            Apprentice.PrintSithDetails();
        }
    }
}
