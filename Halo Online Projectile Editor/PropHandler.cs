using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    class PropHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
        0x00002888, // Mounted Machine gun
        0x00001A8A, // Covenant Junk 1
        0x01001A8B, // Covenant Junk 2
        0x02001A8C, // Covenant Junk 3
        0x00002603, // Junk 1
        0x00002607, // Junk 2
        0x00002608, // Junk 3
        0x00002958, // Scorpion junk
        0x000034A4, // Fusion Coil
        0x00002EC3, // Flag Stand
        0x00002EC3, // Flag Stand 2
        0x00002EC5, // Flag Stand 3
        0x00002ECA, // Flag Stand 4
        0x00002EED, // Invisible Prop
        0x00002EEE, // Invisible Prop 2
        0x00002EEF, // Invisible Prop 3
        0x00002EBC, // Unsc Crate
        0x00002EBD, // Generator
        0x00002EBE, // Covenant Weapon Holder
        0x00002EC0, // Teleporter Sender
        0x00002EC1, // Teleporter Reciever
        0x00002EC2, // Teleporter Two-way
        0x00002EC4, // Bomb Point 1
        0x00002EC6, // Bomb Point 2
        0x00002EC7, // Bomb Point 3
        0x00002EC9, // Bomb Point 4
        0x000015A5, // Hill Marker 1
        0x00002EC8, // Hill Marker 2
        0x00002EDC, // Hill Marker 3
        0x00002EDB, // Man Cannon 1
        0x000034BE, // Man Cannon 2
        0x000034BF, // Man Cannon 3
        0x000034A5, // Radio Antenna
        0x000034A6, // Small Crate
        0x000034A7, // Small Radio
        0x000034A8, // Drop Pod
        0x000034A9, // Drop Pod Cover
        0x000034AA, // Barrier
        0x000034AB, // Medical Crate
        0x000034C0, // Covenant Weapon Crate
        0x000034C1, // Barrel
        0x000034C2, // Jerry Can
        0x000034C3, // Small Jerry Can
        0x000034C4, // Tree
        0x000034C5, // Big Tree
        0x00000000, // Extra

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
