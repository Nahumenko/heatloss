﻿namespace heatLoss
{
    partial class fFiveCalc
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
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblDiametr = new System.Windows.Forms.Label();
            this.lblDlina = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tbDiametr = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Надземная прокладка"});
            this.cbType.Location = new System.Drawing.Point(12, 49);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 21);
            this.cbType.TabIndex = 0;
            // 
            // lblDiametr
            // 
            this.lblDiametr.AutoSize = true;
            this.lblDiametr.Location = new System.Drawing.Point(166, 29);
            this.lblDiametr.Name = "lblDiametr";
            this.lblDiametr.Size = new System.Drawing.Size(50, 13);
            this.lblDiametr.TabIndex = 1;
            this.lblDiametr.Text = "диаметр";
            // 
            // lblDlina
            // 
            this.lblDlina.AutoSize = true;
            this.lblDlina.Location = new System.Drawing.Point(289, 29);
            this.lblDlina.Name = "lblDlina";
            this.lblDlina.Size = new System.Drawing.Size(37, 13);
            this.lblDlina.TabIndex = 2;
            this.lblDlina.Text = "длина";
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Items.AddRange(new object[] {
            "до 1994 г.",
            "после 1994 г."});
            this.cbYear.Location = new System.Drawing.Point(379, 49);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(121, 21);
            this.cbYear.TabIndex = 3;
            // 
            // tbDiametr
            // 
            this.tbDiametr.Location = new System.Drawing.Point(157, 50);
            this.tbDiametr.Name = "tbDiametr";
            this.tbDiametr.Size = new System.Drawing.Size(69, 20);
            this.tbDiametr.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(266, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(78, 20);
            this.textBox2.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(506, 227);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "расчёт";
            this.btnCalc.UseVisualStyleBackColor = true;
            // 
            // fFiveCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 262);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbDiametr);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblDlina);
            this.Controls.Add(this.lblDiametr);
            this.Controls.Add(this.cbType);
            this.Name = "fFiveCalc";
            this.Text = "fFiveCalc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblDiametr;
        private System.Windows.Forms.Label lblDlina;
        private System.Windows.Forms.ComboBox cbYear;
        private System.Windows.Forms.TextBox tbDiametr;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalc;
    }
}