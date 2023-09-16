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
            Entradas();
        }

        int Ncasos;
        double w1, w2, w0, x0, alfa, MaxTrain, erro, y, Maxy, Miny;
        int ContTrain;
        int ContEvolu;


        private void button1_Click(object sender, EventArgs e)
        {
            LT_Log.Items.Clear();
            ContTrain = 0;
            //Amazernar Valores Globais
            w1 = double.Parse(TB_W1.Text);
            w2 = double.Parse(TB_W2.Text);
            w0 = double.Parse(TB_W0.Text);
            x0 = double.Parse(TB_X0.Text);

            Maxy = double.Parse(TB_Y1.Text);
            Miny = double.Parse(TB_Y0.Text);

            alfa = double.Parse(TB_Alfa.Text);
            MaxTrain = double.Parse(TB_MT.Text);

            #region Criação Grafico de Casos
            GrafC.Titles.Clear();
            GrafC.Series.Clear();
            GrafC.Legends.Clear();

            GrafC.Titles.Add("Caso");
            GrafC.Series.Add("X1");
            GrafC.Series.Add("X2");
            GrafC.Legends.Add("X1");
            GrafC.Legends.Add("X2");


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


            #region
            for (int i = 0; i < MaxTrain; i++)
            {
                LT_Log.ForeColor = Color.Black;
                LT_Log.Items.Add("-------------------------------------");
                LT_Log.Items.Add("Treinamento:" + ContTrain + " w1: " + w1 + " w2: " + w2 + " w0: " + w0);
                LT_Log.Items.Add("-------------------------------------");

                ContEvolu = 0;

                for (int j = 0; j < Ncasos; j++)
                {
                    LT_Log.ForeColor = Color.Black;
                    double xx1 = double.Parse(Tab_Entradas.Rows[j].Cells[0].Value.ToString());
                    double xx2 = double.Parse(Tab_Entradas.Rows[j].Cells[1].Value.ToString());
                    double target = double.Parse(Tab_Entradas.Rows[j].Cells[2].Value.ToString());

                    double s = Math.Round((w0 * x0) + (w1 * xx1) + (w2 * xx2));

                    erro = target - s;

                    //GraficoPeso(w1,w2,erro);

                    GrafP.Series["W1"].Points.AddXY(w1, erro);

                    GrafP.Series["W2"].Points.AddXY(w2, erro);


                    w0 = w0 + (alfa * erro * x0);
                    w1 = w1 + (alfa * erro * xx1);
                    w2 = w2 + (alfa * erro * xx2);

                    LT_Log.Items.Add("Caso: " + j);
                    LT_Log.Items.Add("x1: " + xx1);
                    LT_Log.Items.Add("x1: " + xx2);
                    LT_Log.Items.Add("Target: " + target);

                    if (s > Maxy)
                    {
                        y = 1;
                    }

                    if (s < Miny)
                    {
                        y = -1;
                    }



                    if (target == y)
                    {
                        ContEvolu++;
                        LT_Log.ForeColor = Color.Green;
                        LT_Log.Items.Add(" y: " + y + " OK");
                        LT_Log.Items.Add("-----------------");
                        LT_Log.ForeColor = Color.Black;
                    }
                    else
                    {
                        LT_Log.ForeColor = Color.Red;
                        LT_Log.Items.Add(" y: " + y + " ERROR");
                        LT_Log.Items.Add("-----------------");

                    }



                    if (ContEvolu == Ncasos)
                    {
                        Lb_NTreinamento.Text = (ContTrain + 1).ToString();
                        break;
                    }

                }

                if (ContEvolu == Ncasos)
                {
                    break;
                }

                ContTrain++;
            }

            Lb_W1F.Text = w1.ToString();
            Lb_W2F.Text = w2.ToString();
            #endregion



            // WidrowHoff();
        }

        public void GraficoCaso()
        {
            for (int i = 0; i < Ncasos; i++)
            {
                double xxx1 = double.Parse(Tab_Entradas.Rows[i].Cells[0].Value.ToString());
                double xxx2 = double.Parse(Tab_Entradas.Rows[i].Cells[1].Value.ToString());
                double target1 = double.Parse(Tab_Entradas.Rows[i].Cells[2].Value.ToString());


                if (target1 == 1)
                {
                    GrafC.Series["X1"].Points.AddXY(xxx1, xxx2);
                }
                else
                {
                    GrafC.Series["X2"].Points.AddXY(xxx1, xxx2);
                }

            }

        }

        /*
                public void WidrowHoff()
                {
                    for (int i = 0; i < MaxTrain; i++)
                    {
                        LT_Log.Items.Add("-------------------------------------");
                        LT_Log.Items.Add("Treinamento:" + ContTrain + " w1: " + w1 + " w2: " + w2 + " w0: " + w0);
                        LT_Log.Items.Add("-------------------------------------");

                        for (int j = 0; j < Ncasos; j++)
                        {
                            double xx1 = double.Parse(Tab_Entradas.Rows[j].Cells[0].Value.ToString());
                            double xx2 = double.Parse(Tab_Entradas.Rows[j].Cells[1].Value.ToString());
                            double target = double.Parse(Tab_Entradas.Rows[j].Cells[2].Value.ToString());

                            double y = Math.Round((w0 * x0) + (w1 * xx1) + (w2 * xx2), 2);

                            erro = target - y;

                            //GraficoPeso(w1,w2,erro);

                            GrafP.Series["W1"].Points.AddXY(w1, erro);

                            GrafP.Series["W2"].Points.AddXY(w2, erro);


                            w0 = w0 + alfa * erro * x0;
                            w1 = w1 + alfa * erro * xx1;
                            w2 = w2 + alfa * erro * xx2;



                            LT_Log.Items.Add("Caso: " + j);
                            LT_Log.Items.Add("x1: " + xx1);
                            LT_Log.Items.Add("x1: " + xx2);
                            LT_Log.Items.Add("Target: " + target);
                            LT_Log.Items.Add(" y: " + y);
                            LT_Log.Items.Add(" Erro: " + erro);
                            LT_Log.Items.Add("-----------------");


                            if (Math.Abs(erro) < 0.0001)
                            {
                                Lb_NTreinamento.Text = (ContTrain + 1).ToString();
                                break;
                            }

                        }

                        ContTrain++;
                    }

                    Lb_W1F.Text = w1.ToString();
                    Lb_W2F.Text = w2.ToString();
                    Lb_NTreinamento.Text = (ContTrain).ToString();

                }
        */

        public void Entradas()
        {
            // Entradas de X1 X2 Target (Na tabela entradas) Obs.: Utilizando valores base do exemplo "Cabelo Sapato"
            Tab_Entradas.Rows.Add(25, 34, -1);
            Tab_Entradas.Rows.Add(22, 37, -1);
            Tab_Entradas.Rows.Add(30, 33, -1);
            Tab_Entradas.Rows.Add(27, 37, -1);
            Tab_Entradas.Rows.Add(4, 40, 1);
            Tab_Entradas.Rows.Add(6, 38, 1);
            Tab_Entradas.Rows.Add(10, 44, 1);
            Tab_Entradas.Rows.Add(3, 42, 1);
            Ncasos = Tab_Entradas.RowCount - 1;
        }

    }
}