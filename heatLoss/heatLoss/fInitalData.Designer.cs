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
            this.regionName = new System.Windows.Forms.ComboBox();
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
            this.cbSystemOpen = new System.Windows.Forms.CheckBox();
            this.cbCirculation = new System.Windows.Forms.CheckBox();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnMass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMassReturn = new System.Windows.Forms.Button();
            this.Data_temps = new System.Windows.Forms.Button();
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
            // regionName
            // 
            this.regionName.DataSource = this.regionBindingSource;
            this.regionName.DisplayMember = "region";
            this.regionName.FormattingEnabled = true;
            this.regionName.Location = new System.Drawing.Point(142, 20);
            this.regionName.Name = "regionName";
            this.regionName.Size = new System.Drawing.Size(121, 21);
            this.regionName.TabIndex = 1;
            this.regionName.ValueMember = "keyRegion";
            this.regionName.SelectedIndexChanged += new System.EventHandler(this.season_SelectedIndexChanged);
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
            this.cbBetweenHeating.CheckedChanged += new System.EventHandler(this.cbBetweenHeating_CheckedChanged);
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
            this.dgvTemptable.AllowUserToAddRows = false;
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
            // cbSystemOpen
            // 
            this.cbSystemOpen.AutoSize = true;
            this.cbSystemOpen.Location = new System.Drawing.Point(332, 54);
            this.cbSystemOpen.Name = "cbSystemOpen";
            this.cbSystemOpen.Size = new System.Drawing.Size(130, 17);
            this.cbSystemOpen.TabIndex = 12;
            this.cbSystemOpen.Text = "Система открытая ?";
            this.cbSystemOpen.UseVisualStyleBackColor = true;
            this.cbSystemOpen.Visible = false;
            this.cbSystemOpen.CheckedChanged += new System.EventHandler(this.cbSystemOpen_CheckedChanged);
            // 
            // cbCirculation
            // 
            this.cbCirculation.AutoSize = true;
            this.cbCirculation.Location = new System.Drawing.Point(512, 54);
            this.cbCirculation.Name = "cbCirculation";
            this.cbCirculation.Size = new System.Drawing.Size(144, 17);
            this.cbCirculation.TabIndex = 13;
            this.cbCirculation.Text = "работа с циркуляцией?";
            this.cbCirculation.UseVisualStyleBackColor = true;
            this.cbCirculation.Visible = false;
            this.cbCirculation.CheckedChanged += new System.EventHandler(this.cbCirculation_CheckedChanged);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(737, 75);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 14;
            this.btnRandom.Text = "Рандом";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMass
            // 
            this.btnMass.Location = new System.Drawing.Point(737, 12);
            this.btnMass.Name = "btnMass";
            this.btnMass.Size = new System.Drawing.Size(75, 23);
            this.btnMass.TabIndex = 15;
            this.btnMass.Text = "В Массив";
            this.btnMass.UseVisualStyleBackColor = true;
            this.btnMass.Click += new System.EventHandler(this.btnMass_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(452, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // btnMassReturn
            // 
            this.btnMassReturn.Location = new System.Drawing.Point(546, 13);
            this.btnMassReturn.Name = "btnMassReturn";
            this.btnMassReturn.Size = new System.Drawing.Size(75, 23);
            this.btnMassReturn.TabIndex = 17;
            this.btnMassReturn.Text = "верни массив";
            this.btnMassReturn.UseVisualStyleBackColor = true;
            this.btnMassReturn.Click += new System.EventHandler(this.btnMassReturn_Click);
            // 
            // Data_temps
            // 
            this.Data_temps.Location = new System.Drawing.Point(737, 105);
            this.Data_temps.Name = "Data_temps";
            this.Data_temps.Size = new System.Drawing.Size(75, 23);
            this.Data_temps.TabIndex = 18;
            this.Data_temps.Text = "Data";
            this.Data_temps.UseVisualStyleBackColor = true;
            this.Data_temps.Click += new System.EventHandler(this.Data_temps_Click);
            // 
            // fInitalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 612);
            this.Controls.Add(this.Data_temps);
            this.Controls.Add(this.btnMassReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMass);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.cbCirculation);
            this.Controls.Add(this.cbSystemOpen);
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
            this.Controls.Add(this.regionName);
            this.Controls.Add(this.lblCitySelect);
            this.Name = "fInitalData";
            this.Text = "Ввод исходных данных";
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
        private System.Windows.Forms.ComboBox regionName;
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
        private System.Windows.Forms.BindingSource seasonBindingSource1;
        private System.Windows.Forms.BindingSource seasontemperatureBindingSource;
        private System.Windows.Forms.BindingSource seasontemperatureBindingSource1;
        private System.Windows.Forms.CheckBox cbSystemOpen;
        private System.Windows.Forms.CheckBox cbCirculation;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnMass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewComboBoxColumn mouth;
        private System.Windows.Forms.DataGridViewTextBoxColumn TempVozd;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempGrunt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempWather;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1p;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1f;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2p;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2f;
        private System.Windows.Forms.Button btnMassReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTemperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeSeasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureAirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avarageTemperatureGroundDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Data_temps;
    }
}