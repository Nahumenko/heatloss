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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.methodOfLayingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._BD01_02_2016DataSet = new heatLoss._BD01_02_2016DataSet();
            this.lblDiametr = new System.Windows.Forms.Label();
            this.lblDlina = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tbDiametr = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbNhwInYear = new System.Windows.Forms.ComboBox();
            this.dgv_heatloss = new System.Windows.Forms.DataGridView();
            this.outsideDiameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deltaTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.standardHeatLossBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.standardHeatLossTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.standardHeatLossTableAdapter();
            this.deltaTTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.deltaTTableAdapter();
            this.outsideDiameterTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter();
            this.methodOfLayingTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.methodOfLayingTableAdapter();
            this.cboutD = new System.Windows.Forms.ComboBox();
            this.outsideDiameterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.codePipelineSortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeOutsideDiameterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.keyStandardHeatLossDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDeltaTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueOfHeatlossKALDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startupDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nhwINyearDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.superPositionDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.codeHeatDissipationSortDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeMethodOfLayingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assessedValueDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.extrapolationDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.kt1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kt2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kt3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeInsulationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.methodOfLayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_heatloss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardHeatLossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DataSource = this.methodOfLayingBindingSource;
            this.cbType.DisplayMember = "methodOflayingSortPipeLine";
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 82);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(349, 21);
            this.cbType.TabIndex = 0;
            this.cbType.ValueMember = "keyMethodOfLaying";
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
            this.lblDiametr.Location = new System.Drawing.Point(165, 8);
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
            this.tbDiametr.Location = new System.Drawing.Point(156, 29);
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
            this.btnCalc.Location = new System.Drawing.Point(812, 364);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "расчёт";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(71, 121);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(503, 266);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // cbNhwInYear
            // 
            this.cbNhwInYear.FormattingEnabled = true;
            this.cbNhwInYear.Items.AddRange(new object[] {
            ">5000",
            "<5000"});
            this.cbNhwInYear.Location = new System.Drawing.Point(537, 49);
            this.cbNhwInYear.Name = "cbNhwInYear";
            this.cbNhwInYear.Size = new System.Drawing.Size(121, 21);
            this.cbNhwInYear.TabIndex = 8;
            // 
            // dgv_heatloss
            // 
            this.dgv_heatloss.AllowUserToAddRows = false;
            this.dgv_heatloss.AutoGenerateColumns = false;
            this.dgv_heatloss.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_heatloss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_heatloss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codePipelineSortDataGridViewTextBoxColumn,
            this.codeOutsideDiameterDataGridViewTextBoxColumn,
            this.keyStandardHeatLossDataGridViewTextBoxColumn,
            this.codeDeltaTDataGridViewTextBoxColumn,
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn,
            this.valueOfHeatlossKALDataGridViewTextBoxColumn,
            this.startupDataGridViewCheckBoxColumn,
            this.nhwINyearDataGridViewCheckBoxColumn,
            this.superPositionDataGridViewCheckBoxColumn,
            this.codeHeatDissipationSortDataGridViewTextBoxColumn,
            this.codeMethodOfLayingDataGridViewTextBoxColumn,
            this.assessedValueDataGridViewCheckBoxColumn,
            this.extrapolationDataGridViewCheckBoxColumn,
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn,
            this.kt1DataGridViewTextBoxColumn,
            this.kt2DataGridViewTextBoxColumn,
            this.kt3DataGridViewTextBoxColumn,
            this.codeInsulationTypeDataGridViewTextBoxColumn});
            this.dgv_heatloss.DataSource = this.standardHeatLossBindingSource;
            this.dgv_heatloss.Location = new System.Drawing.Point(12, 109);
            this.dgv_heatloss.Name = "dgv_heatloss";
            this.dgv_heatloss.RowHeadersVisible = false;
            this.dgv_heatloss.Size = new System.Drawing.Size(838, 202);
            this.dgv_heatloss.TabIndex = 9;
            this.dgv_heatloss.Visible = false;
            // 
            // outsideDiameterBindingSource
            // 
            this.outsideDiameterBindingSource.DataMember = "outsideDiameter";
            this.outsideDiameterBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // deltaTBindingSource
            // 
            this.deltaTBindingSource.DataMember = "deltaT";
            this.deltaTBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // standardHeatLossBindingSource
            // 
            this.standardHeatLossBindingSource.DataMember = "standardHeatLoss";
            this.standardHeatLossBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(379, 77);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(135, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Год (yes если с 1994 )";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(537, 77);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(139, 17);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Часы (yes если <5000)";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // cboutD
            // 
            this.cboutD.DataSource = this.outsideDiameterBindingSource1;
            this.cboutD.DisplayMember = "nameOutsideDiameter";
            this.cboutD.FormattingEnabled = true;
            this.cboutD.Location = new System.Drawing.Point(156, 55);
            this.cboutD.Name = "cboutD";
            this.cboutD.Size = new System.Drawing.Size(69, 21);
            this.cboutD.TabIndex = 13;
            this.cboutD.ValueMember = "keyOutsideDiameter";
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
            // codePipelineSortDataGridViewTextBoxColumn
            // 
            this.codePipelineSortDataGridViewTextBoxColumn.DataPropertyName = "CodePipelineSort";
            this.codePipelineSortDataGridViewTextBoxColumn.HeaderText = "CodePipelineSort";
            this.codePipelineSortDataGridViewTextBoxColumn.Name = "codePipelineSortDataGridViewTextBoxColumn";
            this.codePipelineSortDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeOutsideDiameterDataGridViewTextBoxColumn
            // 
            this.codeOutsideDiameterDataGridViewTextBoxColumn.DataPropertyName = "CodeOutsideDiameter";
            this.codeOutsideDiameterDataGridViewTextBoxColumn.DataSource = this.outsideDiameterBindingSource;
            this.codeOutsideDiameterDataGridViewTextBoxColumn.DisplayMember = "nameOutsideDiameter";
            this.codeOutsideDiameterDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeOutsideDiameterDataGridViewTextBoxColumn.HeaderText = "CodeOutsideDiameter";
            this.codeOutsideDiameterDataGridViewTextBoxColumn.Name = "codeOutsideDiameterDataGridViewTextBoxColumn";
            this.codeOutsideDiameterDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codeOutsideDiameterDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codeOutsideDiameterDataGridViewTextBoxColumn.ValueMember = "keyOutsideDiameter";
            this.codeOutsideDiameterDataGridViewTextBoxColumn.Visible = false;
            // 
            // keyStandardHeatLossDataGridViewTextBoxColumn
            // 
            this.keyStandardHeatLossDataGridViewTextBoxColumn.DataPropertyName = "keyStandardHeatLoss";
            this.keyStandardHeatLossDataGridViewTextBoxColumn.HeaderText = "keyStandardHeatLoss";
            this.keyStandardHeatLossDataGridViewTextBoxColumn.Name = "keyStandardHeatLossDataGridViewTextBoxColumn";
            this.keyStandardHeatLossDataGridViewTextBoxColumn.Visible = false;
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
            // valueOfHeatlossMVTDataGridViewTextBoxColumn
            // 
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.DataPropertyName = "ValueOfHeatlossMVT";
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.HeaderText = "ValueOfHeatlossMVT";
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.Name = "valueOfHeatlossMVTDataGridViewTextBoxColumn";
            // 
            // valueOfHeatlossKALDataGridViewTextBoxColumn
            // 
            this.valueOfHeatlossKALDataGridViewTextBoxColumn.DataPropertyName = "ValueOfHeatlossKAL";
            this.valueOfHeatlossKALDataGridViewTextBoxColumn.HeaderText = "ValueOfHeatlossKAL";
            this.valueOfHeatlossKALDataGridViewTextBoxColumn.Name = "valueOfHeatlossKALDataGridViewTextBoxColumn";
            // 
            // startupDataGridViewCheckBoxColumn
            // 
            this.startupDataGridViewCheckBoxColumn.DataPropertyName = "startup";
            this.startupDataGridViewCheckBoxColumn.HeaderText = "startup";
            this.startupDataGridViewCheckBoxColumn.Name = "startupDataGridViewCheckBoxColumn";
            this.startupDataGridViewCheckBoxColumn.Visible = false;
            // 
            // nhwINyearDataGridViewCheckBoxColumn
            // 
            this.nhwINyearDataGridViewCheckBoxColumn.DataPropertyName = "nhwINyear";
            this.nhwINyearDataGridViewCheckBoxColumn.HeaderText = "nhwINyear";
            this.nhwINyearDataGridViewCheckBoxColumn.Name = "nhwINyearDataGridViewCheckBoxColumn";
            this.nhwINyearDataGridViewCheckBoxColumn.Visible = false;
            // 
            // superPositionDataGridViewCheckBoxColumn
            // 
            this.superPositionDataGridViewCheckBoxColumn.DataPropertyName = "superPosition";
            this.superPositionDataGridViewCheckBoxColumn.HeaderText = "superPosition";
            this.superPositionDataGridViewCheckBoxColumn.Name = "superPositionDataGridViewCheckBoxColumn";
            this.superPositionDataGridViewCheckBoxColumn.Visible = false;
            // 
            // codeHeatDissipationSortDataGridViewTextBoxColumn
            // 
            this.codeHeatDissipationSortDataGridViewTextBoxColumn.DataPropertyName = "codeHeatDissipationSort";
            this.codeHeatDissipationSortDataGridViewTextBoxColumn.HeaderText = "codeHeatDissipationSort";
            this.codeHeatDissipationSortDataGridViewTextBoxColumn.Name = "codeHeatDissipationSortDataGridViewTextBoxColumn";
            this.codeHeatDissipationSortDataGridViewTextBoxColumn.Visible = false;
            // 
            // codeMethodOfLayingDataGridViewTextBoxColumn
            // 
            this.codeMethodOfLayingDataGridViewTextBoxColumn.DataPropertyName = "codeMethodOfLaying";
            this.codeMethodOfLayingDataGridViewTextBoxColumn.HeaderText = "codeMethodOfLaying";
            this.codeMethodOfLayingDataGridViewTextBoxColumn.Name = "codeMethodOfLayingDataGridViewTextBoxColumn";
            this.codeMethodOfLayingDataGridViewTextBoxColumn.Visible = false;
            // 
            // assessedValueDataGridViewCheckBoxColumn
            // 
            this.assessedValueDataGridViewCheckBoxColumn.DataPropertyName = "assessedValue";
            this.assessedValueDataGridViewCheckBoxColumn.HeaderText = "assessedValue";
            this.assessedValueDataGridViewCheckBoxColumn.Name = "assessedValueDataGridViewCheckBoxColumn";
            this.assessedValueDataGridViewCheckBoxColumn.Visible = false;
            // 
            // extrapolationDataGridViewCheckBoxColumn
            // 
            this.extrapolationDataGridViewCheckBoxColumn.DataPropertyName = "extrapolation";
            this.extrapolationDataGridViewCheckBoxColumn.HeaderText = "extrapolation";
            this.extrapolationDataGridViewCheckBoxColumn.Name = "extrapolationDataGridViewCheckBoxColumn";
            this.extrapolationDataGridViewCheckBoxColumn.Visible = false;
            // 
            // influenccePipelineINcanalDataGridViewCheckBoxColumn
            // 
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn.DataPropertyName = "influenccePipelineINcanal";
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn.HeaderText = "influenccePipelineINcanal";
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn.Name = "influenccePipelineINcanalDataGridViewCheckBoxColumn";
            this.influenccePipelineINcanalDataGridViewCheckBoxColumn.Visible = false;
            // 
            // kt1DataGridViewTextBoxColumn
            // 
            this.kt1DataGridViewTextBoxColumn.DataPropertyName = "Kt1";
            this.kt1DataGridViewTextBoxColumn.HeaderText = "Kt1";
            this.kt1DataGridViewTextBoxColumn.Name = "kt1DataGridViewTextBoxColumn";
            this.kt1DataGridViewTextBoxColumn.Visible = false;
            // 
            // kt2DataGridViewTextBoxColumn
            // 
            this.kt2DataGridViewTextBoxColumn.DataPropertyName = "Kt2";
            this.kt2DataGridViewTextBoxColumn.HeaderText = "Kt2";
            this.kt2DataGridViewTextBoxColumn.Name = "kt2DataGridViewTextBoxColumn";
            this.kt2DataGridViewTextBoxColumn.Visible = false;
            // 
            // kt3DataGridViewTextBoxColumn
            // 
            this.kt3DataGridViewTextBoxColumn.DataPropertyName = "Kt3";
            this.kt3DataGridViewTextBoxColumn.HeaderText = "Kt3";
            this.kt3DataGridViewTextBoxColumn.Name = "kt3DataGridViewTextBoxColumn";
            this.kt3DataGridViewTextBoxColumn.Visible = false;
            // 
            // codeInsulationTypeDataGridViewTextBoxColumn
            // 
            this.codeInsulationTypeDataGridViewTextBoxColumn.DataPropertyName = "CodeInsulationType";
            this.codeInsulationTypeDataGridViewTextBoxColumn.HeaderText = "CodeInsulationType";
            this.codeInsulationTypeDataGridViewTextBoxColumn.Name = "codeInsulationTypeDataGridViewTextBoxColumn";
            this.codeInsulationTypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // fFiveCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 399);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.cboutD);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dgv_heatloss);
            this.Controls.Add(this.cbNhwInYear);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbDiametr);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.lblDlina);
            this.Controls.Add(this.lblDiametr);
            this.Controls.Add(this.cbType);
            this.Name = "fFiveCalc";
            this.Text = "fFiveCalc";
            this.Load += new System.EventHandler(this.fFiveCalc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.methodOfLayingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_heatloss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardHeatLossBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cbNhwInYear;
        private System.Windows.Forms.DataGridView dgv_heatloss;
        private _BD01_02_2016DataSet _BD01_02_2016DataSet;
        private System.Windows.Forms.BindingSource standardHeatLossBindingSource;
        private _BD01_02_2016DataSetTableAdapters.standardHeatLossTableAdapter standardHeatLossTableAdapter;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource deltaTBindingSource;
        private _BD01_02_2016DataSetTableAdapters.deltaTTableAdapter deltaTTableAdapter;
        private System.Windows.Forms.BindingSource outsideDiameterBindingSource;
        private _BD01_02_2016DataSetTableAdapters.outsideDiameterTableAdapter outsideDiameterTableAdapter;
        private System.Windows.Forms.BindingSource methodOfLayingBindingSource;
        private _BD01_02_2016DataSetTableAdapters.methodOfLayingTableAdapter methodOfLayingTableAdapter;
        private System.Windows.Forms.ComboBox cboutD;
        private System.Windows.Forms.BindingSource outsideDiameterBindingSource1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePipelineSortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeOutsideDiameterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyStandardHeatLossDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeDeltaTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOfHeatlossMVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOfHeatlossKALDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn startupDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn nhwINyearDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn superPositionDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeHeatDissipationSortDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeMethodOfLayingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn assessedValueDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn extrapolationDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn influenccePipelineINcanalDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kt1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kt2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kt3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeInsulationTypeDataGridViewTextBoxColumn;
    }
}