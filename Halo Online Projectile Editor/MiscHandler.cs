using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class MiscHandler
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
        0x000001DD, // Headless Spartan 0
        0x00000C13, // Headless Spartan Hologram 1
        0x000015A0, // Monitor 2
        0x000015A1, // Forge Marker 3
        0x000015A5, // Spawn Point 4
        0x000015D1, // Trip Mine (Active) 5
        0x000015D3, // Flare 6
        0x000015D2, // Power Drain (Active) 7
        0x000015D4, // Power Drain Red (Active) 8
        0x000015D5, // Power Drain Yellow (Active) 9
        0x00001560, // New Equipment 10
        0x00001562, // Cloaking 1 11
        0x00001563, // Cloaking 2 12
        0x00001561, // Power Drain (Inactive) 13
        0x00001564, // Bubble Shield (Inactive) 14
        0x00001565, // Flare (Inactive) 15
        0x00001566, // Regen (Inactive) 16
        0x00001567, // Trip Mine (Inactive) 17
        0x00001568, // Sentry (Inactive) 18
        0x00001569, // Dropshield (Inactive) 19
        0x00001574, // Power Drain 1 (Inactive) 20
        0x00001575, // Power Drain 2 (Inactive) 21
        0x00001576, // Power Drain 3 (Inactive) 23
        //Added in 0.1.4 27 new
        0x000001AC, // Frag Grenade 24
        0x000001AF, // Plasma Grenade 25
        0x000001B2, // Spike Grenade 26
        0x000001B5, // Incendiary Grenade 27
        0x00002EBF, // Grav-Lift (Active) 28
        0x00002EA9, // Grav-Lift (Inactive) 29
        0x0000317F, // Grav-Lift Explosion 30
        0x00001A6E, // Drop Shield (Active) 31
        0x00001A6B, // Drop Shield (Inactive) 32
        0x00001B04, // Exploding Drop Shield 33
        0x0000016A, // Active Camo 34
        0x00002EAA, // Big Active Camo 35
        0x00002EAB, // Big Overshield 36
        0x00002EAC, // Big Custom Power-Up 37
        0x0000016C, // Yellow Cloaker 1 38
        0x0000016F, // Yellow Cloaker 2 39
        0x00001A6C, // Yellow Cloaker 3 40
        0x000018AC, // Blue Explosion 1 41
        0x00001B7E, // Blue Explosion 2 42
        0x0000196E, // Yellow Explosion 43
        0x00001965, // Green Explosion 44
        0x00001B8E, // Ammo Drop (Large) 45
        0x00001B8F, // Ammo Drop (Small) 46
        0x00001CA0, // Rocket Ammo 47
        0x00001EFF, // Small Ammobox 48
        0x00001F91, // Small Ammobox 2 49
        0x000020EE, // Unknown 50
        };
        public static string[] list =
        {
            "Headless Spartan", //0
            "Headless Spartan Hologram", //1
            "Monitor", //2
            "Forge Marker", //3
            "Spawn Point", //4
            "Trip Mine (Active)", //5
            "Flare", //6
            "Power Drain (Active)", //7
            "Power Drain Red (Active)", //8
            "Power Drain Yellow (Active)", //9
            "New Equipment", //10
            "Cloaking 1", //11
            "Cloaking 2", //12
            "Power Drain (Inactive)", //13
            "Bubble Shield (Inactive)", //14
            "Flare (Inactive)", //15
            "Regen (Inactive)", //16
            "Trip Mine (Inactive)", //17
            "Sentry (Inactive)", //18
            "Dropshield (Inactive)", //19
            "Power Drain 1 (Inactive)", //20
            "Power Drain 2 (Inactive)", //21
            "Power Drain 3 (Inactive)", //22
            // Added in 0.1.4
            "Frag Grenade", //23
            "Plasma Grenade", //24
            "Spike Grenade", //25
            "Incendiary Grenade", //26
            "Grav-Lift (Active)", //27
            "Grav-Lift (Inactive)", //28
            "Grav-Lift Explosion", //29
            "Drop Shield (Active)", //30
            "Drop Shield (Inactive)", //31
            "Exploding Drop Shield", //32
            "Active Camo", //33
            "Big Active Camo", // 34
            "Big Overshield", //35
            "Big Custom Power-Up", //36
            "Yellow Cloaker 1", //37
            "Yellow Cloaker 2", //38
            "Yellow Cloaker 3", //39
            "Blue Explosion 1", //40
            "Blue Explosion 2", //41
            "Yellow Explosion", //42
            "Green Explosion", //43
            "Ammo Drop (Large)", //44
            "Ammo Drop (Small)", //45
            "Rocket Ammo", //46
            "Small Ammobox", //47
            "Small Ammobox 2", //48
            "Unknown", //49
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
