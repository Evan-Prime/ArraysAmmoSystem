using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAmmoSystem
{
    internal class Program
    {

        static int[] ammo = new int[] {6, 2, 4, 8, 7}; // Ammo Capacity
        static string[] weaponName = new string[] {"Revoler", "Shotgun", "Rifle", "Rocket Launcher", "B.F.G."}; // Weapon Types
        static int weaponIndex; // Current Weapon
        static int currentAmmo; // Current Weapon's Unused Ammo

        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine(" +-----------+");
            Console.WriteLine(" |Ammo System|");
            Console.WriteLine(" +-----------+");
            Console.WriteLine("");

            // show current weapon (without hardcoding)
            weaponIndex = 0;
            currentAmmo = ammo[weaponIndex];
            Console.WriteLine(" " + weaponName[weaponIndex] + " " + currentAmmo + "/" + ammo[weaponIndex]);
            currentAmmo--;
            Console.WriteLine(" " + weaponName[weaponIndex] + " " + currentAmmo + "/" + ammo[weaponIndex]);
            weaponIndex = 2;
            currentAmmo = ammo[weaponIndex];
            Console.WriteLine(" " + weaponName[weaponIndex] + " " + currentAmmo + "/" + ammo[weaponIndex]);


            Console.ReadKey(true);
        }

        static void Fire()
        {

        }
    }
}
