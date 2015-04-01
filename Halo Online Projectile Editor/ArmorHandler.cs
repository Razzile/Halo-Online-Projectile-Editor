using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    class ArmorHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
            0x001530, // Armor 1
            0x001531, // Armor 2
            0x001532, // Armor 3
            0x001533, // Armor 4
            0x001534, // Armor 5
            0x001535, // Armor 6
            0x001536, // Armor 7
            0x001537, // Armor 8
            0x001538, // Armor 9
            0x001539, // Armor 10
            0x00153A, // Armor 11
            0x00153B, // Armor 12
            0x00153C, // Armor 13
            0x00153D, // Armor 14
            0x00153E, // Armor 15
            0x00153F, // Armor 16
            0x001540, // Armor 17
            0x001541, // Armor 18
            0x001542, // Armor 19
            0x001543, // Armor 20
            0x001544, // Armor 21
            0x001545, // Armor 22
            0x001546, // Armor 23
            0x001547, // Armor 24
            0x001548, // Armor 25
            0x001549, // Armor 26
            0x00154A, // Armor 27
        };
        public static string[] list =
        {
            "Armor 1",
            "Armor 2",
            "Armor 3",
            "Armor 4",
            "Armor 5",
            "Armor 6",
            "Armor 7",
            "Armor 8",
            "Armor 9",
            "Armor 10",
            "Armor 11",
            "Armor 12",
            "Armor 13",
            "Armor 14",
            "Armor 15",
            "Armor 16",
            "Armor 17",
            "Armor 18",
            "Armor 19",
            "Armor 20",
            "Armor 21",
            "Armor 22",
            "Armor 23",
            "Armor 24",
            "Armor 25",
            "Armor 26",
            "Armor 27",
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
