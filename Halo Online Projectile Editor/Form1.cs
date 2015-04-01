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

        private void projectileCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(ProjectileHandler.list, projectileCombo.SelectedItem);
                ProjectileHandler.SetNewProjectile(ProjectileHandler.projectiles[index]);
                label6.Text = "Selected: " + projectileCombo.SelectedItem;
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(WeaponHandler.list, weaponsCombo.SelectedItem);
                WeaponHandler.SetNewProjectile(WeaponHandler.projectiles[index]);
                label6.Text = "Selected: " + weaponsCombo.SelectedItem;
                projectileCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
            }
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(MiscHandler.list, miscCombo.SelectedItem);
                MiscHandler.SetNewProjectile(MiscHandler.projectiles[index]);
                label6.Text = "Selected: " + miscCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(VehicleHandler.list, vehiclesCombo.SelectedItem);
                VehicleHandler.SetNewProjectile(VehicleHandler.projectiles[index]);
                label6.Text = "Selected: " + vehiclesCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(ArmorHandler.list, armorCombo.SelectedItem);
                ArmorHandler.SetNewProjectile(ArmorHandler.projectiles[index]);
                label6.Text = "Selected: " + armorCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                propCombo.Text = "";
                miscCombo.Text = "";
            }
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                ComboBox box = (ComboBox)sender;
                int index = Array.IndexOf(PropHandler.list, propCombo.SelectedItem);
                PropHandler.SetNewProjectile(PropHandler.projectiles[index]);
                label6.Text = "Selected: " + propCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                miscCombo.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nexusau.com/halo-online-trainer");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                mapCombo.Enabled = true;
                groupBox2.Enabled = true;
                setButton.Enabled = true;
                mapLabel.Enabled = true;
            }
            else
            {
                mapCombo.Enabled = false;
                groupBox2.Enabled = false;
                setButton.Enabled = false;
                mapLabel.Enabled = false;
            }
        }

        private void mapCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                groupBox2.Enabled = true;
                mapLabel.Text = "Selected: " + mapCombo.SelectedItem;

                weaponsCombo.Items.Clear();
                vehiclesCombo.Items.Clear();
                propCombo.Items.Clear();
                projectileCombo.Items.Clear();
                miscCombo.Items.Clear();
                // LOAD ON SET BUTTON PRESS //
                //Weapons
                weaponsCombo.Items.Add(WeaponHandler.list[0]);
                weaponsCombo.Items.Add(WeaponHandler.list[1]);
                weaponsCombo.Items.Add(WeaponHandler.list[2]);
                weaponsCombo.Items.Add(WeaponHandler.list[3]);
                weaponsCombo.Items.Add(WeaponHandler.list[4]);
                weaponsCombo.Items.Add(WeaponHandler.list[5]);
                weaponsCombo.Items.Add(WeaponHandler.list[6]);
                weaponsCombo.Items.Add(WeaponHandler.list[7]);
                weaponsCombo.Items.Add(WeaponHandler.list[8]);
                weaponsCombo.Items.Add(WeaponHandler.list[9]);
                weaponsCombo.Items.Add(WeaponHandler.list[10]);
                weaponsCombo.Items.Add(WeaponHandler.list[11]);
                weaponsCombo.Items.Add(WeaponHandler.list[12]);
                weaponsCombo.Items.Add(WeaponHandler.list[13]);
                weaponsCombo.Items.Add(WeaponHandler.list[14]);
                weaponsCombo.Items.Add(WeaponHandler.list[15]);
                weaponsCombo.Items.Add(WeaponHandler.list[16]);
                weaponsCombo.Items.Add(WeaponHandler.list[17]);
                weaponsCombo.Items.Add(WeaponHandler.list[18]);
                weaponsCombo.Items.Add(WeaponHandler.list[19]);
                weaponsCombo.Items.Add(WeaponHandler.list[20]);
                weaponsCombo.Items.Add(WeaponHandler.list[21]);
                weaponsCombo.Items.Add(WeaponHandler.list[22]);
                weaponsCombo.Items.Add(WeaponHandler.list[23]);
                weaponsCombo.Items.Add(WeaponHandler.list[24]);
                weaponsCombo.Items.Add(WeaponHandler.list[25]);
                weaponsCombo.Items.Add(WeaponHandler.list[26]);
                weaponsCombo.Items.Add(WeaponHandler.list[27]);
                weaponsCombo.Items.Add(WeaponHandler.list[28]);
                weaponsCombo.Items.Add(WeaponHandler.list[29]);
                weaponsCombo.Items.Add(WeaponHandler.list[30]);
                weaponsCombo.Items.Add(WeaponHandler.list[31]);
                weaponsCombo.Items.Add(WeaponHandler.list[32]);
                weaponsCombo.Items.Add(WeaponHandler.list[33]);
                weaponsCombo.Items.Add(WeaponHandler.list[34]);
                weaponsCombo.Items.Add(WeaponHandler.list[35]);
                weaponsCombo.Items.Add(WeaponHandler.list[36]);
                weaponsCombo.Items.Add(WeaponHandler.list[37]);
                weaponsCombo.Items.Add(WeaponHandler.list[38]);
                weaponsCombo.Items.Add(WeaponHandler.list[39]);
                weaponsCombo.Items.Add(WeaponHandler.list[40]);
                weaponsCombo.Items.Add(WeaponHandler.list[41]);
                weaponsCombo.Items.Add(WeaponHandler.list[42]);
                weaponsCombo.Items.Add(WeaponHandler.list[43]);
                weaponsCombo.Items.Add(WeaponHandler.list[44]);
                weaponsCombo.Items.Add(WeaponHandler.list[45]);
                weaponsCombo.Items.Add(WeaponHandler.list[46]);
                weaponsCombo.Items.Add(WeaponHandler.list[47]);
                weaponsCombo.Items.Add(WeaponHandler.list[48]);
                weaponsCombo.Items.Add(WeaponHandler.list[49]);
                weaponsCombo.Items.Add(WeaponHandler.list[50]);
                weaponsCombo.Items.Add(WeaponHandler.list[51]);
                weaponsCombo.Items.Add(WeaponHandler.list[52]);
                weaponsCombo.Items.Add(WeaponHandler.list[53]);
                weaponsCombo.Items.Add(WeaponHandler.list[54]);
                weaponsCombo.Items.Add(WeaponHandler.list[55]); //blue br
                weaponsCombo.Items.Add(WeaponHandler.list[56]);
                //Vehicles
                vehiclesCombo.Items.Add(VehicleHandler.list[0]);
                vehiclesCombo.Items.Add(VehicleHandler.list[1]);
                vehiclesCombo.Items.Add(VehicleHandler.list[2]);
                vehiclesCombo.Items.Add(VehicleHandler.list[3]);
                vehiclesCombo.Items.Add(VehicleHandler.list[4]);
                vehiclesCombo.Items.Add(VehicleHandler.list[5]);
                vehiclesCombo.Items.Add(VehicleHandler.list[6]); //Scorpion
                vehiclesCombo.Items.Add(VehicleHandler.list[7]);
                vehiclesCombo.Items.Add(VehicleHandler.list[8]);
                vehiclesCombo.Items.Add(VehicleHandler.list[9]);
                vehiclesCombo.Items.Add(VehicleHandler.list[10]);
                vehiclesCombo.Items.Add(VehicleHandler.list[11]);
                vehiclesCombo.Items.Add(VehicleHandler.list[12]);
                vehiclesCombo.Items.Add(VehicleHandler.list[13]);
                vehiclesCombo.Items.Add(VehicleHandler.list[14]);
                vehiclesCombo.Items.Add(VehicleHandler.list[15]);
                vehiclesCombo.Items.Add(VehicleHandler.list[16]);
                vehiclesCombo.Items.Add(VehicleHandler.list[17]);
                vehiclesCombo.Items.Add(VehicleHandler.list[18]); //Water Drum
                vehiclesCombo.Items.Add(VehicleHandler.list[19]);
                vehiclesCombo.Items.Add(VehicleHandler.list[20]); //Turret
                //ProJectile
                projectileCombo.Items.Add(ProjectileHandler.list[0]);
                projectileCombo.Items.Add(ProjectileHandler.list[1]);
                projectileCombo.Items.Add(ProjectileHandler.list[2]);
                projectileCombo.Items.Add(ProjectileHandler.list[3]);
                projectileCombo.Items.Add(ProjectileHandler.list[4]);
                projectileCombo.Items.Add(ProjectileHandler.list[5]);
                projectileCombo.Items.Add(ProjectileHandler.list[6]);
                projectileCombo.Items.Add(ProjectileHandler.list[7]);
                projectileCombo.Items.Add(ProjectileHandler.list[8]);
                projectileCombo.Items.Add(ProjectileHandler.list[9]);
                projectileCombo.Items.Add(ProjectileHandler.list[10]);
                projectileCombo.Items.Add(ProjectileHandler.list[11]);
                projectileCombo.Items.Add(ProjectileHandler.list[12]);
                projectileCombo.Items.Add(ProjectileHandler.list[13]);
                projectileCombo.Items.Add(ProjectileHandler.list[14]);
                projectileCombo.Items.Add(ProjectileHandler.list[15]);
                projectileCombo.Items.Add(ProjectileHandler.list[16]);
                projectileCombo.Items.Add(ProjectileHandler.list[17]);
                projectileCombo.Items.Add(ProjectileHandler.list[18]);
                projectileCombo.Items.Add(ProjectileHandler.list[19]);
                projectileCombo.Items.Add(ProjectileHandler.list[20]);
                projectileCombo.Items.Add(ProjectileHandler.list[21]);
                projectileCombo.Items.Add(ProjectileHandler.list[22]);
                projectileCombo.Items.Add(ProjectileHandler.list[23]);
                projectileCombo.Items.Add(ProjectileHandler.list[24]);
                projectileCombo.Items.Add(ProjectileHandler.list[25]);
                projectileCombo.Items.Add(ProjectileHandler.list[26]);
                projectileCombo.Items.Add(ProjectileHandler.list[27]);
                projectileCombo.Items.Add(ProjectileHandler.list[28]);
                projectileCombo.Items.Add(ProjectileHandler.list[29]);
                projectileCombo.Items.Add(ProjectileHandler.list[30]);
                projectileCombo.Items.Add(ProjectileHandler.list[31]);
                //Added in 0.1.2
                projectileCombo.Items.Add(ProjectileHandler.list[32]);
                projectileCombo.Items.Add(ProjectileHandler.list[33]);
                projectileCombo.Items.Add(ProjectileHandler.list[34]);
                projectileCombo.Items.Add(ProjectileHandler.list[35]);
                projectileCombo.Items.Add(ProjectileHandler.list[36]);
                projectileCombo.Items.Add(ProjectileHandler.list[37]);
                projectileCombo.Items.Add(ProjectileHandler.list[38]);
                projectileCombo.Items.Add(ProjectileHandler.list[39]);
                projectileCombo.Items.Add(ProjectileHandler.list[40]);
                projectileCombo.Items.Add(ProjectileHandler.list[41]);
                projectileCombo.Items.Add(ProjectileHandler.list[42]);
                projectileCombo.Items.Add(ProjectileHandler.list[43]);
                projectileCombo.Items.Add(ProjectileHandler.list[44]);
                projectileCombo.Items.Add(ProjectileHandler.list[45]);
                projectileCombo.Items.Add(ProjectileHandler.list[46]);
                projectileCombo.Items.Add(ProjectileHandler.list[47]);
                projectileCombo.Items.Add(ProjectileHandler.list[48]);
                //Props
                propCombo.Items.Add(PropHandler.list[0]);
                propCombo.Items.Add(PropHandler.list[1]);
                propCombo.Items.Add(PropHandler.list[2]);
                propCombo.Items.Add(PropHandler.list[3]);
                propCombo.Items.Add(PropHandler.list[4]);
                propCombo.Items.Add(PropHandler.list[5]);
                propCombo.Items.Add(PropHandler.list[6]);
                propCombo.Items.Add(PropHandler.list[7]);
                propCombo.Items.Add(PropHandler.list[8]);
                propCombo.Items.Add(PropHandler.list[9]);
                propCombo.Items.Add(PropHandler.list[10]);
                propCombo.Items.Add(PropHandler.list[11]);
                propCombo.Items.Add(PropHandler.list[12]);
                propCombo.Items.Add(PropHandler.list[13]);
                propCombo.Items.Add(PropHandler.list[14]);
                propCombo.Items.Add(PropHandler.list[15]);
                propCombo.Items.Add(PropHandler.list[16]);
                propCombo.Items.Add(PropHandler.list[17]);
                propCombo.Items.Add(PropHandler.list[18]);
                propCombo.Items.Add(PropHandler.list[19]);
                propCombo.Items.Add(PropHandler.list[20]);
                propCombo.Items.Add(PropHandler.list[21]);
                propCombo.Items.Add(PropHandler.list[22]);
                propCombo.Items.Add(PropHandler.list[23]);
                propCombo.Items.Add(PropHandler.list[24]);
                propCombo.Items.Add(PropHandler.list[25]);
                propCombo.Items.Add(PropHandler.list[26]);
                propCombo.Items.Add(PropHandler.list[27]);
                propCombo.Items.Add(PropHandler.list[28]);
                propCombo.Items.Add(PropHandler.list[29]);
                propCombo.Items.Add(PropHandler.list[30]);
                propCombo.Items.Add(PropHandler.list[31]);
                propCombo.Items.Add(PropHandler.list[32]);
                propCombo.Items.Add(PropHandler.list[33]);
                propCombo.Items.Add(PropHandler.list[34]);
                propCombo.Items.Add(PropHandler.list[35]);
                propCombo.Items.Add(PropHandler.list[36]);
                propCombo.Items.Add(PropHandler.list[37]);
                propCombo.Items.Add(PropHandler.list[38]);
                propCombo.Items.Add(PropHandler.list[39]);
                propCombo.Items.Add(PropHandler.list[40]);
                propCombo.Items.Add(PropHandler.list[41]);
                propCombo.Items.Add(PropHandler.list[42]);
                propCombo.Items.Add(PropHandler.list[43]);
                propCombo.Items.Add(PropHandler.list[44]);
                //Added in 0.1.4
                propCombo.Items.Add(PropHandler.list[45]);
                propCombo.Items.Add(PropHandler.list[46]);
                propCombo.Items.Add(PropHandler.list[47]);
                propCombo.Items.Add(PropHandler.list[48]);
                propCombo.Items.Add(PropHandler.list[49]);
                propCombo.Items.Add(PropHandler.list[50]);
                propCombo.Items.Add(PropHandler.list[51]);
                propCombo.Items.Add(PropHandler.list[52]);
                propCombo.Items.Add(PropHandler.list[53]);
                propCombo.Items.Add(PropHandler.list[54]);
                propCombo.Items.Add(PropHandler.list[55]);
                propCombo.Items.Add(PropHandler.list[56]);
                //Equipment (Added in 0.1.4)
                miscCombo.Items.Add(MiscHandler.list[0]);
                miscCombo.Items.Add(MiscHandler.list[1]);
                miscCombo.Items.Add(MiscHandler.list[2]);
                miscCombo.Items.Add(MiscHandler.list[3]);
                miscCombo.Items.Add(MiscHandler.list[4]);
                miscCombo.Items.Add(MiscHandler.list[5]);
                miscCombo.Items.Add(MiscHandler.list[6]);
                miscCombo.Items.Add(MiscHandler.list[7]);
                miscCombo.Items.Add(MiscHandler.list[8]);
                miscCombo.Items.Add(MiscHandler.list[9]);
                miscCombo.Items.Add(MiscHandler.list[10]);
                miscCombo.Items.Add(MiscHandler.list[11]);
                miscCombo.Items.Add(MiscHandler.list[12]);
                miscCombo.Items.Add(MiscHandler.list[13]);
                miscCombo.Items.Add(MiscHandler.list[14]);
                miscCombo.Items.Add(MiscHandler.list[15]);
                miscCombo.Items.Add(MiscHandler.list[16]);
                miscCombo.Items.Add(MiscHandler.list[17]);
                miscCombo.Items.Add(MiscHandler.list[18]);
                miscCombo.Items.Add(MiscHandler.list[19]);
                miscCombo.Items.Add(MiscHandler.list[20]);
                miscCombo.Items.Add(MiscHandler.list[21]);
                miscCombo.Items.Add(MiscHandler.list[22]);
                miscCombo.Items.Add(MiscHandler.list[23]);
                miscCombo.Items.Add(MiscHandler.list[24]);
                miscCombo.Items.Add(MiscHandler.list[25]);
                miscCombo.Items.Add(MiscHandler.list[26]);
                miscCombo.Items.Add(MiscHandler.list[27]);
                miscCombo.Items.Add(MiscHandler.list[28]);
                miscCombo.Items.Add(MiscHandler.list[29]);
                miscCombo.Items.Add(MiscHandler.list[30]);
                miscCombo.Items.Add(MiscHandler.list[31]);
                miscCombo.Items.Add(MiscHandler.list[32]);
                miscCombo.Items.Add(MiscHandler.list[33]);
                miscCombo.Items.Add(MiscHandler.list[34]);
                miscCombo.Items.Add(MiscHandler.list[35]);
                miscCombo.Items.Add(MiscHandler.list[36]);
                miscCombo.Items.Add(MiscHandler.list[37]);
                miscCombo.Items.Add(MiscHandler.list[38]);
                miscCombo.Items.Add(MiscHandler.list[39]);
                miscCombo.Items.Add(MiscHandler.list[40]);
                miscCombo.Items.Add(MiscHandler.list[41]);
                miscCombo.Items.Add(MiscHandler.list[42]);
                miscCombo.Items.Add(MiscHandler.list[43]);
                miscCombo.Items.Add(MiscHandler.list[44]);
                miscCombo.Items.Add(MiscHandler.list[45]);
                miscCombo.Items.Add(MiscHandler.list[46]);
                miscCombo.Items.Add(MiscHandler.list[47]);
                miscCombo.Items.Add(MiscHandler.list[48]);
                miscCombo.Items.Add(MiscHandler.list[49]);
            }
            if (mapCombo.SelectedItem.ToString() == "Default")
            {
                weaponsCombo.Items.Clear();
                vehiclesCombo.Items.Clear();
                propCombo.Items.Clear();
                projectileCombo.Items.Clear();
                // LOAD ON SET BUTTON PRESS //
                //Weapons
                weaponsCombo.Items.Add(WeaponHandler.list[0]);
                weaponsCombo.Items.Add(WeaponHandler.list[1]);
                weaponsCombo.Items.Add(WeaponHandler.list[2]);
                weaponsCombo.Items.Add(WeaponHandler.list[3]);
                weaponsCombo.Items.Add(WeaponHandler.list[4]);
                weaponsCombo.Items.Add(WeaponHandler.list[5]);
                weaponsCombo.Items.Add(WeaponHandler.list[6]);
                weaponsCombo.Items.Add(WeaponHandler.list[7]);
                weaponsCombo.Items.Add(WeaponHandler.list[8]);
                weaponsCombo.Items.Add(WeaponHandler.list[9]);
                weaponsCombo.Items.Add(WeaponHandler.list[10]);
                weaponsCombo.Items.Add(WeaponHandler.list[11]);
                weaponsCombo.Items.Add(WeaponHandler.list[12]);
                weaponsCombo.Items.Add(WeaponHandler.list[13]);
                weaponsCombo.Items.Add(WeaponHandler.list[14]);
                weaponsCombo.Items.Add(WeaponHandler.list[15]);
                weaponsCombo.Items.Add(WeaponHandler.list[16]);
                weaponsCombo.Items.Add(WeaponHandler.list[17]);
                weaponsCombo.Items.Add(WeaponHandler.list[18]);
                weaponsCombo.Items.Add(WeaponHandler.list[19]);
                weaponsCombo.Items.Add(WeaponHandler.list[20]);
                weaponsCombo.Items.Add(WeaponHandler.list[21]);
                weaponsCombo.Items.Add(WeaponHandler.list[22]);
                weaponsCombo.Items.Add(WeaponHandler.list[23]);
                weaponsCombo.Items.Add(WeaponHandler.list[24]);
                weaponsCombo.Items.Add(WeaponHandler.list[25]);
                weaponsCombo.Items.Add(WeaponHandler.list[26]);
                weaponsCombo.Items.Add(WeaponHandler.list[27]);
                weaponsCombo.Items.Add(WeaponHandler.list[28]);
                weaponsCombo.Items.Add(WeaponHandler.list[29]);
                weaponsCombo.Items.Add(WeaponHandler.list[30]);
                weaponsCombo.Items.Add(WeaponHandler.list[31]);
                weaponsCombo.Items.Add(WeaponHandler.list[32]);
                weaponsCombo.Items.Add(WeaponHandler.list[33]);
                weaponsCombo.Items.Add(WeaponHandler.list[34]);
                weaponsCombo.Items.Add(WeaponHandler.list[35]);
                weaponsCombo.Items.Add(WeaponHandler.list[36]);
                weaponsCombo.Items.Add(WeaponHandler.list[37]);
                weaponsCombo.Items.Add(WeaponHandler.list[38]);
                weaponsCombo.Items.Add(WeaponHandler.list[39]);
                weaponsCombo.Items.Add(WeaponHandler.list[40]);
                weaponsCombo.Items.Add(WeaponHandler.list[41]);
                weaponsCombo.Items.Add(WeaponHandler.list[42]);
                weaponsCombo.Items.Add(WeaponHandler.list[43]);
                weaponsCombo.Items.Add(WeaponHandler.list[44]);
                weaponsCombo.Items.Add(WeaponHandler.list[45]);
                weaponsCombo.Items.Add(WeaponHandler.list[46]);
                weaponsCombo.Items.Add(WeaponHandler.list[47]);
                weaponsCombo.Items.Add(WeaponHandler.list[48]);
                weaponsCombo.Items.Add(WeaponHandler.list[49]);
                weaponsCombo.Items.Add(WeaponHandler.list[50]);
                weaponsCombo.Items.Add(WeaponHandler.list[51]);
                weaponsCombo.Items.Add(WeaponHandler.list[52]);
                weaponsCombo.Items.Add(WeaponHandler.list[53]);
                weaponsCombo.Items.Add(WeaponHandler.list[54]);
                weaponsCombo.Items.Add(WeaponHandler.list[55]); //blue br
                weaponsCombo.Items.Add(WeaponHandler.list[56]);
                //Vehicles
                vehiclesCombo.Items.Add(VehicleHandler.list[0]);
                vehiclesCombo.Items.Add(VehicleHandler.list[1]);
                vehiclesCombo.Items.Add(VehicleHandler.list[2]);
                vehiclesCombo.Items.Add(VehicleHandler.list[3]);
                vehiclesCombo.Items.Add(VehicleHandler.list[4]);
                vehiclesCombo.Items.Add(VehicleHandler.list[5]);
                vehiclesCombo.Items.Add(VehicleHandler.list[6]); //Scorpion
                vehiclesCombo.Items.Add(VehicleHandler.list[7]);
                vehiclesCombo.Items.Add(VehicleHandler.list[8]);
                vehiclesCombo.Items.Add(VehicleHandler.list[9]);
                vehiclesCombo.Items.Add(VehicleHandler.list[10]);
                vehiclesCombo.Items.Add(VehicleHandler.list[11]);
                vehiclesCombo.Items.Add(VehicleHandler.list[12]);
                vehiclesCombo.Items.Add(VehicleHandler.list[13]);
                vehiclesCombo.Items.Add(VehicleHandler.list[14]);
                vehiclesCombo.Items.Add(VehicleHandler.list[15]);
                vehiclesCombo.Items.Add(VehicleHandler.list[16]);
                vehiclesCombo.Items.Add(VehicleHandler.list[17]);
                vehiclesCombo.Items.Add(VehicleHandler.list[18]); //Water Drum
                vehiclesCombo.Items.Add(VehicleHandler.list[19]);
                vehiclesCombo.Items.Add(VehicleHandler.list[20]); //Turret
                //ProJectile
                projectileCombo.Items.Add(ProjectileHandler.list[0]);
                projectileCombo.Items.Add(ProjectileHandler.list[1]);
                projectileCombo.Items.Add(ProjectileHandler.list[2]);
                projectileCombo.Items.Add(ProjectileHandler.list[3]);
                projectileCombo.Items.Add(ProjectileHandler.list[4]);
                projectileCombo.Items.Add(ProjectileHandler.list[5]);
                projectileCombo.Items.Add(ProjectileHandler.list[6]);
                projectileCombo.Items.Add(ProjectileHandler.list[7]);
                projectileCombo.Items.Add(ProjectileHandler.list[8]);
                projectileCombo.Items.Add(ProjectileHandler.list[9]);
                projectileCombo.Items.Add(ProjectileHandler.list[10]);
                projectileCombo.Items.Add(ProjectileHandler.list[11]);
                projectileCombo.Items.Add(ProjectileHandler.list[12]);
                projectileCombo.Items.Add(ProjectileHandler.list[13]);
                projectileCombo.Items.Add(ProjectileHandler.list[14]);
                projectileCombo.Items.Add(ProjectileHandler.list[15]);
                projectileCombo.Items.Add(ProjectileHandler.list[16]);
                projectileCombo.Items.Add(ProjectileHandler.list[17]);
                projectileCombo.Items.Add(ProjectileHandler.list[18]);
                projectileCombo.Items.Add(ProjectileHandler.list[19]);
                projectileCombo.Items.Add(ProjectileHandler.list[20]);
                projectileCombo.Items.Add(ProjectileHandler.list[21]);
                projectileCombo.Items.Add(ProjectileHandler.list[22]);
                projectileCombo.Items.Add(ProjectileHandler.list[23]);
                projectileCombo.Items.Add(ProjectileHandler.list[24]);
                projectileCombo.Items.Add(ProjectileHandler.list[25]);
                projectileCombo.Items.Add(ProjectileHandler.list[26]);
                projectileCombo.Items.Add(ProjectileHandler.list[27]);
                projectileCombo.Items.Add(ProjectileHandler.list[28]);
                projectileCombo.Items.Add(ProjectileHandler.list[29]);
                projectileCombo.Items.Add(ProjectileHandler.list[30]);
                projectileCombo.Items.Add(ProjectileHandler.list[31]);
                //Added in 0.1.2
                projectileCombo.Items.Add(ProjectileHandler.list[32]);
                projectileCombo.Items.Add(ProjectileHandler.list[33]);
                projectileCombo.Items.Add(ProjectileHandler.list[34]);
                projectileCombo.Items.Add(ProjectileHandler.list[35]);
                projectileCombo.Items.Add(ProjectileHandler.list[36]);
                projectileCombo.Items.Add(ProjectileHandler.list[37]);
                projectileCombo.Items.Add(ProjectileHandler.list[38]);
                projectileCombo.Items.Add(ProjectileHandler.list[39]);
                projectileCombo.Items.Add(ProjectileHandler.list[40]);
                projectileCombo.Items.Add(ProjectileHandler.list[41]);
                projectileCombo.Items.Add(ProjectileHandler.list[42]);
                projectileCombo.Items.Add(ProjectileHandler.list[43]);
                projectileCombo.Items.Add(ProjectileHandler.list[44]);
                projectileCombo.Items.Add(ProjectileHandler.list[45]);
                projectileCombo.Items.Add(ProjectileHandler.list[46]);
                projectileCombo.Items.Add(ProjectileHandler.list[47]);
                projectileCombo.Items.Add(ProjectileHandler.list[48]);
                //Props
                propCombo.Items.Add(PropHandler.list[0]);
                propCombo.Items.Add(PropHandler.list[1]);
                propCombo.Items.Add(PropHandler.list[2]);
                propCombo.Items.Add(PropHandler.list[3]);
                propCombo.Items.Add(PropHandler.list[4]);
                propCombo.Items.Add(PropHandler.list[5]);
                propCombo.Items.Add(PropHandler.list[6]);
                propCombo.Items.Add(PropHandler.list[7]);
                propCombo.Items.Add(PropHandler.list[8]);
                propCombo.Items.Add(PropHandler.list[9]);
                propCombo.Items.Add(PropHandler.list[10]);
                propCombo.Items.Add(PropHandler.list[11]);
                propCombo.Items.Add(PropHandler.list[12]);
                propCombo.Items.Add(PropHandler.list[13]);
                propCombo.Items.Add(PropHandler.list[14]);
                propCombo.Items.Add(PropHandler.list[15]);
                propCombo.Items.Add(PropHandler.list[16]);
                propCombo.Items.Add(PropHandler.list[17]);
                propCombo.Items.Add(PropHandler.list[18]);
                propCombo.Items.Add(PropHandler.list[19]);
                propCombo.Items.Add(PropHandler.list[20]);
                propCombo.Items.Add(PropHandler.list[21]);
                propCombo.Items.Add(PropHandler.list[22]);
                propCombo.Items.Add(PropHandler.list[23]);
                propCombo.Items.Add(PropHandler.list[24]);
                propCombo.Items.Add(PropHandler.list[25]);
                propCombo.Items.Add(PropHandler.list[26]);
                propCombo.Items.Add(PropHandler.list[27]);
                propCombo.Items.Add(PropHandler.list[28]);
                propCombo.Items.Add(PropHandler.list[29]);
                propCombo.Items.Add(PropHandler.list[30]);
                propCombo.Items.Add(PropHandler.list[31]);
                propCombo.Items.Add(PropHandler.list[32]);
                propCombo.Items.Add(PropHandler.list[33]);
                propCombo.Items.Add(PropHandler.list[34]);
                propCombo.Items.Add(PropHandler.list[35]);
                propCombo.Items.Add(PropHandler.list[36]);
                propCombo.Items.Add(PropHandler.list[37]);
                propCombo.Items.Add(PropHandler.list[38]);
                propCombo.Items.Add(PropHandler.list[39]);
                propCombo.Items.Add(PropHandler.list[40]);
                propCombo.Items.Add(PropHandler.list[41]);
                propCombo.Items.Add(PropHandler.list[42]);
                propCombo.Items.Add(PropHandler.list[43]);
                propCombo.Items.Add(PropHandler.list[44]);
                //Added in 0.1.4
                propCombo.Items.Add(PropHandler.list[45]);
                propCombo.Items.Add(PropHandler.list[46]);
                propCombo.Items.Add(PropHandler.list[47]);
                propCombo.Items.Add(PropHandler.list[48]);
                propCombo.Items.Add(PropHandler.list[49]);
                propCombo.Items.Add(PropHandler.list[50]);
                propCombo.Items.Add(PropHandler.list[51]);
                propCombo.Items.Add(PropHandler.list[52]);
                propCombo.Items.Add(PropHandler.list[53]);
                propCombo.Items.Add(PropHandler.list[54]);
                propCombo.Items.Add(PropHandler.list[55]);
                propCombo.Items.Add(PropHandler.list[56]);
                //Equipment (Added in 0.1.4)
                miscCombo.Items.Add(MiscHandler.list[0]);
                miscCombo.Items.Add(MiscHandler.list[1]);
                miscCombo.Items.Add(MiscHandler.list[2]);
                miscCombo.Items.Add(MiscHandler.list[3]);
                miscCombo.Items.Add(MiscHandler.list[4]);
                miscCombo.Items.Add(MiscHandler.list[5]);
                miscCombo.Items.Add(MiscHandler.list[6]);
                miscCombo.Items.Add(MiscHandler.list[7]);
                miscCombo.Items.Add(MiscHandler.list[8]);
                miscCombo.Items.Add(MiscHandler.list[9]);
                miscCombo.Items.Add(MiscHandler.list[10]);
                miscCombo.Items.Add(MiscHandler.list[11]);
                miscCombo.Items.Add(MiscHandler.list[12]);
                miscCombo.Items.Add(MiscHandler.list[13]);
                miscCombo.Items.Add(MiscHandler.list[14]);
                miscCombo.Items.Add(MiscHandler.list[15]);
                miscCombo.Items.Add(MiscHandler.list[16]);
                miscCombo.Items.Add(MiscHandler.list[17]);
                miscCombo.Items.Add(MiscHandler.list[18]);
                miscCombo.Items.Add(MiscHandler.list[19]);
                miscCombo.Items.Add(MiscHandler.list[20]);
                miscCombo.Items.Add(MiscHandler.list[21]);
                miscCombo.Items.Add(MiscHandler.list[22]);
                miscCombo.Items.Add(MiscHandler.list[23]);
                miscCombo.Items.Add(MiscHandler.list[24]);
                miscCombo.Items.Add(MiscHandler.list[25]);
                miscCombo.Items.Add(MiscHandler.list[26]);
                miscCombo.Items.Add(MiscHandler.list[27]);
                miscCombo.Items.Add(MiscHandler.list[28]);
                miscCombo.Items.Add(MiscHandler.list[29]);
                miscCombo.Items.Add(MiscHandler.list[30]);
                miscCombo.Items.Add(MiscHandler.list[31]);
                miscCombo.Items.Add(MiscHandler.list[32]);
                miscCombo.Items.Add(MiscHandler.list[33]);
                miscCombo.Items.Add(MiscHandler.list[34]);
                miscCombo.Items.Add(MiscHandler.list[35]);
                miscCombo.Items.Add(MiscHandler.list[36]);
                miscCombo.Items.Add(MiscHandler.list[37]);
                miscCombo.Items.Add(MiscHandler.list[38]);
                miscCombo.Items.Add(MiscHandler.list[39]);
                miscCombo.Items.Add(MiscHandler.list[40]);
                miscCombo.Items.Add(MiscHandler.list[41]);
                miscCombo.Items.Add(MiscHandler.list[42]);
                miscCombo.Items.Add(MiscHandler.list[43]);
                miscCombo.Items.Add(MiscHandler.list[44]);
                miscCombo.Items.Add(MiscHandler.list[45]);
                miscCombo.Items.Add(MiscHandler.list[46]);
                miscCombo.Items.Add(MiscHandler.list[47]);
                miscCombo.Items.Add(MiscHandler.list[48]);
                miscCombo.Items.Add(MiscHandler.list[49]);
            }
            
            if (mapCombo.SelectedItem.ToString() == "Guardian")
            {
                //Weapons(None)
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove(VehicleHandler.list[0]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[1]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[3]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[5]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[6]); //Scorpion
                vehiclesCombo.Items.Remove(VehicleHandler.list[7]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[8]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[9]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[10]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[11]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[12]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[13]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[14]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[15]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[16]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[17]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[18]); //Water Drum
                vehiclesCombo.Items.Remove(VehicleHandler.list[19]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[20]); //Turret
                //Projectiles
                projectileCombo.Items.Remove(ProjectileHandler.list[10]);
                projectileCombo.Items.Remove(ProjectileHandler.list[14]);
                projectileCombo.Items.Remove(ProjectileHandler.list[16]);
                projectileCombo.Items.Remove(ProjectileHandler.list[37]);
                projectileCombo.Items.Remove(ProjectileHandler.list[43]);
                projectileCombo.Items.Remove(ProjectileHandler.list[44]);
                projectileCombo.Items.Remove(ProjectileHandler.list[46]);
                projectileCombo.Items.Remove(ProjectileHandler.list[47]);
                projectileCombo.Items.Remove(ProjectileHandler.list[48]);
                //Props
                propCombo.Items.Remove(PropHandler.list[7]);
                propCombo.Items.Remove(PropHandler.list[8]);
                propCombo.Items.Remove(PropHandler.list[30]);
                propCombo.Items.Remove(PropHandler.list[31]);
                propCombo.Items.Remove(PropHandler.list[32]);
                propCombo.Items.Remove(PropHandler.list[33]);
                propCombo.Items.Remove(PropHandler.list[34]);
                propCombo.Items.Remove(PropHandler.list[35]);
                propCombo.Items.Remove(PropHandler.list[36]);
                propCombo.Items.Remove(PropHandler.list[37]);
                propCombo.Items.Remove(PropHandler.list[38]);
                propCombo.Items.Remove(PropHandler.list[39]);
                propCombo.Items.Remove(PropHandler.list[40]);
                propCombo.Items.Remove(PropHandler.list[41]);
                propCombo.Items.Remove(PropHandler.list[42]);
                propCombo.Items.Remove(PropHandler.list[43]);
                propCombo.Items.Remove(PropHandler.list[44]);
            }

            if (mapCombo.SelectedItem.ToString() == "Riverworld")
            {
                //Weapons(None)
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove(VehicleHandler.list[4]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[10]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[11]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[12]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[14]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[15]);
                //Projectiles(None)
                //Props
                propCombo.Items.Remove(PropHandler.list[30]);

            }
            if (mapCombo.SelectedItem.ToString() == "s3d_avalanche")
            {
                //Weapons(None)
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove(VehicleHandler.list[4]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[10]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[11]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[13]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[12]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[15]);
                //Projectiles(None)
                //Prop
                propCombo.Items.Remove(PropHandler.list[7]);
                propCombo.Items.Remove(PropHandler.list[28]);
                propCombo.Items.Remove(PropHandler.list[31]);
                propCombo.Items.Remove(PropHandler.list[32]);
                propCombo.Items.Remove(PropHandler.list[33]);
                propCombo.Items.Remove(PropHandler.list[34]);
                propCombo.Items.Remove(PropHandler.list[35]);
                propCombo.Items.Remove(PropHandler.list[36]);
                propCombo.Items.Remove(PropHandler.list[37]);
                propCombo.Items.Remove(PropHandler.list[38]);
                propCombo.Items.Remove(PropHandler.list[39]);
                propCombo.Items.Remove(PropHandler.list[40]);
                propCombo.Items.Remove(PropHandler.list[42]);
                propCombo.Items.Remove(PropHandler.list[43]);
                propCombo.Items.Remove(PropHandler.list[44]);
            }


            if (mapCombo.SelectedItem.ToString() == "s3d_edge")
            {
                //Weapons
                weaponsCombo.Items.Remove(WeaponHandler.list[56]);
                //Vehicles
                vehiclesCombo.Enabled = false;
                //Projectiles
                projectileCombo.Items.Remove(ProjectileHandler.list[10]);
                projectileCombo.Items.Remove(ProjectileHandler.list[14]);
                projectileCombo.Items.Remove(ProjectileHandler.list[16]);
                projectileCombo.Items.Remove(ProjectileHandler.list[37]);
                projectileCombo.Items.Remove(ProjectileHandler.list[43]);
                projectileCombo.Items.Remove(ProjectileHandler.list[44]);
                projectileCombo.Items.Remove(ProjectileHandler.list[46]);
                projectileCombo.Items.Remove(ProjectileHandler.list[47]);
                projectileCombo.Items.Remove(ProjectileHandler.list[48]);
                //Props
                propCombo.Items.Remove(PropHandler.list[1]);
                propCombo.Items.Remove(PropHandler.list[7]);
                propCombo.Items.Remove(PropHandler.list[8]);
                propCombo.Items.Remove(PropHandler.list[10]);
                propCombo.Items.Remove(PropHandler.list[12]);
                propCombo.Items.Remove(PropHandler.list[13]);
                propCombo.Items.Remove(PropHandler.list[14]);
                propCombo.Items.Remove(PropHandler.list[15]);
                propCombo.Items.Remove(PropHandler.list[16]);
                propCombo.Items.Remove(PropHandler.list[17]);
                propCombo.Items.Remove(PropHandler.list[19]);
                propCombo.Items.Remove(PropHandler.list[20]);
                propCombo.Items.Remove(PropHandler.list[21]);
                propCombo.Items.Remove(PropHandler.list[24]);
                propCombo.Items.Remove(PropHandler.list[28]);
                propCombo.Items.Remove(PropHandler.list[29]);
                propCombo.Items.Remove(PropHandler.list[30]);
                propCombo.Items.Remove(PropHandler.list[31]);
                propCombo.Items.Remove(PropHandler.list[32]);
                propCombo.Items.Remove(PropHandler.list[33]);
                propCombo.Items.Remove(PropHandler.list[34]);
                propCombo.Items.Remove(PropHandler.list[35]);
                propCombo.Items.Remove(PropHandler.list[36]);
                propCombo.Items.Remove(PropHandler.list[37]);
                propCombo.Items.Remove(PropHandler.list[38]);
                propCombo.Items.Remove(PropHandler.list[39]);
                propCombo.Items.Remove(PropHandler.list[40]);
                propCombo.Items.Remove(PropHandler.list[41]);
                propCombo.Items.Remove(PropHandler.list[42]);
                propCombo.Items.Remove(PropHandler.list[43]);
                propCombo.Items.Remove(PropHandler.list[44]);
            }

             if (mapCombo.SelectedItem.ToString() == "s3d_reactor")
             {
                 //Weapons
                 weaponsCombo.Items.Remove(WeaponHandler.list[56]);
                 //Vehicles
                 vehiclesCombo.Enabled = true;
                 vehiclesCombo.Items.Remove(VehicleHandler.list[0]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[3]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[4]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[5]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[10]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[11]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[12]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[13]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[14]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[15]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[16]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[17]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[18]); //Water Drum
                 vehiclesCombo.Items.Remove(VehicleHandler.list[19]);
                 vehiclesCombo.Items.Remove(VehicleHandler.list[20]); //Turret
                 //Projectiles
                 projectileCombo.Items.Remove(ProjectileHandler.list[10]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[14]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[16]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[43]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[44]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[46]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[47]);
                 projectileCombo.Items.Remove(ProjectileHandler.list[48]);
                 //Props
                 propCombo.Items.Remove(PropHandler.list[7]);
                 propCombo.Items.Remove(PropHandler.list[8]);
                 propCombo.Items.Remove(PropHandler.list[12]);
                 propCombo.Items.Remove(PropHandler.list[13]);
                 propCombo.Items.Remove(PropHandler.list[14]);
                 propCombo.Items.Remove(PropHandler.list[15]);
                 propCombo.Items.Remove(PropHandler.list[16]);
                 propCombo.Items.Remove(PropHandler.list[17]);
                 propCombo.Items.Remove(PropHandler.list[18]);
                 propCombo.Items.Remove(PropHandler.list[19]);
                 propCombo.Items.Remove(PropHandler.list[20]);
                 propCombo.Items.Remove(PropHandler.list[21]);
                 propCombo.Items.Remove(PropHandler.list[24]);
                 propCombo.Items.Remove(PropHandler.list[28]);
                 propCombo.Items.Remove(PropHandler.list[29]);
                 propCombo.Items.Remove(PropHandler.list[30]);
                 propCombo.Items.Remove(PropHandler.list[31]);
                 propCombo.Items.Remove(PropHandler.list[32]);
                 propCombo.Items.Remove(PropHandler.list[34]);
                 propCombo.Items.Remove(PropHandler.list[35]);
                 propCombo.Items.Remove(PropHandler.list[36]);
                 propCombo.Items.Remove(PropHandler.list[38]);
                 propCombo.Items.Remove(PropHandler.list[39]);
                 propCombo.Items.Remove(PropHandler.list[40]);
                 propCombo.Items.Remove(PropHandler.list[41]);
                 propCombo.Items.Remove(PropHandler.list[42]);
                 propCombo.Items.Remove(PropHandler.list[43]);
                 propCombo.Items.Remove(PropHandler.list[44]);
             }
            
            if (mapCombo.SelectedItem.ToString() == "s3d_turf")
            {
                //Weapons
                weaponsCombo.Items.Remove(WeaponHandler.list[2]); //Hammer
                weaponsCombo.Items.Remove(WeaponHandler.list[56]);
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove(VehicleHandler.list[0]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[1]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[2]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[3]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[4]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[5]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[6]); //Scorpion
                vehiclesCombo.Items.Remove(VehicleHandler.list[8]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[13]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[14]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[15]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[16]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[17]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[18]); //Water Drum
                vehiclesCombo.Items.Remove(VehicleHandler.list[19]);
                vehiclesCombo.Items.Remove(VehicleHandler.list[20]); //Turret
                //Projectiles
                projectileCombo.Items.Remove(ProjectileHandler.list[10]);
                projectileCombo.Items.Remove(ProjectileHandler.list[14]);
                projectileCombo.Items.Remove(ProjectileHandler.list[16]);
                projectileCombo.Items.Remove(ProjectileHandler.list[37]);
                projectileCombo.Items.Remove(ProjectileHandler.list[43]);
                projectileCombo.Items.Remove(ProjectileHandler.list[44]);
                projectileCombo.Items.Remove(ProjectileHandler.list[46]);
                projectileCombo.Items.Remove(ProjectileHandler.list[47]);
                projectileCombo.Items.Remove(ProjectileHandler.list[48]);
                //Props
                propCombo.Items.Remove(PropHandler.list[0]);
                propCombo.Items.Remove(PropHandler.list[1]);
                propCombo.Items.Remove(PropHandler.list[7]);
                propCombo.Items.Remove(PropHandler.list[10]);
                propCombo.Items.Remove(PropHandler.list[11]);
                propCombo.Items.Remove(PropHandler.list[12]);
                propCombo.Items.Remove(PropHandler.list[13]);
                propCombo.Items.Remove(PropHandler.list[14]);
                propCombo.Items.Remove(PropHandler.list[15]);
                propCombo.Items.Remove(PropHandler.list[16]);
                propCombo.Items.Remove(PropHandler.list[17]);
                propCombo.Items.Remove(PropHandler.list[18]);
                propCombo.Items.Remove(PropHandler.list[19]);
                propCombo.Items.Remove(PropHandler.list[20]);
                propCombo.Items.Remove(PropHandler.list[21]);
                propCombo.Items.Remove(PropHandler.list[24]);
                propCombo.Items.Remove(PropHandler.list[25]);
                propCombo.Items.Remove(PropHandler.list[26]);
                propCombo.Items.Remove(PropHandler.list[27]);
                propCombo.Items.Remove(PropHandler.list[28]);
                propCombo.Items.Remove(PropHandler.list[29]);
                propCombo.Items.Remove(PropHandler.list[30]);
                propCombo.Items.Remove(PropHandler.list[31]);
                propCombo.Items.Remove(PropHandler.list[32]);
                propCombo.Items.Remove(PropHandler.list[33]);
                propCombo.Items.Remove(PropHandler.list[34]);
                propCombo.Items.Remove(PropHandler.list[35]);
                propCombo.Items.Remove(PropHandler.list[36]);
                propCombo.Items.Remove(PropHandler.list[37]);
                propCombo.Items.Remove(PropHandler.list[38]);
                propCombo.Items.Remove(PropHandler.list[39]);
                propCombo.Items.Remove(PropHandler.list[40]);
                propCombo.Items.Remove(PropHandler.list[41]);
                propCombo.Items.Remove(PropHandler.list[42]);
                propCombo.Items.Remove(PropHandler.list[43]);
                propCombo.Items.Remove(PropHandler.list[44]);
            }
        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void jumpCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (jumpCheck.Checked)
            {
                byte[] rawData = new byte[10];
                rawData[0] = 0xB8; // mov eax

                byte[] heightData = BitConverter.GetBytes((float)jumpTrackbar.Value);
                byte[] paddingData = { 0x89, 0x45, 0xF8, 0x90, 0x90 };

                heightData.CopyTo(rawData, 1);
                paddingData.CopyTo(rawData, 5);

                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mov eax, {jump height} -> mov [ebp-8], eax -> nop padding
            }
            else 
            {
                byte[] rawData = { 0xF3, 0x0F, 0x59, 0x4D, 0xF8, 0xF3, 0x0F, 0x11, 0x4D, 0xF8 };
                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mulss xmm1, [ebp+var_8] - > movss [ebp+var_8], xmm1
            }
        }

        private void jumpTrackbar_ValueChanged(object sender, EventArgs e)
        {
            if (jumpCheck.Checked)
            {
                byte[] rawData = new byte[10];
                rawData[0] = 0xB8; // mov eax

                byte[] heightData = BitConverter.GetBytes((float)jumpTrackbar.Value);
                byte[] paddingData = { 0x89, 0x45, 0xF8, 0x90, 0x90 };

                heightData.CopyTo(rawData, 1);
                paddingData.CopyTo(rawData, 5);

                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                // mov eax, {jump height} -> mov [ebp-8], eax -> nop padding
            }
        }

        private void fireRateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (fireRateCheck.Checked)
            {
                byte[] rawData = { 0x90, 0x90 }; // nop, nop
                MemoryManager.WriteToAddress(0xB60E60, rawData);
            }

            else
            {
                byte[] rawData = { 0x74, 0x49 }; // jz short loc_B60EAB
                MemoryManager.WriteToAddress(0xB60E60, rawData);
            }
        }

        private void resetHeightBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Halo Online Realtime Editor \r\n\r\nCreated by Razzile, NexusAU, FishPhd, Bivi \r\nand many more from the ElDorito IRC \nVersion 0.1.4", "About/Version");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void jumpTrackbar_Scroll(object sender, EventArgs e)
        {

        }

    }
    }