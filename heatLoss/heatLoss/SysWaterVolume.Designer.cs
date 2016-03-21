namespace heatLoss
{
    partial class SysWaterVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SysWaterVolume));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.keySysWaterVolumeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demesnialWaterVolumem3MvtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOverfallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sysTemperatureDifferenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.codeEquipmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.heatEquipmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysWaterVolumeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sysWaterVolumeTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.sysWaterVolumeTableAdapter();
            this.sysTemperatureDifferenceTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.sysTemperatureDifferenceTableAdapter();
            this.heatEquipmentTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.heatEquipmentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysTemperatureDifferenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatEquipmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysWaterVolumeBindingSource)).BeginInit();
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
            this.button1.Size = new System.Drawing.Size(204, 23);
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
            this.keySysWaterVolumeDataGridViewTextBoxColumn,
            this.demesnialWaterVolumem3MvtDataGridViewTextBoxColumn,
            this.demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn,
            this.codeOverfallDataGridViewTextBoxColumn,
            this.codeEquipmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sysWaterVolumeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(284, 234);
            this.dataGridView1.TabIndex = 2;
            // 
            // keySysWaterVolumeDataGridViewTextBoxColumn
            // 
            this.keySysWaterVolumeDataGridViewTextBoxColumn.DataPropertyName = "keySysWaterVolume";
            this.keySysWaterVolumeDataGridViewTextBoxColumn.HeaderText = "Код";
            this.keySysWaterVolumeDataGridViewTextBoxColumn.Name = "keySysWaterVolumeDataGridViewTextBoxColumn";
            // 
            // demesnialWaterVolumem3MvtDataGridViewTextBoxColumn
            // 
            this.demesnialWaterVolumem3MvtDataGridViewTextBoxColumn.DataPropertyName = "demesnialWaterVolume_m3/Mvt";
            this.demesnialWaterVolumem3MvtDataGridViewTextBoxColumn.HeaderText = "м3/МВт";
            this.demesnialWaterVolumem3MvtDataGridViewTextBoxColumn.Name = "demesnialWaterVolumem3MvtDataGridViewTextBoxColumn";
            // 
            // demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn
            // 
            this.demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn.DataPropertyName = "demesnialWaterVolume_m3h/Gkal";
            this.demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn.HeaderText = "м3*ч/Гкал";
            this.demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn.Name = "demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn";
            // 
            // codeOverfallDataGridViewTextBoxColumn
            // 
            this.codeOverfallDataGridViewTextBoxColumn.DataPropertyName = "codeOverfall";
            this.codeOverfallDataGridViewTextBoxColumn.DataSource = this.sysTemperatureDifferenceBindingSource;
            this.codeOverfallDataGridViewTextBoxColumn.DisplayMember = "temperatureDifference";
            this.codeOverfallDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeOverfallDataGridViewTextBoxColumn.HeaderText = "Перепад температур";
            this.codeOverfallDataGridViewTextBoxColumn.Name = "codeOverfallDataGridViewTextBoxColumn";
            this.codeOverfallDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeOverfallDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeOverfallDataGridViewTextBoxColumn.ValueMember = "keySysTemperatureDifference";
            // 
            // sysTemperatureDifferenceBindingSource
            // 
            this.sysTemperatureDifferenceBindingSource.DataMember = "sysTemperatureDifference";
            this.sysTemperatureDifferenceBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // _BD01_02_2016DataSet
            // 
            this._BD01_02_2016DataSet.DataSetName = "_BD01_02_2016DataSet";
            this._BD01_02_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // codeEquipmentDataGridViewTextBoxColumn
            // 
            this.codeEquipmentDataGridViewTextBoxColumn.DataPropertyName = "codeEquipment";
            this.codeEquipmentDataGridViewTextBoxColumn.DataSource = this.heatEquipmentBindingSource;
            this.codeEquipmentDataGridViewTextBoxColumn.DisplayMember = "equipment";
            this.codeEquipmentDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeEquipmentDataGridViewTextBoxColumn.HeaderText = "Оборудование";
            this.codeEquipmentDataGridViewTextBoxColumn.Name = "codeEquipmentDataGridViewTextBoxColumn";
            this.codeEquipmentDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeEquipmentDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeEquipmentDataGridViewTextBoxColumn.ValueMember = "keyHeatEquipment";
            // 
            // heatEquipmentBindingSource
            // 
            this.heatEquipmentBindingSource.DataMember = "heatEquipment";
            this.heatEquipmentBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // sysWaterVolumeBindingSource
            // 
            this.sysWaterVolumeBindingSource.DataMember = "sysWaterVolume";
            this.sysWaterVolumeBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // sysWaterVolumeTableAdapter
            // 
            this.sysWaterVolumeTableAdapter.ClearBeforeFill = true;
            // 
            // sysTemperatureDifferenceTableAdapter
            // 
            this.sysTemperatureDifferenceTableAdapter.ClearBeforeFill = true;
            // 
            // heatEquipmentTableAdapter
            // 
            this.heatEquipmentTableAdapter.ClearBeforeFill = true;
            // 
            // SysWaterVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SysWaterVolume";
            this.Text = "Объем воды в системе";
            this.Load += new System.EventHandler(this.SysWaterVolume_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysTemperatureDifferenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heatEquipmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sysWaterVolumeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource sysWaterVolumeBindingSource;
        private _BD01_02_2016DataSetTableAdapters.sysWaterVolumeTableAdapter sysWaterVolumeTableAdapter;
        private System.Windows.Forms.BindingSource sysTemperatureDifferenceBindingSource;
        private _BD01_02_2016DataSetTableAdapters.sysTemperatureDifferenceTableAdapter sysTemperatureDifferenceTableAdapter;
        private System.Windows.Forms.BindingSource heatEquipmentBindingSource;
        private _BD01_02_2016DataSetTableAdapters.heatEquipmentTableAdapter heatEquipmentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keySysWaterVolumeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demesnialWaterVolumem3MvtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demesnialWaterVolumem3hGkalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeOverfallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeEquipmentDataGridViewTextBoxColumn;
    }
}