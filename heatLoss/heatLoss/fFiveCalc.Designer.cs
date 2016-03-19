namespace heatLoss
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.methodOfLayingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.lblDiametr = new System.Windows.Forms.Label();
            this.lblDlina = new System.Windows.Forms.Label();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgv_heatloss = new System.Windows.Forms.DataGridView();
            this.codeDeltaTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.deltaTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.standardHeatLossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.outsideDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbYear = new System.Windows.Forms.CheckBox();
            this.cbNhwInYear = new System.Windows.Forms.CheckBox();
            this.standardHeatLossTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.standardHeatLossTableAdapter();
            this.deltaTTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.deltaTTableAdapter();
            this.outsideDiameterTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter();
            this.methodOfLayingTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.methodOfLayingTableAdapter();
            this.cbOutDiam = new System.Windows.Forms.ComboBox();
            this.outsideDiameterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbPipeNumber = new System.Windows.Forms.ComboBox();
            this.lblTemP = new System.Windows.Forms.Label();
            this.lblQ = new System.Windows.Forms.Label();
            this.cBoxDepth = new System.Windows.Forms.CheckBox();
            this.comBInsulationType = new System.Windows.Forms.ComboBox();
            this.insulationTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.insulationTypeTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.insulationTypeTableAdapter();
            this.insulationKt2TableAdapter1 = new heatLoss._BD01_02_2016DataSetTableAdapters.insulationKt2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.methodOfLayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_heatloss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardHeatLossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insulationTypeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DataSource = this.methodOfLayingBindingSource;
            this.cbType.DisplayMember = "methodOflayingSortPipeLine";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(779, 21);
            this.cbType.TabIndex = 0;
            this.cbType.ValueMember = "keyMethodOfLaying";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // methodOfLayingBindingSource
            // 
            this.methodOfLayingBindingSource.DataMember = "methodOfLaying";
            this.methodOfLayingBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // _BD01_02_2016DataSet
            // 
            this._BD01_02_2016DataSet.DataSetName = "_BD01_02_2016DataSet";
            this._BD01_02_2016DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblDiametr
            // 
            this.lblDiametr.AutoSize = true;
            this.lblDiametr.Location = new System.Drawing.Point(19, 29);
            this.lblDiametr.Name = "lblDiametr";
            this.lblDiametr.Size = new System.Drawing.Size(50, 13);
            this.lblDiametr.TabIndex = 1;
            this.lblDiametr.Text = "диаметр";
            // 
            // lblDlina
            // 
            this.lblDlina.AutoSize = true;
            this.lblDlina.Location = new System.Drawing.Point(125, 29);
            this.lblDlina.Name = "lblDlina";
            this.lblDlina.Size = new System.Drawing.Size(37, 13);
            this.lblDlina.TabIndex = 2;
            this.lblDlina.Text = "длина";
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(100, 49);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(78, 20);
            this.tbLength.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(812, 400);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "расчёт";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(22, 109);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(503, 266);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // dgv_heatloss
            // 
            this.dgv_heatloss.AllowUserToAddRows = false;
            this.dgv_heatloss.AllowUserToDeleteRows = false;
            this.dgv_heatloss.AutoGenerateColumns = false;
            this.dgv_heatloss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_heatloss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_heatloss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDeltaTDataGridViewTextBoxColumn,
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn});
            this.dgv_heatloss.DataSource = this.standardHeatLossBindingSource;
            this.dgv_heatloss.Location = new System.Drawing.Point(642, 109);
            this.dgv_heatloss.Name = "dgv_heatloss";
            this.dgv_heatloss.RowHeadersVisible = false;
            this.dgv_heatloss.Size = new System.Drawing.Size(245, 266);
            this.dgv_heatloss.TabIndex = 9;
            this.dgv_heatloss.Visible = false;
            // 
            // codeDeltaTDataGridViewTextBoxColumn
            // 
            this.codeDeltaTDataGridViewTextBoxColumn.DataPropertyName = "codeDeltaT";
            this.codeDeltaTDataGridViewTextBoxColumn.DataSource = this.deltaTBindingSource;
            this.codeDeltaTDataGridViewTextBoxColumn.DisplayMember = "valueDeltaT";
            this.codeDeltaTDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeDeltaTDataGridViewTextBoxColumn.HeaderText = "codeDeltaT";
            this.codeDeltaTDataGridViewTextBoxColumn.Name = "codeDeltaTDataGridViewTextBoxColumn";
            this.codeDeltaTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeDeltaTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeDeltaTDataGridViewTextBoxColumn.ValueMember = "keyDeltaT";
            // 
            // deltaTBindingSource
            // 
            this.deltaTBindingSource.DataMember = "deltaT";
            this.deltaTBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // valueOfHeatlossMVTDataGridViewTextBoxColumn
            // 
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.DataPropertyName = "ValueOfHeatlossMVT";
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.HeaderText = "ValueOfHeatlossMVT";
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.Name = "valueOfHeatlossMVTDataGridViewTextBoxColumn";
            // 
            // standardHeatLossBindingSource
            // 
            this.standardHeatLossBindingSource.DataMember = "standardHeatLoss";
            this.standardHeatLossBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // outsideDiameterBindingSource
            // 
            this.outsideDiameterBindingSource.DataMember = "outsideDiameter";
            this.outsideDiameterBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // cbYear
            // 
            this.cbYear.AutoSize = true;
            this.cbYear.Location = new System.Drawing.Point(202, 50);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(135, 17);
            this.cbYear.TabIndex = 10;
            this.cbYear.Text = "Год (yes если с 1994 )";
            this.cbYear.UseVisualStyleBackColor = true;
            // 
            // cbNhwInYear
            // 
            this.cbNhwInYear.AutoSize = true;
            this.cbNhwInYear.Location = new System.Drawing.Point(343, 49);
            this.cbNhwInYear.Name = "cbNhwInYear";
            this.cbNhwInYear.Size = new System.Drawing.Size(139, 17);
            this.cbNhwInYear.TabIndex = 11;
            this.cbNhwInYear.Text = "Часы (yes если <5000)";
            this.cbNhwInYear.UseVisualStyleBackColor = true;
            // 
            // standardHeatLossTableAdapter
            // 
            this.standardHeatLossTableAdapter.ClearBeforeFill = true;
            // 
            // deltaTTableAdapter
            // 
            this.deltaTTableAdapter.ClearBeforeFill = true;
            // 
            // outsideDiameterTableAdapter
            // 
            this.outsideDiameterTableAdapter.ClearBeforeFill = true;
            // 
            // methodOfLayingTableAdapter
            // 
            this.methodOfLayingTableAdapter.ClearBeforeFill = true;
            // 
            // cbOutDiam
            // 
            this.cbOutDiam.DataSource = this.outsideDiameterBindingSource1;
            this.cbOutDiam.DisplayMember = "nameOutsideDiameter";
            this.cbOutDiam.FormattingEnabled = true;
            this.cbOutDiam.Location = new System.Drawing.Point(12, 49);
            this.cbOutDiam.Name = "cbOutDiam";
            this.cbOutDiam.Size = new System.Drawing.Size(69, 21);
            this.cbOutDiam.TabIndex = 13;
            this.cbOutDiam.ValueMember = "keyOutsideDiameter";
            // 
            // outsideDiameterBindingSource1
            // 
            this.outsideDiameterBindingSource1.DataMember = "outsideDiameter";
            this.outsideDiameterBindingSource1.DataSource = this._BD01_02_2016DataSet;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(812, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(82, 17);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "FuckYouBill";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbPipeNumber
            // 
            this.cbPipeNumber.FormattingEnabled = true;
            this.cbPipeNumber.Items.AddRange(new object[] {
            "двухтрубная прокладка",
            "подающий отдельно",
            "обратный отдельно"});
            this.cbPipeNumber.Location = new System.Drawing.Point(498, 45);
            this.cbPipeNumber.Name = "cbPipeNumber";
            this.cbPipeNumber.Size = new System.Drawing.Size(121, 21);
            this.cbPipeNumber.TabIndex = 15;
            // 
            // lblTemP
            // 
            this.lblTemP.AutoSize = true;
            this.lblTemP.Location = new System.Drawing.Point(85, 378);
            this.lblTemP.Name = "lblTemP";
            this.lblTemP.Size = new System.Drawing.Size(35, 13);
            this.lblTemP.TabIndex = 16;
            this.lblTemP.Text = "label1";
            this.lblTemP.Visible = false;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(85, 400);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(35, 13);
            this.lblQ.TabIndex = 17;
            this.lblQ.Text = "label2";
            this.lblQ.Visible = false;
            // 
            // cBoxDepth
            // 
            this.cBoxDepth.AutoSize = true;
            this.cBoxDepth.Location = new System.Drawing.Point(642, 45);
            this.cBoxDepth.Name = "cBoxDepth";
            this.cBoxDepth.Size = new System.Drawing.Size(185, 17);
            this.cBoxDepth.TabIndex = 18;
            this.cBoxDepth.Text = "Заглубление ТП 0,7 м и менее ";
            this.cBoxDepth.UseVisualStyleBackColor = true;
            // 
            // comBInsulationType
            // 
            this.comBInsulationType.DataSource = this.insulationTypeBindingSource;
            this.comBInsulationType.DisplayMember = "insulation";
            this.comBInsulationType.FormattingEnabled = true;
            this.comBInsulationType.Location = new System.Drawing.Point(498, 72);
            this.comBInsulationType.Name = "comBInsulationType";
            this.comBInsulationType.Size = new System.Drawing.Size(121, 21);
            this.comBInsulationType.TabIndex = 19;
            this.comBInsulationType.ValueMember = "keyInsulationType";
            // 
            // insulationTypeBindingSource
            // 
            this.insulationTypeBindingSource.DataMember = "insulationType";
            this.insulationTypeBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // insulationTypeTableAdapter
            // 
            this.insulationTypeTableAdapter.ClearBeforeFill = true;
            // 
            // insulationKt2TableAdapter1
            // 
            this.insulationKt2TableAdapter1.ClearBeforeFill = true;
            // 
            // fFiveCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 434);
            this.Controls.Add(this.comBInsulationType);
            this.Controls.Add(this.cBoxDepth);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.lblTemP);
            this.Controls.Add(this.cbPipeNumber);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cbOutDiam);
            this.Controls.Add(this.cbNhwInYear);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.dgv_heatloss);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.tbLength);
            this.Controls.Add(this.lblDlina);
            this.Controls.Add(this.lblDiametr);
            this.Controls.Add(this.cbType);
            this.Name = "fFiveCalc";
            this.Text = "fFiveCalc";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fFiveCalc_FormClosing);
            this.Load += new System.EventHandler(this.fFiveCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.methodOfLayingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_heatloss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardHeatLossBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insulationTypeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblDiametr;
        private System.Windows.Forms.Label lblDlina;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dgv_heatloss;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource standardHeatLossBindingSource;
        private _BD01_02_2016DataSetTableAdapters.standardHeatLossTableAdapter standardHeatLossTableAdapter;
        private System.Windows.Forms.CheckBox cbYear;
        private System.Windows.Forms.CheckBox cbNhwInYear;
        private System.Windows.Forms.BindingSource deltaTBindingSource;
        private _BD01_02_2016DataSetTableAdapters.deltaTTableAdapter deltaTTableAdapter;
        private System.Windows.Forms.BindingSource outsideDiameterBindingSource;
        private _BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter outsideDiameterTableAdapter;
        private System.Windows.Forms.BindingSource methodOfLayingBindingSource;
        private _BD01_02_2016DataSetTableAdapters.methodOfLayingTableAdapter methodOfLayingTableAdapter;
        private System.Windows.Forms.ComboBox cbOutDiam;
        private System.Windows.Forms.BindingSource outsideDiameterBindingSource1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeDeltaTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOfHeatlossMVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbPipeNumber;
        private System.Windows.Forms.Label lblTemP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.CheckBox cBoxDepth;
        private System.Windows.Forms.ComboBox comBInsulationType;
        private System.Windows.Forms.BindingSource insulationTypeBindingSource;
        private _BD01_02_2016DataSetTableAdapters.insulationTypeTableAdapter insulationTypeTableAdapter;
        private _BD01_02_2016DataSetTableAdapters.insulationKt2TableAdapter insulationKt2TableAdapter1;
    }
}