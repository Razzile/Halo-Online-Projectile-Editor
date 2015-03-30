using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Halo_Online_Projectile_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void projectileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (projectileCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                ProjectileHandler.SetNewProjectile(ProjectileHandler.projectiles[box.SelectedIndex]);
            }
        }

        private void godCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xB555DC;

            if (godCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0xF3, 0x0F, 0x11, 0x87, 0x00, 0x01, 0x00, 0x00 };
                // movss dword ptr [edi+100h], xmm0
                MemoryManager.WriteToAddress(addr, data);
            }
        }

        private void ammoCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xB5FACD;

            if (ammoCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0x66, 0x29, 0x94, 0x31, 0x8E, 0x02, 0x00, 0x00 };
                // sub [ecx+esi+28Eh], dx
                MemoryManager.WriteToAddress(addr, data);
            }
        }

        private void grenadeCheck_CheckedChanged(object sender, EventArgs e)
        {
            uint addr = 0xBA3C01;

            if (grenadeCheck.Checked)
            {
                byte[] data = { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 };
                // nop, nop, nop, nop, nop, nop
                MemoryManager.WriteToAddress(addr, data);
            }
            else
            {
                byte[] data = { 0x88, 0x81, 0x20, 0x03, 0x00, 0x00 };
                // mov [ecx+320h], al
                MemoryManager.WriteToAddress(addr, data);
            }
        }
    }
}
