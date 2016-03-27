﻿namespace heatLoss
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fFiveCalc));
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
            this.cBoxNoProeject = new System.Windows.Forms.ComboBox();
            this.cBoxPipes = new System.Windows.Forms.ComboBox();
            this.pipelineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSteamPipe = new System.Windows.Forms.Label();
            this.pipelineTableAdapter = new heatLoss._BD01_02_2016DataSetTableAdapters.pipelineTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.methodOfLayingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._BD01_02_2016DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_heatloss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deltaTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.standardHeatLossBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outsideDiameterBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insulationTypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipelineBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbType
            // 
            this.cbType.DataSource = this.methodOfLayingBindingSource;
            this.cbType.DisplayMember = "methodOflayingSortPipeLine";
            this.cbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(12, 2);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(892, 28);
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
            this.lblDiametr.BackColor = System.Drawing.Color.Transparent;
            this.lblDiametr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiametr.Location = new System.Drawing.Point(8, 42);
            this.lblDiametr.Name = "lblDiametr";
            this.lblDiametr.Size = new System.Drawing.Size(77, 20);
            this.lblDiametr.TabIndex = 1;
            this.lblDiametr.Text = "Диаметр";
            // 
            // lblDlina
            // 
            this.lblDlina.AutoSize = true;
            this.lblDlina.BackColor = System.Drawing.Color.Transparent;
            this.lblDlina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDlina.Location = new System.Drawing.Point(111, 42);
            this.lblDlina.Name = "lblDlina";
            this.lblDlina.Size = new System.Drawing.Size(58, 20);
            this.lblDlina.TabIndex = 2;
            this.lblDlina.Text = "Длина";
            // 
            // tbLength
            // 
            this.tbLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLength.Location = new System.Drawing.Point(104, 61);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(78, 26);
            this.tbLength.TabIndex = 5;
            this.tbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLength_KeyPress);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc.Location = new System.Drawing.Point(793, 411);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 41);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Расчёт";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 128);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(560, 266);
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
            this.dgv_heatloss.Location = new System.Drawing.Point(603, 128);
            this.dgv_heatloss.Name = "dgv_heatloss";
            this.dgv_heatloss.RowHeadersVisible = false;
            this.dgv_heatloss.Size = new System.Drawing.Size(301, 266);
            this.dgv_heatloss.TabIndex = 9;
            this.dgv_heatloss.Visible = false;
            // 
            // codeDeltaTDataGridViewTextBoxColumn
            // 
            this.codeDeltaTDataGridViewTextBoxColumn.DataPropertyName = "codeDeltaT";
            this.codeDeltaTDataGridViewTextBoxColumn.DataSource = this.deltaTBindingSource;
            this.codeDeltaTDataGridViewTextBoxColumn.DisplayMember = "valueDeltaT";
            this.codeDeltaTDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.codeDeltaTDataGridViewTextBoxColumn.HeaderText = "Темп. перепад";
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
            this.valueOfHeatlossMVTDataGridViewTextBoxColumn.HeaderText = "Потери, МВт";
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
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbYear.Location = new System.Drawing.Point(202, 50);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(257, 24);
            this.cbYear.TabIndex = 10;
            this.cbYear.Text = "Год (выберите, если с 1994 )   ";
            this.cbYear.UseVisualStyleBackColor = false;
            // 
            // cbNhwInYear
            // 
            this.cbNhwInYear.AutoSize = true;
            this.cbNhwInYear.BackColor = System.Drawing.Color.Transparent;
            this.cbNhwInYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNhwInYear.Location = new System.Drawing.Point(202, 74);
            this.cbNhwInYear.Name = "cbNhwInYear";
            this.cbNhwInYear.Size = new System.Drawing.Size(257, 24);
            this.cbNhwInYear.TabIndex = 11;
            this.cbNhwInYear.Text = "Часы (выберите, если <5000)  ";
            this.cbNhwInYear.UseVisualStyleBackColor = false;
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
            this.cbOutDiam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbOutDiam.FormattingEnabled = true;
            this.cbOutDiam.Location = new System.Drawing.Point(12, 59);
            this.cbOutDiam.Name = "cbOutDiam";
            this.cbOutDiam.Size = new System.Drawing.Size(69, 28);
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
            this.checkBox3.BackColor = System.Drawing.Color.Transparent;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(700, 102);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(183, 24);
            this.checkBox3.TabIndex = 14;
            this.checkBox3.Text = "Таблица значений    ";
            this.checkBox3.UseVisualStyleBackColor = false;
            this.checkBox3.Visible = false;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbPipeNumber
            // 
            this.cbPipeNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPipeNumber.FormattingEnabled = true;
            this.cbPipeNumber.Items.AddRange(new object[] {
            "двухтрубная прокладка",
            "подающий отдельно",
            "обратный отдельно"});
            this.cbPipeNumber.Location = new System.Drawing.Point(475, 42);
            this.cbPipeNumber.Name = "cbPipeNumber";
            this.cbPipeNumber.Size = new System.Drawing.Size(178, 28);
            this.cbPipeNumber.TabIndex = 15;
            // 
            // lblTemP
            // 
            this.lblTemP.AutoSize = true;
            this.lblTemP.BackColor = System.Drawing.Color.Indigo;
            this.lblTemP.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTemP.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblTemP.Location = new System.Drawing.Point(72, 397);
            this.lblTemP.Name = "lblTemP";
            this.lblTemP.Size = new System.Drawing.Size(79, 29);
            this.lblTemP.TabIndex = 16;
            this.lblTemP.Text = "label1";
            this.lblTemP.Visible = false;
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.BackColor = System.Drawing.Color.Indigo;
            this.lblQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQ.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblQ.Location = new System.Drawing.Point(72, 426);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(79, 29);
            this.lblQ.TabIndex = 17;
            this.lblQ.Text = "label2";
            this.lblQ.Visible = false;
            // 
            // cBoxDepth
            // 
            this.cBoxDepth.AutoSize = true;
            this.cBoxDepth.BackColor = System.Drawing.Color.Transparent;
            this.cBoxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxDepth.Location = new System.Drawing.Point(202, 98);
            this.cBoxDepth.Name = "cBoxDepth";
            this.cBoxDepth.Size = new System.Drawing.Size(257, 24);
            this.cBoxDepth.TabIndex = 18;
            this.cBoxDepth.Text = "Заглубление ТП 0,7 м и менее";
            this.cBoxDepth.UseVisualStyleBackColor = false;
            // 
            // comBInsulationType
            // 
            this.comBInsulationType.DataSource = this.insulationTypeBindingSource;
            this.comBInsulationType.DisplayMember = "insulation";
            this.comBInsulationType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comBInsulationType.FormattingEnabled = true;
            this.comBInsulationType.Location = new System.Drawing.Point(475, 72);
            this.comBInsulationType.Name = "comBInsulationType";
            this.comBInsulationType.Size = new System.Drawing.Size(178, 28);
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
            // cBoxNoProeject
            // 
            this.cBoxNoProeject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxNoProeject.FormattingEnabled = true;
            this.cBoxNoProeject.Items.AddRange(new object[] {
            "перевода на непроектный режим работы не было",
            "Два в режиме подающего",
            "Два в режиме обратного",
            "Подающий в режиме обратного",
            "Обратный в режиме подающего"});
            this.cBoxNoProeject.Location = new System.Drawing.Point(670, 72);
            this.cBoxNoProeject.Name = "cBoxNoProeject";
            this.cBoxNoProeject.Size = new System.Drawing.Size(213, 28);
            this.cBoxNoProeject.TabIndex = 20;
            // 
            // cBoxPipes
            // 
            this.cBoxPipes.DataSource = this.pipelineBindingSource;
            this.cBoxPipes.DisplayMember = "pipelineSort";
            this.cBoxPipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cBoxPipes.FormattingEnabled = true;
            this.cBoxPipes.Location = new System.Drawing.Point(670, 42);
            this.cBoxPipes.Name = "cBoxPipes";
            this.cBoxPipes.Size = new System.Drawing.Size(213, 28);
            this.cBoxPipes.TabIndex = 21;
            this.cBoxPipes.ValueMember = "keyPipeline";
            // 
            // pipelineBindingSource
            // 
            this.pipelineBindingSource.DataMember = "pipeline";
            this.pipelineBindingSource.DataSource = this._BD01_02_2016DataSet;
            // 
            // lblSteamPipe
            // 
            this.lblSteamPipe.AutoSize = true;
            this.lblSteamPipe.BackColor = System.Drawing.Color.Transparent;
            this.lblSteamPipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSteamPipe.Location = new System.Drawing.Point(612, 163);
            this.lblSteamPipe.Name = "lblSteamPipe";
            this.lblSteamPipe.Size = new System.Drawing.Size(277, 120);
            this.lblSteamPipe.TabIndex = 22;
            this.lblSteamPipe.Text = "При совместной прокладке паро-\r\nпровода и конденсатопровода в\r\nнепроходном канале" +
    ",удельные \r\nсреднегодовые потери определя-\r\nются раздельно для паропровода \r\nи к" +
    "онденсатопровода.";
            // 
            // pipelineTableAdapter
            // 
            this.pipelineTableAdapter.ClearBeforeFill = true;
            // 
            // fFiveCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 453);
            this.Controls.Add(this.cBoxPipes);
            this.Controls.Add(this.cBoxNoProeject);
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
            this.Controls.Add(this.lblSteamPipe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(957, 491);
            this.MinimumSize = new System.Drawing.Size(957, 491);
            this.Name = "fFiveCalc";
            this.Text = "Расчет потерь";
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
            ((System.ComponentModel.ISupportInitialize)(this.pipelineBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox cbPipeNumber;
        private System.Windows.Forms.Label lblTemP;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.CheckBox cBoxDepth;
        private System.Windows.Forms.ComboBox comBInsulationType;
        private System.Windows.Forms.BindingSource insulationTypeBindingSource;
        private _BD01_02_2016DataSetTableAdapters.insulationTypeTableAdapter insulationTypeTableAdapter;
        private _BD01_02_2016DataSetTableAdapters.insulationKt2TableAdapter insulationKt2TableAdapter1;
        private System.Windows.Forms.ComboBox cBoxNoProeject;
        private System.Windows.Forms.ComboBox cBoxPipes;
        private System.Windows.Forms.Label lblSteamPipe;
        private System.Windows.Forms.BindingSource pipelineBindingSource;
        private _BD01_02_2016DataSetTableAdapters.pipelineTableAdapter pipelineTableAdapter;
        private System.Windows.Forms.DataGridViewComboBoxColumn codeDeltaTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueOfHeatlossMVTDataGridViewTextBoxColumn;
    }
}