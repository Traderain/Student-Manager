namespace OKJ2._0
{
    partial class Befizet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Befizet));
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.befizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.újBefizetésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kijelöltTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.összesTörléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 777);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 42);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(863, 715);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(175, 777);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Mégsem";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(392, 777);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 46);
            this.button3.TabIndex = 3;
            this.button3.Text = "Összegzés";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(544, 791);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Egyenleg:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = global::OKJ2._0.Properties.Resources.index_0001_BG;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.befizetésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(921, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // befizetésToolStripMenuItem
            // 
            this.befizetésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.újBefizetésToolStripMenuItem,
            this.kijelöltTörléseToolStripMenuItem,
            this.összesTörléseToolStripMenuItem,
            this.szerkesztésToolStripMenuItem});
            this.befizetésToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.befizetésToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.vallet;
            this.befizetésToolStripMenuItem.Name = "befizetésToolStripMenuItem";
            this.befizetésToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.befizetésToolStripMenuItem.Text = "Befizetés";
            // 
            // újBefizetésToolStripMenuItem
            // 
            this.újBefizetésToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.bulb;
            this.újBefizetésToolStripMenuItem.Name = "újBefizetésToolStripMenuItem";
            this.újBefizetésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.újBefizetésToolStripMenuItem.Text = "Új befizetés";
            this.újBefizetésToolStripMenuItem.Click += new System.EventHandler(this.újBefizetésToolStripMenuItem_Click);
            // 
            // kijelöltTörléseToolStripMenuItem
            // 
            this.kijelöltTörléseToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.trash;
            this.kijelöltTörléseToolStripMenuItem.Name = "kijelöltTörléseToolStripMenuItem";
            this.kijelöltTörléseToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.kijelöltTörléseToolStripMenuItem.Text = "Kijelölt törlése";
            this.kijelöltTörléseToolStripMenuItem.Click += new System.EventHandler(this.kijelöltTörléseToolStripMenuItem_Click);
            // 
            // összesTörléseToolStripMenuItem
            // 
            this.összesTörléseToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.truck;
            this.összesTörléseToolStripMenuItem.Name = "összesTörléseToolStripMenuItem";
            this.összesTörléseToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.összesTörléseToolStripMenuItem.Text = "Összes törlése";
            this.összesTörléseToolStripMenuItem.Click += new System.EventHandler(this.összesTörléseToolStripMenuItem_Click);
            // 
            // szerkesztésToolStripMenuItem
            // 
            this.szerkesztésToolStripMenuItem.Image = global::OKJ2._0.Properties.Resources.pen;
            this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
            this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
            this.szerkesztésToolStripMenuItem.Click += new System.EventHandler(this.szerkesztésToolStripMenuItem_Click);
            // 
            // Befizet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::OKJ2._0.Properties.Resources.index_0001_BG;
            this.ClientSize = new System.Drawing.Size(921, 836);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Befizet";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Befizet";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem befizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem újBefizetésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kijelöltTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem összesTörléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
    }
}