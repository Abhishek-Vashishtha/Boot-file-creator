namespace Boot_file_creator
{
    partial class Bootfile_Creator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bootfile_Creator));
            this.label1 = new System.Windows.Forms.Label();
            this.Button_select_fw_file = new System.Windows.Forms.Button();
            this.Button_create_bootfile = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Label_bootfle_size = new System.Windows.Forms.Label();
            this.Btn_HowToUse = new System.Windows.Forms.Button();
            this.Btn_About = new System.Windows.Forms.Button();
            this.ChkBox_Rj45 = new System.Windows.Forms.CheckBox();
            this.Chkbox_Optical = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boot File Creation";
            // 
            // Button_select_fw_file
            // 
            this.Button_select_fw_file.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Button_select_fw_file.Location = new System.Drawing.Point(122, 88);
            this.Button_select_fw_file.Name = "Button_select_fw_file";
            this.Button_select_fw_file.Size = new System.Drawing.Size(147, 27);
            this.Button_select_fw_file.TabIndex = 1;
            this.Button_select_fw_file.Text = "Browse Fw Bin File";
            this.Button_select_fw_file.UseVisualStyleBackColor = false;
            this.Button_select_fw_file.Click += new System.EventHandler(this.Button_select_fw_file_Click);
            // 
            // Button_create_bootfile
            // 
            this.Button_create_bootfile.BackColor = System.Drawing.Color.DarkOrange;
            this.Button_create_bootfile.Location = new System.Drawing.Point(122, 144);
            this.Button_create_bootfile.Name = "Button_create_bootfile";
            this.Button_create_bootfile.Size = new System.Drawing.Size(147, 27);
            this.Button_create_bootfile.TabIndex = 2;
            this.Button_create_bootfile.Text = "Create Boot File";
            this.Button_create_bootfile.UseVisualStyleBackColor = false;
            this.Button_create_bootfile.Click += new System.EventHandler(this.Button_create_bootfile_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(372, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Label_bootfle_size
            // 
            this.Label_bootfle_size.AutoSize = true;
            this.Label_bootfle_size.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_bootfle_size.ForeColor = System.Drawing.Color.Navy;
            this.Label_bootfle_size.Location = new System.Drawing.Point(297, 100);
            this.Label_bootfle_size.Name = "Label_bootfle_size";
            this.Label_bootfle_size.Size = new System.Drawing.Size(63, 15);
            this.Label_bootfle_size.TabIndex = 4;
            this.Label_bootfle_size.Text = "File Size";
            this.Label_bootfle_size.Click += new System.EventHandler(this.Label_bootfle_size_Click);
            // 
            // Btn_HowToUse
            // 
            this.Btn_HowToUse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_HowToUse.Location = new System.Drawing.Point(0, 0);
            this.Btn_HowToUse.Name = "Btn_HowToUse";
            this.Btn_HowToUse.Size = new System.Drawing.Size(120, 23);
            this.Btn_HowToUse.TabIndex = 5;
            this.Btn_HowToUse.Text = "How To Use";
            this.Btn_HowToUse.UseVisualStyleBackColor = true;
            this.Btn_HowToUse.Click += new System.EventHandler(this.Btn_HowToUse_Click);
            // 
            // Btn_About
            // 
            this.Btn_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_About.Location = new System.Drawing.Point(126, 0);
            this.Btn_About.Name = "Btn_About";
            this.Btn_About.Size = new System.Drawing.Size(66, 23);
            this.Btn_About.TabIndex = 6;
            this.Btn_About.Text = "About";
            this.Btn_About.UseVisualStyleBackColor = true;
            this.Btn_About.Click += new System.EventHandler(this.Btn_About_Click);
            // 
            // ChkBox_Rj45
            // 
            this.ChkBox_Rj45.AutoSize = true;
            this.ChkBox_Rj45.Location = new System.Drawing.Point(12, 94);
            this.ChkBox_Rj45.Name = "ChkBox_Rj45";
            this.ChkBox_Rj45.Size = new System.Drawing.Size(59, 17);
            this.ChkBox_Rj45.TabIndex = 7;
            this.ChkBox_Rj45.Text = "RJ 45";
            this.ChkBox_Rj45.UseVisualStyleBackColor = true;
            this.ChkBox_Rj45.CheckedChanged += new System.EventHandler(this.ChkBox_Rj45_CheckedChanged);
            // 
            // Chkbox_Optical
            // 
            this.Chkbox_Optical.AutoSize = true;
            this.Chkbox_Optical.Location = new System.Drawing.Point(12, 126);
            this.Chkbox_Optical.Name = "Chkbox_Optical";
            this.Chkbox_Optical.Size = new System.Drawing.Size(78, 17);
            this.Chkbox_Optical.TabIndex = 8;
            this.Chkbox_Optical.Text = "OPTICAL";
            this.Chkbox_Optical.UseVisualStyleBackColor = true;
            this.Chkbox_Optical.CheckedChanged += new System.EventHandler(this.Chkbox_Optical_CheckedChanged);
            // 
            // Bootfile_Creator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(372, 271);
            this.Controls.Add(this.Chkbox_Optical);
            this.Controls.Add(this.ChkBox_Rj45);
            this.Controls.Add(this.Btn_About);
            this.Controls.Add(this.Btn_HowToUse);
            this.Controls.Add(this.Label_bootfle_size);
            this.Controls.Add(this.Button_create_bootfile);
            this.Controls.Add(this.Button_select_fw_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Bootfile_Creator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boot file Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_select_fw_file;
        private System.Windows.Forms.Button Button_create_bootfile;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Label_bootfle_size;
        private System.Windows.Forms.Button Btn_HowToUse;
        private System.Windows.Forms.Button Btn_About;
        private System.Windows.Forms.CheckBox ChkBox_Rj45;
        private System.Windows.Forms.CheckBox Chkbox_Optical;
    }
}

