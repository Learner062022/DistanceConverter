using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DylanDeSouzaAssignment1
{
    public partial class frmDistanceConverter : Form
    {
        public frmDistanceConverter()
        {
            InitializeComponent();
        }
        const double INCHES_CENTIMETRES = 2.54D, FOOT_METRES = 0.3048D, YARD_METRES = 0.9144D, MILES_KILOMETRES = 1.609D;
        int intInchesCentimetres, intFeetMetres, intYardsMetres, intMilesKilometres;
        float fltInchesCentimetres, fltFeetMetres, fltYardsMetres, fltMilesKilometres;
        double dblInchesCentimetres, dblFeetMetres, dblYardsMetres, dblMilesKilometres;

        private void txtEnteredValue_Leave(object sender, EventArgs e)
        {
            lblEnteredValue.Visible = true;
            txtConversion.Visible = true;
            lblConversion.Visible = true;
            lblEquals.Visible = true;
        }

        private void txtEnteredValue_Enter(object sender, EventArgs e)
        {
            lblEnteredValue.Visible = false;
            txtConversion.Visible = false;
            lblConversion.Visible = false;
            lblEquals.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmDistanceConverter.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblEnteredValue.Text = ("inches");
            lblConversion.Text = ("centimetres");
            
            if (txtEnteredValue.TextLength != 0)
            {
                if (int.TryParse(txtEnteredValue.Text, out intInchesCentimetres))
                {
                    if (intInchesCentimetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative number");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblInchesCentimetres = intInchesCentimetres * INCHES_CENTIMETRES;
                        txtConversion.Text = dblInchesCentimetres.ToString();
                    }
                }
                else if (float.TryParse(txtEnteredValue.Text, out fltInchesCentimetres))
                {
                    if (dblInchesCentimetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative number");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblInchesCentimetres = fltInchesCentimetres * INCHES_CENTIMETRES;
                        txtConversion.Text = dblInchesCentimetres.ToString();
                    }
                }
                else if (double.TryParse(txtEnteredValue.Text, out dblInchesCentimetres))
                {
                    if (dblInchesCentimetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative number");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblInchesCentimetres = dblInchesCentimetres * INCHES_CENTIMETRES;
                        txtConversion.Text = dblInchesCentimetres.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("The entry must be numeric - please re - enter a value");
                    txtEnteredValue.Focus();
                }
            }
            else
            {
                MessageBox.Show("A number must be entered");
                txtEnteredValue.Focus();
            }
        }


        private void btnFeetMetres_Click(object sender, EventArgs e)
        {
            lblEnteredValue.Text = ("foot");
            lblConversion.Text = ("metres");

            if (txtEnteredValue.TextLength != 0)
            {
                if (int.TryParse(txtEnteredValue.Text, out intFeetMetres))
                {
                    if (intFeetMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblFeetMetres = intFeetMetres * FOOT_METRES;
                        txtConversion.Text = dblFeetMetres.ToString();
                    }
                }
                else if (float.TryParse(txtEnteredValue.Text, out fltFeetMetres))
                {
                    if (fltFeetMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative number");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblFeetMetres = fltFeetMetres * FOOT_METRES;
                        txtConversion.Text = dblFeetMetres.ToString();
                    }
                }
                else if (double.TryParse(txtEnteredValue.Text, out dblFeetMetres))
                {
                    if (dblFeetMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative number");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblFeetMetres = dblFeetMetres * FOOT_METRES;
                        txtConversion.Text = dblFeetMetres.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("The entry must be numeric - please re - enter a value");
                    txtEnteredValue.Focus();
                }
            }
            else
            {
                MessageBox.Show("A number must be entered");
                txtEnteredValue.Focus();
            }
        }

        private void btnYardsMetres_Click(object sender, EventArgs e)
        {
            lblEnteredValue.Text = ("yards");
            lblConversion.Text = ("metres");

            if (txtEnteredValue.TextLength != 0)
            {
                if (int.TryParse(txtEnteredValue.Text, out intYardsMetres))
                {
                    if (intYardsMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblYardsMetres = intYardsMetres * YARD_METRES;
                        txtConversion.Text = dblYardsMetres.ToString();
                    }
                }
                else if (float.TryParse(txtEnteredValue.Text, out fltYardsMetres))
                {
                    if (fltYardsMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblYardsMetres = fltYardsMetres * YARD_METRES;
                        txtConversion.Text = dblYardsMetres.ToString();
                    }
                }
                else if (double.TryParse(txtEnteredValue.Text, out dblYardsMetres))
                {
                    if (dblYardsMetres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblYardsMetres = dblYardsMetres * YARD_METRES;
                        txtConversion.Text = dblYardsMetres.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("The entry must be numeric - please re - enter a value");
                    txtEnteredValue.Focus();
                }
            }
            else
            {
                MessageBox.Show("A number must be entered");
                txtEnteredValue.Focus();
            }
        }

        private void btnKilometres_Click(object sender, EventArgs e)
        {
            lblEnteredValue.Text = ("miles");
            lblConversion.Text = ("kilometres");

            if (txtEnteredValue.TextLength != 0)
            {
                if (int.TryParse(txtEnteredValue.Text, out intMilesKilometres))
                {
                    if (intMilesKilometres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblMilesKilometres = intMilesKilometres * MILES_KILOMETRES;
                        txtConversion.Text = dblMilesKilometres.ToString();
                    }
                }
                else if (float.TryParse(txtEnteredValue.Text, out fltMilesKilometres))
                {
                    if (fltMilesKilometres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblMilesKilometres = fltMilesKilometres * MILES_KILOMETRES;
                        txtConversion.Text = dblMilesKilometres.ToString();
                    }
                }
                else if (double.TryParse(txtEnteredValue.Text, out dblMilesKilometres))
                {
                    if (dblMilesKilometres < 0)
                    {
                        MessageBox.Show("The entry cannot be a negative");
                        txtEnteredValue.Focus();
                    }
                    else
                    {
                        dblMilesKilometres = dblMilesKilometres * MILES_KILOMETRES;
                        txtConversion.Text = dblMilesKilometres.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("The entry must be numeric - please re - enter a value");
                    txtEnteredValue.Focus();
                }
            }
            else
            {
                MessageBox.Show("A number must be entered");
                txtEnteredValue.Focus();
            }
        }
    }
}
