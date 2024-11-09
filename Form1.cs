using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatorr
{
    public partial class Form1 : Form
    {

        double val = 0;
        string text = "";
        bool oper_press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((output.Text == "0")||(oper_press))
            {
                output.Clear();
            }
            Button button = (Button)sender;
            output.Text = output.Text + button.Text;
        }

        private void button2_click(object sender, EventArgs e)
        {
            output.Text = "0";
        }

        private void opres(object sender, EventArgs e)
        {

        }

        private void op_pres(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            text = button.Text;
            val = double.Parse(output.Text);
            oper_press = true;
        }

        private void op_res(object sender, EventArgs e)
        {
            switch(text)
            {
                case "+":
                    output.Text = (val + double.Parse(output.Text)).ToString();
                    break;
                case "-":
                    output.Text = (val - double.Parse(output.Text)).ToString();
                    break;
                case "/":
                    output.Text = (val / double.Parse(output.Text)).ToString();
                    break;
                case "x":
                    output.Text = (val * double.Parse(output.Text)).ToString();
                    break;
                default:
                    break;
            }
            oper_press = false;
        }

        private void c_pres(object sender, EventArgs e)
        {
            output.Clear();
            val = 0;
        }
    }
}
