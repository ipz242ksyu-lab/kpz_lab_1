using System;

namespace WindowsForms
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шифруватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дешифруватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem архівуватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem розархівуватиToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шифруватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дешифруватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.архівуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.розархівуватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.MistyRose;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 30);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(641, 395);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Назва файлу";
            this.columnHeader2.Width = 565;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(641, 30);
            this.menuStrip.TabIndex = 1;
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.шифруватиToolStripMenuItem,
            this.дешифруватиToolStripMenuItem,
            this.архівуватиToolStripMenuItem,
            this.розархівуватиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 26);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.OpenFileToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // шифруватиToolStripMenuItem
            // 
            this.шифруватиToolStripMenuItem.Name = "шифруватиToolStripMenuItem";
            this.шифруватиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.шифруватиToolStripMenuItem.Text = "Шифрувати";
            this.шифруватиToolStripMenuItem.Click += new System.EventHandler(this.EncodingToolStripMenuItem_Click);
            // 
            // дешифруватиToolStripMenuItem
            // 
            this.дешифруватиToolStripMenuItem.Name = "дешифруватиToolStripMenuItem";
            this.дешифруватиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.дешифруватиToolStripMenuItem.Text = "Дешифрувати";
            this.дешифруватиToolStripMenuItem.Click += new System.EventHandler(this.DecodingToolStripMenuItem_Click);
            // 
            // архівуватиToolStripMenuItem
            // 
            this.архівуватиToolStripMenuItem.Name = "архівуватиToolStripMenuItem";
            this.архівуватиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.архівуватиToolStripMenuItem.Text = "Архівувати";
            this.архівуватиToolStripMenuItem.Click += new System.EventHandler(this.ZippingToolStripMenuItem_Click);
            // 
            // розархівуватиToolStripMenuItem
            // 
            this.розархівуватиToolStripMenuItem.Name = "розархівуватиToolStripMenuItem";
            this.розархівуватиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.розархівуватиToolStripMenuItem.Text = "Розархівувати";
            this.розархівуватиToolStripMenuItem.Click += new System.EventHandler(this.ZippingToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MistyRose;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(350, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Криворука Софія ІПЗ-24-2(2)";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 82;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(641, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Файловий провідник";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

