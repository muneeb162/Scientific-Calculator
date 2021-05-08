using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MetroFramework.Forms;
using ScientificCalculaor.Properties;

namespace ScientificCalculaor
{
    public partial class Form1 : Form
    {
        const int MaxN = 10; // the maximum allowable dimension of the matrix
        int n = 3; //dimension of the matrix, which user types on keyboard into control textBox1;
        TextBox[,] MatrText = null; // two-dimensional matrix of controls TextBox type. In this matrix is entered the cells of matrix as strings. The data entering will be formed in the form “Form2”.
        double[,] Matr1 = new double[MaxN, MaxN]; // matrices of elements of “double” type. Data will be copied from MatrText into Matr1
        double[,] Matr2 = new double[MaxN, MaxN]; // matrices of elements of “double” type. Data will be copied from MatrText into Matr2
        double[,] Matr3 = new double[MaxN, MaxN]; // the resulting matrix, which is equal to product of matrices Matr1 and Matr2
        bool f1; // flag, which indicates about that the data were entered into the matrix Matr1
        bool f2; // flag, which indicates about that the data were entered into the matrix Matr2
        int dx = 40, dy = 20; // width and height of cells in MatrText [,]
        Form2 form2 = null;   // an instance (object) of the class form "Form2"
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "";
            f1 = f2 = false; // matrices are not yet filled
            label2.Text = "false";
            label3.Text = "false";

            int i, j;
            form2 = new Form2();

            // Memory allocation for the whole matrix (not for cells)
            MatrText = new TextBox[MaxN, MaxN];

            // Memory allocation for each cell of the matrix and its setting
            for (i = 0; i < MaxN; i++)
                for (j = 0; j < MaxN; j++)
                {
                    // Allocate memory
                    //for the whole matrix MatrText as two - dimensional array;
                    //for every element of matrix, which is the object of type “TextBox”.
                    MatrText[i, j] = new TextBox();

                    //After allocating memory, for any object is carried out the setting of main internal properties (position, size, text and visibility).
                    //Also, every cell, which is created, is added (placed) on the form “Form2” using method Add() from class “Controls”. Every new cell can be added on the any other form of application.
                    //Set the value to zero
                    MatrText[i, j].Text = "0";

                    //Set the position of cell in the Form2
                    MatrText[i, j].Location = new System.Drawing.Point(10 + i * dx, 10 + j * dy);

                    //Set the size of cell
                    MatrText[i, j].Size = new System.Drawing.Size(dx, dy);

                    //Hide the cell
                    MatrText[i, j].Visible = false;
                    //Add MatrText[i,j] into the form2
                    form2.Controls.Add(MatrText[i, j]);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Reading of the matrix dimension
            if (textBox1.Text == "") return;
            n = int.Parse(textBox1.Text);

            // Clear Matrix
            Clear_MatrText();

            // Setting the properties of the matrix cells
            // with binding to the value of n and the form Form2
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    // Tab order
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    // Set the cell as visible
                    MatrText[i, j].Visible = true;
                }

            // Correcting of form size
            form2.Width = 10 + n * dx + 20;
            form2.Height = 10 + n * dy + form2.button1.Height + 50;

            // Correcting of the position and size of the button on the Form2
            form2.button1.Left = 10;
            form2.button1.Top = 10 + n * dy + 10;
            form2.button1.Width = form2.Width - 30;

            // Calling the form Form2
            if (form2.ShowDialog() == DialogResult.OK)
            {
                // Moving lines from the Form2 form into the matrix Matr1
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (MatrText[i, j].Text != "")
                        {
                            if (CheckValid(MatrText[i, j].Text))
                            {
                                Matr1[i, j] = Double.Parse(MatrText[i, j].Text);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Input that Input is considiring as zero");
                                Matr1[i, j] = 0;
                                f1 = false;
                            }
                        }
                        else
                            Matr1[i, j] = 0;
                    }
                }

