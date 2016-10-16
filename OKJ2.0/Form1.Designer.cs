namespace OKJ2._0
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tanuloMemberDGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fájlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésMáskéntToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.megnyitásToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanulóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újTanulóToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelöltTörláseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konzol = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tanuloMemberDGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tanuloMemberDGV
            // 
            this.tanuloMemberDGV.BackgroundColor = System.Drawing.Color.Gray;
            this.tanuloMemberDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tanuloMemberDGV.Location = new System.Drawing.Point(40, 42);
            this.tanuloMemberDGV.Name = "tanuloMemberDGV";
            this.tanuloMemberDGV.Size = new System.Drawing.Size(936, 564);
            this.tanuloMemberDGV.TabIndex = 0;
            this.tanuloMemberDGV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tanuloMemberDGV_CellDoubleClick);
            this.tanuloMemberDGV.SelectionChanged += new System.EventHandler(this.tanuloMemberDGV_SelectionChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fájlToolStripMenuItem,
            this.tanulóToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fájlToolStripMenuItem
            // 
            this.fájlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mentésMáskéntToolStripMenuItem,
            this.mentésToolStripMenuItem,
            this.megnyitásToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.fájlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fájlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fájlToolStripMenuItem.Image")));
            this.fájlToolStripMenuItem.Name = "fájlToolStripMenuItem";
            this.fájlToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.fájlToolStripMenuItem.Text = "Fájl";
            // 
            // mentésMáskéntToolStripMenuItem
            // 
            this.mentésMáskéntToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mentésMáskéntToolStripMenuItem.Image")));
            this.mentésMáskéntToolStripMenuItem.Name = "mentésMáskéntToolStripMenuItem";
            this.mentésMáskéntToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésMáskéntToolStripMenuItem.Text = "Mentés másként";
            this.mentésMáskéntToolStripMenuItem.Click += new System.EventHandler(this.mentésMáskéntToolStripMenuItem_Click);
            // 
            // mentésToolStripMenuItem
            // 
            this.mentésToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mentésToolStripMenuItem.Image")));
            this.mentésToolStripMenuItem.Name = "mentésToolStripMenuItem";
            this.mentésToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.mentésToolStripMenuItem.Text = "Mentés";
            this.mentésToolStripMenuItem.Click += new System.EventHandler(this.mentésToolStripMenuItem_Click);
            // 
            // megnyitásToolStripMenuItem
            // 
            this.megnyitásToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("megnyitásToolStripMenuItem.Image")));
            this.megnyitásToolStripMenuItem.Name = "megnyitásToolStripMenuItem";
            this.megnyitásToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.megnyitásToolStripMenuItem.Text = "Megnyitás";
            this.megnyitásToolStripMenuItem.Click += new System.EventHandler(this.megnyitásToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.heart;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.creditsToolStripMenuItem.Text = "Verzió";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.creditsToolStripMenuItem_Click);
            // 
            // tanulóToolStripMenuItem
            // 
            this.tanulóToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újTanulóToolStripMenuItem,
            this.kijelöltTörláseToolStripMenuItem,
            this.szerkesztésToolStripMenuItem});
            this.tanulóToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tanulóToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tanulóToolStripMenuItem.Image")));
            this.tanulóToolStripMenuItem.Name = "tanulóToolStripMenuItem";
            this.tanulóToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tanulóToolStripMenuItem.Text = "Tanuló";
            // 
            // újTanulóToolStripMenuItem
            // 
            this.újTanulóToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("újTanulóToolStripMenuItem.Image")));
            this.újTanulóToolStripMenuItem.Name = "újTanulóToolStripMenuItem";
            this.újTanulóToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.újTanulóToolStripMenuItem.Text = "Új tanuló";
            this.újTanulóToolStripMenuItem.Click += new System.EventHandler(this.újTanulóToolStripMenuItem_Click);
            // 
            // kijelöltTörláseToolStripMenuItem
            // 
            this.kijelöltTörláseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kijelöltTörláseToolStripMenuItem.Image")));
            this.kijelöltTörláseToolStripMenuItem.Name = "kijelöltTörláseToolStripMenuItem";
            this.kijelöltTörláseToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.kijelöltTörláseToolStripMenuItem.Text = "Kijelölt törlése";
            this.kijelöltTörláseToolStripMenuItem.Click += new System.EventHandler(this.kijelöltTörláseToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("szerkesztésToolStripMenuItem.Image")));
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.szerkesztésToolStripMenuItem_Click);
            // 
            // konzol
            // 
            this.konzol.BackColor = System.Drawing.SystemColors.MenuText;
            this.konzol.ForeColor = System.Drawing.Color.White;
            this.konzol.Location = new System.Drawing.Point(40, 617);
            this.konzol.Name = "konzol";
            this.konzol.ReadOnly = true;
            this.konzol.Size = new System.Drawing.Size(936, 96);
            this.konzol.TabIndex = 5;
            this.konzol.Text = "----------------------";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1005, 731);
            this.Controls.Add(this.konzol);
            this.Controls.Add(this.tanuloMemberDGV);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "OKJ Tanulókezelő";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.tanuloMemberDGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tanuloMemberDGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fájlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésMáskéntToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mentésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem megnyitásToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanulóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újTanulóToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelöltTörláseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
        private System.Windows.Forms.RichTextBox konzol;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
    }
}

