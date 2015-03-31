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
            if (projectileCombo.Enabled = true)
            {
                ComboBox box = (ComboBox)sender;
                ProjectileHandler.SetNewProjectile(ProjectileHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + projectileCombo.SelectedItem;
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                ComboBox box = (ComboBox)sender;
                WeaponHandler.SetNewProjectile(WeaponHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + weaponsCombo.SelectedItem;
                projectileCombo.Text = "";
                miscCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                ComboBox box = (ComboBox)sender;
                MiscHandler.SetNewProjectile(MiscHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + miscCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.nexusau.com/halo-online-trainer");
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
                ComboBox box = (ComboBox)sender;
                VehicleHandler.SetNewProjectile(VehicleHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + vehiclesCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                miscCombo.Text = "";
                armorCombo.Text = "";
                propCombo.Text = "";
            
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
                ComboBox box = (ComboBox)sender;
                ArmorHandler.SetNewProjectile(ArmorHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + armorCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                propCombo.Text = "";
                miscCombo.Text = "";
        }

        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
                ComboBox box = (ComboBox)sender;
                PropHandler.SetNewProjectile(PropHandler.projectiles[box.SelectedIndex]);
                label6.Text = "Selected: " + propCombo.SelectedItem;
                projectileCombo.Text = "";
                weaponsCombo.Text = "";
                vehiclesCombo.Text = "";
                armorCombo.Text = "";
                miscCombo.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (mapCheck.Checked)
            {
                mapCombo.Enabled = true;
            }
            else
            {
                mapCombo.Enabled = false;
                PropHandler.SetNewProjectile(PropHandler.projectiles[1]);
                label6.Text = "Selected: Default";
            }
        }

        private void mapCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            label11.Text = "Selected: " + mapCombo.SelectedItem;
            //Vehicles
            vehiclesCombo.Items.Clear();
            vehiclesCombo.Items.Add("Banshee");
            vehiclesCombo.Items.Add("Ghost");
            vehiclesCombo.Items.Add("Mongoose");
            vehiclesCombo.Items.Add("Brute Chopper");
            vehiclesCombo.Items.Add("Shade");
            vehiclesCombo.Items.Add("Scorpion");
            vehiclesCombo.Items.Add("Warthog");
            vehiclesCombo.Items.Add("Warthog (Chaingun)");
            vehiclesCombo.Items.Add("Warthog (Gauss Rifle)");
            vehiclesCombo.Items.Add("Warthog (Troop)");
            vehiclesCombo.Items.Add("Warthog (Snow)");
            vehiclesCombo.Items.Add("Warthog (Chaingun Snow)");
            vehiclesCombo.Items.Add("Warthog (Gauss Rifle Snow)");
            vehiclesCombo.Items.Add("Hornet");
            vehiclesCombo.Items.Add("Hornet (Lite)");
            vehiclesCombo.Items.Add("Hornet (Main Menu)");
            vehiclesCombo.Items.Add("Wraith");
            vehiclesCombo.Items.Add("Wraith (Mortar)");
            vehiclesCombo.Items.Add("Wraith (Anti-infantry)");
            vehiclesCombo.Items.Add("Wraith (Anti-Air)");
            vehiclesCombo.Items.Add("Wraith (Anti-Infantry + Air)");
            VehicleHandler.reset(0x00151A, 0); // Banshee
            VehicleHandler.reset(0x001517, 1); // Ghost
            VehicleHandler.reset(0x001596, 2); // Mongoose
            VehicleHandler.reset(0x001518, 3); // Brute Chopper
            VehicleHandler.reset(0x001516, 4); // Shade
            VehicleHandler.reset(0x001520, 5); // Scorpion
            VehicleHandler.reset(0x00151F, 6); // Warthog
            VehicleHandler.reset(0x0029EC, 7); // Warthog (Chaingun)
            VehicleHandler.reset(0x0029ED, 8); // Warthog (Gauss Rifle)
            VehicleHandler.reset(0x0029EE, 9); // Warthog (Troop)
            VehicleHandler.reset(0x001599, 10); // Warthog (Snow)
            VehicleHandler.reset(0x00433A, 11); // Warthog (Chaingun Snow)
            VehicleHandler.reset(0x00433B, 12); // Warthog (Gauss Rifle Snow)
            VehicleHandler.reset(0x001598, 13); // Hornet
            VehicleHandler.reset(0x00159B, 14); // Hornet Lite
            VehicleHandler.reset(0x0027D8, 15); // Hornet Main Menu
            VehicleHandler.reset(0x001519, 16); // Wraith
            VehicleHandler.reset(0x003742, 17); // Wraith (Mortar)
            VehicleHandler.reset(0x003743, 18); // Wraith (Anti-infantry)
            VehicleHandler.reset(0x003744, 19); // Wraith (Anti-Air)
            VehicleHandler.reset(0x003745, 20); // Wraith (Anti-Infantry + Air)
            //Projectiles
            projectileCombo.Items.Clear();
            projectileCombo.Items.Add("Frag Grenade");
            projectileCombo.Items.Add("Plasma Grenade");
            projectileCombo.Items.Add("Spike Grenade");
            projectileCombo.Items.Add("Flame Grenade");
            projectileCombo.Items.Add("Spike (Grenade)");
            projectileCombo.Items.Add("Flamethrower Flame (Variant 1)");
            projectileCombo.Items.Add("Flamethrower Flame (Variant 2)");
            projectileCombo.Items.Add("Flamethrower Flame (Variant 3)");
            projectileCombo.Items.Add("Flamethrower Flame (Variant 4)");
            projectileCombo.Items.Add("Plasma Grenade (Long Fuse)");
            projectileCombo.Items.Add("Fuel Rod Round (Variant 1)");
            projectileCombo.Items.Add("Fuel Rod Round (Variant 2)");
            projectileCombo.Items.Add("Rocket");
            projectileCombo.Items.Add("Missile Pod Rocket");
            projectileCombo.Items.Add("Wraith Blast");
            projectileCombo.Items.Add("Brute Shot Round");
            projectileCombo.Items.Add("Hornet Rocket");
            projectileCombo.Items.Add("Frage Grenade (Red Trail)");
            projectileCombo.Items.Add("Assault Rifle Round");
            projectileCombo.Items.Add("Battle Rifle Round");
            projectileCombo.Items.Add("Carbine Round");
            projectileCombo.Items.Add("DMR Round");
            projectileCombo.Items.Add("Plasma Rifle Round");
            projectileCombo.Items.Add("Shotgun Pellet");
            projectileCombo.Items.Add("Magnum Round");
            projectileCombo.Items.Add("Sniper Round");
            projectileCombo.Items.Add("Spike (Spiker)");
            projectileCombo.Items.Add("Mauler Round");
            projectileCombo.Items.Add("Human Projectile (possible)");
            projectileCombo.Items.Add("Needler Round");
            projectileCombo.Items.Add("Machine Gun Turret Round");
            projectileCombo.Items.Add("Plasma Pistol Round");
            ProjectileHandler.reset(0x0001AD, 0);   //Frag Grenade");
            ProjectileHandler.reset(0x0001B0, 1);   //Plasma Grenade");
            ProjectileHandler.reset(0x0001B3, 2);   //Spike Grenade");
            ProjectileHandler.reset(0x0001B6, 3);   //Flame Grenade");
            ProjectileHandler.reset(0x000587, 4);   //Spike (Grenade)");
            ProjectileHandler.reset(0x0006D9, 5);   //Flamethrower Flame (Variant 1)");
            ProjectileHandler.reset(0x0006DB, 6);   //Flamethrower Flame (Variant 2)");
            ProjectileHandler.reset(0x0006DC, 7);   //Flamethrower Flame (Variant 3)");
            ProjectileHandler.reset(0x0006FB, 8);   //Flamethrower Flame (Variant 4)");
            ProjectileHandler.reset(0x0015A7, 9);   //Plasma Grenade (Long Fuse)");
            ProjectileHandler.reset(0x0015C8, 10);  //Fuel Rod Round (Variant 1)");
            ProjectileHandler.reset(0x0015CF, 11);  //Fuel Rod Round (Variant 2)");
            ProjectileHandler.reset(0x0015C9, 12);  //Rocket");
            ProjectileHandler.reset(0x0015CA, 13);  //Missile Pod Rocket");
            ProjectileHandler.reset(0x0015CB, 14);  //Wraith Blast");
            ProjectileHandler.reset(0x0015CD, 15);  //Brute Shot Round");
            ProjectileHandler.reset(0x0015CE, 16);  //Hornet Rocket");
            ProjectileHandler.reset(0x0015D0, 17);  //Frage Grenade (Red Trail)");
            ProjectileHandler.reset(0x001B90, 18);  //Assault Rifle Round");
            ProjectileHandler.reset(0x001D88, 19);  //Battle Rifle Round");
            ProjectileHandler.reset(0x001DBC, 20);  //Carbine Round");
            ProjectileHandler.reset(0x001E12, 21);  //DMR Round");
            ProjectileHandler.reset(0x001E49, 22);  //Plasma Rifle Round");
            ProjectileHandler.reset(0x001F00, 23);  //Shotgun Pellet");
            ProjectileHandler.reset(0x001F51, 24);  //Magnum Round");
            ProjectileHandler.reset(0x001F92, 25);  //Sniper Round");
            ProjectileHandler.reset(0x002058, 26);  //Spike (Spiker)");
            ProjectileHandler.reset(0x00208F, 27);  //Mauler Round");
            ProjectileHandler.reset(0x0020BD, 28);  //Human Projectile (possible)");
            ProjectileHandler.reset(0x0020EF, 29);  //Needler Round");
            ProjectileHandler.reset(0x00219E, 30);  //Machine Gun Turret Round");
            ProjectileHandler.reset(0x00225C, 31);  //Plasma Pistol Round");
            //Weapons
            weaponsCombo.Items.Clear();
            weaponsCombo.Items.Add("Spiker");
            weaponsCombo.Items.Add("Beam Rifle");
            weaponsCombo.Items.Add("Hammer");
            weaponsCombo.Items.Add("Plasma Turret");
            weaponsCombo.Items.Add("Assault Rifle (Defualt)");
            weaponsCombo.Items.Add("Assault Rifle (Red)");
            weaponsCombo.Items.Add("Assault Rifle (Yellow)");
            weaponsCombo.Items.Add("Assault Rifle (Green)");
            weaponsCombo.Items.Add("Assault Rifle (Gold)");
            weaponsCombo.Items.Add("Smg (Default)");
            weaponsCombo.Items.Add("Smg (Red)");
            weaponsCombo.Items.Add("Smg (Yellow)");
            weaponsCombo.Items.Add("Smg (Green)");
            weaponsCombo.Items.Add("Smg (Gold)");
            weaponsCombo.Items.Add("Battle Rifle (Default)");
            weaponsCombo.Items.Add("Battle Rifle (Red)");
            weaponsCombo.Items.Add("Battle Rifle (Yellow)");
            weaponsCombo.Items.Add("Battle Rifle (Green)");
            weaponsCombo.Items.Add("Battle Rifle (Blue)");
            weaponsCombo.Items.Add("Battle Rifle (Purple)");
            weaponsCombo.Items.Add("Battle Rifle (Gold)");
            weaponsCombo.Items.Add("DMR (Default)");
            weaponsCombo.Items.Add("DMR (Red)");
            weaponsCombo.Items.Add("DMR (Yellow)");
            weaponsCombo.Items.Add("DMR (Green)");
            weaponsCombo.Items.Add("DMR (Blue)");
            weaponsCombo.Items.Add("DMR (Purple)");
            weaponsCombo.Items.Add("DMR (Gold)");
            weaponsCombo.Items.Add("Magnum (Default)");
            weaponsCombo.Items.Add("Magnum (Red)");
            weaponsCombo.Items.Add("Magnum (Gold)");
            weaponsCombo.Items.Add("Carbine (Default)");
            weaponsCombo.Items.Add("Carbine (Red)");
            weaponsCombo.Items.Add("Carbine (Yellow)");
            weaponsCombo.Items.Add("Carbine (Green)");
            weaponsCombo.Items.Add("Carbine (Blue)");
            weaponsCombo.Items.Add("Carbine (Purple)");
            weaponsCombo.Items.Add("Carbine (Gold)");
            weaponsCombo.Items.Add("Mauler (Default)");
            weaponsCombo.Items.Add("Mauler (Gold)");
            weaponsCombo.Items.Add("Energy Sword");
            weaponsCombo.Items.Add("Energy Sword (No Charge)");
            weaponsCombo.Items.Add("Plasma Rifle (default)");
            weaponsCombo.Items.Add("Plasma Rifle (gold)");
            weaponsCombo.Items.Add("Plasma Pistol (default)");
            weaponsCombo.Items.Add("Plasma Pistol (gold)");
            weaponsCombo.Items.Add("Flag");
            weaponsCombo.Items.Add("Skull");
            weaponsCombo.Items.Add("Bomb");
            weaponsCombo.Items.Add("Sniper");
            weaponsCombo.Items.Add("Spartan Laser");
            weaponsCombo.Items.Add("Rocker Launcher");
            weaponsCombo.Items.Add("Needler");
            weaponsCombo.Items.Add("Fuel Rod");
            weaponsCombo.Items.Add("Brute Shot");
            weaponsCombo.Items.Add("Shotgun");
            weaponsCombo.Items.Add("Sentinel Beam");
            WeaponHandler.reset(0x001500, 0);   //Spiker
            WeaponHandler.reset(0x001509, 1);   //Beam Rifle
            WeaponHandler.reset(0x00150C, 2);   //Hammer
            WeaponHandler.reset(0x00150E, 3);   //Plasma Turret
            WeaponHandler.reset(0x00151E, 4);   //Assault Rifle (Defualt)
            WeaponHandler.reset(0x001581, 5);   //Assault Rifle (Red)
            WeaponHandler.reset(0x001582, 6);   //Assault Rifle (Yellow)
            WeaponHandler.reset(0x001583, 7);   //Assault Rifle (Green)
            WeaponHandler.reset(0x001584, 8);   //Assault Rifle (Gold)
            WeaponHandler.reset(0x00157D, 9);   //Smg (Default)
            WeaponHandler.reset(0x00158E, 10);  //Smg (Red)
            WeaponHandler.reset(0x00158C, 11);  //Smg (Yellow)
            WeaponHandler.reset(0x00158D, 12);  //Smg (Green)
            WeaponHandler.reset(0x00158F, 13);  //Smg (Gold)
            WeaponHandler.reset(0x00157C, 14);  //Battle Rifle (Default)
            WeaponHandler.reset(0x001586, 15);  //Battle Rifle (Red)
            WeaponHandler.reset(0x0015BB, 16);  //Battle Rifle (Yellow)
            WeaponHandler.reset(0x0015BC, 17);  //Battle Rifle (Green)
            WeaponHandler.reset(0x001585, 18);  //Battle Rifle (Blue)
            WeaponHandler.reset(0x0015BD, 19);  //Battle Rifle (Purple)
            WeaponHandler.reset(0x001587, 20);  //Battle Rifle (Gold)
            WeaponHandler.reset(0x001580, 21);  //DMR (Default)
            WeaponHandler.reset(0x00158A, 22);  //DMR (Red)
            WeaponHandler.reset(0x001589, 23);  //DMR (Yellow)
            WeaponHandler.reset(0x001588, 24);  //DMR (Green)
            WeaponHandler.reset(0x0015BE, 25);  //DMR (Blue)
            WeaponHandler.reset(0x0015BF, 26);  //DMR (Purple)
            WeaponHandler.reset(0x00158B, 27);  //DMR (Gold)
            WeaponHandler.reset(0x00157E, 28);  //Magnum (Default)
            WeaponHandler.reset(0x001593, 29);  //Magnum (Red)
            WeaponHandler.reset(0x001594, 30);  //Magnum (Gold)
            WeaponHandler.reset(0x0014FE, 31);  //Carbine (Default)
            WeaponHandler.reset(0x0015C3, 32);  //Carbine (Red)
            WeaponHandler.reset(0x0015C0, 33);  //Carbine (Yellow)
            WeaponHandler.reset(0x0015C4, 34);  //Carbine (Green)
            WeaponHandler.reset(0x0015C1, 35);  //Carbine (Blue)
            WeaponHandler.reset(0x0015C2, 36);  //Carbine (Purple)
            WeaponHandler.reset(0x001591, 37);  //Carbine (Gold)
            WeaponHandler.reset(0x001504, 38);  //Mauler (Default)
            WeaponHandler.reset(0x001592, 39);  //Mauler (Gold)
            WeaponHandler.reset(0x00159E, 40);  //Energy Sword
            WeaponHandler.reset(0x00157F, 41);  //Energy Sword (No Charge)
            WeaponHandler.reset(0x001525, 42);  //Plasma Rifle (default)
            WeaponHandler.reset(0x001590, 43);  //Plasma Rifle (gold)
            WeaponHandler.reset(0x0014F7, 44);  //Plasma Pistol (default)
            WeaponHandler.reset(0x001595, 45);  //Plasma Pistol (gold)
            WeaponHandler.reset(0x0015A2, 46);  //Flag
            WeaponHandler.reset(0x0015A3, 47);  //Skull
            WeaponHandler.reset(0x0015A4, 48);  //Bomb
            WeaponHandler.reset(0x0015B1, 49);  //Sniper
            WeaponHandler.reset(0x0015B2, 50);  //Spartan Laser
            WeaponHandler.reset(0x0015B3, 51);  //Rocker Launcher
            WeaponHandler.reset(0x0014F8, 52);  //Needler
            WeaponHandler.reset(0x0014F9, 53);  //Fuel Rod
            WeaponHandler.reset(0x0014FF, 54);  //Brute Shot
            WeaponHandler.reset(0x001585, 55);  //Shotgun
            WeaponHandler.reset(0x001A56, 56);  //Sentinel Beam
            //Props
            propCombo.Items.Add("Mounted Machine gun");
            propCombo.Items.Add("Covenant Junk 1");
            propCombo.Items.Add("Covenant Junk 2");
            propCombo.Items.Add("Covenant Junk 3");
            propCombo.Items.Add("Junk 1");
            propCombo.Items.Add("Junk 2");
            propCombo.Items.Add("Junk 3");
            propCombo.Items.Add("Scorpion junk");
            propCombo.Items.Add("Fusion Coil");
            propCombo.Items.Add("Flag Stand");
            propCombo.Items.Add("Flag Stand 2");
            propCombo.Items.Add("Flag Stand 3");
            propCombo.Items.Add("Flag Stand 4");
            propCombo.Items.Add("Invisible Prop");
            propCombo.Items.Add("Invisible Prop 2");
            propCombo.Items.Add("Invisible Prop 3");
            propCombo.Items.Add("Unsc Crate");
            propCombo.Items.Add("Generator");
            propCombo.Items.Add("Covenant Weapon Holder");
            propCombo.Items.Add("Teleporter Sender");
            propCombo.Items.Add("Teleporter Reciever");
            propCombo.Items.Add("Teleporter Two-way");
            propCombo.Items.Add("Bomb Point 1");
            propCombo.Items.Add("Bomb Point 2");
            propCombo.Items.Add("Bomb Point 3");
            propCombo.Items.Add("Bomb Point 4");
            propCombo.Items.Add("Hill Marker 1");
            propCombo.Items.Add("Hill Marker 2");
            propCombo.Items.Add("Hill Marker 3");
            propCombo.Items.Add("Man Cannon 1");
            propCombo.Items.Add("Man Cannon 2");
            propCombo.Items.Add("Man Cannon 3");
            propCombo.Items.Add("Radio Antenna");
            propCombo.Items.Add("Small Crate");
            propCombo.Items.Add("Small Radio");
            propCombo.Items.Add("Drop Pod");
            propCombo.Items.Add("Drop Pod Cover");
            propCombo.Items.Add("Barrier");
            propCombo.Items.Add("Medical Crate");
            propCombo.Items.Add("Covenant Weapon Crate");
            propCombo.Items.Add("Barrel");
            propCombo.Items.Add("Jerry Can");
            propCombo.Items.Add("Small Jerry Can");
            propCombo.Items.Add("Tree");
            propCombo.Items.Add("Big Tree");
            PropHandler.reset(0x00002888, 0);   // Mounted Machine gun
            PropHandler.reset(0x00001A8A, 1);   // Covenant Junk 1
            PropHandler.reset(0x01001A8B, 2);   // Covenant Junk 2
            PropHandler.reset(0x02001A8C, 3);   // Covenant Junk 3
            PropHandler.reset(0x00002603, 4);   // Junk 1
            PropHandler.reset(0x00002607, 5);   // Junk 2
            PropHandler.reset(0x00002608, 6);   // Junk 3
            PropHandler.reset(0x00002958, 7);   // Scorpion junk
            PropHandler.reset(0x000034A4, 8);   // Fusion Coil
            PropHandler.reset(0x00002EC3, 9);   // Flag Stand
            PropHandler.reset(0x00002EC3, 10);  // Flag Stand 2
            PropHandler.reset(0x00002EC5, 11);  // Flag Stand 3
            PropHandler.reset(0x00002ECA, 12);  // Flag Stand 4
            PropHandler.reset(0x00002EED, 13);  // Invisible Prop
            PropHandler.reset(0x00002EEE, 14);  // Invisible Prop 2
            PropHandler.reset(0x00002EEF, 15);  // Invisible Prop 3
            PropHandler.reset(0x00002EBC, 16);  // Unsc Crate
            PropHandler.reset(0x00002EBD, 17);  // Generator
            PropHandler.reset(0x00002EBE, 18);  // Covenant Weapon Holder
            PropHandler.reset(0x00002EC0, 19);  // Teleporter Sender
            PropHandler.reset(0x00002EC1, 20);  // Teleporter Reciever
            PropHandler.reset(0x00002EC2, 21);  // Teleporter Two-way
            PropHandler.reset(0x00002EC4, 22);  // Bomb Point 1
            PropHandler.reset(0x00002EC6, 23);  // Bomb Point 2
            PropHandler.reset(0x00002EC7, 24);  // Bomb Point 3
            PropHandler.reset(0x00002EC9, 25);  // Bomb Point 4
            PropHandler.reset(0x000015A5, 26);  // Hill Marker 1
            PropHandler.reset(0x00002EC8, 27);  // Hill Marker 2
            PropHandler.reset(0x00002EDC, 28);  // Hill Marker 3
            PropHandler.reset(0x00002EDB, 29);  // Man Cannon 1
            PropHandler.reset(0x000034BE, 30);  // Man Cannon 2
            PropHandler.reset(0x000034BF, 31);  // Man Cannon 3
            PropHandler.reset(0x000034A5, 32);  // Radio Antenna
            PropHandler.reset(0x000034A6, 33);  // Small Crate
            PropHandler.reset(0x000034A7, 34);  // Small Radio
            PropHandler.reset(0x000034A8, 35);  // Drop Pod
            PropHandler.reset(0x000034A9, 36);  // Drop Pod Cover
            PropHandler.reset(0x000034AA, 37);  // Barrier
            PropHandler.reset(0x000034AB, 38);  // Medical Crate
            PropHandler.reset(0x000034C0, 39);  // Covenant Weapon Crate
            PropHandler.reset(0x000034C1, 40);  // Barrel
            PropHandler.reset(0x000034C2, 41);  // Jerry Can
            PropHandler.reset(0x000034C3, 42);  // Small Jerry Can
            PropHandler.reset(0x000034C4, 43);  // Tree
            PropHandler.reset(0x000034C5, 44);  // Big Tree



            if (mapCombo.SelectedItem.ToString() == "Riverworld")
            {
                vehiclesCombo.Enabled = true;
                //Vehicles
                vehiclesCombo.Items.Remove("Brute Chopper");
                vehiclesCombo.Items.Remove("Warthog (Snow)");
                vehiclesCombo.Items.Remove("Warthog (Chaingun Snow)");
                vehiclesCombo.Items.Remove("Warthog (Gauss Rifle Snow)");
                vehiclesCombo.Items.Remove("Hornet (Lite)");
                vehiclesCombo.Items.Remove("Hornet (Main Menu)");
                VehicleHandler.reset(0x001518, 21); // Brute Chopper
                VehicleHandler.reset(0x001599, 21); // Warthog (Snow)
                VehicleHandler.reset(0x00433A, 21); // Warthog (Chaingun Snow)
                VehicleHandler.reset(0x00433B, 21); // Warthog (Gauss Rifle Snow)
                VehicleHandler.reset(0x00159B, 21); // Hornet Lite
                VehicleHandler.reset(0x0027D8, 21); // Hornet Main Menu
                //Props
                propCombo.Items.Remove("Man Cannon 2");
                PropHandler.reset(0x000034BE, 45);  // Man Cannon 2

            }
            
            if (mapCombo.SelectedItem.ToString() == "Guardian")
            {
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove("Banshee");
                vehiclesCombo.Items.Remove("Ghost");
                vehiclesCombo.Items.Remove("Brute Chopper");
                vehiclesCombo.Items.Remove("Scorpion");
                vehiclesCombo.Items.Remove("Warthog");
                vehiclesCombo.Items.Remove("Warthog (Chaingun)");
                vehiclesCombo.Items.Remove("Warthog (Gauss Rifle)");
                vehiclesCombo.Items.Remove("Warthog (Troop)");
                vehiclesCombo.Items.Remove("Warthog (Snow)");
                vehiclesCombo.Items.Remove("Warthog (Chaingun Snow)");
                vehiclesCombo.Items.Remove("Warthog (Gauss Rifle Snow)");
                vehiclesCombo.Items.Remove("Hornet");
                vehiclesCombo.Items.Remove("Hornet (Lite)");
                vehiclesCombo.Items.Remove("Hornet (Main Menu)");
                vehiclesCombo.Items.Remove("Wraith");
                vehiclesCombo.Items.Remove("Wraith (Mortar)");
                vehiclesCombo.Items.Remove("Wraith (Anti-infantry)");
                vehiclesCombo.Items.Remove("Wraith (Anti-Air)");
                vehiclesCombo.Items.Remove("Wraith (Anti-Infantry + Air)");
                VehicleHandler.reset(0x00151A, 22); // Banshee
                VehicleHandler.reset(0x001517, 21); // Ghost
                VehicleHandler.reset(0x001518, 21); // Brute Chopper
                VehicleHandler.reset(0x001520, 21); // Scorpion
                VehicleHandler.reset(0x00151F, 21); // Warthog
                VehicleHandler.reset(0x0029EC, 21); // Warthog (Chaingun)
                VehicleHandler.reset(0x0029ED, 21); // Warthog (Gauss Rifle)
                VehicleHandler.reset(0x0029EE, 21); // Warthog (Troop)
                VehicleHandler.reset(0x001599, 21); // Warthog (Snow)
                VehicleHandler.reset(0x00433A, 21); // Warthog (Chaingun Snow)
                VehicleHandler.reset(0x00433B, 21); // Warthog (Gauss Rifle Snow)
                VehicleHandler.reset(0x001598, 21); // Hornet
                VehicleHandler.reset(0x00159B, 21); // Hornet Lite
                VehicleHandler.reset(0x0027D8, 21); // Hornet Main Menu
                VehicleHandler.reset(0x001519, 21); // Wraith
                VehicleHandler.reset(0x003742, 21); // Wraith (Mortar)
                VehicleHandler.reset(0x003743, 21); // Wraith (Anti-infantry)
                VehicleHandler.reset(0x003744, 21); // Wraith (Anti-Air)
                VehicleHandler.reset(0x003745, 21); // Wraith (Anti-Infantry + Air)
                //Projectiles
                projectileCombo.Items.Remove("Fuel Rod Round (Variant 1)");
                projectileCombo.Items.Remove("Wraith Blast");
                projectileCombo.Items.Remove("Hornet Rocket");
                ProjectileHandler.reset(0x0015C8, 32); // Fuel Rod Round (Variant 1)
                ProjectileHandler.reset(0x0015CB, 32); // Wraith Blast
                ProjectileHandler.reset(0x0015CE, 32); // Hornet Rocket
                //Props
                propCombo.Items.Remove("Scorpion junk");
                propCombo.Items.Remove("Fusion Coil");
                propCombo.Items.Remove("Man Cannon 2");
                propCombo.Items.Remove("Man Cannon 3");
                propCombo.Items.Remove("Radio Antenna");
                propCombo.Items.Remove("Small Crate");
                propCombo.Items.Remove("Small Radio");
                propCombo.Items.Remove("Drop Pod");
                propCombo.Items.Remove("Drop Pod Cover");
                propCombo.Items.Remove("Barrier");
                propCombo.Items.Remove("Medical Crate");
                propCombo.Items.Remove("Covenant Weapon Crate");
                propCombo.Items.Remove("Barrel");
                propCombo.Items.Remove("Jerry Can");
                propCombo.Items.Remove("Small Jerry Can");
                propCombo.Items.Remove("Tree");
                propCombo.Items.Remove("Big Tree");
                PropHandler.reset(0x00002958, 45);   // Scorpion junk
                PropHandler.reset(0x000034A4, 45);   // Fusion Coil
                PropHandler.reset(0x000034BE, 45);  // Man Cannon 2
                PropHandler.reset(0x000034BF, 45);  // Man Cannon 3
                PropHandler.reset(0x000034A5, 45);  // Radio Antenna
                PropHandler.reset(0x000034A6, 45);  // Small Crate
                PropHandler.reset(0x000034A7, 45);  // Small Radio
                PropHandler.reset(0x000034A8, 45);  // Drop Pod
                PropHandler.reset(0x000034A9, 45);  // Drop Pod Cover
                PropHandler.reset(0x000034AA, 45);  // Barrier
                PropHandler.reset(0x000034AB, 45);  // Medical Crate
                PropHandler.reset(0x000034C0, 45);  // Covenant Weapon Crate
                PropHandler.reset(0x000034C1, 45);  // Barrel
                PropHandler.reset(0x000034C2, 45);  // Jerry Can
                PropHandler.reset(0x000034C3, 45);  // Small Jerry Can
                PropHandler.reset(0x000034C4, 45);  // Tree
                PropHandler.reset(0x000034C5, 45);  // Big Tree
            }

            if (mapCombo.SelectedItem.ToString() == "s3d_avalanche")
            {
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove("Shade");
                vehiclesCombo.Items.Remove("Warthog (Troop)");
                vehiclesCombo.Items.Remove("Warthog (Snow)");
                vehiclesCombo.Items.Remove("Warthog (Chaingun Snow)");
                vehiclesCombo.Items.Remove("Warthog (Gauss Rifle Snow)");
                vehiclesCombo.Items.Remove("Hornet");
                vehiclesCombo.Items.Remove("Hornet (Main Menu)");
                VehicleHandler.reset(0x001516, 21); // Shade
                VehicleHandler.reset(0x0029EE, 21); // Warthog (Troop)
                VehicleHandler.reset(0x001599, 21); // Warthog (Snow)
                VehicleHandler.reset(0x00433A, 21); // Warthog (Chaingun Snow)
                VehicleHandler.reset(0x00433B, 21); // Warthog (Gauss Rifle Snow)
                VehicleHandler.reset(0x001598, 21); // Hornet
                VehicleHandler.reset(0x0027D8, 21); // Hornet Main Menu
                //Projectiles
                projectileCombo.Items.Remove("Wraith Blast");
                ProjectileHandler.reset(0x0015CB, 32); // Wraith Blast
                //Props
                propCombo.Items.Remove("Unsc Crate");
                propCombo.Items.Remove("Generator");
                propCombo.Items.Remove("Covenant Weapon Holder");
                propCombo.Items.Remove("Hill Marker 3");
                propCombo.Items.Remove("Man Cannon 3");
                propCombo.Items.Remove("Radio Antenna");
                propCombo.Items.Remove("Small Crate");
                propCombo.Items.Remove("Small Radio");
                propCombo.Items.Remove("Drop Pod");
                propCombo.Items.Remove("Drop Pod Cover");
                propCombo.Items.Remove("Barrier");
                propCombo.Items.Remove("Medical Crate");
                propCombo.Items.Remove("Covenant Weapon Crate");
                propCombo.Items.Remove("Barrel");
                propCombo.Items.Remove("Small Jerry Can");
                propCombo.Items.Remove("Tree");
                propCombo.Items.Remove("Big Tree");
                PropHandler.reset(0x00002EBC, 45);  // Unsc Crate
                PropHandler.reset(0x00002EBD, 45);  // Generator
                PropHandler.reset(0x00002EBE, 45);  // Covenant Weapon Holder
                PropHandler.reset(0x00002EDC, 45);  // Hill Marker 3
                PropHandler.reset(0x000034BF, 45);  // Man Cannon 3
                PropHandler.reset(0x000034A5, 45);  // Radio Antenna
                PropHandler.reset(0x000034A6, 45);  // Small Crate
                PropHandler.reset(0x000034A7, 45);  // Small Radio
                PropHandler.reset(0x000034A8, 45);  // Drop Pod
                PropHandler.reset(0x000034A9, 45);  // Drop Pod Cover
                PropHandler.reset(0x000034AA, 45);  // Barrier
                PropHandler.reset(0x000034AB, 45);  // Medical Crate
                PropHandler.reset(0x000034C0, 45);  // Covenant Weapon Crate
                PropHandler.reset(0x000034C1, 45);  // Barrel
                PropHandler.reset(0x000034C3, 45);  // Small Jerry Can
                PropHandler.reset(0x000034C4, 45);  // Tree
                PropHandler.reset(0x000034C5, 45);  // Big Tree
            }


            if (mapCombo.SelectedItem.ToString() == "s3d_edge")
            {
                //Vehicles
                vehiclesCombo.Enabled = false;
                //Projectiles
                projectileCombo.Items.Remove("Fuel Rod Round (Variant 1)");
                projectileCombo.Items.Remove("Wraith Blast");
                projectileCombo.Items.Remove("Hornet Rocket");
                ProjectileHandler.reset(0x0015C8, 32); // Fuel Rod Round (Variant 1)
                ProjectileHandler.reset(0x0015CB, 32); // Wraith Blast
                ProjectileHandler.reset(0x0015CE, 32); // Hornet Rocket
                //Props
                propCombo.Items.Remove("Mounted Machine gun");
                propCombo.Items.Remove("Scorpion junk");
                propCombo.Items.Remove("Fusion Coil");
                propCombo.Items.Remove("Flag Stand 4");
                propCombo.Items.Remove("Invisible Prop");
                propCombo.Items.Remove("Invisible Prop 2");
                propCombo.Items.Remove("Invisible Prop 3");
                propCombo.Items.Remove("Unsc Crate");
                propCombo.Items.Remove("Generator");
                propCombo.Items.Remove("Teleporter Sender");
                propCombo.Items.Remove("Teleporter Reciever");
                propCombo.Items.Remove("Teleporter Two-way");
                propCombo.Items.Remove("Bomb Point 3");
                propCombo.Items.Remove("Hill Marker 3");
                propCombo.Items.Remove("Man Cannon 1");
                propCombo.Items.Remove("Man Cannon 2");
                propCombo.Items.Remove("Man Cannon 3");
                propCombo.Items.Remove("Radio Antenna");
                propCombo.Items.Remove("Small Crate");
                propCombo.Items.Remove("Small Radio");
                propCombo.Items.Remove("Drop Pod");
                propCombo.Items.Remove("Drop Pod Cover");
                propCombo.Items.Remove("Barrier");
                propCombo.Items.Remove("Medical Crate");
                propCombo.Items.Remove("Covenant Weapon Crate");
                propCombo.Items.Remove("Barrel");
                propCombo.Items.Remove("Jerry Can");
                propCombo.Items.Remove("Small Jerry Can");
                propCombo.Items.Remove("Tree");
                propCombo.Items.Remove("Big Tree");
                PropHandler.reset(0x00002888, 45);   // Mounted Machine gun
                PropHandler.reset(0x00002958, 45);   // Scorpion junk
                PropHandler.reset(0x000034A4, 45);   // Fusion Coil
                PropHandler.reset(0x00002ECA, 45);  // Flag Stand 4
                PropHandler.reset(0x00002EED, 45);  // Invisible Prop
                PropHandler.reset(0x00002EEE, 45);  // Invisible Prop 2
                PropHandler.reset(0x00002EEF, 45);  // Invisible Prop 3
                PropHandler.reset(0x00002EBC, 45);  // Unsc Crate
                PropHandler.reset(0x00002EBD, 45);  // Generator
                PropHandler.reset(0x00002EC0, 45);  // Teleporter Sender
                PropHandler.reset(0x00002EC1, 45);  // Teleporter Reciever
                PropHandler.reset(0x00002EC2, 45);  // Teleporter Two-way
                PropHandler.reset(0x00002EC7, 45);  // Bomb Point 3
                PropHandler.reset(0x00002EDC, 45);  // Hill Marker 3
                PropHandler.reset(0x00002EDB, 45);  // Man Cannon 1
                PropHandler.reset(0x000034BE, 45);  // Man Cannon 2
                PropHandler.reset(0x000034BF, 45);  // Man Cannon 3
                PropHandler.reset(0x000034A5, 45);  // Radio Antenna
                PropHandler.reset(0x000034A6, 45);  // Small Crate
                PropHandler.reset(0x000034A7, 45);  // Small Radio
                PropHandler.reset(0x000034A8, 45);  // Drop Pod
                PropHandler.reset(0x000034A9, 45);  // Drop Pod Cover
                PropHandler.reset(0x000034AA, 45);  // Barrier
                PropHandler.reset(0x000034AB, 45);  // Medical Crate
                PropHandler.reset(0x000034C0, 45);  // Covenant Weapon Crate
                PropHandler.reset(0x000034C1, 45);  // Barrel
                PropHandler.reset(0x000034C2, 45);  // Jerry Can
                PropHandler.reset(0x000034C3, 45);  // Small Jerry Can
                PropHandler.reset(0x000034C4, 45);  // Tree
                PropHandler.reset(0x000034C5, 45);  // Big Tree
            }

             if (mapCombo.SelectedItem.ToString() == "s3d_reactor")
             {
                 //Vehicles
                 vehiclesCombo.Enabled = true;
                 vehiclesCombo.Items.Remove("Banshee");
                 vehiclesCombo.Items.Remove("Brute Chopper");
                 vehiclesCombo.Items.Remove("Shade");
                 vehiclesCombo.Items.Remove("Scorpion");
                 vehiclesCombo.Items.Remove("Warthog (Snow)");
                 vehiclesCombo.Items.Remove("Warthog (Chaingun Snow)");
                 vehiclesCombo.Items.Remove("Warthog (Gauss Rifle Snow)");
                 vehiclesCombo.Items.Remove("Hornet");
                 vehiclesCombo.Items.Remove("Hornet (Lite)");
                 vehiclesCombo.Items.Remove("Hornet (Main Menu)");
                 vehiclesCombo.Items.Remove("Wraith");
                 vehiclesCombo.Items.Remove("Wraith (Mortar)");
                 vehiclesCombo.Items.Remove("Wraith (Anti-infantry)");
                 vehiclesCombo.Items.Remove("Wraith (Anti-Air)");
                 vehiclesCombo.Items.Remove("Wraith (Anti-Infantry + Air)");
                 VehicleHandler.reset(0x00151A, 22); // Banshee
                 VehicleHandler.reset(0x001518, 21); // Brute Chopper
                 VehicleHandler.reset(0x001516, 21); // Shade
                 VehicleHandler.reset(0x001520, 21); // Scorpion
                 VehicleHandler.reset(0x001599, 21); // Warthog (Snow)
                 VehicleHandler.reset(0x00433A, 21); // Warthog (Chaingun Snow)
                 VehicleHandler.reset(0x00433B, 21); // Warthog (Gauss Rifle Snow)
                 VehicleHandler.reset(0x001598, 21); // Hornet
                 VehicleHandler.reset(0x00159B, 21); // Hornet Lite
                 VehicleHandler.reset(0x0027D8, 21); // Hornet Main Menu
                 VehicleHandler.reset(0x001519, 21); // Wraith
                 VehicleHandler.reset(0x003742, 21); // Wraith (Mortar)
                 VehicleHandler.reset(0x003743, 21); // Wraith (Anti-infantry)
                 VehicleHandler.reset(0x003744, 21); // Wraith (Anti-Air)
                 VehicleHandler.reset(0x003745, 21); // Wraith (Anti-Infantry + Air)
                 //Projectiles
                 projectileCombo.Items.Remove("Fuel Rod Round (Variant 1)");
                 projectileCombo.Items.Remove("Wraith Blast");
                 projectileCombo.Items.Remove("Hornet Rocket");
                 ProjectileHandler.reset(0x0015C8, 32); // Fuel Rod Round (Variant 1)
                 ProjectileHandler.reset(0x0015CB, 32); // Wraith Blast
                 ProjectileHandler.reset(0x0015CE, 32); // Hornet Rocket
                 //Props
                 propCombo.Items.Remove("Scorpion junk");
                 propCombo.Items.Remove("Fusion Coil");
                 propCombo.Items.Remove("Flag Stand 4");
                 propCombo.Items.Remove("Invisible Prop");
                 propCombo.Items.Remove("Invisible Prop 2");
                 propCombo.Items.Remove("Invisible Prop 3");
                 propCombo.Items.Remove("Unsc Crate");
                 propCombo.Items.Remove("Generator");
                 propCombo.Items.Remove("Covenant Weapon Holder");
                 propCombo.Items.Remove("Teleporter Sender");
                 propCombo.Items.Remove("Teleporter Reciever");
                 propCombo.Items.Remove("Teleporter Two-way");
                 propCombo.Items.Remove("Bomb Point 3");
                 propCombo.Items.Remove("Hill Marker 3");
                 propCombo.Items.Remove("Man Cannon 1");
                 propCombo.Items.Remove("Man Cannon 2");
                 propCombo.Items.Remove("Man Cannon 3");
                 propCombo.Items.Remove("Radio Antenna");
                 propCombo.Items.Remove("Small Radio");
                 propCombo.Items.Remove("Drop Pod");
                 propCombo.Items.Remove("Drop Pod Cover");
                 propCombo.Items.Remove("Medical Crate");
                 propCombo.Items.Remove("Covenant Weapon Crate");
                 propCombo.Items.Remove("Barrel");
                 propCombo.Items.Remove("Jerry Can");
                 propCombo.Items.Remove("Small Jerry Can");
                 propCombo.Items.Remove("Tree");
                 propCombo.Items.Remove("Big Tree");
                 PropHandler.reset(0x00002958, 45);   // Scorpion junk
                 PropHandler.reset(0x000034A4, 45);   // Fusion Coil
                 PropHandler.reset(0x00002ECA, 45);  // Flag Stand 4
                 PropHandler.reset(0x00002EED, 45);  // Invisible Prop
                 PropHandler.reset(0x00002EEE, 45);  // Invisible Prop 2
                 PropHandler.reset(0x00002EEF, 45);  // Invisible Prop 3
                 PropHandler.reset(0x00002EBC, 45);  // Unsc Crate
                 PropHandler.reset(0x00002EBD, 45);  // Generator
                 PropHandler.reset(0x00002EBE, 45);  // Covenant Weapon Holder
                 PropHandler.reset(0x00002EC0, 45);  // Teleporter Sender
                 PropHandler.reset(0x00002EC1, 45);  // Teleporter Reciever
                 PropHandler.reset(0x00002EC2, 45);  // Teleporter Two-way
                 PropHandler.reset(0x00002EC7, 45);  // Bomb Point 3
                 PropHandler.reset(0x00002EDC, 45);  // Hill Marker 3
                 PropHandler.reset(0x00002EDB, 45);  // Man Cannon 1
                 PropHandler.reset(0x000034BE, 45);  // Man Cannon 2
                 PropHandler.reset(0x000034BF, 45);  // Man Cannon 3
                 PropHandler.reset(0x000034A5, 45);  // Radio Antenna
                 PropHandler.reset(0x000034A7, 45);  // Small Radio
                 PropHandler.reset(0x000034A8, 45);  // Drop Pod
                 PropHandler.reset(0x000034A9, 45);  // Drop Pod Cover
                 PropHandler.reset(0x000034AB, 45);  // Medical Crate
                 PropHandler.reset(0x000034C0, 45);  // Covenant Weapon Crate
                 PropHandler.reset(0x000034C1, 45);  // Barrel
                 PropHandler.reset(0x000034C2, 45);  // Jerry Can
                 PropHandler.reset(0x000034C3, 45);  // Small Jerry Can
                 PropHandler.reset(0x000034C4, 45);  // Tree
                 PropHandler.reset(0x000034C5, 45);  // Big Tree
             }

            if (mapCombo.SelectedItem.ToString() == "DEFAULT")
            {
                //Vehicles
                vehiclesCombo.Items.Clear();
                vehiclesCombo.Items.Add("Banshee");
                vehiclesCombo.Items.Add("Ghost");
                vehiclesCombo.Items.Add("Mongoose");
                vehiclesCombo.Items.Add("Brute Chopper");
                vehiclesCombo.Items.Add("Shade");
                vehiclesCombo.Items.Add("Scorpion");
                vehiclesCombo.Items.Add("Warthog");
                vehiclesCombo.Items.Add("Warthog (Chaingun)");
                vehiclesCombo.Items.Add("Warthog (Gauss Rifle)");
                vehiclesCombo.Items.Add("Warthog (Troop)");
                vehiclesCombo.Items.Add("Warthog (Snow)");
                vehiclesCombo.Items.Add("Warthog (Chaingun Snow)");
                vehiclesCombo.Items.Add("Warthog (Gauss Rifle Snow)");
                vehiclesCombo.Items.Add("Hornet");
                vehiclesCombo.Items.Add("Hornet (Lite)");
                vehiclesCombo.Items.Add("Hornet (Main Menu)");
                vehiclesCombo.Items.Add("Wraith");
                vehiclesCombo.Items.Add("Wraith (Mortar)");
                vehiclesCombo.Items.Add("Wraith (Anti-infantry)");
                vehiclesCombo.Items.Add("Wraith (Anti-Air)");
                vehiclesCombo.Items.Add("Wraith (Anti-Infantry + Air)");
                VehicleHandler.reset(0x00151A, 0); // Banshee
                VehicleHandler.reset(0x001517, 1); // Ghost
                VehicleHandler.reset(0x001596, 2); // Mongoose
                VehicleHandler.reset(0x001518, 3); // Brute Chopper
                VehicleHandler.reset(0x001516, 4); // Shade
                VehicleHandler.reset(0x001520, 5); // Scorpion
                VehicleHandler.reset(0x00151F, 6); // Warthog
                VehicleHandler.reset(0x0029EC, 7); // Warthog (Chaingun)
                VehicleHandler.reset(0x0029ED, 8); // Warthog (Gauss Rifle)
                VehicleHandler.reset(0x0029EE, 9); // Warthog (Troop)
                VehicleHandler.reset(0x001599, 10); // Warthog (Snow)
                VehicleHandler.reset(0x00433A, 11); // Warthog (Chaingun Snow)
                VehicleHandler.reset(0x00433B, 12); // Warthog (Gauss Rifle Snow)
                VehicleHandler.reset(0x001598, 13); // Hornet
                VehicleHandler.reset(0x00159B, 14); // Hornet Lite
                VehicleHandler.reset(0x0027D8, 15); // Hornet Main Menu
                VehicleHandler.reset(0x001519, 16); // Wraith
                VehicleHandler.reset(0x003742, 17); // Wraith (Mortar)
                VehicleHandler.reset(0x003743, 18); // Wraith (Anti-infantry)
                VehicleHandler.reset(0x003744, 19); // Wraith (Anti-Air)
                VehicleHandler.reset(0x003745, 20); // Wraith (Anti-Infantry + Air)
                //Projectiles
                projectileCombo.Items.Clear();
                projectileCombo.Items.Add("Frag Grenade");
                projectileCombo.Items.Add("Plasma Grenade");
                projectileCombo.Items.Add("Spike Grenade");
                projectileCombo.Items.Add("Flame Grenade");
                projectileCombo.Items.Add("Spike (Grenade)");
                projectileCombo.Items.Add("Flamethrower Flame (Variant 1)");
                projectileCombo.Items.Add("Flamethrower Flame (Variant 2)");
                projectileCombo.Items.Add("Flamethrower Flame (Variant 3)");
                projectileCombo.Items.Add("Flamethrower Flame (Variant 4)");
                projectileCombo.Items.Add("Plasma Grenade (Long Fuse)");
                projectileCombo.Items.Add("Fuel Rod Round (Variant 1)");
                projectileCombo.Items.Add("Fuel Rod Round (Variant 2)");
                projectileCombo.Items.Add("Rocket");
                projectileCombo.Items.Add("Missile Pod Rocket");
                projectileCombo.Items.Add("Wraith Blast");
                projectileCombo.Items.Add("Brute Shot Round");
                projectileCombo.Items.Add("Hornet Rocket");
                projectileCombo.Items.Add("Frage Grenade (Red Trail)");
                projectileCombo.Items.Add("Assault Rifle Round");
                projectileCombo.Items.Add("Battle Rifle Round");
                projectileCombo.Items.Add("Carbine Round");
                projectileCombo.Items.Add("DMR Round");
                projectileCombo.Items.Add("Plasma Rifle Round");
                projectileCombo.Items.Add("Shotgun Pellet");
                projectileCombo.Items.Add("Magnum Round");
                projectileCombo.Items.Add("Sniper Round");
                projectileCombo.Items.Add("Spike (Spiker)");
                projectileCombo.Items.Add("Mauler Round");
                projectileCombo.Items.Add("Human Projectile (possible)");
                projectileCombo.Items.Add("Needler Round");
                projectileCombo.Items.Add("Machine Gun Turret Round");
                projectileCombo.Items.Add("Plasma Pistol Round");
                ProjectileHandler.reset(0x0001AD, 0);   //Frag Grenade");
                ProjectileHandler.reset(0x0001B0, 1);   //Plasma Grenade");
                ProjectileHandler.reset(0x0001B3, 2);   //Spike Grenade");
                ProjectileHandler.reset(0x0001B6, 3);   //Flame Grenade");
                ProjectileHandler.reset(0x000587, 4);   //Spike (Grenade)");
                ProjectileHandler.reset(0x0006D9, 5);   //Flamethrower Flame (Variant 1)");
                ProjectileHandler.reset(0x0006DB, 6);   //Flamethrower Flame (Variant 2)");
                ProjectileHandler.reset(0x0006DC, 7);   //Flamethrower Flame (Variant 3)");
                ProjectileHandler.reset(0x0006FB, 8);   //Flamethrower Flame (Variant 4)");
                ProjectileHandler.reset(0x0015A7, 9);   //Plasma Grenade (Long Fuse)");
                ProjectileHandler.reset(0x0015C8, 10);  //Fuel Rod Round (Variant 1)");
                ProjectileHandler.reset(0x0015CF, 11);  //Fuel Rod Round (Variant 2)");
                ProjectileHandler.reset(0x0015C9, 12);  //Rocket");
                ProjectileHandler.reset(0x0015CA, 13);  //Missile Pod Rocket");
                ProjectileHandler.reset(0x0015CB, 14);  //Wraith Blast");
                ProjectileHandler.reset(0x0015CD, 15);  //Brute Shot Round");
                ProjectileHandler.reset(0x0015CE, 16);  //Hornet Rocket");
                ProjectileHandler.reset(0x0015D0, 17);  //Frage Grenade (Red Trail)");
                ProjectileHandler.reset(0x001B90, 18);  //Assault Rifle Round");
                ProjectileHandler.reset(0x001D88, 19);  //Battle Rifle Round");
                ProjectileHandler.reset(0x001DBC, 20);  //Carbine Round");
                ProjectileHandler.reset(0x001E12, 21);  //DMR Round");
                ProjectileHandler.reset(0x001E49, 22);  //Plasma Rifle Round");
                ProjectileHandler.reset(0x001F00, 23);  //Shotgun Pellet");
                ProjectileHandler.reset(0x001F51, 24);  //Magnum Round");
                ProjectileHandler.reset(0x001F92, 25);  //Sniper Round");
                ProjectileHandler.reset(0x002058, 26);  //Spike (Spiker)");
                ProjectileHandler.reset(0x00208F, 27);  //Mauler Round");
                ProjectileHandler.reset(0x0020BD, 28);  //Human Projectile (possible)");
                ProjectileHandler.reset(0x0020EF, 29);  //Needler Round");
                ProjectileHandler.reset(0x00219E, 30);  //Machine Gun Turret Round");
                ProjectileHandler.reset(0x00225C, 31);  //Plasma Pistol Round");
                //Weapons
                weaponsCombo.Items.Clear();
                weaponsCombo.Items.Add("Spiker");
                weaponsCombo.Items.Add("Beam Rifle");
                weaponsCombo.Items.Add("Hammer");
                weaponsCombo.Items.Add("Plasma Turret");
                weaponsCombo.Items.Add("Assault Rifle (Defualt)");
                weaponsCombo.Items.Add("Assault Rifle (Red)");
                weaponsCombo.Items.Add("Assault Rifle (Yellow)");
                weaponsCombo.Items.Add("Assault Rifle (Green)");
                weaponsCombo.Items.Add("Assault Rifle (Gold)");
                weaponsCombo.Items.Add("Smg (Default)");
                weaponsCombo.Items.Add("Smg (Red)");
                weaponsCombo.Items.Add("Smg (Yellow)");
                weaponsCombo.Items.Add("Smg (Green)");
                weaponsCombo.Items.Add("Smg (Gold)");
                weaponsCombo.Items.Add("Battle Rifle (Default)");
                weaponsCombo.Items.Add("Battle Rifle (Red)");
                weaponsCombo.Items.Add("Battle Rifle (Yellow)");
                weaponsCombo.Items.Add("Battle Rifle (Green)");
                weaponsCombo.Items.Add("Battle Rifle (Blue)");
                weaponsCombo.Items.Add("Battle Rifle (Purple)");
                weaponsCombo.Items.Add("Battle Rifle (Gold)");
                weaponsCombo.Items.Add("DMR (Default)");
                weaponsCombo.Items.Add("DMR (Red)");
                weaponsCombo.Items.Add("DMR (Yellow)");
                weaponsCombo.Items.Add("DMR (Green)");
                weaponsCombo.Items.Add("DMR (Blue)");
                weaponsCombo.Items.Add("DMR (Purple)");
                weaponsCombo.Items.Add("DMR (Gold)");
                weaponsCombo.Items.Add("Magnum (Default)");
                weaponsCombo.Items.Add("Magnum (Red)");
                weaponsCombo.Items.Add("Magnum (Gold)");
                weaponsCombo.Items.Add("Carbine (Default)");
                weaponsCombo.Items.Add("Carbine (Red)");
                weaponsCombo.Items.Add("Carbine (Yellow)");
                weaponsCombo.Items.Add("Carbine (Green)");
                weaponsCombo.Items.Add("Carbine (Blue)");
                weaponsCombo.Items.Add("Carbine (Purple)");
                weaponsCombo.Items.Add("Carbine (Gold)");
                weaponsCombo.Items.Add("Mauler (Default)");
                weaponsCombo.Items.Add("Mauler (Gold)");
                weaponsCombo.Items.Add("Energy Sword");
                weaponsCombo.Items.Add("Energy Sword (No Charge)");
                weaponsCombo.Items.Add("Plasma Rifle (default)");
                weaponsCombo.Items.Add("Plasma Rifle (gold)");
                weaponsCombo.Items.Add("Plasma Pistol (default)");
                weaponsCombo.Items.Add("Plasma Pistol (gold)");
                weaponsCombo.Items.Add("Flag");
                weaponsCombo.Items.Add("Skull");
                weaponsCombo.Items.Add("Bomb");
                weaponsCombo.Items.Add("Sniper");
                weaponsCombo.Items.Add("Spartan Laser");
                weaponsCombo.Items.Add("Rocker Launcher");
                weaponsCombo.Items.Add("Needler");
                weaponsCombo.Items.Add("Fuel Rod");
                weaponsCombo.Items.Add("Brute Shot");
                weaponsCombo.Items.Add("Shotgun");
                WeaponHandler.reset(0x001500, 0);   //Spiker
                WeaponHandler.reset(0x001509, 1);   //Beam Rifle
                WeaponHandler.reset(0x00150C, 2);   //Hammer
                WeaponHandler.reset(0x00150E, 3);   //Plasma Turret
                WeaponHandler.reset(0x00151E, 4);   //Assault Rifle (Defualt)
                WeaponHandler.reset(0x001581, 5);   //Assault Rifle (Red)
                WeaponHandler.reset(0x001582, 6);   //Assault Rifle (Yellow)
                WeaponHandler.reset(0x001583, 7);   //Assault Rifle (Green)
                WeaponHandler.reset(0x001584, 8);   //Assault Rifle (Gold)
                WeaponHandler.reset(0x00157D, 9);   //Smg (Default)
                WeaponHandler.reset(0x00158E, 10);  //Smg (Red)
                WeaponHandler.reset(0x00158C, 11);  //Smg (Yellow)
                WeaponHandler.reset(0x00158D, 12);  //Smg (Green)
                WeaponHandler.reset(0x00158F, 13);  //Smg (Gold)
                WeaponHandler.reset(0x00157C, 14);  //Battle Rifle (Default)
                WeaponHandler.reset(0x001586, 15);  //Battle Rifle (Red)
                WeaponHandler.reset(0x0015BB, 16);  //Battle Rifle (Yellow)
                WeaponHandler.reset(0x0015BC, 17);  //Battle Rifle (Green)
                WeaponHandler.reset(0x001585, 18);  //Battle Rifle (Blue)
                WeaponHandler.reset(0x0015BD, 19);  //Battle Rifle (Purple)
                WeaponHandler.reset(0x001587, 20);  //Battle Rifle (Gold)
                WeaponHandler.reset(0x001580, 21);  //DMR (Default)
                WeaponHandler.reset(0x00158A, 22);  //DMR (Red)
                WeaponHandler.reset(0x001589, 23);  //DMR (Yellow)
                WeaponHandler.reset(0x001588, 24);  //DMR (Green)
                WeaponHandler.reset(0x0015BE, 25);  //DMR (Blue)
                WeaponHandler.reset(0x0015BF, 26);  //DMR (Purple)
                WeaponHandler.reset(0x00158B, 27);  //DMR (Gold)
                WeaponHandler.reset(0x00157E, 28);  //Magnum (Default)
                WeaponHandler.reset(0x001593, 29);  //Magnum (Red)
                WeaponHandler.reset(0x001594, 30);  //Magnum (Gold)
                WeaponHandler.reset(0x0014FE, 31);  //Carbine (Default)
                WeaponHandler.reset(0x0015C3, 32);  //Carbine (Red)
                WeaponHandler.reset(0x0015C0, 33);  //Carbine (Yellow)
                WeaponHandler.reset(0x0015C4, 34);  //Carbine (Green)
                WeaponHandler.reset(0x0015C1, 35);  //Carbine (Blue)
                WeaponHandler.reset(0x0015C2, 36);  //Carbine (Purple)
                WeaponHandler.reset(0x001591, 37);  //Carbine (Gold)
                WeaponHandler.reset(0x001504, 38);  //Mauler (Default)
                WeaponHandler.reset(0x001592, 39);  //Mauler (Gold)
                WeaponHandler.reset(0x00159E, 40);  //Energy Sword
                WeaponHandler.reset(0x00157F, 41);  //Energy Sword (No Charge)
                WeaponHandler.reset(0x001525, 42);  //Plasma Rifle (default)
                WeaponHandler.reset(0x001590, 43);  //Plasma Rifle (gold)
                WeaponHandler.reset(0x0014F7, 44);  //Plasma Pistol (default)
                WeaponHandler.reset(0x001595, 45);  //Plasma Pistol (gold)
                WeaponHandler.reset(0x0015A2, 46);  //Flag
                WeaponHandler.reset(0x0015A3, 47);  //Skull
                WeaponHandler.reset(0x0015A4, 48);  //Bomb
                WeaponHandler.reset(0x0015B1, 49);  //Sniper
                WeaponHandler.reset(0x0015B2, 50);  //Spartan Laser
                WeaponHandler.reset(0x0015B3, 51);  //Rocker Launcher
                WeaponHandler.reset(0x0014F8, 52);  //Needler
                WeaponHandler.reset(0x0014F9, 53);  //Fuel Rod
                WeaponHandler.reset(0x0014FF, 54);  //Brute Shot
                WeaponHandler.reset(0x001585, 55);  //Shotgun
                //Props
                propCombo.Items.Add("Mounted Machine gun");
                propCombo.Items.Add("Covenant Junk 1");
                propCombo.Items.Add("Covenant Junk 2");
                propCombo.Items.Add("Covenant Junk 3");
                propCombo.Items.Add("Junk 1");
                propCombo.Items.Add("Junk 2");
                propCombo.Items.Add("Junk 3");
                propCombo.Items.Add("Scorpion junk");
                propCombo.Items.Add("Fusion Coil");
                propCombo.Items.Add("Flag Stand");
                propCombo.Items.Add("Flag Stand 2");
                propCombo.Items.Add("Flag Stand 3");
                propCombo.Items.Add("Flag Stand 4");
                propCombo.Items.Add("Invisible Prop");
                propCombo.Items.Add("Invisible Prop 2");
                propCombo.Items.Add("Invisible Prop 3");
                propCombo.Items.Add("Unsc Crate");
                propCombo.Items.Add("Generator");
                propCombo.Items.Add("Covenant Weapon Holder");
                propCombo.Items.Add("Teleporter Sender");
                propCombo.Items.Add("Teleporter Reciever");
                propCombo.Items.Add("Teleporter Two-way");
                propCombo.Items.Add("Bomb Point 1");
                propCombo.Items.Add("Bomb Point 2");
                propCombo.Items.Add("Bomb Point 3");
                propCombo.Items.Add("Bomb Point 4");
                propCombo.Items.Add("Hill Marker 1");
                propCombo.Items.Add("Hill Marker 2");
                propCombo.Items.Add("Hill Marker 3");
                propCombo.Items.Add("Man Cannon 1");
                propCombo.Items.Add("Man Cannon 2");
                propCombo.Items.Add("Man Cannon 3");
                propCombo.Items.Add("Radio Antenna");
                propCombo.Items.Add("Small Crate");
                propCombo.Items.Add("Small Radio");
                propCombo.Items.Add("Drop Pod");
                propCombo.Items.Add("Drop Pod Cover");
                propCombo.Items.Add("Barrier");
                propCombo.Items.Add("Medical Crate");
                propCombo.Items.Add("Covenant Weapon Crate");
                propCombo.Items.Add("Barrel");
                propCombo.Items.Add("Jerry Can");
                propCombo.Items.Add("Small Jerry Can");
                propCombo.Items.Add("Tree");
                propCombo.Items.Add("Big Tree");
                PropHandler.reset(0x00002888, 0);   // Mounted Machine gun
                PropHandler.reset(0x00001A8A, 1);   // Covenant Junk 1
                PropHandler.reset(0x01001A8B, 2);   // Covenant Junk 2
                PropHandler.reset(0x02001A8C, 3);   // Covenant Junk 3
                PropHandler.reset(0x00002603, 4);   // Junk 1
                PropHandler.reset(0x00002607, 5);   // Junk 2
                PropHandler.reset(0x00002608, 6);   // Junk 3
                PropHandler.reset(0x00002958, 7);   // Scorpion junk
                PropHandler.reset(0x000034A4, 8);   // Fusion Coil
                PropHandler.reset(0x00002EC3, 9);   // Flag Stand
                PropHandler.reset(0x00002EC3, 10);  // Flag Stand 2
                PropHandler.reset(0x00002EC5, 11);  // Flag Stand 3
                PropHandler.reset(0x00002ECA, 12);  // Flag Stand 4
                PropHandler.reset(0x00002EED, 13);  // Invisible Prop
                PropHandler.reset(0x00002EEE, 14);  // Invisible Prop 2
                PropHandler.reset(0x00002EEF, 15);  // Invisible Prop 3
                PropHandler.reset(0x00002EBC, 16);  // Unsc Crate
                PropHandler.reset(0x00002EBD, 17);  // Generator
                PropHandler.reset(0x00002EBE, 18);  // Covenant Weapon Holder
                PropHandler.reset(0x00002EC0, 19);  // Teleporter Sender
                PropHandler.reset(0x00002EC1, 20);  // Teleporter Reciever
                PropHandler.reset(0x00002EC2, 21);  // Teleporter Two-way
                PropHandler.reset(0x00002EC4, 22);  // Bomb Point 1
                PropHandler.reset(0x00002EC6, 23);  // Bomb Point 2
                PropHandler.reset(0x00002EC7, 24);  // Bomb Point 3
                PropHandler.reset(0x00002EC9, 25);  // Bomb Point 4
                PropHandler.reset(0x000015A5, 26);  // Hill Marker 1
                PropHandler.reset(0x00002EC8, 27);  // Hill Marker 2
                PropHandler.reset(0x00002EDC, 28);  // Hill Marker 3
                PropHandler.reset(0x00002EDB, 29);  // Man Cannon 1
                PropHandler.reset(0x000034BE, 30);  // Man Cannon 2
                PropHandler.reset(0x000034BF, 31);  // Man Cannon 3
                PropHandler.reset(0x000034A5, 32);  // Radio Antenna
                PropHandler.reset(0x000034A6, 33);  // Small Crate
                PropHandler.reset(0x000034A7, 34);  // Small Radio
                PropHandler.reset(0x000034A8, 35);  // Drop Pod
                PropHandler.reset(0x000034A9, 36);  // Drop Pod Cover
                PropHandler.reset(0x000034AA, 37);  // Barrier
                PropHandler.reset(0x000034AB, 38);  // Medical Crate
                PropHandler.reset(0x000034C0, 39);  // Covenant Weapon Crate
                PropHandler.reset(0x000034C1, 40);  // Barrel
                PropHandler.reset(0x000034C2, 41);  // Jerry Can
                PropHandler.reset(0x000034C3, 42);  // Small Jerry Can
                PropHandler.reset(0x000034C4, 43);  // Tree
                PropHandler.reset(0x000034C5, 44);  // Big Tree
            }

            if (mapCombo.SelectedItem.ToString() == "s3d_turf")
            {
                //Vehicles
                vehiclesCombo.Enabled = true;
                vehiclesCombo.Items.Remove("Banshee");
                vehiclesCombo.Items.Remove("Ghost");
                vehiclesCombo.Items.Remove("Mongoose");
                vehiclesCombo.Items.Remove("Brute Chopper");
                vehiclesCombo.Items.Remove("Shade");
                vehiclesCombo.Items.Remove("Scorpion");
                vehiclesCombo.Items.Remove("Warthog");
                vehiclesCombo.Items.Remove("Warthog (Gauss Rifle)");
                vehiclesCombo.Items.Remove("Hornet");
                vehiclesCombo.Items.Remove("Hornet (Lite)");
                vehiclesCombo.Items.Remove("Hornet (Main Menu)");
                vehiclesCombo.Items.Remove("Wraith");
                vehiclesCombo.Items.Remove("Wraith (Mortar)");
                vehiclesCombo.Items.Remove("Wraith (Anti-infantry)");
                vehiclesCombo.Items.Remove("Wraith (Anti-Air)");
                vehiclesCombo.Items.Remove("Wraith (Anti-Infantry + Air)");
                VehicleHandler.reset(0x00151A, 22); // Banshee
                VehicleHandler.reset(0x001517, 21); // Ghost
                VehicleHandler.reset(0x001596, 21); // Mongoose
                VehicleHandler.reset(0x001518, 21); // Brute Chopper
                VehicleHandler.reset(0x001516, 21); // Shade
                VehicleHandler.reset(0x001520, 21); // Scorpion
                VehicleHandler.reset(0x00151F, 21); // Warthog
                VehicleHandler.reset(0x0029ED, 21); // Warthog (Gauss Rifle)
                VehicleHandler.reset(0x001598, 21); // Hornet
                VehicleHandler.reset(0x00159B, 21); // Hornet Lite
                VehicleHandler.reset(0x0027D8, 21); // Hornet Main Menu
                VehicleHandler.reset(0x001519, 21); // Wraith
                VehicleHandler.reset(0x003742, 21); // Wraith (Mortar)
                VehicleHandler.reset(0x003743, 21); // Wraith (Anti-infantry)
                VehicleHandler.reset(0x003744, 21); // Wraith (Anti-Air)
                VehicleHandler.reset(0x003745, 21); // Wraith (Anti-Infantry + Air)
                //Projectiles
                projectileCombo.Items.Remove("Fuel Rod Round (Variant 1)");
                projectileCombo.Items.Remove("Wraith Blast");
                projectileCombo.Items.Remove("Hornet Rocket");
                ProjectileHandler.reset(0x0015C8, 32); // Fuel Rod Round (Variant 1)
                ProjectileHandler.reset(0x0015CB, 32); // Wraith Blast
                ProjectileHandler.reset(0x0015CE, 32); // Hornet Rocket
                //Weapons
                weaponsCombo.Items.Remove("Hammer");
                WeaponHandler.reset(0x00150C, 56);   //Hammer
                //Props
                propCombo.Items.Remove("Mounted Machine gun");
                propCombo.Items.Remove("Scorpion junk");
                propCombo.Items.Remove("Fusion Coil");
                propCombo.Items.Remove("Flag Stand 4");
                propCombo.Items.Remove("Invisible Prop");
                propCombo.Items.Remove("Invisible Prop 2");
                propCombo.Items.Remove("Invisible Prop 3");
                propCombo.Items.Remove("Unsc Crate");
                propCombo.Items.Remove("Generator");
                propCombo.Items.Remove("Covenant Weapon Holder");
                propCombo.Items.Remove("Teleporter Sender");
                propCombo.Items.Remove("Teleporter Reciever");
                propCombo.Items.Remove("Teleporter Two-way");
                propCombo.Items.Remove("Bomb Point 3");
                propCombo.Items.Remove("Hill Marker 3");
                propCombo.Items.Remove("Man Cannon 1");
                propCombo.Items.Remove("Man Cannon 2");
                propCombo.Items.Remove("Man Cannon 3");
                propCombo.Items.Remove("Radio Antenna");
                propCombo.Items.Remove("Small Crate");
                propCombo.Items.Remove("Small Radio");
                propCombo.Items.Remove("Drop Pod");
                propCombo.Items.Remove("Drop Pod Cover");
                propCombo.Items.Remove("Barrier");
                propCombo.Items.Remove("Medical Crate");
                propCombo.Items.Remove("Covenant Weapon Crate");
                propCombo.Items.Remove("Barrel");
                propCombo.Items.Remove("Jerry Can");
                propCombo.Items.Remove("Small Jerry Can");
                propCombo.Items.Remove("Tree");
                propCombo.Items.Remove("Big Tree");
                PropHandler.reset(0x00002888, 45);   // Mounted Machine gun
                PropHandler.reset(0x00002958, 45);   // Scorpion junk
                PropHandler.reset(0x000034A4, 45);   // Fusion Coil
                PropHandler.reset(0x00002ECA, 45);  // Flag Stand 4
                PropHandler.reset(0x00002EEE, 45);  // Invisible Prop 2
                PropHandler.reset(0x00002EEF, 45);  // Invisible Prop 3
                PropHandler.reset(0x00002EBC, 45);  // Unsc Crate
                PropHandler.reset(0x00002EBD, 45);  // Generator
                PropHandler.reset(0x00002EBE, 45);  // Covenant Weapon Holder
                PropHandler.reset(0x00002EC0, 45);  // Teleporter Sender
                PropHandler.reset(0x00002EC1, 45);  // Teleporter Reciever
                PropHandler.reset(0x00002EC2, 45);  // Teleporter Two-way
                PropHandler.reset(0x00002EC7, 45);  // Bomb Point 3
                PropHandler.reset(0x00002EDC, 45);  // Hill Marker 3
                PropHandler.reset(0x00002EDB, 45);  // Man Cannon 1
                PropHandler.reset(0x000034BE, 45);  // Man Cannon 2
                PropHandler.reset(0x000034BF, 45);  // Man Cannon 3
                PropHandler.reset(0x000034A5, 45);  // Radio Antenna
                PropHandler.reset(0x000034A6, 45);  // Small Crate
                PropHandler.reset(0x000034A7, 45);  // Small Radio
                PropHandler.reset(0x000034A8, 45);  // Drop Pod
                PropHandler.reset(0x000034A9, 45);  // Drop Pod Cover
                PropHandler.reset(0x000034AA, 45);  // Barrier
                PropHandler.reset(0x000034AB, 45);  // Medical Crate
                PropHandler.reset(0x000034C0, 45);  // Covenant Weapon Crate
                PropHandler.reset(0x000034C1, 45);  // Barrel
                PropHandler.reset(0x000034C2, 45);  // Jerry Can
                PropHandler.reset(0x000034C3, 45);  // Small Jerry Can
                PropHandler.reset(0x000034C4, 45);  // Tree
                PropHandler.reset(0x000034C5, 45);  // Big Tree

               
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
                /* mov eax, {jump height} -> mov [ebp-8], eax -> nop padding */
            }
            else 
            {
                byte[] rawData = { 0xF3, 0x0F, 0x59, 0x4D, 0xF8, 0xF3, 0x0F, 0x11, 0x4D, 0xF8 };
                MemoryManager.WriteToAddress(0xBE1C23, rawData);
                /* mulss xmm1, [ebp+var_8] - > movss [ebp+var_8], xmm1 */
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
                /* mov eax, {jump height} -> mov [ebp-8], eax -> nop padding */
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
            byte[] rawData = { 0xF3, 0x0F, 0x59, 0x4D, 0xF8, 0xF3, 0x0F, 0x11, 0x4D, 0xF8 };
            MemoryManager.WriteToAddress(0xBE1C23, rawData);
            /* mulss xmm1, [ebp+var_8] - > movss [ebp+var_8], xmm1 */
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cyka - Halo Online Realtime Editor \r\n\r\nCreated by Razzile, NexusAU, FishPhd, Bivi \r\nand many more from the ElDorito IRC", "About");
        }

    }
}
