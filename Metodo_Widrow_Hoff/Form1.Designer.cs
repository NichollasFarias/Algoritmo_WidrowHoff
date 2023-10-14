namespace Metodo_Widrow_Hoff
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.GrafC = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GrafP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.LT_Log = new System.Windows.Forms.ListBox();
            this.Tab_Entradas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TB_W2 = new System.Windows.Forms.TextBox();
            this.TB_W1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_X0 = new System.Windows.Forms.TextBox();
            this.TB_W0 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TB_MT = new System.Windows.Forms.TextBox();
            this.TB_Alfa = new System.Windows.Forms.TextBox();
            this.Lb_NTreinamento = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Lb_W2F = new System.Windows.Forms.Label();
            this.Lb_W1F = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BT_ExCS = new System.Windows.Forms.Button();
            this.BT_VP1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.X1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.T = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TB_X2Tabela = new System.Windows.Forms.TextBox();
            this.TB_X1Tabela = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.RB_Mais1 = new System.Windows.Forms.RadioButton();
            this.RB_Menos1 = new System.Windows.Forms.RadioButton();
            this.BT_AddTabela = new System.Windows.Forms.Button();
            this.BT_LimparTabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GrafC)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrafP)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Entradas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrafC
            // 
            chartArea7.Name = "ChartArea1";
            this.GrafC.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.GrafC.Legends.Add(legend7);
            this.GrafC.Location = new System.Drawing.Point(8, 10);
            this.GrafC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrafC.Name = "GrafC";
            this.GrafC.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.GrafC.Series.Add(series7);
            this.GrafC.Size = new System.Drawing.Size(676, 362);
            this.GrafC.TabIndex = 0;
            this.GrafC.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(413, 380);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(700, 415);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrafC);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(692, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Casos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GrafP);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(692, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pesos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GrafP
            // 
            chartArea8.Name = "ChartArea1";
            this.GrafP.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.GrafP.Legends.Add(legend8);
            this.GrafP.Location = new System.Drawing.Point(8, 10);
            this.GrafP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GrafP.Name = "GrafP";
            this.GrafP.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Series1";
            this.GrafP.Series.Add(series8);
            this.GrafP.Size = new System.Drawing.Size(676, 362);
            this.GrafP.TabIndex = 0;
            this.GrafP.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.LT_Log);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(692, 382);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LOG";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // LT_Log
            // 
            this.LT_Log.FormattingEnabled = true;
            this.LT_Log.ItemHeight = 20;
            this.LT_Log.Location = new System.Drawing.Point(8, 5);
            this.LT_Log.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LT_Log.Name = "LT_Log";
            this.LT_Log.Size = new System.Drawing.Size(676, 364);
            this.LT_Log.TabIndex = 0;
            // 
            // Tab_Entradas
            // 
            this.Tab_Entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Tab_Entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tab_Entradas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X1,
            this.X2,
            this.T});
            this.Tab_Entradas.Location = new System.Drawing.Point(199, 19);
            this.Tab_Entradas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tab_Entradas.Name = "Tab_Entradas";
            this.Tab_Entradas.RowHeadersVisible = false;
            this.Tab_Entradas.Size = new System.Drawing.Size(493, 311);
            this.Tab_Entradas.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_LimparTabela);
            this.groupBox1.Controls.Add(this.BT_AddTabela);
            this.groupBox1.Controls.Add(this.RB_Menos1);
            this.groupBox1.Controls.Add(this.RB_Mais1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TB_X2Tabela);
            this.groupBox1.Controls.Add(this.TB_X1Tabela);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.Tab_Entradas);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox1.Location = new System.Drawing.Point(413, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(700, 340);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Casos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TB_W2);
            this.groupBox2.Controls.Add(this.TB_W1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(183, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(162, 133);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesos Iniciais";
            // 
            // TB_W2
            // 
            this.TB_W2.Location = new System.Drawing.Point(52, 78);
            this.TB_W2.Name = "TB_W2";
            this.TB_W2.Size = new System.Drawing.Size(100, 26);
            this.TB_W2.TabIndex = 3;
            // 
            // TB_W1
            // 
            this.TB_W1.Location = new System.Drawing.Point(52, 48);
            this.TB_W1.Name = "TB_W1";
            this.TB_W1.Size = new System.Drawing.Size(100, 26);
            this.TB_W1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label2.Location = new System.Drawing.Point(12, 79);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "W2:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "W1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TB_X0);
            this.groupBox3.Controls.Add(this.TB_W0);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(13, 116);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(162, 133);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bias";
            // 
            // TB_X0
            // 
            this.TB_X0.Location = new System.Drawing.Point(48, 77);
            this.TB_X0.Name = "TB_X0";
            this.TB_X0.Size = new System.Drawing.Size(100, 26);
            this.TB_X0.TabIndex = 7;
            // 
            // TB_W0
            // 
            this.TB_W0.Location = new System.Drawing.Point(48, 47);
            this.TB_W0.Name = "TB_W0";
            this.TB_W0.Size = new System.Drawing.Size(100, 26);
            this.TB_W0.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label3.Location = new System.Drawing.Point(8, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "X0:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label4.Location = new System.Drawing.Point(8, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "W0:";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Controls.Add(this.TB_MT);
            this.groupBox5.Controls.Add(this.TB_Alfa);
            this.groupBox5.Controls.Add(this.Lb_NTreinamento);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.groupBox5.Location = new System.Drawing.Point(12, 259);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(333, 150);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Treinamento";
            // 
            // TB_MT
            // 
            this.TB_MT.Location = new System.Drawing.Point(216, 62);
            this.TB_MT.Name = "TB_MT";
            this.TB_MT.Size = new System.Drawing.Size(100, 26);
            this.TB_MT.TabIndex = 10;
            // 
            // TB_Alfa
            // 
            this.TB_Alfa.Location = new System.Drawing.Point(216, 30);
            this.TB_Alfa.Name = "TB_Alfa";
            this.TB_Alfa.Size = new System.Drawing.Size(100, 26);
            this.TB_Alfa.TabIndex = 9;
            // 
            // Lb_NTreinamento
            // 
            this.Lb_NTreinamento.AutoSize = true;
            this.Lb_NTreinamento.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_NTreinamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Lb_NTreinamento.Location = new System.Drawing.Point(149, 92);
            this.Lb_NTreinamento.Name = "Lb_NTreinamento";
            this.Lb_NTreinamento.Size = new System.Drawing.Size(25, 27);
            this.Lb_NTreinamento.TabIndex = 8;
            this.Lb_NTreinamento.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label9.Location = new System.Drawing.Point(18, 97);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 20);
            this.label9.TabIndex = 7;
            this.label9.Text = "Nº de Treinamento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label8.Location = new System.Drawing.Point(18, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Nº Máximo de Treinamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(18, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Taxa de Aprendizagem (passo):";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Lb_W2F);
            this.groupBox6.Controls.Add(this.Lb_W1F);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(13, 492);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox6.Size = new System.Drawing.Size(332, 116);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesos Finais";
            // 
            // Lb_W2F
            // 
            this.Lb_W2F.AutoSize = true;
            this.Lb_W2F.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_W2F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Lb_W2F.Location = new System.Drawing.Point(47, 75);
            this.Lb_W2F.Name = "Lb_W2F";
            this.Lb_W2F.Size = new System.Drawing.Size(25, 27);
            this.Lb_W2F.TabIndex = 10;
            this.Lb_W2F.Text = "0";
            // 
            // Lb_W1F
            // 
            this.Lb_W1F.AutoSize = true;
            this.Lb_W1F.Font = new System.Drawing.Font("Arial Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_W1F.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.Lb_W1F.Location = new System.Drawing.Point(47, 47);
            this.Lb_W1F.Name = "Lb_W1F";
            this.Lb_W1F.Size = new System.Drawing.Size(25, 27);
            this.Lb_W1F.TabIndex = 9;
            this.Lb_W1F.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label10.Location = new System.Drawing.Point(8, 79);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "W2:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.label11.Location = new System.Drawing.Point(8, 49);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "W1:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.button1.Location = new System.Drawing.Point(13, 419);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Treinar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("AniMe Matrix - MB_EN", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(278, 41);
            this.label5.TabIndex = 17;
            this.label5.Text = "NeuroN 2.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label6.Location = new System.Drawing.Point(23, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Dados:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label12.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label12.Location = new System.Drawing.Point(10, 640);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 32);
            this.label12.TabIndex = 19;
            this.label12.Text = "Exemplos:";
            // 
            // BT_ExCS
            // 
            this.BT_ExCS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_ExCS.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BT_ExCS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.BT_ExCS.Location = new System.Drawing.Point(11, 677);
            this.BT_ExCS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_ExCS.Name = "BT_ExCS";
            this.BT_ExCS.Size = new System.Drawing.Size(162, 63);
            this.BT_ExCS.TabIndex = 20;
            this.BT_ExCS.Text = "Cabelo/Sapato";
            this.BT_ExCS.UseVisualStyleBackColor = false;
            this.BT_ExCS.Click += new System.EventHandler(this.BT_ExCS_Click);
            // 
            // BT_VP1
            // 
            this.BT_VP1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_VP1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BT_VP1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.BT_VP1.Location = new System.Drawing.Point(181, 677);
            this.BT_VP1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_VP1.Name = "BT_VP1";
            this.BT_VP1.Size = new System.Drawing.Size(162, 63);
            this.BT_VP1.TabIndex = 21;
            this.BT_VP1.Text = "Valores de P1";
            this.BT_VP1.UseVisualStyleBackColor = false;
            this.BT_VP1.Click += new System.EventHandler(this.BT_VP1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label13.Location = new System.Drawing.Point(12, 783);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(177, 19);
            this.label13.TabIndex = 22;
            this.label13.Text = "© 2023 Nichollas F.L.S";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label14.Location = new System.Drawing.Point(8, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 19);
            this.label14.TabIndex = 23;
            this.label14.Text = "Valores:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label15.Location = new System.Drawing.Point(8, 56);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 19);
            this.label15.TabIndex = 24;
            this.label15.Text = "X1:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label16.Location = new System.Drawing.Point(8, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 19);
            this.label16.TabIndex = 25;
            this.label16.Text = "X2:";
            // 
            // X1
            // 
            this.X1.HeaderText = "X1";
            this.X1.Name = "X1";
            this.X1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // X2
            // 
            this.X2.HeaderText = "X2";
            this.X2.Name = "X2";
            this.X2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // T
            // 
            this.T.HeaderText = "Target";
            this.T.Name = "T";
            this.T.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // TB_X2Tabela
            // 
            this.TB_X2Tabela.Location = new System.Drawing.Point(49, 87);
            this.TB_X2Tabela.Name = "TB_X2Tabela";
            this.TB_X2Tabela.Size = new System.Drawing.Size(142, 26);
            this.TB_X2Tabela.TabIndex = 27;
            // 
            // TB_X1Tabela
            // 
            this.TB_X1Tabela.Location = new System.Drawing.Point(49, 52);
            this.TB_X1Tabela.Name = "TB_X1Tabela";
            this.TB_X1Tabela.Size = new System.Drawing.Size(142, 26);
            this.TB_X1Tabela.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.label17.Location = new System.Drawing.Point(8, 128);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "Target:";
            // 
            // RB_Mais1
            // 
            this.RB_Mais1.AutoSize = true;
            this.RB_Mais1.Location = new System.Drawing.Point(77, 123);
            this.RB_Mais1.Name = "RB_Mais1";
            this.RB_Mais1.Size = new System.Drawing.Size(42, 24);
            this.RB_Mais1.TabIndex = 29;
            this.RB_Mais1.TabStop = true;
            this.RB_Mais1.Text = "+1";
            this.RB_Mais1.UseVisualStyleBackColor = true;
            // 
            // RB_Menos1
            // 
            this.RB_Menos1.AutoSize = true;
            this.RB_Menos1.Location = new System.Drawing.Point(125, 123);
            this.RB_Menos1.Name = "RB_Menos1";
            this.RB_Menos1.Size = new System.Drawing.Size(38, 24);
            this.RB_Menos1.TabIndex = 30;
            this.RB_Menos1.TabStop = true;
            this.RB_Menos1.Text = "-1";
            this.RB_Menos1.UseVisualStyleBackColor = true;
            // 
            // BT_AddTabela
            // 
            this.BT_AddTabela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_AddTabela.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BT_AddTabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.BT_AddTabela.Location = new System.Drawing.Point(12, 161);
            this.BT_AddTabela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_AddTabela.Name = "BT_AddTabela";
            this.BT_AddTabela.Size = new System.Drawing.Size(179, 59);
            this.BT_AddTabela.TabIndex = 31;
            this.BT_AddTabela.Text = "Adicionar";
            this.BT_AddTabela.UseVisualStyleBackColor = false;
            this.BT_AddTabela.Click += new System.EventHandler(this.BT_AddTabela_Click);
            // 
            // BT_LimparTabela
            // 
            this.BT_LimparTabela.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BT_LimparTabela.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.BT_LimparTabela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(58)))), ((int)(((byte)(183)))));
            this.BT_LimparTabela.Location = new System.Drawing.Point(12, 230);
            this.BT_LimparTabela.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BT_LimparTabela.Name = "BT_LimparTabela";
            this.BT_LimparTabela.Size = new System.Drawing.Size(179, 59);
            this.BT_LimparTabela.TabIndex = 32;
            this.BT_LimparTabela.Text = "Limpar";
            this.BT_LimparTabela.UseVisualStyleBackColor = false;
            this.BT_LimparTabela.Click += new System.EventHandler(this.BT_LimparTabela_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1124, 811);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.BT_VP1);
            this.Controls.Add(this.BT_ExCS);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "NeuroN 2.0";
            ((System.ComponentModel.ISupportInitialize)(this.GrafC)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrafP)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Entradas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart GrafC;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView Tab_Entradas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart GrafP;
        private System.Windows.Forms.ListBox LT_Log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_W2;
        private System.Windows.Forms.TextBox TB_W1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_X0;
        private System.Windows.Forms.TextBox TB_W0;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Lb_NTreinamento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lb_W2F;
        private System.Windows.Forms.Label Lb_W1F;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TB_MT;
        private System.Windows.Forms.TextBox TB_Alfa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BT_ExCS;
        private System.Windows.Forms.Button BT_VP1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn X1;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn T;
        private System.Windows.Forms.Button BT_LimparTabela;
        private System.Windows.Forms.Button BT_AddTabela;
        private System.Windows.Forms.RadioButton RB_Menos1;
        private System.Windows.Forms.RadioButton RB_Mais1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TB_X2Tabela;
        private System.Windows.Forms.TextBox TB_X1Tabela;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
    }
}

