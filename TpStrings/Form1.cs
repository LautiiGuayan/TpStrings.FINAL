using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TpStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B3_Click(object sender, EventArgs e)
        {

            string separar = " ";

            T3.Text = T1.Text + separar + T2.Text;

        }

        private void B1_Click(object sender, EventArgs e)
        {
            int caracteres = 0;
            caracteres = T3.Text.Length;

            LONGITUD.Text = caracteres.ToString();
        }

        private void B2_Click(object sender, EventArgs e)
        {
            T1.Text = "";
            T2.Text = "";
            T3.Text = "";
            LONGITUD.Text = " ";
            extraer1.Text = "";
        }

        private void MAYUSCULA_Click(object sender, EventArgs e)
        {

            T3.Text = T3.Text.ToUpper();
        }

        private void minuscula_Click(object sender, EventArgs e)
        {
            T3.Text = T3.Text.ToLower();
        }

        private void EXTRAER_Click(object sender, EventArgs e)
        {
            T3.Text = T3.Text.Replace(extraer1.Text, "");
        }

        private void RESTA_Click(object sender, EventArgs e)
        {
            int a, b, restar;

            a = int.Parse(T1.Text);
            b = int.Parse(T2.Text);
            restar = a - b;


            T3.Text = restar.ToString();

        }

        private void suma_Click(object sender, EventArgs e)
        {
            int a, b, sumar;

            a = int.Parse(T1.Text);
            b = int.Parse(T2.Text);
            sumar = a + b;


            T3.Text = sumar.ToString();
        }

        private void CERRAR_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
