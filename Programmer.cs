using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using ScientificCalculaor.Properties;

namespace ScientificCalculaor
{
    public partial class Programmer : MetroForm
    {
        public Programmer()
        {
            InitializeComponent();
        }

        private void Programmer_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button59.Enabled = false;
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button56_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("+"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            if ((textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("-"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("*"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button49_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("+")) && textBox1.Text.StartsWith("/"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            btnmin.Enabled = true;
            btnplus.Enabled = true;
            btnBin.Enabled = true;
            btnBin.BringToFront();
            btnHex.Enabled = false;
            btnOct.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            btnmin.Enabled = true;
            btnplus.Enabled = true;
            btnBin.Enabled = false;
            btnHex.Enabled = false;
            btnOct.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = false;
            btn9.Enabled = false;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnE.Enabled = false;
            btnF.Enabled = false;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            btnmin.Enabled = true;
            btnplus.Enabled = true;
            btnBin.Enabled = false;
            btnHex.Enabled = false;
            btnOct.Enabled = true;
            btnOct.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            btn0.Enabled = true;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnE.Enabled = true;
            btnF.Enabled = true;
            btndiv.Enabled = true;
            btnmul.Enabled = true;
            btnmin.Enabled = true;
            btnplus.Enabled = true;
            btnBin.Enabled = false;
            btnHex.Enabled = true;
            btnHex.BringToFront();
            btnOct.Enabled = false;
        }

        public static bool CheckValidBin(string my_string)
        {
            string array = "01";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckValidDec(string my_string)
        {
            string array = "0123456789";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckValidOct(string my_string)
        {
            string array = "01234567";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckValidHexa(string my_string)
        {
            string array = "0123456789ABCDEabcde";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button96_Click(object sender, EventArgs e)
        {
            if (CheckValidBin(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.bin_dec(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            if (CheckValidBin(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.bin_octal(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            if (CheckValidBin(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.bin_hexa(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (CheckValidDec(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.dec_bin(Convert.ToInt32(textBox2.Text));
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (CheckValidDec(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.dec_octal(Convert.ToInt32(textBox2.Text));
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (CheckValidDec(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.dec_hexa(Convert.ToInt32(textBox2.Text));
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (CheckValidOct(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.octal_bin(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (CheckValidOct(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.octal_dec(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (CheckValidOct(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.octal_hexa(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (CheckValidHexa(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.hexa_bin(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (CheckValidHexa(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.hexa_octal(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (CheckValidHexa(textBox1.Text) && textBox1.Text != string.Empty)
            {
                textBox2.Text += textBox1.Text;
                textBox1.Text = Programmer_Calculator.hexa_dec(textBox2.Text);
            }
            else
            {
                textBox1.Text = "";
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Equation f = new Equation();
            this.Hide();
            f.Show();
            f.BringToFront();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
            f.BringToFront();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Scientific f = new Scientific();
            this.Hide();
            f.Show();
            f.BringToFront();
        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button36.Image = Resources.delete_25px;
                panel2.Width += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button36.Image = Resources.menu_25px;
                panel2.Width -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button97.Image = Resources.Collapse_Arrow_20px;
                panel1.Height += 10;
                if (panel1.Size == panel1.MaximumSize)
                {
                    timer2.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button97.Image = Resources.Expand_Arrow_20px;
                panel1.Height -= 10;
                if (panel1.Size == panel1.MinimumSize)
                {
                    timer2.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button13.Image = Resources.Collapse_Arrow_20px;
                panel4.Height += 10;
                if (panel4.Size == panel4.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button13.Image = Resources.Expand_Arrow_20px;
                panel4.Height -= 10;
                if (panel4.Size == panel4.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button9.Image = Resources.Collapse_Arrow_20px;
                panel3.Height += 10;
                if (panel3.Size == panel3.MaximumSize)
                {
                    timer4.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button9.Image = Resources.Expand_Arrow_20px;
                panel3.Height -= 10;
                if (panel3.Size == panel3.MinimumSize)
                {
                    timer4.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timer4.Start();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            timer5.Start();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button17.Image = Resources.Collapse_Arrow_20px;
                panel5.Height += 10;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer5.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button17.Image = Resources.Expand_Arrow_20px;
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer5.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            if (CheckValidBinP(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.binary_arithmetic(textBox2.Text, '+');
            }
            else if (CheckValidBinM(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.binary_arithmetic(textBox2.Text, '-');
            }
            else if (CheckValidBinMul(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.binary_arithmetic(textBox2.Text, '*');
            }
            else if (CheckValidBinD(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.binary_arithmetic(textBox2.Text, '/');
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = textBox1.Text = string.Empty;
            }
        }
        public static bool CheckValidBinP(string my_string)
        {
            string array = "01+";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidBinM(string my_string)
        {
            string array = "01-";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidBinMul(string my_string)
        {
            string array = "01*";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidBinD(string my_string)
        {
            string array = "01/";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidOctP(string my_string)
        {
            string array = "01234567+";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidOctM(string my_string)
        {
            string array = "01234567-";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidOctMul(string my_string)
        {
            string array = "01234567*";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidOctD(string my_string)
        {
            string array = "01234567/";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidHexP(string my_string)
        {
            string array = "0123456789abcdefABCDEF+";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidHexM(string my_string)
        {
            string array = "0123456789abcdefABCDEF-";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidHexMul(string my_string)
        {
            string array = "0123456789abcdefABCDEF*";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CheckValidHexD(string my_string)
        {
            string array = "0123456789abcdefABCDEF/";

            int count = 0;
            for (int i = 0; i < my_string.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (my_string[i] == array[j])
                    {
                        count++;
                    }
                }
            }

            if (count == my_string.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnOct_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            if (CheckValidOctP(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.octal_arithmetic(textBox2.Text, '+');
            }
            else if (CheckValidOctM(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.octal_arithmetic(textBox2.Text, '-');
            }
            else if (CheckValidOctMul(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.octal_arithmetic(textBox2.Text, '*');
            }
            else if (CheckValidOctD(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.octal_arithmetic(textBox2.Text, '/');
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = textBox1.Text = string.Empty;
            }
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            if (CheckValidHexP(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.hexa_arithmetic(textBox2.Text, '+');
            }
            else if (CheckValidHexM(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.hexa_arithmetic(textBox2.Text, '-');
            }
            else if (CheckValidHexMul(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.hexa_arithmetic(textBox2.Text, '*');
            }
            else if (CheckValidHexD(textBox2.Text) && textBox2.Text != string.Empty)
            {
                textBox1.Text = Programmer_Calculator.hexa_arithmetic(textBox2.Text, '/');
            }
            else
            {
                MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = textBox1.Text = string.Empty;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            textBox1.Text += "F";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            textBox1.Text += "E";
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            textBox1.Text += "D";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text += "C";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            textBox1.Text += "B";
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            textBox1.Text += "A";
        }
    }
}
