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
            0x0001AD, // Frag 0
            0x0001B0, // Plasma 1
            0x0001B3, // Spike 2
            0x0001B6, // Flame 3
            0x000587, // Spike 4
            0x0006D9, // Flamethrower Flame 5
            0x0006DB, // Flamethrower Flame 2 6
            0x0006DC, // Flamethrower Flame 3 7
            0x0006FB, // Flamethrower Flame 4 8
            0x0015A7, // Plasma (Long Fuse) 9
            0x0015C8, // Fuel Rod round 1 10
            0x0015CF, // Fuel Rod round 2 11
            0x0015C9, // Rockets 12
            0x0015CA, // Missile Pod 13
            0x0015CB, // Wraith shots 14
            0x0015CD, // Brute Shot 15
            0x0015CE, // Hornet Rocket 16
            0x0015D0, // Frag Grenade (Red trail) 17
            0x001B90, // Assault Rifle Round 18
            0x001D88, // Battle Rifle Round 19
            0x001DBC, // Covenant Rifle Round 20
            0x001E12, // DMR/AR round 21
            0x001E49, // Plasma Rifle/Ghost Round 22 
            0x001F00, // Shotgun Pellet 23 
            0x001F51, // Magnum Round 24
            0x001F92, // Sniper Round 25
            0x002058, // Spiker Round 26
            0x00208F, // Mauler Round 27
            0x0020BD, // Human Projectile 28
            0x0020EF, // Needler Round 29
            0x00219E, // Machine Gun Turret Round 30
            0x00225C, // Plasma Pistol 31
            //Added in 0.1.2
            0x00225E, // Charged Plasma Pistol 32
            0x00240A, // Mauler Round (?) 33
            0x002413, // Unknown 34
            0x001A1E, // Plasma Bolt 1 35
            0x002571, // Plasma Bolt 2 36
            0x00384F, // Plasma Bolt 3 37 
            0x00245A, // Beam Rifle 38
            0x0024AC, // Spartan Laser 1 39
            0x0024AE, // Spartan Laser 2 40
            0x002528, // Banshee Projectile 41
            0x002558, // Gauss Shot 1 42
            0x0038BF, // Gauss Shot 2 43
            0x0028E1, // Scorpion Shot 44
            0x00322D, // Sentinel Beam 45
            0x003677, // Plasma Shot 1 46
            0x003799, // Plasma Shot 2 47
            0x0037B0, // AA Wraith 48
        };

        public static string[] list =
        {
            "Frag",
            "Plasma",
            "Spike",
            "Flame",
            "Spike",
            "Flamethrower Flame",
            "Flamethrower Flame 2",
            "Flamethrower Flame 3",
            "Flamethrower Flame 4",
            "Plasma (Long Fuse)",
            "Fuel Rod round 1",
            "Fuel Rod round 2",
            "Rockets",
            "Missile Pod",
            "Wraith shots",
            "Brute Shot",
            "Hornet Rocket",
            "Frag Grenade (Red trail)",
            "Assault Rifle Round",
            "Battle Rifle Round",
            "Covenant Rifle Round",
            "DMR/AR round",
            "Plasma Rifle/Ghost Round",
            "Shotgun Pellet",
            "Magnum Round",
            "Sniper Round",
            "Spiker Round",
            "Mauler Round",
            "Human Projectile",
            "Needler Round",
            "Machine Gun Turret Round",
            "Plasma Pistol",
            //Added in 0.1.2
            "Charged Plasma Pistol",
            "Mauler Round",
            "Human Projectile",
            "Plasma Bolt 1",
            "Plasma Bolt 2",
            "Plasma Bolt 3",
            "Beam Rifle",
            "Spartan Laser Sight",
            "Spartan Laser",
            "Banshee Projectile",
            "Gauss Shot 1",
            "Gauss Shot 2",
            "Scorpion Shot",
            "Sentinel Beam",
            "Plasma Shot 1",
            "Plasma Shot 2",
            "AA Wraith",
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
