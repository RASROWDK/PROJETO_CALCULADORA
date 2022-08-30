using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROJETO_CALCULADORA
{
    public partial class Form1 : Form
    {
        public bool soma { get; set; }

        public bool porcentagem { get; set; }

        public bool subtracao { get; set; } 
        
        public bool multiplicacao { get; set; }

        public bool raiz { get; set; }
 
        public bool divisao { get; set; }

        public decimal num1 { get; set; }

        public decimal num2 { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "1";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            txtBox1.Text += ",";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var resultado = Convert.ToDecimal(txtBox1.Text) * -1;
            txtBox1.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDecimal(txtBox1.Text);
            if (soma)
            {
                var resultado = num1 + num2;
                txtBox1.Text = resultado.ToString();
                soma = false;
            }
            else if (divisao)
            {
                var resultado = num1 / num2;
                txtBox1.Text = resultado.ToString();
                divisao = false;
            }
            else if (multiplicacao)
            {
                var resultado = num1 * num2;
                txtBox1.Text = resultado.ToString();
                multiplicacao = false;
            }
            else if (subtracao)
            {
                var resultado = num1 - num2;
                txtBox1.Text = resultado.ToString();
                subtracao = false;

            } 
            else if(porcentagem){

                var resultado = num1 / 100 * num2;
                txtBox1.Text = resultado.ToString();
                porcentagem = false;

            }
            else if (raiz)
            {        
                var resultado = Math.Sqrt((double)num1);
                txtBox1.Text = resultado.ToString();
              
            }
            

        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "7";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "8";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "6";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "2";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "3";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            txtBox1.Text += "0";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            txtBox1.Text = "";
        }

        public void button17_Click(object sender, EventArgs e)
        {
            soma = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = "";
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var resultado = Convert.ToDecimal(txtBox1.Text) * Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = resultado.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            subtracao = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            divisao = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            multiplicacao = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var numero = txtBox1.Text;
            txtBox1.Text = numero.Remove(numero.Length -1);
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            porcentagem = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
            txtBox1.Text = ""; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            raiz = true;
            num1 = Convert.ToDecimal(txtBox1.Text);
           
        }
    }
}
