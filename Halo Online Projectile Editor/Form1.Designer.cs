namespace Halo_Online_Projectile_Editor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fireRateCheck = new System.Windows.Forms.CheckBox();
            this.jumpTrackbar = new System.Windows.Forms.TrackBar();
            this.jumpCheck = new System.Windows.Forms.CheckBox();
            this.grenadeCheck = new System.Windows.Forms.CheckBox();
            this.ammoCheck = new System.Windows.Forms.CheckBox();
            this.godCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.propCombo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.armorCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vehiclesCombo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.miscCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weaponsCombo = new System.Windows.Forms.ComboBox();
            this.projectileCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mapCombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mapLabel = new System.Windows.Forms.Label();
            this.setButton = new System.Windows.Forms.Button();
            this.mapCheck = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTrackbar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fireRateCheck);
            this.groupBox1.Controls.Add(this.jumpTrackbar);
            this.groupBox1.Controls.Add(this.jumpCheck);
            this.groupBox1.Controls.Add(this.grenadeCheck);
            this.groupBox1.Controls.Add(this.ammoCheck);
            this.groupBox1.Controls.Add(this.godCheck);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Options";
            // 
            // fireRateCheck
            // 
            this.fireRateCheck.AutoSize = true;
            this.fireRateCheck.Location = new System.Drawing.Point(131, 68);
            this.fireRateCheck.Name = "fireRateCheck";
            this.fireRateCheck.Size = new System.Drawing.Size(94, 17);
            this.fireRateCheck.TabIndex = 6;
            this.fireRateCheck.Text = "High Fire Rate";
            this.fireRateCheck.UseVisualStyleBackColor = true;
            this.fireRateCheck.CheckedChanged += new System.EventHandler(this.fireRateCheck_CheckedChanged);
            // 
            // jumpTrackbar
            // 
            this.jumpTrackbar.Location = new System.Drawing.Point(123, 34);
            this.jumpTrackbar.Maximum = 15;
            this.jumpTrackbar.Name = "jumpTrackbar";
            this.jumpTrackbar.Size = new System.Drawing.Size(98, 45);
            this.jumpTrackbar.TabIndex = 4;
            this.jumpTrackbar.TabStop = false;
            this.jumpTrackbar.Scroll += new System.EventHandler(this.jumpTrackbar_Scroll);
            this.jumpTrackbar.ValueChanged += new System.EventHandler(this.jumpTrackbar_ValueChanged);
            // 
            // jumpCheck
            // 
            this.jumpCheck.AutoSize = true;
            this.jumpCheck.Location = new System.Drawing.Point(131, 11);
            this.jumpCheck.Name = "jumpCheck";
            this.jumpCheck.Size = new System.Drawing.Size(85, 17);
            this.jumpCheck.TabIndex = 3;
            this.jumpCheck.Text = "Jump Height";
            this.jumpCheck.UseVisualStyleBackColor = true;
            this.jumpCheck.CheckedChanged += new System.EventHandler(this.jumpCheck_CheckedChanged);
            // 
            // grenadeCheck
            // 
            this.grenadeCheck.AutoSize = true;
            this.grenadeCheck.Location = new System.Drawing.Point(7, 68);
            this.grenadeCheck.Name = "grenadeCheck";
            this.grenadeCheck.Size = new System.Drawing.Size(118, 17);
            this.grenadeCheck.TabIndex = 2;
            this.grenadeCheck.Text = "Unlimited Grenades";
            this.grenadeCheck.UseVisualStyleBackColor = true;
            this.grenadeCheck.CheckedChanged += new System.EventHandler(this.grenadeCheck_CheckedChanged);
            // 
            // ammoCheck
            // 
            this.ammoCheck.AutoSize = true;
            this.ammoCheck.Location = new System.Drawing.Point(7, 44);
            this.ammoCheck.Name = "ammoCheck";
            this.ammoCheck.Size = new System.Drawing.Size(101, 17);
            this.ammoCheck.TabIndex = 1;
            this.ammoCheck.Text = "Unlimited Ammo";
            this.ammoCheck.UseVisualStyleBackColor = true;
            this.ammoCheck.CheckedChanged += new System.EventHandler(this.ammoCheck_CheckedChanged);
            // 
            // godCheck
            // 
            this.godCheck.AutoSize = true;
            this.godCheck.Location = new System.Drawing.Point(7, 20);
            this.godCheck.Name = "godCheck";
            this.godCheck.Size = new System.Drawing.Size(75, 17);
            this.godCheck.TabIndex = 0;
            this.godCheck.Text = "God mode";
            this.godCheck.UseVisualStyleBackColor = true;
            this.godCheck.CheckedChanged += new System.EventHandler(this.godCheck_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.propCombo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.armorCombo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.vehiclesCombo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.miscCombo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.weaponsCombo);
            this.groupBox2.Controls.Add(this.projectileCombo);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 359);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 333);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projectile Selector";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // propCombo
            // 
            this.propCombo.FormattingEnabled = true;
            this.propCombo.Items.AddRange(new object[] {
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
            "Big Tree"});
            this.propCombo.Location = new System.Drawing.Point(8, 273);
            this.propCombo.Name = "propCombo";
            this.propCombo.Size = new System.Drawing.Size(208, 21);
            this.propCombo.TabIndex = 12;
            this.propCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_2);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Props";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Armor";
            // 
            // armorCombo
            // 
            this.armorCombo.FormattingEnabled = true;
            this.armorCombo.Items.AddRange(new object[] {
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
            "Armor 27"});
            this.armorCombo.Location = new System.Drawing.Point(8, 223);
            this.armorCombo.Name = "armorCombo";
            this.armorCombo.Size = new System.Drawing.Size(208, 21);
            this.armorCombo.TabIndex = 9;
            this.armorCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Vehicles";
            // 
            // vehiclesCombo
            // 
            this.vehiclesCombo.FormattingEnabled = true;
            this.vehiclesCombo.Items.AddRange(new object[] {
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
            "Wraith (Anti-Infantry + Air)"});
            this.vehiclesCombo.Location = new System.Drawing.Point(8, 177);
            this.vehiclesCombo.Name = "vehiclesCombo";
            this.vehiclesCombo.Size = new System.Drawing.Size(208, 21);
            this.vehiclesCombo.TabIndex = 7;
            this.vehiclesCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Equipment/Bipeds";
            // 
            // miscCombo
            // 
            this.miscCombo.FormattingEnabled = true;
            this.miscCombo.Items.AddRange(new object[] {
            "Headless Spartan",
            "Headless Spartan Hologram",
            "Monitor",
            "Forge Marker",
            "Spawn Point",
            "Trip Mine (Active)",
            "Flare",
            "Power Drain (Active)",
            "Power Drain Red (Active)",
            "Power Drain Yellow (Active)",
            "New Equipment",
            "Cloaking 1",
            "Cloaking 2",
            "Power Drain (Inactive)",
            "Bubble Shield (Inactive)",
            "Flare (Inactive)",
            "Regen (Inactive)",
            "Trip Mine (Inactive)",
            "Sentry (Inactive)",
            "Dropshield (Inactive)",
            "Power Drain 1 (Inactive)",
            "Power Drain 2 (Inactive)",
            "Power Drain 3 (Inactive)"});
            this.miscCombo.Location = new System.Drawing.Point(8, 130);
            this.miscCombo.Name = "miscCombo";
            this.miscCombo.Size = new System.Drawing.Size(208, 21);
            this.miscCombo.TabIndex = 5;
            this.miscCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(4, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selected: Default";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Weapons";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Projectiles";
            // 
            // weaponsCombo
            // 
            this.weaponsCombo.FormattingEnabled = true;
            this.weaponsCombo.Items.AddRange(new object[] {
            "Spiker",
            "Beam Rifle",
            "Hammer",
            "Plasma Turret",
            "Assault Rifle (Default)",
            "Assault Rifle (Red)",
            "Assault Rifle (Yellow)",
            "Assault Rifle (Green)",
            "Assault Rifle (Gold)",
            "Smg (Default)",
            "Smg (Red)",
            "Smg (Yellow)",
            "Smg (Green)",
            "Smg (Gold)",
            "Battle Rifle (Default)",
            "Battle Rifle (Red)",
            "Battle Rifle (Yellow)",
            "Battle Rifle (Green)",
            "Battle Rifle (Blue)",
            "Battle Rifle (Purple)",
            "Battle Rifle (Gold)",
            "DMR (Default)",
            "DMR (Red)",
            "DMR (Yellow)",
            "DMR (Green)",
            "DMR (Blue)",
            "DMR (Purple)",
            "DMR (Gold)",
            "Magnum (Default)",
            "Magnum (Red)",
            "Magnum (Gold)",
            "Carbine (Default)",
            "Carbine (Red)",
            "Carbine (Yellow)",
            "Carbine (Green)",
            "Carbine (Blue)",
            "Carbine (Purple)",
            "Carbine (Gold)",
            "Mauler (Default)",
            "Mauler (Gold)",
            "Energy Sword",
            "Energy Sword (No Charge)",
            "Plasma Rifle (default)",
            "Plasma Rifle (gold)",
            "Plasma Pistol (default)",
            "Plasma Pistol (gold)",
            "Flag",
            "Skull",
            "Bomb",
            "Sniper",
            "Spartan Laser",
            "Rocker Launcher",
            "Needler",
            "Fuel Rod",
            "Brute Shot",
            "Shotgun",
            "Sentinel Beam"});
            this.weaponsCombo.Location = new System.Drawing.Point(8, 83);
            this.weaponsCombo.Name = "weaponsCombo";
            this.weaponsCombo.Size = new System.Drawing.Size(208, 21);
            this.weaponsCombo.TabIndex = 1;
            this.weaponsCombo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // projectileCombo
            // 
            this.projectileCombo.FormattingEnabled = true;
            this.projectileCombo.Items.AddRange(new object[] {
            "Frag",
            "Plasma",
            "Spike",
            "Flame",
            "Spike",
            "Flamethrower Flame",
            "Flamethrower Flame 2",
            "Flamethrower Flame 3",
            "Flamethrower Flame 4",
            "Plasma (Long Fuse)",
            "Fuel Rod round 1",
            "Fuel Rod round 2",
            "Rockets",
            "Missile Pod",
            "Wraith shots",
            "Brute Shot",
            "Hornet Rocket",
            "Frag Grenade (Red trail)",
            "Assault Rifle Round",
            "Battle Rifle Round",
            "Covenant Rifle Round",
            "DMR/AR round",
            "Plasma Rifle/Ghost Round",
            "Shotgun Pellet",
            "Magnum Round",
            "Sniper Round",
            "Spiker Round",
            "Mauler Round",
            "Human Projectile",
            "Needler Round",
            "Machine Gun Turret Round",
            "Plasma Pistol"});
            this.projectileCombo.Location = new System.Drawing.Point(9, 38);
            this.projectileCombo.Name = "projectileCombo";
            this.projectileCombo.Size = new System.Drawing.Size(207, 21);
            this.projectileCombo.TabIndex = 1;
            this.projectileCombo.SelectedIndexChanged += new System.EventHandler(this.projectileCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mapCombo
            // 
            this.mapCombo.Enabled = false;
            this.mapCombo.FormattingEnabled = true;
            this.mapCombo.Items.AddRange(new object[] {
            "Default",
            "Guardian",
            "Riverworld",
            "s3d_avalanche",
            "s3d_edge",
            "s3d_reactor",
            "s3d_turf"});
            this.mapCombo.Location = new System.Drawing.Point(7, 45);
            this.mapCombo.Name = "mapCombo";
            this.mapCombo.Size = new System.Drawing.Size(209, 21);
            this.mapCombo.TabIndex = 13;
            this.mapCombo.SelectedIndexChanged += new System.EventHandler(this.mapCombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.mapLabel);
            this.groupBox3.Controls.Add(this.setButton);
            this.groupBox3.Controls.Add(this.mapCheck);
            this.groupBox3.Controls.Add(this.mapCombo);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Map Selector";
            // 
            // mapLabel
            // 
            this.mapLabel.AutoSize = true;
            this.mapLabel.Enabled = false;
            this.mapLabel.Location = new System.Drawing.Point(9, 75);
            this.mapLabel.Name = "mapLabel";
            this.mapLabel.Size = new System.Drawing.Size(89, 13);
            this.mapLabel.TabIndex = 15;
            this.mapLabel.Text = "Selected: Default";
            this.mapLabel.Click += new System.EventHandler(this.label11_Click);
            // 
            // setButton
            // 
            this.setButton.Enabled = false;
            this.setButton.Location = new System.Drawing.Point(163, 70);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(53, 23);
            this.setButton.TabIndex = 14;
            this.setButton.Text = "Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // mapCheck
            // 
            this.mapCheck.AutoSize = true;
            this.mapCheck.Location = new System.Drawing.Point(6, 19);
            this.mapCheck.Name = "mapCheck";
            this.mapCheck.Size = new System.Drawing.Size(140, 17);
            this.mapCheck.TabIndex = 13;
            this.mapCheck.Text = "Allow Custom Projectiles";
            this.mapCheck.UseVisualStyleBackColor = true;
            this.mapCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Halo_Online_Projectile_Editor.Properties.Resources.banner;
            this.pictureBox1.Location = new System.Drawing.Point(-130, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // aboutBtn
            // 
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutBtn.Location = new System.Drawing.Point(12, 698);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(225, 23);
            this.aboutBtn.TabIndex = 6;
            this.aboutBtn.Text = "About/Version";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(247, 731);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Halo Online Trainer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.jumpTrackbar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox grenadeCheck;
        private System.Windows.Forms.CheckBox ammoCheck;
        private System.Windows.Forms.CheckBox godCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox projectileCombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox weaponsCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox miscCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox vehiclesCombo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox armorCombo;
        private System.Windows.Forms.ComboBox propCombo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox mapCombo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox mapCheck;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Label mapLabel;
        private System.Windows.Forms.CheckBox fireRateCheck;
        private System.Windows.Forms.TrackBar jumpTrackbar;
        private System.Windows.Forms.CheckBox jumpCheck;
        private System.Windows.Forms.Button aboutBtn;
    }
}