                // Data were entered into matrix
                f1 = true;
                label2.Text = "true";
            }
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
        //In the listing above, the value of n is read.After that, is carry out the setting of cells of matrix MatrText.
        //Based on the inputted value of n are formed the sizes of form “form2” and position of button “button1”.
        //If, into the form “Form2”, user is pressed on the button “OK” (button2) then the rows from MatrText are
        //moved into the two-dimensional matrix “Matr1” of floating point numbers.Converting from string to the corresponding real number is performed by the method Paste() from the class Double.
        //Also, is formed the variable f1, which points that data were inputted into matrix “Matr1”.


        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") return;
            n = int.Parse(textBox1.Text);

            Clear_MatrText();


            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    MatrText[i, j].Visible = true;
                }

            form2.Width = 10 + n * dx + 20;
            form2.Height = 10 + n * dy + form2.button1.Height + 50;

            form2.button1.Left = 10;
            form2.button1.Top = 10 + n * dy + 10;
            form2.button1.Width = form2.Width - 30;


            if (form2.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (MatrText[i, j].Text != "")
                        {
                            if (CheckValid(MatrText[i, j].Text))
                            {
                                Matr2[i, j] = Double.Parse(MatrText[i, j].Text);
                            }
                            else
                            {
                                MessageBox.Show("Invalid Input that Input is considiring as zero");
                                Matr2[i, j] = 0;
                                f2 = false;
                            }
                        }
                        else
                            Matr2[i, j] = 0;
                    }
                }

                f2 = true;
                label3.Text = "true";
            }
        }

        //In the application may be a situation when the user changes n to a new value.In this case, the flags f1 and f2 must be set to the new values.Also, the size of matrix MatrText must be changed.
        //You can control the changing of value n using the event “Leave” of control textBox1. The event “Leave” is generated in time when control “textBox1” leaves the input focus
        private void textBox1_Leave(object sender, EventArgs e)
        {
            int nn;
            nn = Int16.Parse(textBox1.Text);
            if (nn != n)
            {
                f1 = f2 = false;
                label2.Text = "false";
                label3.Text = "false";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (!((f1 == true) && (f2 == true))) return;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr3[j, i] = 0;
                    for (int k = 0; k < n; k++)
                        Matr3[j, i] = Matr3[j, i] + Matr1[k, i] * Matr2[j, k];
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }

            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //FileStream fw = null;
            //string msg;
            //byte[] msgByte = null; // array of bytes

            //// 1. Open file for writing
            //fw = new FileStream("Res_Matr.txt", FileMode.Create);

            //// 2. Saving the matrix of result in file

            //// 2.1. Save the number of elements of the matrix Matr3
            //msg = n.ToString() + "\r\n";

            //// Converting the string msg into a byte array msgByte
            //msgByte = Encoding.Default.GetBytes(msg);

            //// save of array msgByte into the file
            //fw.Write(msgByte, 0, msgByte.Length);

            //// 2.2. Now saving of the matrix
            //msg = "";
            //for (int i = 0; i < n; i++)
            //{
            //    // forming of a string based on the matrix
            //    for (int j = 0; j < n; j++)
            //        msg = msg + Matr3[i, j].ToString() + "  ";
            //    msg = msg + "\r\n"; // new line
            //}

            //// 3. Converting the strings into a byte array
            //msgByte = Encoding.Default.GetBytes(msg);

            //// 4. Saving the strings into the file
            //fw.Write(msgByte, 0, msgByte.Length);

            //// 5. Close the file
            //if (fw != null) fw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!((f1 == true) && (f2 == true))) return;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr3[j, i] = Matr1[j, i] + Matr2[j, i];
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }

            form2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!((f1 == true) && (f2 == true))) return;

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    Matr3[j, i] = Matr1[j, i] - Matr2[j, i];
                }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    MatrText[i, j].TabIndex = i * n + j + 1;

                    MatrText[i, j].Text = Matr3[i, j].ToString();
                }

            form2.ShowDialog();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            Scientific f = new Scientific();
            this.Hide();
            f.Show();
            f.BringToFront();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            Equation f = new Equation();
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

        private void button101_Click(object sender, EventArgs e)
        {
            Programmer f = new Programmer();
            this.Hide();
            f.Show();
            f.BringToFront();
        }

        private void Clear_MatrText()
        {
            // Setting the cells of MatrText to zero
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    MatrText[i, j].Text = "0";
        }
        public static bool CheckValid(string my_string)
        {
            string array = "0123456789-. ";

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
    }
}
