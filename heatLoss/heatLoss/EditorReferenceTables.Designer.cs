﻿namespace heatLoss
{
    partial class EditorReferenceTables
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.температурыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.наружныйДиаментрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.условныйДиаметрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объемВодыВСистемеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.теплопотериToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.температурыToolStripMenuItem,
            this.наружныйДиаментрToolStripMenuItem,
            this.условныйДиаметрToolStripMenuItem,
            this.объемВодыВСистемеToolStripMenuItem,
            this.теплопотериToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // температурыToolStripMenuItem
            // 
            this.температурыToolStripMenuItem.Name = "температурыToolStripMenuItem";
            this.температурыToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.температурыToolStripMenuItem.Text = "Температуры";
            this.температурыToolStripMenuItem.Click += new System.EventHandler(this.температурыToolStripMenuItem_Click);
            // 
            // наружныйДиаментрToolStripMenuItem
            // 
            this.наружныйДиаментрToolStripMenuItem.Name = "наружныйДиаментрToolStripMenuItem";
            this.наружныйДиаментрToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.наружныйДиаментрToolStripMenuItem.Text = "Наружный диаметр";
            this.наружныйДиаментрToolStripMenuItem.Click += new System.EventHandler(this.наружныйДиаментрToolStripMenuItem_Click);
            // 
            // условныйДиаметрToolStripMenuItem
            // 
            this.условныйДиаметрToolStripMenuItem.Name = "условныйДиаметрToolStripMenuItem";
            this.условныйДиаметрToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.условныйДиаметрToolStripMenuItem.Text = "Условный диаметр";
            this.условныйДиаметрToolStripMenuItem.Click += new System.EventHandler(this.условныйДиаметрToolStripMenuItem_Click);
            // 
            // объемВодыВСистемеToolStripMenuItem
            // 
            this.объемВодыВСистемеToolStripMenuItem.Name = "объемВодыВСистемеToolStripMenuItem";
            this.объемВодыВСистемеToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.объемВодыВСистемеToolStripMenuItem.Text = "Объем воды в системе";
            this.объемВодыВСистемеToolStripMenuItem.Click += new System.EventHandler(this.объемВодыВСистемеToolStripMenuItem_Click);
            // 
            // теплопотериToolStripMenuItem
            // 
            this.теплопотериToolStripMenuItem.Name = "теплопотериToolStripMenuItem";
            this.теплопотериToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.теплопотериToolStripMenuItem.Text = "Теплопотери";
            this.теплопотериToolStripMenuItem.Click += new System.EventHandler(this.теплопотериToolStripMenuItem_Click);
            // 
            // EditorReferenceTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 334);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorReferenceTables";
            this.Text = "Редактирование справочных таблиц";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem температурыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem наружныйДиаментрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem условныйДиаметрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объемВодыВСистемеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem теплопотериToolStripMenuItem;
    }
}