﻿namespace PuntoFijo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.txtMaxi = new System.Windows.Forms.TextBox();
            this.txtTolerancia = new System.Windows.Forms.TextBox();
            this.txtVi = new System.Windows.Forms.TextBox();
            this.txtGx = new System.Windows.Forms.TextBox();
            this.txtFx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbFuncion = new System.Windows.Forms.Label();
            this.lbIteraciones = new System.Windows.Forms.Label();
            this.lbER = new System.Windows.Forms.Label();
            this.lbRaiz = new System.Windows.Forms.Label();
            this.dgvTabla_resultados = new System.Windows.Forms.DataGridView();
            this.col_n = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_x = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gdex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_er = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Método de Punto Fijo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingresando los Datos a Utilizar ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Función a Evaluar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btnAyuda);
            this.panel1.Controls.Add(this.txtMaxi);
            this.panel1.Controls.Add(this.txtTolerancia);
            this.panel1.Controls.Add(this.txtVi);
            this.panel1.Controls.Add(this.txtGx);
            this.panel1.Controls.Add(this.txtFx);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(30, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 369);
            this.panel1.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(163, 331);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(201, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "A éste se le agrega una Primera Iteración";
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.White;
            this.btnAyuda.BackgroundImage = global::PuntoFijo.Properties.Resources.information_button2;
            this.btnAyuda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyuda.FlatAppearance.BorderSize = 0;
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Location = new System.Drawing.Point(292, 7);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(36, 35);
            this.btnAyuda.TabIndex = 11;
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            this.btnAyuda.MouseHover += new System.EventHandler(this.btnAyuda_MouseHover);
            // 
            // txtMaxi
            // 
            this.txtMaxi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxi.Location = new System.Drawing.Point(166, 299);
            this.txtMaxi.Name = "txtMaxi";
            this.txtMaxi.Size = new System.Drawing.Size(84, 29);
            this.txtMaxi.TabIndex = 10;
            this.txtMaxi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressSoloNumerosEnteros);
            // 
            // txtTolerancia
            // 
            this.txtTolerancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTolerancia.Location = new System.Drawing.Point(136, 243);
            this.txtTolerancia.Name = "txtTolerancia";
            this.txtTolerancia.Size = new System.Drawing.Size(203, 29);
            this.txtTolerancia.TabIndex = 9;
            this.txtTolerancia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimales);
            // 
            // txtVi
            // 
            this.txtVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVi.Location = new System.Drawing.Point(136, 183);
            this.txtVi.Name = "txtVi";
            this.txtVi.Size = new System.Drawing.Size(203, 29);
            this.txtVi.TabIndex = 8;
            this.txtVi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressDecimales);
            // 
            // txtGx
            // 
            this.txtGx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGx.Location = new System.Drawing.Point(136, 122);
            this.txtGx.Name = "txtGx";
            this.txtGx.Size = new System.Drawing.Size(203, 29);
            this.txtGx.TabIndex = 7;
            // 
            // txtFx
            // 
            this.txtFx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFx.Location = new System.Drawing.Point(136, 69);
            this.txtFx.Name = "txtFx";
            this.txtFx.Size = new System.Drawing.Size(203, 29);
            this.txtFx.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 18);
            this.label7.TabIndex = 5;
            this.label7.Text = "Máximo de Iteraciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tolerancia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(48, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor Inicial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "g(x)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(984, 75);
            this.panel2.TabIndex = 6;
            // 
            // chart1
            // 
            chartArea3.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea3.AlignmentStyle = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentStyles.Position;
            chartArea3.AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisX.Crossing = 0D;
            chartArea3.AxisX.Interval = 1D;
            chartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.IsMarginVisible = false;
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisX.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisX.LabelStyle.Angle = 2;
            chartArea3.AxisX.LabelStyle.Interval = 5D;
            chartArea3.AxisX.LineColor = System.Drawing.Color.Red;
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.Maximum = 5D;
            chartArea3.AxisX.Minimum = -5D;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisX.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea3.AxisX.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea3.AxisX2.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;
            chartArea3.AxisX2.Crossing = 0D;
            chartArea3.AxisX2.Maximum = 5D;
            chartArea3.AxisX2.Minimum = -5D;
            chartArea3.AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            chartArea3.AxisY.Crossing = 0D;
            chartArea3.AxisY.Interval = 1D;
            chartArea3.AxisY.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisY.LabelAutoFitStyle = ((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles)((((((System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.IncreaseFont | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.DecreaseFont) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.StaggeredLabels) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep30) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.LabelsAngleStep45) 
            | System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap)));
            chartArea3.AxisY.LabelStyle.Interval = 5D;
            chartArea3.AxisY.LineColor = System.Drawing.Color.Red;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY.Maximum = 5D;
            chartArea3.AxisY.Minimum = -5D;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea3.AxisY2.Maximum = 6D;
            chartArea3.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea3.BorderColor = System.Drawing.Color.White;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 88.4641F;
            chartArea3.InnerPlotPosition.Width = 86F;
            chartArea3.InnerPlotPosition.X = 14F;
            chartArea3.InnerPlotPosition.Y = 5F;
            chartArea3.IsSameFontSizeForAllAxes = true;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.DarkGray;
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(413, 74);
            this.chart1.Name = "chart1";
            series5.BorderColor = System.Drawing.Color.Gray;
            series5.BorderWidth = 2;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Lime;
            series5.LabelBorderWidth = 2;
            series5.Legend = "Legend1";
            series5.Name = "Gx";
            series6.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series6.BorderColor = System.Drawing.Color.White;
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.DarkBlue;
            series6.LabelBorderWidth = 2;
            series6.Legend = "Legend1";
            series6.Name = "Identidad";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(574, 426);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "Grafica";
            this.chart1.UseWaitCursor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::PuntoFijo.Properties.Resources.salir_btn;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(899, 483);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 38);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackgroundImage = global::PuntoFijo.Properties.Resources.limpiar_btn;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpiar.Location = new System.Drawing.Point(109, 482);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(82, 39);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            this.btnLimpiar.MouseHover += new System.EventHandler(this.btnLimpiar_MouseHover);
            // 
            // btnCheck
            // 
            this.btnCheck.BackgroundImage = global::PuntoFijo.Properties.Resources.check_button1;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheck.Location = new System.Drawing.Point(242, 482);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(117, 39);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            this.btnCheck.MouseHover += new System.EventHandler(this.btnCheck_MouseHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 551);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lbFuncion);
            this.panel3.Controls.Add(this.lbIteraciones);
            this.panel3.Controls.Add(this.lbER);
            this.panel3.Controls.Add(this.lbRaiz);
            this.panel3.Controls.Add(this.dgvTabla_resultados);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Controls.Add(this.chart1);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(975, 1192);
            this.panel3.TabIndex = 0;
            // 
            // lbFuncion
            // 
            this.lbFuncion.AutoSize = true;
            this.lbFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFuncion.Location = new System.Drawing.Point(701, 664);
            this.lbFuncion.Name = "lbFuncion";
            this.lbFuncion.Size = new System.Drawing.Size(75, 20);
            this.lbFuncion.TabIndex = 21;
            this.lbFuncion.Text = "Ninguna";
            // 
            // lbIteraciones
            // 
            this.lbIteraciones.AutoSize = true;
            this.lbIteraciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIteraciones.Location = new System.Drawing.Point(468, 664);
            this.lbIteraciones.Name = "lbIteraciones";
            this.lbIteraciones.Size = new System.Drawing.Size(75, 20);
            this.lbIteraciones.TabIndex = 20;
            this.lbIteraciones.Text = "Ninguna";
            // 
            // lbER
            // 
            this.lbER.AutoSize = true;
            this.lbER.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbER.Location = new System.Drawing.Point(265, 664);
            this.lbER.Name = "lbER";
            this.lbER.Size = new System.Drawing.Size(75, 20);
            this.lbER.TabIndex = 19;
            this.lbER.Text = "Ninguno";
            // 
            // lbRaiz
            // 
            this.lbRaiz.AutoSize = true;
            this.lbRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRaiz.Location = new System.Drawing.Point(26, 662);
            this.lbRaiz.Name = "lbRaiz";
            this.lbRaiz.Size = new System.Drawing.Size(75, 20);
            this.lbRaiz.TabIndex = 18;
            this.lbRaiz.Text = "Ninguno";
            // 
            // dgvTabla_resultados
            // 
            this.dgvTabla_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_n,
            this.col_x,
            this.col_gdex,
            this.col_er});
            this.dgvTabla_resultados.Location = new System.Drawing.Point(30, 723);
            this.dgvTabla_resultados.Name = "dgvTabla_resultados";
            this.dgvTabla_resultados.RowHeadersWidth = 62;
            this.dgvTabla_resultados.Size = new System.Drawing.Size(900, 400);
            this.dgvTabla_resultados.TabIndex = 17;
            // 
            // col_n
            // 
            this.col_n.HeaderText = "N";
            this.col_n.MinimumWidth = 8;
            this.col_n.Name = "col_n";
            this.col_n.ReadOnly = true;
            this.col_n.Width = 85;
            // 
            // col_x
            // 
            this.col_x.HeaderText = "X";
            this.col_x.MinimumWidth = 8;
            this.col_x.Name = "col_x";
            this.col_x.ReadOnly = true;
            this.col_x.Width = 250;
            // 
            // col_gdex
            // 
            this.col_gdex.HeaderText = "g(x)";
            this.col_gdex.MinimumWidth = 8;
            this.col_gdex.Name = "col_gdex";
            this.col_gdex.ReadOnly = true;
            this.col_gdex.Width = 250;
            // 
            // col_er
            // 
            this.col_er.HeaderText = "Porcentaje de Error";
            this.col_er.MinimumWidth = 8;
            this.col_er.Name = "col_er";
            this.col_er.ReadOnly = true;
            this.col_er.Width = 250;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(704, 630);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 12;
            this.label12.Text = "Función Utilizada";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(469, 630);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Iteraciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 630);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Error Relativo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 630);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Raíz Encontrada";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Resultados";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 1139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(698, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Si no se muestran el número de Iteraciones Insertadas(+1) pruebe reducir el valor" +
    " de la Tolerancia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 555);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 594);
            this.MinimumSize = new System.Drawing.Size(857, 454);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto Fijo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla_resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.TextBox txtMaxi;
        private System.Windows.Forms.TextBox txtTolerancia;
        private System.Windows.Forms.TextBox txtVi;
        private System.Windows.Forms.TextBox txtGx;
        private System.Windows.Forms.TextBox txtFx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dgvTabla_resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_n;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_x;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gdex;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_er;
        private System.Windows.Forms.Label lbFuncion;
        private System.Windows.Forms.Label lbIteraciones;
        private System.Windows.Forms.Label lbER;
        private System.Windows.Forms.Label lbRaiz;
        private System.Windows.Forms.Label label13;
    }
}

