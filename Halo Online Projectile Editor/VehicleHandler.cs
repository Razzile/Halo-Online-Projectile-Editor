using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class VehicleHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
            0x00151A, // Banshee 0
            0x001517, // Ghost 1
            0x001596, // Mongoose 2
            0x001518, // Brute Chopper 3
            0x001516, // Shade 4
            0x001520, // Scorpion 5
            0x00151F, // Warthog 6
            0x0029EC, // Warthog (Chaingun) 7 
            0x0029ED, // Warthog (Gauss Rifle) 8
            0x0029EE, // Warthog (Troop) 9
            0x001599, // Warthog (Snow) 10
            0x00433A, // Warthog (Chaingun Snow) 11
            0x00433B, // Warthog (Gauss Rifle Snow) 12
            0x001598, // Hornet 13
            0x00159B, // Hornet (Lite) 14
            0x0027D8, // Hornet (Main Menu) 15
            0x001519, // Wraith 16
            0x003742, // Wraith (Mortar) 17
            0x003743, // Wraith (Anti-infantry) 18
            0x003744, // Wraith (Anti-Air) 19
            0x003745, // Wraith (Anti-Infantry + Air) 20

        };
        public static string[] list =
        {
            "Banshee",
            "Ghost",
            "Mongoose",
            "Brute Chopper",
            "Shade",
            "Scorpion",
            "Warthog",
            "Warthog (Chaingun)",
            "Warthog (Gauss Rifle)",
            "Warthog (Troop)",
            "Warthog (Snow)",
            "Warthog (Chaingun Snow)",
            "Warthog (Gauss Rifle Snow)",
            "Hornet",
            "Hornet (Lite)",
            "Hornet (Main Menu)",
            "Wraith",
            "Wraith (Mortar)",
            "Wraith (Anti-infantry)",
            "Wraith (Anti-Air)",
            "Wraith (Anti-Infantry + Air)",
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
