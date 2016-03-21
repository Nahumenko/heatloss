namespace heatLoss
{
    partial class TempRegion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TempRegion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keyTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.codeSeasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.avarageTemperatureAirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avarageTemperatureGroundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.temperatureTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.temperatureTableAdapter();
            this.regionTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.regionTableAdapter();
            this.seasonTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.seasonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureBindingSource)).BeginInit();
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
            this.button1.Size = new System.Drawing.Size(199, 23);
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
            this.keyTemperatureDataGridViewTextBoxColumn,
            this.codeRegionDataGridViewTextBoxColumn,
            this.codeSeasonDataGridViewTextBoxColumn,
            this.avarageTemperatureAirDataGridViewTextBoxColumn,
            this.avarageTemperatureGroundDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.temperatureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 232);
            this.dataGridView1.TabIndex = 2;
            // 
            // keyTemperatureDataGridViewTextBoxColumn
            // 
            this.keyTemperatureDataGridViewTextBoxColumn.DataPropertyName = "keyTemperature";
            this.keyTemperatureDataGridViewTextBoxColumn.HeaderText = "Код";
            this.keyTemperatureDataGridViewTextBoxColumn.Name = "keyTemperatureDataGridViewTextBoxColumn";
            // 
            // codeRegionDataGridViewTextBoxColumn
            // 
            this.codeRegionDataGridViewTextBoxColumn.DataPropertyName = "codeRegion";
            this.codeRegionDataGridViewTextBoxColumn.DataSource = this.regionBindingSource;
            this.codeRegionDataGridViewTextBoxColumn.DisplayMember = "region";
            this.codeRegionDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeRegionDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.codeRegionDataGridViewTextBoxColumn.Name = "codeRegionDataGridViewTextBoxColumn";
            this.codeRegionDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeRegionDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeRegionDataGridViewTextBoxColumn.ValueMember = "keyRegion";
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // _BD01_02_2016DataSet
            // 
            this._BD01_02_2016DataSet.DataSetName = "_BD01_02_2016DataSet";
            this._BD01_02_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeSeasonDataGridViewTextBoxColumn
            // 
            this.codeSeasonDataGridViewTextBoxColumn.DataPropertyName = "codeSeason";
            this.codeSeasonDataGridViewTextBoxColumn.DataSource = this.seasonBindingSource;
            this.codeSeasonDataGridViewTextBoxColumn.DisplayMember = "seasonName";
            this.codeSeasonDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeSeasonDataGridViewTextBoxColumn.HeaderText = "Период";
            this.codeSeasonDataGridViewTextBoxColumn.Name = "codeSeasonDataGridViewTextBoxColumn";
            this.codeSeasonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeSeasonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeSeasonDataGridViewTextBoxColumn.ValueMember = "keySeason";
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataMember = "season";
            this.seasonBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // avarageTemperatureAirDataGridViewTextBoxColumn
            // 
            this.avarageTemperatureAirDataGridViewTextBoxColumn.DataPropertyName = "avarageTemperatureAir";
            this.avarageTemperatureAirDataGridViewTextBoxColumn.HeaderText = "Температура наружного воздуха";
            this.avarageTemperatureAirDataGridViewTextBoxColumn.Name = "avarageTemperatureAirDataGridViewTextBoxColumn";
            // 
            // avarageTemperatureGroundDataGridViewTextBoxColumn
            // 
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.DataPropertyName = "avarageTemperatureGround";
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.HeaderText = "Температура грунта";
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.Name = "avarageTemperatureGroundDataGridViewTextBoxColumn";
            // 
            // temperatureBindingSource
            // 
            this.temperatureBindingSource.DataMember = "temperature";
            this.temperatureBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // temperatureTableAdapter
            // 
            this.temperatureTableAdapter.ClearBeforeFill = true;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // seasonTableAdapter
            // 
            this.seasonTableAdapter.ClearBeforeFill = true;
            // 
            // TempRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TempRegion";
            this.Text = "Температуры";
            this.Load += new System.EventHandler(this.TempRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource temperatureBindingSource;
        private _BD01_02_2016DataSetTableAdapters.temperatureTableAdapter temperatureTableAdapter;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private _BD01_02_2016DataSetTableAdapters.regionTableAdapter regionTableAdapter;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private _BD01_02_2016DataSetTableAdapters.seasonTableAdapter seasonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureAirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureGroundDataGridViewTextBoxColumn;
    }
}