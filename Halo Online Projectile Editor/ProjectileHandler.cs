using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class ProjectileHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
            0x0001AD, // Frag
            0x0001B0, // Plasma
            0x0001B3, // Spike
            0x0001B6, // Flame
            0x000587, // Spike (possible B7)
            0x0006D9, // Flamethrower Flame
            0x0006DB, // Flamethrower Flame 2
            0x0006DC, // Flamethrower Flame 3
            0x0006FB, // Flamethrower Flame 4
            0x0015A7, // Plasma (Long Fuse)
            0x0015C8, // Fuel Rod round 1
            0x0015CF, // Fuel Rod round 2
            0x0015C9, // Rockets
            0x0015CA, // Missile Pod
            0x0015CB, // Wraith shots
            0x0015CD, // Brute Shot
            0x0015CE, // Hornet Rocket
            0x0015D0, // Frag Grenade (red trail)
            0x001AE1, // Plasma Bolt (?)
            0x001B90, // Assault Rifle Round
            0x001D88, // Battle Rifle Round
            0x0015BC, // Covenant Rifle Round
            0x001E12, // DMR/AR round (?)
            0x001E49, // Plasma Rifle/Ghost Round
            0x001F00, // Shotgun Pellet
            0x001F51, // Magnum Round
            0x001F92, // Sniper Round
            0x002058, // Spiker Round
            0x00208F, // Mauler Round
            0x0020BD, // Human Projectile (?)
            0x0020EF, // Needler Round
            0x00219E, // Machine Gun Turret Round
            0x00225C, // Plasma Pistol
            0x0015B1, // Sniper Rifle
        };

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
