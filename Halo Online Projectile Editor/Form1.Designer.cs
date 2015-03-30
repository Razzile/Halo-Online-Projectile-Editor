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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grenadeCheck = new System.Windows.Forms.CheckBox();
            this.ammoCheck = new System.Windows.Forms.CheckBox();
            this.godCheck = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.projectileCombo = new System.Windows.Forms.ComboBox();
            this.projectileCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.grenadeCheck);
            this.groupBox1.Controls.Add(this.ammoCheck);
            this.groupBox1.Controls.Add(this.godCheck);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Options";
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
            this.groupBox2.Controls.Add(this.projectileCombo);
            this.groupBox2.Controls.Add(this.projectileCheck);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Projectiles";
            // 
            // projectileCombo
            // 
            this.projectileCombo.FormattingEnabled = true;
            this.projectileCombo.Items.AddRange(new object[] {
            "Frag Grenade",
            "Plasma Grenade",
            "Spike Grenade",
            "Flame Grenade",
            "Spike (Grenade)",
            "Flamethrower Flame (Variant 1)",
            "Flamethrower Flame (Variant 2)",
            "Flamethrower Flame (Variant 3)",
            "Flamethrower Flame (Variant 4)",
            "Plasma Grenade (Long Fuse)",
            "Fuel Rod Round (Variant 1)",
            "Fuel Rod Round (Variant 2)",
            "Rocket",
            "Missile Pod Rocket",
            "Wraith Blast",
            "Brute Shot Round",
            "Hornet Rocket",
            "Frage Grenade (Red Trail)",
            "Plasma Bolt (possible)",
            "Assault Rifle Round",
            "Battle Rifle Round",
            "Carbine Round",
            "DMR Round",
            "Plasma Rifle Round",
            "Shotgun Pellet",
            "Magnum Round",
            "Sniper Round",
            "Spike (Spiker)",
            "Mauler Round",
            "Human Projectile (possible)",
            "Needler Round",
            "Machine Gun Turret Round",
            "Plasma Pistol Round",
            "Sniper Rifle"});
            this.projectileCombo.Location = new System.Drawing.Point(7, 43);
            this.projectileCombo.Name = "projectileCombo";
            this.projectileCombo.Size = new System.Drawing.Size(121, 21);
            this.projectileCombo.TabIndex = 1;
            this.projectileCombo.SelectedIndexChanged += new System.EventHandler(this.projectileCombo_SelectedIndexChanged);
            // 
            // projectileCheck
            // 
            this.projectileCheck.AutoSize = true;
            this.projectileCheck.Location = new System.Drawing.Point(7, 20);
            this.projectileCheck.Name = "projectileCheck";
            this.projectileCheck.Size = new System.Drawing.Size(153, 17);
            this.projectileCheck.TabIndex = 0;
            this.projectileCheck.Text = "Custom Projectiles enabled";
            this.projectileCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox grenadeCheck;
        private System.Windows.Forms.CheckBox ammoCheck;
        private System.Windows.Forms.CheckBox godCheck;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox projectileCombo;
        private System.Windows.Forms.CheckBox projectileCheck;
    }
}

