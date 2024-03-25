using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Listbox_Lookup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "")
            {
                MessageBox.Show("Please Input Something");
            }
            else
            {
                listBox1.Items.Add(txtInput.Text);
                MessageBox.Show("Added to records");
                txtInput.Text = string.Empty;
            }
        }
        private void btnSort_Click(object sender, EventArgs args)
        {
            listBox1.Sorted = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (txtInput.Text == "")
                {
                    listBox1.Items.RemoveAt(0);
                }
                else
                {
                    int number;
                    try
                    {
                        if (int.TryParse(txtInput.Text, out number))
                        {
                            number = Convert.ToInt32(txtInput.Text);
                            if (number <= listBox1.Items.Count)
                            {
                                listBox1.Items.RemoveAt(number);
                            }
                            else MessageBox.Show("Invalid Position");
                        }
                    }
                    catch (ArithmeticException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else MessageBox.Show("There's nothing to delete!");
        }

        private void btnChangeForColor_Click(object sender, EventArgs e)
        {
            string colorName = txtInput.Text;
            Color c = listBox1.ForeColor;
            if (Color.FromName(colorName).IsKnownColor || colorName.StartsWith("#") || colorName.StartsWith("0x"))
            {
                try
                {
                    c = ColorTranslator.FromHtml(colorName);
                }catch(Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
                listBox1.ForeColor = c;
            }
        }

        private void btnChangeBackColor_Click(object sender, EventArgs e)
        {
            string colorName = txtInput.Text;
            Color c = listBox1.BackColor;
            if (colorName.StartsWith("#") || colorName.StartsWith("0x") || Color.FromName(colorName).IsKnownColor)
            {
                try
                {
                    c = ColorTranslator.FromHtml(colorName);
                }catch(Exception ex)
                {
                    MessageBox.Show("Err : " + ex.Message);
                }
            }
            listBox1.BackColor = c;
        }
        private void btnResize_Click(object sender, EventArgs e)
        {
            
            if (listBox1.Size == new System.Drawing.Size(200,100) )
            {
                listBox1.Size = new System.Drawing.Size(300, 200);
            }
            else
            {
                listBox1.Size = new System.Drawing.Size(200, 100);
            }
        }
    }
}
