using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        //Objeto randomizer par generar numeros aleatorios
        Random randomizer = new Random();

        //Variables enteros para guardar numeros 
        //De cada operacion matematica
        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        //Variable para el tiempo restante
        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }
        public void StartTheQuiz()
        {
            //Rellenar los label con Operacion Suma
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            lblPlusLeft.Text = addend1.ToString();
            lblPlusRight.Text = addend2.ToString();
            Sum.Value = 0;

            //Rellenar los label con Operacion Resta
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            lblMinusLeft.Text = minuend.ToString();
            lblMinusRight.Text = subtrahend.ToString();
            Difference.Value = 0;

            //Rellenar los label con Operacion Multiplicacion
            multiplicand = randomizer.Next(1, 12);
            multiplier = randomizer.Next(1, 12);
            lblTimesLeft.Text = multiplicand.ToString();
            lblTimesRight.Text = multiplier.ToString();
            Product.Value = 0;

            //Rellenar los label con Operacion Division
            divisor = randomizer.Next(1, 12);
            int temporaryQuotient = randomizer.Next(1, 12);
            dividend = divisor * temporaryQuotient;
            lblLeftDivide.Text = dividend.ToString();
            lblRightDivide.Text = divisor.ToString();
            Quotient.Value = 0;

            //Empieza el temporizador
            timeLeft = 30;
            lblTime.Text = "60 Seconds";
            timer1.Start();

            //Las casillas de numericupdown empezaran en blanco
            Sum.Text = "";
            Difference.Text = "";
            Product.Text = "";
            Quotient.Text = "";

        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == Sum.Value)
                && (minuend - subtrahend == Difference.Value)
                && (multiplicand * multiplier == Product.Value)
                && (dividend / divisor == Quotient.Value))
                return true;
            else
                return false;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            BtnStart.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                timer1.Stop();
                MessageBox.Show("Todas las respuestas son correctas",
                    "Felicidades!");
                BtnStart.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                lblTime.Text = timeLeft + "Seconds";
            }
            else
            {
                timer1.Stop();
                lblTime.Text = "Agotado!";
                MessageBox.Show("Usted no termino a tiempo.", "Sorry!");
                Sum.Value = addend1 + addend2;
                Difference.Value = minuend - subtrahend;
                Product.Value = multiplicand * multiplier;
                Quotient.Value = dividend / divisor;
                BtnStart.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lenghtOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lenghtOfAnswer);
            }
        }

        private void lblTime_Click(object sender, EventArgs e)
        {
            if (timeLeft < 6)
            {
                lblTime.Text = "5 Seconds";
                lblTime.BackColor = Color.Red;
            }
            else
            {
                lblTime.BackColor = Color.WhiteSmoke;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

