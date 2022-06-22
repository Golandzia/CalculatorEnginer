using System;
using static System.Math;
using System.Windows.Forms;

namespace CalculatorEnginer
{
    public partial class Form1 : Form
    {
        double memory, preresult;
        bool addition, subtraction, multiplication, division;
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button_1_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "1";
        }//ready

        private void button_2_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "2";
        }//ready

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "3";
        }//ready

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "4";
        }//ready

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "5";
        }//ready

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "6";
        }//ready

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "7";
        }//ready

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "8";
        }//ready

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "9";
        }//ready

        private void button_0_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.EndsWith("0") && !textbox_Output.Text.Contains(".") && textbox_Output.Text.StartsWith("0")) { }
            else textbox_Output.Text = textbox_Output.Text + "0";
        }//ready

        private void button_Point_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.Contains(".")) { }
            else textbox_Output.Text = textbox_Output.Text + ".";

        }//ready

        private void button_C_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = "";
        }//ready

        private void button_delOneSymbol_Click(object sender, EventArgs e)
        {
            try { textbox_Output.Text = textbox_Output.Text.Remove(textbox_Output.Text.Length - 1); }
            catch (Exception) { }
        }//ready

        private void button_off_Click(object sender, EventArgs e)
        {
            this.Close();
        }//ready

        private void button_equil_Click(object sender, EventArgs e)
        {
            if(addition)
            {
                textbox_Output.Text = Convert.ToString(preresult + Convert.ToDouble(textbox_Output.Text));
                addition = false;
                if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
            }//ready
            if(subtraction)
            {
                textbox_Output.Text = Convert.ToString(preresult - Convert.ToDouble(textbox_Output.Text));
                subtraction = false;
                if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
            }//ready
            if(division)
            {
                textbox_Output.Text = Convert.ToString(preresult / Convert.ToDouble(textbox_Output.Text));
                division = false;
                if (textbox_Output.Text == "не число" && textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
            }//ready
            if(multiplication)
            {
                textbox_Output.Text = Convert.ToString(Convert.ToDouble(Pow(preresult, Convert.ToInt32(textbox_Output.Text))));
                multiplication = false;
                if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
            }//ready
        }

        private void button_Plus_Click(object sender, EventArgs e)
        {
            preresult = Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = "";
            addition = true;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_minus_Click(object sender, EventArgs e)
        {
            preresult = Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = "";
            subtraction = true;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_multiply_Click(object sender, EventArgs e)
        {
            preresult = Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = "";
            multiplication = true;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Mod_Click(object sender, EventArgs e)
        {
            if (textbox_Output.Text.StartsWith("-"))
                textbox_Output.Text = textbox_Output.Text.Remove(0, 1);
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_PlusMinusChange_Click(object sender, EventArgs e)
        {
            if (!textbox_Output.Text.StartsWith("-"))
                textbox_Output.Text = textbox_Output.Text.Insert(0, "-");
            else textbox_Output.Text = textbox_Output.Text.Remove(0, 1);
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Ln_Click(object sender, EventArgs e)
        {
            textbox_Output.Text =Convert.ToString(Log(Convert.ToDouble(textbox_Output.Text)));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Lg_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString(Log10(Convert.ToDouble(textbox_Output.Text)));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Lg2_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString(Log(Convert.ToDouble(textbox_Output.Text), 2));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Factorial_Click(object sender, EventArgs e)
        {
            double fact = 0;
            for (int i = 1; i <= preresult; i++)
            {
                fact = preresult * i;
            }
            textbox_Output.Text = Convert.ToString(fact);
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Persent_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString((preresult * Convert.ToDouble(textbox_Output.Text)) / 100);
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_degree_Click(object sender, EventArgs e)
        {
            preresult = Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = "";
            multiplication = true;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_root_Click(object sender, EventArgs e)
        {
             textbox_Output.Text = Convert.ToString(Sqrt(preresult));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Sin_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString(Sin(Convert.ToDouble(textbox_Output.Text)));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Tan_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString(Tan(Convert.ToDouble(textbox_Output.Text)));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Ex_Click(object sender, EventArgs e)
        {
            preresult =Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = Convert.ToString(Pow(E, preresult));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_Cos_Click(object sender, EventArgs e)
        {
            textbox_Output.Text= Convert.ToString(Cos(Convert.ToDouble(textbox_Output.Text)));
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_devide_Click(object sender, EventArgs e)
        {
            preresult = Convert.ToDouble(textbox_Output.Text);
            textbox_Output.Text = "";
            division = true;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_RecMem_Click(object sender, EventArgs e)
        {
            try
            {
                label_IsMemoryUsed.Visible = true;
                memory = Convert.ToDouble(textbox_Output.Text);
            }
            catch (Exception) { }
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_ReadMem_Click(object sender, EventArgs e)
        {
            textbox_Output.Text = Convert.ToString(memory);
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        private void button_DelFromMem_Click(object sender, EventArgs e)
        {
            memory = 0;
            label_IsMemoryUsed.Visible = false;
            if (textbox_Output.Text == "не число" || textbox_Output.Text == "∞") textbox_Output.Text = "ERROR";
        }//ready

        
    }
}
