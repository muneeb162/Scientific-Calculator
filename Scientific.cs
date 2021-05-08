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
    public partial class Scientific : MetroForm
    {
        public Scientific()
        {
            InitializeComponent();
            textBox1.Text = string.Empty; textBox2.Text = string.Empty;
        }
        Functions fun = new Functions();
        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
            button17.Text = "xʸ";
            button22.Text = "π";
            button102.Text = "π";
            button102.Hide();
            button26.Text = "x²";
            button30.Text = "x³";
            button32.Text = "³√";
            button54.Text = "x²";
            metroPanel1.Show();
            metroPanel2.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += button13.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += button14.Text;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += button19.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += button18.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Factorial");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("!", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("+"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
            if ((textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("-"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("*") || textBox2.Text.EndsWith("+")) && textBox1.Text.StartsWith("/"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
            if ((textBox2.Text.EndsWith("-") || textBox2.Text.EndsWith("+") || textBox2.Text.EndsWith("/")) && textBox1.Text.StartsWith("*"))
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text += "^";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = string.Empty;
            textBox1.Focus();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
            try
            {
                if (CheckValid(textBox2.Text))
                    textBox1.Text = InfixToPostfix.Calculate(textBox2.Text).ToString();
                else
                {
                    MessageBox.Show("Invalid Input Please Give The Input in Correct Form");
                    textBox2.Text = textBox1.Text = string.Empty;
                }
            }
            catch (MyException ex)
            {
                textBox1.Text = ex.MSG;
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + "(";
            textBox1.Text = string.Empty;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + ")";
            textBox1.Text = string.Empty;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Cube");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                x = Math.Pow(Convert.ToDouble(b), 3).ToString();
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Sqaure root");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("sqrt(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take exponential");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                x = Functions.Logarthimic_Function("e^(", Convert.ToDouble(b)).ToString();
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3.14285";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            metroPanel1.Hide();
            metroPanel2.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            textBox1.Text += "`";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            string b = "", c = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Inverse");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                c = "1/";
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                textBox2.Text += c + b; ;
                textBox1.Text = string.Empty;
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Cube root");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("cbrt(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Log");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("log(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Ln");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("ln(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            //treeView1.Visible = true;
            timer3.Start();
        }

        // Unused Code
        //private void timer1_Tick(object sender, EventArgs e)
        //{
        //    if (hide)
        //    {
        //        Spanel.Width = Spanel.Width + 20;
        //        if (Spanel.Width >= PW)
        //        {
        //            timer1.Stop();
        //            hide = false;
        //            this.Refresh();
        //        }
        //    }
        //    else
        //    {
        //        Spanel.Width = 0;
        //        if (Spanel.Width <= 20)
        //        {
        //            timer1.Stop();
        //            hide = true;
        //            this.Refresh();
        //        }
        //    }
        //}

        private void Spanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //if (e.Node.Name == "Node3")
            //{
            //    label1.Text = "Scientific Calculator";
            //    treeView1.Visible = false;
            //    textBox1.Focus();
            //}
            //if (e.Node.Name == "Node4")
            //{
            //    label1.Text = "Matrix Calculator";
            //    treeView1.Visible = false;
            //    textBox1.Focus();
            //}
            //if (e.Node.Name == "Node5")
            //{
            //    label1.Text = "Equation Calculator";
            //    treeView1.Visible = false;
            //    textBox1.Focus();
            //}
            //if (e.Node.Name == "Node6")
            //{
            //    label1.Text = "Programmer Calculator";
            //    treeView1.Visible = false;
            //    textBox1.Focus();
            //}
        }

        private void button28_Click(object sender, EventArgs e)
        {
            string b = ""; double x = 0;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Abs");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Math.Abs(Convert.ToDouble(b));
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x.ToString();
                textBox1.Text = string.Empty;
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Exp");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = "*10^" + textBox1.Text;
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Sqaure");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                x = Math.Pow(Convert.ToDouble(b), 2).ToString();
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            metroPanel1.Show();
            metroPanel2.Hide();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox1.Text += button61.Text;
        }
        private bool isCollapsed;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button72.Image = Resources.Collapse_Arrow_20px;
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button72.Image = Resources.Expand_Arrow_20px;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button72_Click(object sender, EventArgs e)
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                button36.Image = Resources.delete_25px;
                panel2.Width += 10;
                if (panel2.Size == panel2.MaximumSize)
                {
                    timer3.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                button36.Image = Resources.menu_25px;
                panel2.Width -= 10;
                if (panel2.Size == panel2.MinimumSize)
                {
                    timer3.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take nCr\nlike that n=3 & r=2 so write in textbox like 3,2 and press nCr button");
                textBox1.Focus();
            }
            else if (textBox1.Text.Contains("`"))
            {
                MessageBox.Show("Math Error n and r not in negative number");
                textBox1.Focus();
            }
            else
            {
                //b = textBox1.Text;
                //if (b.Contains("`"))
                //{
                //    b = b.Replace("`", "-");
                //}
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = fun.nCr(Convert.ToDouble(addAndFive), Convert.ToDouble(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button63_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take nPr\nlike that n=3 & r=2 so write in textbox like 3,2 and press nPr button");
                textBox1.Focus();
            }
            else if (textBox1.Text.Contains("`"))
            {
                MessageBox.Show("Math Error n and r not in negative number");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = fun.nPr(Convert.ToDouble(addAndFive), Convert.ToDouble(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take GCD\nlike that n1=3 & n2=2 so write in textbox like 3,2 and press GCD button");
                textBox1.Focus();
            }
            else
            {
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = fun.GCD(Convert.ToInt32(addAndFive), Convert.ToInt32(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take LCM\nlike that n1=3 & n2=2 so write in textbox like 3,2 and press LCM button");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = fun.LCM(Convert.ToInt32(addAndFive), Convert.ToInt32(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take MOD\nlike that n1=3 & n2=2 so write in textbox like 3,2 and press MOD button");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = (Convert.ToInt32(addAndFive) % Convert.ToInt32(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Root of N\nlike that number=3 & power=2 so write in textbox like 3,2 and press ⁿ√ button");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToDouble(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c));
                    x = fun.root_of_power(Convert.ToDouble(addAndFive), Convert.ToInt32(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take logₙN\nlike that n=3 & N=2 so write in textbox like 3,2 and press logₙN button");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    var addAndFive = s.Split(',')[0].Split('*').Sum(c => Convert.ToInt32(c));
                    var addAndTwo = s.Split(',').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToDouble(c));
                    x = fun.LognN(Convert.ToInt32(addAndFive), Convert.ToDouble(addAndTwo)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
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

        private void button54_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Sqaure");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                x = Math.Pow(Convert.ToDouble(b), 2).ToString();
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
            //string x = "", b = "";
            //if (textBox1.Text == string.Empty)
            //{
            //    MessageBox.Show("Please enter the value first for which you want to take Exp");
            //    textBox1.Focus();
            //}
            //else
            //{
            //    b = textBox1.Text;
            //    if (b.Contains("`"))
            //    {
            //        b = b.Replace("`", "-");
            //    }
            //    try
            //    {
            //        x = "*10^" + textBox1.Text;
            //    }
            //    catch (MathError ex)
            //    {
            //        textBox2.Text = ex.MSG;
            //    }
            //    textBox2.Text += x;
            //    textBox1.Text = string.Empty;
            //}
        }

        private void button62_Click(object sender, EventArgs e)
        {
            string b = ""; double x = 0;
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Abs");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Math.Abs(Convert.ToDouble(b));
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x.ToString();
                textBox1.Text = string.Empty;
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            string b = "", c = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Inverse");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                c = "1/";
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                textBox2.Text += c + b;
                textBox1.Text = string.Empty;
            }
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

        private void button45_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text;
            textBox1.Text = string.Empty;
            try
            {
                if (CheckValid(textBox2.Text))
                {
                    textBox1.Text = InfixToPostfix.Calculate(textBox2.Text).ToString();
                }
                else
                {
                    MessageBox.Show("Invalid Input Please Give The Input in Correct Form");
                    textBox2.Text = textBox1.Text = string.Empty;
                }
            }
            catch (MyException ex)
            {
                textBox1.Text = ex.MSG;
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            textBox1.Text += button41.Text;
        }

        private void button43_Click(object sender, EventArgs e)
        {
            textBox1.Text += button43.Text;
        }

        private void button37_Click(object sender, EventArgs e)
        {
            textBox1.Text += "`";
        }

        private void button39_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Ln");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("ln(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            textBox1.Text += button53.Text;
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox1.Text += button57.Text;
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox1.Text += button71.Text;
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox1.Text += button68.Text;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox1.Text += button64.Text;
        }

        private void button52_Click(object sender, EventArgs e)
        {
            textBox1.Text += button52.Text;
        }

        private void button48_Click(object sender, EventArgs e)
        {
            textBox1.Text += button48.Text;
        }

        private void button44_Click(object sender, EventArgs e)
        {
            textBox1.Text += button44.Text;
        }

        private void button65_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Factorial");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    x = Functions.Logarthimic_Function("!", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + ")";
            textBox1.Text = string.Empty;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            textBox2.Text += textBox1.Text + "(";
            textBox1.Text = string.Empty;
        }

        private void button74_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take sin");
                textBox1.Focus();
            }
            else
            {
                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(b).ToString();
                    }
                    x = Functions.TRIGNOMETRY("sin(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button76_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take cosine");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("cos(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button78_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take tangent");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(b).ToString();
                    }
                    x = Functions.TRIGNOMETRY("tan(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take secant");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("sec(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button77_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take cosec");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("cosec(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button79_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take cot");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("cot(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button84_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Asin");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("asin(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button82_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Acos");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("acos(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button80_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Atan");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("atan(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button83_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Asec");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("asec(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button81_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Acosec");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("acosec(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Acot");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("Acot(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            button102.Show();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*3.142";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button102.Hide();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take sinh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("sinh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button92_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take cosh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("cosh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button88_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take tanh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("tanh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button94_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take sech");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("sech(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button90_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take cosech");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("cosech(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button86_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take coth");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("coth(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button95_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take Asinh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("asinh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button91_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take acosh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("acosh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button87_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take atanh");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("atanh(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button93_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take asech");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("asech(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button89_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take acosec");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("acosech(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }

        private void button85_Click(object sender, EventArgs e)
        {
            string x = "", b = "";
            if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Please enter the value first for which you want to take acoth");
                textBox1.Focus();
            }
            else
            {

                b = textBox1.Text;
                if (b.Contains("`"))
                {
                    b = b.Replace("`", "-");
                }
                try
                {
                    if (radioButton2.Checked)
                    {
                        b = ((Convert.ToDouble(b) * Math.PI) / 180).ToString();
                    }
                    else
                    {
                        b = InfixToPostfix.Calculate(textBox1.Text).ToString();
                    }
                    x = Functions.TRIGNOMETRY("acoth(", Convert.ToDouble(b)).ToString();
                }
                catch (MathError ex)
                {
                    textBox2.Text = ex.MSG;
                }
                textBox2.Text += x;
                textBox1.Text = string.Empty;
            }
        }
        public static bool CheckValid(string my_string)
        {
            string array = "0123456789+-*/^().` ";

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

        private void button99_Click_1(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
            f.BringToFront();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            Programmer f = new Programmer();
            this.Hide();
            f.Show();
            f.BringToFront();
        }
    }
}
