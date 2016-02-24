namespace heatLoss
{
    partial class fInitalData
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
            this.lblCitySelect = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.regionTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.regionTableAdapter();
            this.cbBetweenHeating = new System.Windows.Forms.CheckBox();
            this.cbchoseMouth = new System.Windows.Forms.CheckBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.seasonBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regiontemperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.seasonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regiontemperatureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbChangesTable = new System.Windows.Forms.CheckBox();
            this.dgvTemptable = new System.Windows.Forms.DataGridView();
            this.mouth = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TempVozd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempGrunt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempWather = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2f = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyTemperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeSeasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avarageTemperatureAirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avarageTemperatureGroundDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.temperatureTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.temperatureTableAdapter();
            this.seasonTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.seasonTableAdapter();
            this.seasontemperatureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seasontemperatureBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiontemperatureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiontemperatureBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemptable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasontemperatureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasontemperatureBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCitySelect
            // 
            this.lblCitySelect.AutoSize = true;
            this.lblCitySelect.Location = new System.Drawing.Point(12, 23);
            this.lblCitySelect.Name = "lblCitySelect";
            this.lblCitySelect.Size = new System.Drawing.Size(101, 13);
            this.lblCitySelect.TabIndex = 0;
            this.lblCitySelect.Text = "Выберите область";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.regionBindingSource;
            this.comboBox1.DisplayMember = "region";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "keyRegion";
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
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // cbBetweenHeating
            // 
            this.cbBetweenHeating.AutoSize = true;
            this.cbBetweenHeating.Location = new System.Drawing.Point(15, 54);
            this.cbBetweenHeating.Name = "cbBetweenHeating";
            this.cbBetweenHeating.Size = new System.Drawing.Size(220, 17);
            this.cbBetweenHeating.TabIndex = 2;
            this.cbBetweenHeating.Text = "Учитывать меж отопительный сезон?";
            this.cbBetweenHeating.UseVisualStyleBackColor = true;
            // 
            // cbchoseMouth
            // 
            this.cbchoseMouth.AutoSize = true;
            this.cbchoseMouth.Location = new System.Drawing.Point(15, 78);
            this.cbchoseMouth.Name = "cbchoseMouth";
            this.cbchoseMouth.Size = new System.Drawing.Size(276, 17);
            this.cbchoseMouth.TabIndex = 3;
            this.cbchoseMouth.Text = "Произвести расчёт для определенного периода?";
            this.cbchoseMouth.UseVisualStyleBackColor = true;
            this.cbchoseMouth.CheckedChanged += new System.EventHandler(this.cbchoseMouth_CheckedChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.DataSource = this.seasonBindingSource1;
            this.cbFrom.DisplayMember = "seasonName";
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(367, 76);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 4;
            this.cbFrom.ValueMember = "keySeason";
            this.cbFrom.Visible = false;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // seasonBindingSource1
            // 
            this.seasonBindingSource1.DataMember = "season";
            this.seasonBindingSource1.DataSource = this._BD01_02_2016DataSet;
            // 
            // regiontemperatureBindingSource
            // 
            this.regiontemperatureBindingSource.DataMember = "regiontemperature";
            this.regiontemperatureBindingSource.DataSource = this.regionBindingSource;
            // 
            // cbTo
            // 
            this.cbTo.DataSource = this.seasonBindingSource;
            this.cbTo.DisplayMember = "seasonName";
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(563, 75);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 5;
            this.cbTo.ValueMember = "keySeason";
            this.cbTo.Visible = false;
            this.cbTo.SelectedIndexChanged += new System.EventHandler(this.cbTo_SelectedIndexChanged);
            // 
            // seasonBindingSource
            // 
            this.seasonBindingSource.DataMember = "season";
            this.seasonBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // regiontemperatureBindingSource1
            // 
            this.regiontemperatureBindingSource1.DataMember = "regiontemperature";
            this.regiontemperatureBindingSource1.DataSource = this.regionBindingSource;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(329, 78);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(13, 13);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "c";
            this.lblFrom.Visible = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(509, 79);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(19, 13);
            this.lblTo.TabIndex = 7;
            this.lblTo.Text = "по";
            this.lblTo.Visible = false;
            // 
            // cbChangesTable
            // 
            this.cbChangesTable.AutoSize = true;
            this.cbChangesTable.Location = new System.Drawing.Point(15, 102);
            this.cbChangesTable.Name = "cbChangesTable";
            this.cbChangesTable.Size = new System.Drawing.Size(193, 17);
            this.cbChangesTable.TabIndex = 8;
            this.cbChangesTable.Text = "Разрешить изменения таблицы?";
            this.cbChangesTable.UseVisualStyleBackColor = true;
            // 
            // dgvTemptable
            // 
            this.dgvTemptable.AutoGenerateColumns = false;
            this.dgvTemptable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemptable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mouth,
            this.TempVozd,
            this.tempGrunt,
            this.tempWather,
            this.t1p,
            this.t1f,
            this.t2p,
            this.t2f,
            this.keyTemperatureDataGridViewTextBoxColumn,
            this.codeRegionDataGridViewTextBoxColumn,
            this.codeSeasonDataGridViewTextBoxColumn,
            this.avarageTemperatureAirDataGridViewTextBoxColumn,
            this.avarageTemperatureGroundDataGridViewTextBoxColumn});
            this.dgvTemptable.DataSource = this.regiontemperatureBindingSource;
            this.dgvTemptable.Location = new System.Drawing.Point(12, 138);
            this.dgvTemptable.Name = "dgvTemptable";
            this.dgvTemptable.RowHeadersVisible = false;
            this.dgvTemptable.Size = new System.Drawing.Size(800, 367);
            this.dgvTemptable.TabIndex = 9;
            // 
            // mouth
            // 
            this.mouth.DataPropertyName = "codeSeason";
            this.mouth.DataSource = this.seasonBindingSource;
            this.mouth.DisplayMember = "seasonName";
            this.mouth.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.mouth.HeaderText = "Месяц";
            this.mouth.Name = "mouth";
            this.mouth.ReadOnly = true;
            this.mouth.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mouth.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.mouth.ToolTipText = "месяц";
            this.mouth.ValueMember = "keySeason";
            // 
            // TempVozd
            // 
            this.TempVozd.DataPropertyName = "avarageTemperatureAir";
            this.TempVozd.HeaderText = "Тв ср.м";
            this.TempVozd.Name = "TempVozd";
            // 
            // tempGrunt
            // 
            this.tempGrunt.DataPropertyName = "avarageTemperatureGround";
            this.tempGrunt.HeaderText = "Тг ср. м";
            this.tempGrunt.Name = "tempGrunt";
            // 
            // tempWather
            // 
            this.tempWather.HeaderText = "Ти ср.м";
            this.tempWather.Name = "tempWather";
            // 
            // t1p
            // 
            this.t1p.HeaderText = "П подача";
            this.t1p.Name = "t1p";
            // 
            // t1f
            // 
            this.t1f.HeaderText = "Ф подача";
            this.t1f.Name = "t1f";
            // 
            // t2p
            // 
            this.t2p.HeaderText = "П обратка";
            this.t2p.Name = "t2p";
            // 
            // t2f
            // 
            this.t2f.HeaderText = "Ф обратка";
            this.t2f.Name = "t2f";
            // 
            // keyTemperatureDataGridViewTextBoxColumn
            // 
            this.keyTemperatureDataGridViewTextBoxColumn.DataPropertyName = "keyTemperature";
            this.keyTemperatureDataGridViewTextBoxColumn.HeaderText = "keyTemperature";
            this.keyTemperatureDataGridViewTextBoxColumn.Name = "keyTemperatureDataGridViewTextBoxColumn";
            // 
            // codeRegionDataGridViewTextBoxColumn
            // 
            this.codeRegionDataGridViewTextBoxColumn.DataPropertyName = "codeRegion";
            this.codeRegionDataGridViewTextBoxColumn.HeaderText = "codeRegion";
            this.codeRegionDataGridViewTextBoxColumn.Name = "codeRegionDataGridViewTextBoxColumn";
            // 
            // codeSeasonDataGridViewTextBoxColumn
            // 
            this.codeSeasonDataGridViewTextBoxColumn.DataPropertyName = "codeSeason";
            this.codeSeasonDataGridViewTextBoxColumn.HeaderText = "codeSeason";
            this.codeSeasonDataGridViewTextBoxColumn.Name = "codeSeasonDataGridViewTextBoxColumn";
            // 
            // avarageTemperatureAirDataGridViewTextBoxColumn
            // 
            this.avarageTemperatureAirDataGridViewTextBoxColumn.DataPropertyName = "avarageTemperatureAir";
            this.avarageTemperatureAirDataGridViewTextBoxColumn.HeaderText = "avarageTemperatureAir";
            this.avarageTemperatureAirDataGridViewTextBoxColumn.Name = "avarageTemperatureAirDataGridViewTextBoxColumn";
            // 
            // avarageTemperatureGroundDataGridViewTextBoxColumn
            // 
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.DataPropertyName = "avarageTemperatureGround";
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.HeaderText = "avarageTemperatureGround";
            this.avarageTemperatureGroundDataGridViewTextBoxColumn.Name = "avarageTemperatureGroundDataGridViewTextBoxColumn";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(671, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(752, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // temperatureTableAdapter
            // 
            this.temperatureTableAdapter.ClearBeforeFill = true;
            // 
            // seasonTableAdapter
            // 
            this.seasonTableAdapter.ClearBeforeFill = true;
            // 
            // seasontemperatureBindingSource
            // 
            this.seasontemperatureBindingSource.DataMember = "seasontemperature";
            this.seasontemperatureBindingSource.DataSource = this.seasonBindingSource;
            // 
            // seasontemperatureBindingSource1
            // 
            this.seasontemperatureBindingSource1.DataMember = "seasontemperature";
            this.seasontemperatureBindingSource1.DataSource = this.seasonBindingSource;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fInitalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvTemptable);
            this.Controls.Add(this.cbChangesTable);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.cbchoseMouth);
            this.Controls.Add(this.cbBetweenHeating);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCitySelect);
            this.Name = "fInitalData";
            this.Text = "fInitalData";
            this.Load += new System.EventHandler(this.fInitalData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiontemperatureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regiontemperatureBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemptable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasontemperatureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seasontemperatureBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCitySelect;
        private System.Windows.Forms.ComboBox comboBox1;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private _BD01_02_2016DataSetTableAdapters.regionTableAdapter regionTableAdapter;
        private System.Windows.Forms.CheckBox cbBetweenHeating;
        private System.Windows.Forms.CheckBox cbchoseMouth;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.CheckBox cbChangesTable;
        private System.Windows.Forms.DataGridView dgvTemptable;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.BindingSource regiontemperatureBindingSource;
        private _BD01_02_2016DataSetTableAdapters.temperatureTableAdapter temperatureTableAdapter;
        private System.Windows.Forms.BindingSource regiontemperatureBindingSource1;
        private System.Windows.Forms.BindingSource seasonBindingSource;
        private _BD01_02_2016DataSetTableAdapters.seasonTableAdapter seasonTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn mouth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempVozd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempGrunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempWather;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1p;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1f;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2p;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2f;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureAirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureGroundDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource seasonBindingSource1;
        private System.Windows.Forms.BindingSource seasontemperatureBindingSource;
        private System.Windows.Forms.BindingSource seasontemperatureBindingSource1;
        private System.Windows.Forms.Button button1;
    }
}