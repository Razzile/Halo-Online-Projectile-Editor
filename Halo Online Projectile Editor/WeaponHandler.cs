using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class WeaponHandler
    {
        public static uint[] projectiles =
        {
            0x001500, // Spiker
            0x001509, // Beam Rifle
            0x00150C, // Hammer
            0x00150E, // Plasma Turret
            0x00151E, // Assault Rifle (Defualt)
            0x001581, // Assault Rifle (Red)
            0x001582, // Assault Rifle (Yellow)
            0x001583, // Assault Rifle (Green)
            0x001584, // Assault Rifle (Gold)
            0x00157D, // Smg (Default)
            0x00158E, // Smg (Red)
            0x00158C, // Smg (Yellow)
            0x00158D, // Smg (Green)
            0x00158F, // Smg (Gold)
            0x00157C, // Battle Rifle (Default)
            0x001586, // Battle Rifle (Red)
            0x0015BB, // Battle Rifle (Yellow)
            0x0015BC, // Battle Rifle (Green)
            0x001585, // Battle Rifle (Blue)
            0x0015BD, // Battle Rifle (Purple)
            0x001587, // Battle Rifle (Gold)
            0x001580, // DMR (Default)
            0x00158A, // DMR (Red)
            0x001589, // DMR (Yellow)
            0x001588, // DMR (Green)
            0x0015BE, // DMR (Blue)
            0x0015BF, // DMR (Purple)
            0x00158B, // DMR (Gold)
            0x00157E, // Magnum (Default)
            0x001593, // Magnum (Red)
            0x001594, // Magnum (Gold)
            0x0014FE, // Carbine (Default)
            0x0015C3, // Carbine (Red)
            0x0015C0, // Carbine (Yellow)
            0x0015C4, // Carbine (Green)
            0x0015C1, // Carbine (Blue)
            0x0015C2, // Carbine (Purple)
            0x001591, // Carbine (Gold)
            0x001504, // Mauler (Default)
            0x001592, // Mauler (Gold)
            0x00159E, // Energy Sword
            0x00157F, // Energy Sword (No Charge)
            0x001525, // Plasma Rifle (default)
            0x001590, // Plasma Rifle (gold)
            0x0014F7, // Plasma Pistol (default)
            0x001595, // Plasma Pistol (gold)
            0x0015A2, // Flag
            0x0015A3, // Skull
            0x0015A4, // Bomb
            0x0015B1, // Sniper
            0x0015B2, // Spartan Laser
            0x0015B3, // Rocker Launcher
            0x0014F8, // Needler
            0x0014F9, // Fuel Rod
            0x0014FF, // Brute Shot
            0x001585, // Shotgun
            0x001A56, //Sentinel Beam
            0x000000, // Extra
        };

        public static void reset(uint hex, int number)
        {
            projectiles[number] = hex;
        }

        public static void SetNewProjectile(uint hex)
        {
            byte[] hexData = BitConverter.GetBytes(hex);

            byte[] rawData = new byte[6];

            hexData.CopyTo(rawData, 1);
            rawData[0] = 0xBA; // mov edx, {projectile}
            rawData[5] = 0x90; // nop
            // BA {projectile hex} 00 00 90
            MemoryManager.WriteToAddress(0xB5DBA5, rawData);
        }

    }
}
