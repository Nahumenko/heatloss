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
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.cbChangesTable = new System.Windows.Forms.CheckBox();
            this.dgvTemptable = new System.Windows.Forms.DataGridView();
            this.mouth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemptable)).BeginInit();
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
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(367, 76);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 4;
            this.cbFrom.Visible = false;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(563, 75);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 5;
            this.cbTo.Visible = false;
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
            this.dgvTemptable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemptable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mouth});
            this.dgvTemptable.Location = new System.Drawing.Point(15, 162);
            this.dgvTemptable.Name = "dgvTemptable";
            this.dgvTemptable.RowHeadersVisible = false;
            this.dgvTemptable.Size = new System.Drawing.Size(669, 300);
            this.dgvTemptable.TabIndex = 9;
            // 
            // mouth
            // 
            this.mouth.HeaderText = "Месяц";
            this.mouth.Name = "mouth";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(539, 569);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(620, 569);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fInitalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 604);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemptable)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn mouth;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}