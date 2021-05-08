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
    public partial class Equation : MetroForm
    {
        public Equation()
        {

            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            metroPanel1.Visible = false;
            metroPanel2.Visible = false;
            metroPanel3.Visible = false;
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (metroComboBox1.SelectedItem.ToString() == "aₙX+bₙY=cₙ")
            //{
            //    groupBox1.Visible = true;
            //}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "aₙX+bₙY=cₙ")
            {
                metroPanel3.Visible = false;
                metroPanel1.Visible = false;
                metroPanel2.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "ax²+bx+c")
            {
                metroPanel3.Visible = false;
                metroPanel2.Visible = false;
                metroPanel1.Visible = true;
            }
            if (comboBox1.SelectedItem.ToString() == "aₙX+bₙY+cₙZ=dₙ")
            {
                metroPanel2.Visible = false;
                metroPanel1.Visible = false;
                metroPanel3.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty || textBox5.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!CheckValid(textBox1.Text) || !CheckValid(textBox2.Text) || !CheckValid(textBox3.Text) || !CheckValid(textBox4.Text) || !CheckValid(textBox5.Text) || !CheckValid(textBox6.Text))
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                //anX+bnY=cn
                double A = double.Parse(textBox1.Text);
                double B = double.Parse(textBox2.Text);
                double C = double.Parse(textBox3.Text);
                double D = double.Parse(textBox4.Text);
                double E = double.Parse(textBox5.Text);
                double F = double.Parse(textBox6.Text);
                try
                {
                    double x, y;
                    // equate the variable in terms of the constant
                    y = ((A * F) - (C * D)) / ((A * E) - (B * D));
                    if (A == 0) { x = (F - (E * y)) / D; }
                    else { x = (C - (B * y)) / A; }
                    textBox7.Text = x.ToString();
                    textBox8.Text = y.ToString();
                }
                catch
                {
                    MessageBox.Show("Input is either wrong or not a simultaneous equation" + MessageBoxIcon.Error + MessageBoxButtons.YesNo);
                }
            }

        }
        public static bool CheckValid(string my_string)
        {
            string array = "0123456789.-";

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox9.Text == string.Empty || textBox16.Text == string.Empty || textBox11.Text == string.Empty)
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!CheckValid(textBox9.Text) || !CheckValid(textBox16.Text) || !CheckValid(textBox11.Text))
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                double a, b, c, real, determinant, root1, root2, imaginaryPart;
                Console.WriteLine("Enter values of a, b and c: ");
                a = double.Parse(textBox9.Text);
                b = double.Parse(textBox16.Text);
                c = double.Parse(textBox11.Text);


                if (a != 0 || b != 0 || c != 0)
                {
                    determinant = b * b - 4 * a * c;
                    real = -b / (2 * a);
                    //real and different roots
                    if (determinant > 0)
                    {
                        root1 = real + Math.Sqrt(determinant) / (2 * a);
                        root2 = real - Math.Sqrt(determinant) / (2 * a);
                        textBox15.Text = Math.Round(root1, 3).ToString();
                        textBox10.Text = Math.Round(root2, 3).ToString();
                    }
                    //real and equal roots
                    else if (determinant == 0)
                    {
                        root1 = root2 = real;
                        textBox15.Text = Math.Round(root1, 3).ToString();
                        textBox10.Text = Math.Round(root2, 3).ToString();
                    }
                    //not real
                    else if (determinant < 0)
                    {
                        imaginaryPart = Math.Sqrt(-determinant) / (2 * a);
                        textBox15.Text = Math.Round(real, 3) + "+" + Math.Round(imaginaryPart, 3) + "i";
                        textBox10.Text = Math.Round(real, 3) + "-" + Math.Round(imaginaryPart, 3) + "i";

                    }
                }
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox12.Text == string.Empty || textBox13.Text == string.Empty || textBox17.Text == string.Empty || textBox18.Text == string.Empty || textBox19.Text == string.Empty
                || textBox20.Text == string.Empty || textBox22.Text == string.Empty || textBox23.Text == string.Empty || textBox25.Text == string.Empty || textBox26.Text == string.Empty
                || textBox27.Text == string.Empty || textBox28.Text == string.Empty)
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else if (!CheckValid(textBox12.Text) || !CheckValid(textBox13.Text) || !CheckValid(textBox17.Text) || !CheckValid(textBox18.Text) || !CheckValid(textBox19.Text)
                     || !CheckValid(textBox20.Text) || !CheckValid(textBox22.Text) || !CheckValid(textBox23.Text) || !CheckValid(textBox25.Text) || !CheckValid(textBox26.Text)
                     || !CheckValid(textBox27.Text) || !CheckValid(textBox28.Text))
            {
                MessageBox.Show("Please Give the Input in Correct form", "Error Occurred", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                double[,] coeff = {{Convert.ToDouble(textBox12.Text), Convert.ToDouble(textBox13.Text), Convert.ToDouble(textBox20.Text), Convert.ToDouble(textBox23.Text) },
                        { Convert.ToDouble(textBox17.Text), Convert.ToDouble(textBox18.Text), Convert.ToDouble(textBox19.Text), Convert.ToDouble(textBox22.Text) },
                        { Convert.ToDouble(textBox27.Text), Convert.ToDouble(textBox26.Text), Convert.ToDouble(textBox25.Text), Convert.ToDouble(textBox28.Text) }};
                findSolution(coeff);
            }
        }
        // This functions finds the determinant of Matrix
        static double determinantOfMatrix(double[,] mat)
        {
            double ans;
            ans = mat[0, 0] * (mat[1, 1] * mat[2, 2] - mat[2, 1] * mat[1, 2])
                - mat[0, 1] * (mat[1, 0] * mat[2, 2] - mat[1, 2] * mat[2, 0])
                + mat[0, 2] * (mat[1, 0] * mat[2, 1] - mat[1, 1] * mat[2, 0]);
            return ans;
        }

        // This function finds the solution of system of
        // linear equations using cramer's rule
        public void findSolution(double[,] coeff)
        {
            // Matrix d using coeff as given in cramer's rule
            double[,] d = {
        { coeff[0,0], coeff[0,1], coeff[0,2] },
        { coeff[1,0], coeff[1,1], coeff[1,2] },
        { coeff[2,0], coeff[2,1], coeff[2,2] },
            };

            // Matrix d1 using coeff as given in cramer's rule
            double[,] d1 = {
        { coeff[0,3], coeff[0,1], coeff[0,2] },
        { coeff[1,3], coeff[1,1], coeff[1,2] },
        { coeff[2,3], coeff[2,1], coeff[2,2] },
            };

            // Matrix d2 using coeff as given in cramer's rule
            double[,] d2 = {
        { coeff[0,0], coeff[0,3], coeff[0,2] },
        { coeff[1,0], coeff[1,3], coeff[1,2] },
        { coeff[2,0], coeff[2,3], coeff[2,2] },
            };

            // Matrix d3 using coeff as given in cramer's rule
            double[,] d3 = {
        { coeff[0,0], coeff[0,1], coeff[0,3] },
        { coeff[1,0], coeff[1,1], coeff[1,3] },
        { coeff[2,0], coeff[2,1], coeff[2,3] },
            };

            // Calculating Determinant of Matrices d, d1, d2, d3
            double D = determinantOfMatrix(d);
            double D1 = determinantOfMatrix(d1);
            double D2 = determinantOfMatrix(d2);
            double D3 = determinantOfMatrix(d3);
            //MessageBox.Show("D is :  " + D);
            //MessageBox.Show("D1 is :  " + D1);
            //MessageBox.Show("D2 is :  " + D2);
            //MessageBox.Show("D3 is :  " + D3);

            // Case 1
            if (D != 0)
            {
                Equation fo2 = new Equation();
                // Coeff have a unique solution. Apply Cramer's Rule
                double x = D1 / D;
                double y = D2 / D;
                double z = D3 / D; // calculating z using cramer's rule'
                textBox14.Text = Math.Round(x, 3).ToString();
                textBox21.Text = Math.Round(y, 3).ToString();
                textBox24.Text = Math.Round(z, 3).ToString();
                //MessageBox.Show("Value of x is : " + x);
                //MessageBox.Show("Value of y is : " + y);
                //MessageBox.Show("Value of z is : " + z);
            }

            // Case 2
            else
            {
                if (D1 == 0 && D2 == 0 && D3 == 0)
                    MessageBox.Show("Infinite solutions\n");
                else if (D1 != 0 || D2 != 0 || D3 != 0)
                    MessageBox.Show("No solutions\n");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            timer1.Start();
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

        private void button98_Click(object sender, EventArgs e)
        {
            Scientific f = new Scientific();
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
