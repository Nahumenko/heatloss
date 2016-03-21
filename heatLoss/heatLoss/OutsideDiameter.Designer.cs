namespace heatLoss
{
    partial class OutsideDiameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OutsideDiameter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keyOutsideDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOutsideDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outsideDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.outsideDiameterTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
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
            this.button1.Size = new System.Drawing.Size(160, 23);
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
            this.keyOutsideDiameterDataGridViewTextBoxColumn,
            this.nameOutsideDiameterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.outsideDiameterBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // keyOutsideDiameterDataGridViewTextBoxColumn
            // 
            this.keyOutsideDiameterDataGridViewTextBoxColumn.DataPropertyName = "keyOutsideDiameter";
            this.keyOutsideDiameterDataGridViewTextBoxColumn.HeaderText = "Код наружного диаметра";
            this.keyOutsideDiameterDataGridViewTextBoxColumn.Name = "keyOutsideDiameterDataGridViewTextBoxColumn";
            // 
            // nameOutsideDiameterDataGridViewTextBoxColumn
            // 
            this.nameOutsideDiameterDataGridViewTextBoxColumn.DataPropertyName = "nameOutsideDiameter";
            this.nameOutsideDiameterDataGridViewTextBoxColumn.HeaderText = "Наружный диаметр";
            this.nameOutsideDiameterDataGridViewTextBoxColumn.Name = "nameOutsideDiameterDataGridViewTextBoxColumn";
            // 
            // outsideDiameterBindingSource
            // 
            this.outsideDiameterBindingSource.DataMember = "outsideDiameter";
            this.outsideDiameterBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // _BD01_02_2016DataSet
            // 
            this._BD01_02_2016DataSet.DataSetName = "_BD01_02_2016DataSet";
            this._BD01_02_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // outsideDiameterTableAdapter
            // 
            this.outsideDiameterTableAdapter.ClearBeforeFill = true;
            // 
            // OutsideDiameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OutsideDiameter";
            this.Text = "Наружный диаметр";
            this.Load += new System.EventHandler(this.OutsideDiameter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource outsideDiameterBindingSource;
        private _BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter outsideDiameterTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyOutsideDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOutsideDiameterDataGridViewTextBoxColumn;
    }
}