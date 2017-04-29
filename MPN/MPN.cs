using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPN
{
    public partial class MPNCalc : Form
    {
        public MPNCalc()
        {
            InitializeComponent();
        }

        double dilution = 1;

        SortedList<int, double> tblMPN = new SortedList<int, double>
        {
            {000, 3.0 }, {001, 3.0}, {010, 3.0}, {011, 6.1},
            {020, 6.2}, {030, 9.4}, {100, 3.6}, {101, 7.2},
            {102, 11}, {110, 7.4}, {111, 11}, {120, 11},
            {121, 15}, {130, 16}, {200, 9.2}, {201, 14},
            {202, 20}, {210, 15}, {211, 20}, {212, 27},
            {220, 21}, {221, 28}, {222, 35}, {230, 29},
            {231, 36}, {300, 23}, {301, 38}, {302, 64},
            {310, 43}, {311, 75}, {312, 120}, {313, 160},
            {320, 93}, {321, 150}, {322, 210}, {323, 290},
            {330, 240}, {331, 460}, {332, 1100}, {333, 1100}
        };
        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
           
            if (IsValid())
            {
                string MPNkey = txtPOS1.Text + txtPOS2.Text + txtPOS3.Text;

                double MPN = tblMPN[int.Parse(MPNkey)];

                if (MPNkey == "000")
                {
                    txtMPN.Text = "<" + (MPN * dilution).ToString();
                }
                else if (MPNkey == "333")
                {
                    txtMPN.Text = ">" + (MPN * dilution).ToString();
                }
                else
                    txtMPN.Text = (MPN * dilution).ToString();
            }
        }
        
        private void btnLWR_Click(object sender, EventArgs e)
        {
            dilution = dilution * 10;
            txtDIL1.Text = (double.Parse(txtDIL1.Text) * 10).ToString();
            txtDIL2.Text = (double.Parse(txtDIL2.Text) * 10).ToString();
            txtDIL3.Text = (double.Parse(txtDIL3.Text) * 10).ToString();
        }

        private void btnHGHR_Click(object sender, EventArgs e)
        {
            dilution = dilution / 10;
            txtDIL1.Text = (double.Parse(txtDIL1.Text) / 10).ToString();
            txtDIL2.Text = (double.Parse(txtDIL2.Text) / 10).ToString();
            txtDIL3.Text = (double.Parse(txtDIL3.Text) / 10).ToString();
        }

        bool IsInt(TextBox textBox)
        {
            try
            {
                Convert.ToInt32(textBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Number of positive tests must be an integer value.", "Entry Error");
                textBox.Focus();
                return false;
            }
           
        }

        bool IsWithinRange(TextBox textBox, int min, int max)
        {
            int number = Convert.ToInt32(textBox.Text);
            if (number < min || number > max)
            {
                MessageBox.Show("Number of positive tests must be between " + min.ToString()
                    + " and " + max.ToString() + ".", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        bool Exists(string key)
        {
            
            if (tblMPN.ContainsKey(int.Parse(key)))
                return true;
            else
            {
                MessageBox.Show("Invalid test data.", "Entry Error");
                return false;
            }
        }

        bool IsValid()
        {
            return
                
                //POS1
                IsInt(txtPOS1) &&
                IsWithinRange(txtPOS1, 0, 3) &&                
                //POS2
                IsInt(txtPOS2) &&
                IsWithinRange(txtPOS2, 0, 3) &&
                //POS3
                IsInt(txtPOS3) &&
                IsWithinRange(txtPOS3, 0, 3) &&

                //Check for MPNkey
                Exists(txtPOS1.Text+txtPOS2.Text+txtPOS3.Text);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new frmAbout();
            newForm.Show();
        }
    }
}
