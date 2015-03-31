using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halo_Online_Projectile_Editor
{
    public class Reset
    {
        public static uint[] projectiles =
        {
            /* to add your own projectiles from any of the spreadsheets, add the reverse endian of the hex to this list
             * e.g DD010000 for headless spartan will become 0x000001DD here.
             * Just remember to add your changes to the combo box in the form as well (and at the right place) */
            0x0020BD, // Human Projectile (?)
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
