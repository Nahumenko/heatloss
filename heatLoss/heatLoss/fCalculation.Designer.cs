namespace heatLoss
{
    partial class fCalculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCalculation));
            this.btnInitalData = new System.Windows.Forms.Button();
            this.btnFiveCalc = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInitalData
            // 
            this.btnInitalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInitalData.Location = new System.Drawing.Point(24, 26);
            this.btnInitalData.Name = "btnInitalData";
            this.btnInitalData.Size = new System.Drawing.Size(208, 61);
            this.btnInitalData.TabIndex = 0;
            this.btnInitalData.Text = "Ввод исходных данных";
            this.btnInitalData.UseVisualStyleBackColor = true;
            this.btnInitalData.Click += new System.EventHandler(this.btnInitalData_Click);
            // 
            // btnFiveCalc
            // 
            this.btnFiveCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiveCalc.Location = new System.Drawing.Point(24, 123);
            this.btnFiveCalc.Name = "btnFiveCalc";
            this.btnFiveCalc.Size = new System.Drawing.Size(208, 59);
            this.btnFiveCalc.TabIndex = 1;
            this.btnFiveCalc.Text = "Расчет потерь";
            this.btnFiveCalc.UseVisualStyleBackColor = true;
            this.btnFiveCalc.Click += new System.EventHandler(this.btnFiveCalc_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(24, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Отчет о результатах расчета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fCalculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(466, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFiveCalc);
            this.Controls.Add(this.btnInitalData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fCalculation";
            this.Text = "Расчет";
            this.Load += new System.EventHandler(this.fCalculation_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInitalData;
        private System.Windows.Forms.Button btnFiveCalc;
        private System.Windows.Forms.Button button1;
    }
}