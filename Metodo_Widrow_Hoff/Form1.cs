using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Metodo_Widrow_Hoff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ContTrain, ContEvolu, Ncasos;
        double w1, w2, w0, x0, alfa, MaxTrain, erro, y;
       
        private void BT_AddTabela_Click(object sender, EventArgs e)
        {
            int X1tab, X2tab ,Ttab = 0;
            X1tab = int.Parse(TB_X1Tabela.Text);
            X2tab = int.Parse(TB_X2Tabela.Text);
            
            if (RB_Mais1.Checked)
            { Ttab = +1; }
            if(RB_Menos1.Checked)
            { Ttab = -1; }

            Tab_Entradas.Rows.Add(X1tab, X2tab, Ttab);

            TB_X1Tabela.Clear();
            TB_X2Tabela.Clear();
        }

        private void BT_LimparTabela_Click(object sender, EventArgs e)
        {
            Tab_Entradas.Rows.Clear();
        }

        private void BT_VP1_Click(object sender, EventArgs e)
        {
            Tab_Entradas.Rows.Clear();

            Tab_Entradas.Rows.Add(25, 34, -1);
            Tab_Entradas.Rows.Add(22, 37, -1);
            Tab_Entradas.Rows.Add(30, 33, -1);
            Tab_Entradas.Rows.Add(27, 37, -1);

            Tab_Entradas.Rows.Add(35, 34, -1);
            Tab_Entradas.Rows.Add(38, 39, -1);
            Tab_Entradas.Rows.Add(26, 35, -1);
            Tab_Entradas.Rows.Add(33, 37, -1);

            Tab_Entradas.Rows.Add(4, 40, 1);
            Tab_Entradas.Rows.Add(6, 38, 1);
            Tab_Entradas.Rows.Add(10, 44, 1);
            Tab_Entradas.Rows.Add(3, 42, 1);

            Tab_Entradas.Rows.Add(4, 46, 1);
            Tab_Entradas.Rows.Add(15, 45, 1);
            Tab_Entradas.Rows.Add(10, 38, 1);
            Tab_Entradas.Rows.Add(7, 48, 1);

        }

        private void BT_ExCS_Click(object sender, EventArgs e)
        {
            Tab_Entradas.Rows.Clear();

            Tab_Entradas.Rows.Add(25, 34, -1);
            Tab_Entradas.Rows.Add(22, 37, -1);
            Tab_Entradas.Rows.Add(30, 33, -1);
            Tab_Entradas.Rows.Add(27, 37, -1);

            Tab_Entradas.Rows.Add(4, 40, 1);
            Tab_Entradas.Rows.Add(6, 38, 1);
            Tab_Entradas.Rows.Add(10, 44, 1);
            Tab_Entradas.Rows.Add(3, 42, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LT_Log.Items.Clear();
            Lb_NTreinamento.Text = "";
            ContTrain = 0;
            Ncasos = Tab_Entradas.RowCount - 1;

            //Amazernar Valores Globais
            w1 = double.Parse(TB_W1.Text);
            w2 = double.Parse(TB_W2.Text);
            w0 = double.Parse(TB_W0.Text);
            x0 = double.Parse(TB_X0.Text);

            alfa = double.Parse(TB_Alfa.Text);
            MaxTrain = double.Parse(TB_MT.Text);

            #region Criação Grafico de Casos
            GrafC.Titles.Clear();
            GrafC.Series.Clear();
            GrafC.Legends.Clear();

            GrafC.Titles.Add("Caso");
            GrafC.Series.Add("Linha");
            GrafC.Series.Add("X1");
            GrafC.Series.Add("X2");
            GrafC.Legends.Add("X1");
            GrafC.Legends.Add("X2");

            GrafC.Series["Linha"].ChartType = SeriesChartType.Line;
            GrafC.Series["X1"].ChartType = SeriesChartType.Point;
            GrafC.Series["X2"].ChartType = SeriesChartType.Point;

            GraficoCaso();

            #endregion

            #region Criação Grafico de Pesos

            GrafP.Titles.Clear();
            GrafP.Series.Clear();
            GrafP.Legends.Clear();

            GrafP.Titles.Add("Peso");
            GrafP.Series.Add("W1");
            GrafP.Series.Add("W2");
            GrafP.Legends.Add("W1");
            GrafP.Legends.Add("W2");

            GrafP.Series["W1"].ChartType = SeriesChartType.Spline;
            GrafP.Series["W2"].ChartType = SeriesChartType.Spline;
            #endregion


            #region Metodo Widrow Hoff
            for (int i = 0; i < MaxTrain; i++)
            {
               //Log

                LT_Log.Items.Add("-------------------------------------");
                LT_Log.Items.Add("Treinamento:" + ContTrain + " w1: " + w1 + " w2: " + w2 + " w0: " + w0);
                LT_Log.Items.Add("-------------------------------------");

                ContEvolu = 0;

                for (int j = 0; j < Ncasos; j++)
                {

                    //Pegando os valores da tabela

                    double Valor_X1 = double.Parse(Tab_Entradas.Rows[j].Cells[0].Value.ToString());
                    double Valor_X2 = double.Parse(Tab_Entradas.Rows[j].Cells[1].Value.ToString());
                    double Target = double.Parse(Tab_Entradas.Rows[j].Cells[2].Value.ToString());

                    double modulo = Math.Sqrt(Math.Pow(Valor_X1, 2) + Math.Pow(Valor_X2, 2) + Math.Pow(x0, 2));

                    //Linha do Grafico dos Pesos

                    

                    // Saida Intermediaria

                    double s = (w0 * x0) + (w1 * Valor_X1) + (w2 * Valor_X2);

                    //Relé

                    if (s > 0)
                    {
                        y = 1;
                    }
                    else
                    {
                        y = -1;
                    }

                    erro = Target - s;

                    // Grafico de Pesos

                    GrafP.Series["W1"].Points.AddXY(w1, erro);

                    GrafP.Series["W2"].Points.AddXY(w2, erro);
                    

                    w0 = w0 + (alfa * erro * (x0 / Math.Pow(modulo, 2)));
                    w1 = w1 + (alfa * erro * (Valor_X1 / Math.Pow(modulo, 2)));
                    w2 = w2 + (alfa * erro * (Valor_X2 / Math.Pow(modulo, 2)));

                    LT_Log.Items.Add("Caso: " + j);
                    LT_Log.Items.Add("x1: " + Valor_X1);
                    LT_Log.Items.Add("x2: " + Valor_X2);
                    LT_Log.Items.Add("Target: " + Target);

                    // Verificação do Target

                    if (Target == y)
                    {
                        ContEvolu++;

                        LT_Log.Items.Add(" y: " + y + " OK");
                        LT_Log.Items.Add("-----------------");

                    }
                    else
                    {

                        LT_Log.Items.Add(" y: " + y + " ERROR");
                        LT_Log.Items.Add("-----------------");

                    }

                    // Verificação de Conclusão da Evolução

                    if (ContEvolu == Ncasos)
                    {
                        Lb_NTreinamento.Text = (ContTrain + 1).ToString();
                        break;
                    }

                }

                // Verificação de Conclusão da Evolução

                if (ContEvolu == Ncasos)
                {
                    break;
                }
                else { Lb_NTreinamento.Text = "Limite Max."; }

                ContTrain++;
            }

            // Pesos Finais

            Lb_W1F.Text = w1.ToString();
            Lb_W2F.Text = w2.ToString();
            #endregion

        }

        public void GraficoCaso()
        {
            for (int i = 0; i < Ncasos; i++)
            {
                double X1caso = double.Parse(Tab_Entradas.Rows[i].Cells[0].Value.ToString());
                double X2caso = double.Parse(Tab_Entradas.Rows[i].Cells[1].Value.ToString());
                double TargetCaso = double.Parse(Tab_Entradas.Rows[i].Cells[2].Value.ToString());
                double X2W = -((w1 / w2) * X1caso) - (w0 / w2);
               
                if (TargetCaso == 1)
                {
                    GrafC.Series["X1"].Points.AddXY(X1caso, X2caso);
                    GrafC.Series["Linha"].Points.AddXY(X1caso, X2W);
                }
                else
                {
                    GrafC.Series["X2"].Points.AddXY(X1caso, X2caso);
                    GrafC.Series["Linha"].Points.AddXY(X1caso, X2W);
                }

            }

        }

    }
}