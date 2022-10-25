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
        static int minAmmo = 0; // Minimum Ammo for All Weapons

        static void Main(string[] args)
        {
            // show current weapon (without hardcoding)
            ChangeWeapon(0); // Revoler

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Reload();

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            ChangeWeapon(2); // Rifle
            
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Reload();

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            ChangeWeapon(1); // Shotgun

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Reload();

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            ChangeWeapon(3); // Rocket Launcher

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Reload();

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            ChangeWeapon(4); // B.F.G.

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Reload();

            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();
            ShowHUD();
            Fire();

            Console.ReadKey(true);
        }

        static void ShowHUD()
        {
            Console.WriteLine("");
            Console.WriteLine(" +-----------+");
            Console.WriteLine(" |Ammo System|");
            Console.WriteLine(" +-----------+");
            Console.WriteLine("");
            Console.WriteLine(" +----------------------------------");
            Console.WriteLine(" |                                 ");
            Console.WriteLine(" | Current Weapon: " + weaponName[weaponIndex]);
            Console.WriteLine(" |");
            Console.WriteLine(" | Ammo: [" + currentAmmo + "/" + ammo[weaponIndex] + "]");
            Console.WriteLine(" |");
            Console.WriteLine(" +---------+------------------------");
        }

        static void Fire()
        {
            if (currentAmmo > minAmmo)
            {
                currentAmmo--;

                Console.WriteLine(" | Bang!!! |");
                Console.WriteLine(" +---------+");
                
                Console.ReadKey(true);
                Console.Clear();
            }
            else if (currentAmmo <= minAmmo)
            {
                Console.WriteLine(" | *Click* |");
                Console.WriteLine(" +---------+");
                
                Console.ReadKey(true);
                Console.Clear();
            }
        }

        static void Reload()
        {
            currentAmmo = ammo[weaponIndex];

            Console.WriteLine("");
            Console.WriteLine(" +-----------+");
            Console.WriteLine(" | Reloaded! |");
            Console.WriteLine(" +-----------+");
            Console.WriteLine("");

            Console.ReadKey(true);
        }

        static void ChangeWeapon (int numIndex)
        {
            weaponIndex = numIndex;
            currentAmmo = ammo[weaponIndex];
        }
    }
}
