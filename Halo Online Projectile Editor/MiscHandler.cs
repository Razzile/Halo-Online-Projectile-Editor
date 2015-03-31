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
        0x000001DD, // Headless Spartan
        0x00000C13, // Headless Spartan Hologram
        0x000015A0, // Monitor
        0x000015A1, // Forge Marker
        0x000015A5, // Spawn Point
        0x000015D1, // Trip Mine (Active)
        0x000015D3, // Flare
        0x000015D2, // Power Drain (Active)
        0x000015D4, // Power Drain Red (Active)
        0x000015D5, // Power Drain Yellow (Active)
        0x00001560, // New Equipment
        0x00001562, // Cloaking 1
        0x00001563, // Cloaking 2
        0x00001561, // Power Drain (Inactive)
        0x00001564, // Bubble Shield (Inactive)
        0x00001565, // Flare (Inactive)
        0x00001566, // Regen (Inactive)
        0x00001567, // Trip Mine (Inactive)
        0x00001568, // Sentry (Inactive)
        0x00001569, // Dropshield (Inactive)
        0x00001574, // Power Drain 1 (Inactive)
        0x00001575, // Power Drain 2 (Inactive)
        0x00001576, // Power Drain 3 (Inactive)
            
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
