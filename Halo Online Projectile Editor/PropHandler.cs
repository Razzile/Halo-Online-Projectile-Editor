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
        0x00002888, // Mounted Machine gun 0
        0x00001A8A, // Covenant Junk 1 1
        0x01001A8B, // Covenant Junk 2 2
        0x02001A8C, // Covenant Junk 3 3
        0x00002603, // Junk 1 4 
        0x00002607, // Junk 2 5
        0x00002608, // Junk 3 6
        0x00002958, // Scorpion junk 7
        0x000034A4, // Fusion Coil 8
        0x00002EC3, // Flag Stand 9
        0x00002EC3, // Flag Stand 2 10
        0x00002EC5, // Flag Stand 3 11
        0x00002ECA, // Flag Stand 4 12
        0x00002EED, // Invisible Prop 13
        0x00002EEE, // Invisible Prop 2 14
        0x00002EEF, // Invisible Prop 3 15
        0x00002EBC, // Unsc Crate 16
        0x00002EBD, // Generator 17
        0x00002EBE, // Covenant Weapon Holder 18
        0x00002EC0, // Teleporter Sender 19
        0x00002EC1, // Teleporter Reciever 20
        0x00002EC2, // Teleporter Two-way 21
        0x00002EC4, // Bomb Point 1 22
        0x00002EC6, // Bomb Point 2 23
        0x00002EC7, // Bomb Point 3 24
        0x00002EC9, // Bomb Point 4 25
        0x000015A5, // Hill Marker 1 26
        0x00002EC8, // Hill Marker 2 27
        0x00002EDC, // Hill Marker 3 28
        0x00002EDB, // Man Cannon 1 29
        0x000034BE, // Man Cannon 2 30
        0x000034BF, // Man Cannon 3 31
        0x000034A5, // Radio Antenna 32
        0x000034A6, // Small Crate 33
        0x000034A7, // Small Radio 34
        0x000034A8, // Drop Pod 35
        0x000034A9, // Drop Pod Cover 36
        0x000034AA, // Barrier 37
        0x000034AB, // Medical Crate 38
        0x000034C0, // Covenant Weapon Crate 39
        0x000034C1, // Barrel 40
        0x000034C2, // Jerry Can 41
        0x000034C3, // Small Jerry Can 42
        0x000034C4, // Tree 43
        0x000034C5, // Big Tree 44 
        //Added in 0.1.4
        0x00003F88, // Skybox 45
        0x00003F89, // Frigate 46
        0x00003F8A, // Red Light 47
        0x00003F8B, // Blue Light 48
        0x00003F8C, // Yellow Light 49
        0x00003F8D, // Sandbags 50
        0x00003F8E, // Sandbag 51
        0x00003F8F, // 2 Sandbags 52
        0x00003F90, // Curved Sandbags 53
        0x00003F91, // L Sandbags 54
        0x00003F92, // Long Sandbags 55
        0x00003F93, // Block Sandbags 56
        };
        public static string[] list =
        {
            "Mounted Machine gun",
            "Covenant Junk 1",
            "Covenant Junk 2",
            "Covenant Junk 3",
            "Junk 1",
            "Junk 2",
            "Junk 3",
            "Scorpion junk",
            "Fusion Coil",
            "Flag Stand",
            "Flag Stand 2",
            "Flag Stand 3",
            "Flag Stand 4",
            "Invisible Prop",
            "Invisible Prop 2",
            "Invisible Prop 3",
            "Unsc Crate",
            "Generator",
            "Covenant Weapon Holder",
            "Teleporter Sender",
            "Teleporter Reciever",
            "Teleporter Two-way",
            "Bomb Point 1",
            "Bomb Point 2",
            "Bomb Point 3",
            "Bomb Point 4",
            "Hill Marker 1",
            "Hill Marker 2",
            "Hill Marker 3",
            "Man Cannon 1",
            "Man Cannon 2",
            "Man Cannon 3",
            "Radio Antenna",
            "Small Crate",
            "Small Radio",
            "Drop Pod",
            "Drop Pod Cover",
            "Barrier",
            "Medical Crate",
            "Covenant Weapon Crate",
            "Barrel",
            "Jerry Can",
            "Small Jerry Can",
            "Tree",
            "Big Tree ",
            //Added in 0.1.4
            "Skybox",
            "Frigate",
            "Red Light",
            "Blue Light",
            "Yellow Light",
            "Sandbags",
            "Sandbag",
            "2 Sandbags",
            "Curved Sandbags",
            "L Sandbags",
            "Long Sandbags",
            "Block Sandbags",

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
