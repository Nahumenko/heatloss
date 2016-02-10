namespace heatLoss
{
    partial class NominalDiameter
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.nominalDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominalDiameterTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.nominalDiameterTableAdapter();
            this.keyNominalDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominaldiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominalDiameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить изменение БД";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyNominalDiameterDataGridViewTextBoxColumn,
            this.nominaldiameterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nominalDiameterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // _BD01_02_2016DataSet
            // 
            this._BD01_02_2016DataSet.DataSetName = "_BD01_02_2016DataSet";
            this._BD01_02_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominalDiameterBindingSource
            // 
            this.nominalDiameterBindingSource.DataMember = "nominalDiameter";
            this.nominalDiameterBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // nominalDiameterTableAdapter
            // 
            this.nominalDiameterTableAdapter.ClearBeforeFill = true;
            // 
            // keyNominalDiameterDataGridViewTextBoxColumn
            // 
            this.keyNominalDiameterDataGridViewTextBoxColumn.DataPropertyName = "keyNominalDiameter";
            this.keyNominalDiameterDataGridViewTextBoxColumn.HeaderText = "Код условного диаметра";
            this.keyNominalDiameterDataGridViewTextBoxColumn.Name = "keyNominalDiameterDataGridViewTextBoxColumn";
            // 
            // nominaldiameterDataGridViewTextBoxColumn
            // 
            this.nominaldiameterDataGridViewTextBoxColumn.DataPropertyName = "nominaldiameter";
            this.nominaldiameterDataGridViewTextBoxColumn.HeaderText = "Условный диаметр";
            this.nominaldiameterDataGridViewTextBoxColumn.Name = "nominaldiameterDataGridViewTextBoxColumn";
            // 
            // NominalDiameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NominalDiameter";
            this.Text = "Условный диаметр";
            this.Load += new System.EventHandler(this.NominalDiameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominalDiameterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource nominalDiameterBindingSource;
        private _BD01_02_2016DataSetTableAdapters.nominalDiameterTableAdapter nominalDiameterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyNominalDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominaldiameterDataGridViewTextBoxColumn;
    }
}