using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS311_prelimactivity2_Cabelleza
{
    public partial class ProgramA : Form
    {
        public ProgramA()
        {
            InitializeComponent();
        }

        private float opposite, hypotenuse, adjacent, cosine, sine, tangent;
        private int errorCount;
        public void validateOpposite()
        {
            if (string.IsNullOrEmpty(txtopposite.Text))
            {
                errorProvider1.SetError(txtopposite, "Input is empty!");
            }
            else
            {
                opposite = float.Parse(txtopposite.Text);
                if (opposite <= 0)
                {
                    errorProvider1.SetError(txtopposite, "Input must be positive!");
                }
                else
                {
                    errorProvider1.SetError(txtopposite, "");
                }
            }
        }


        public void validateHypotenuse()
        {
            if (string.IsNullOrEmpty(txthypotenuse.Text))
            {
                errorProvider1.SetError(txthypotenuse, "Input is empty!");
            }
            else
            {
                hypotenuse = float.Parse(txthypotenuse.Text);
                if (hypotenuse <= 0)
                {
                    errorProvider1.SetError(txthypotenuse, "Input must be positive!");
                }
                else if (hypotenuse <= adjacent || hypotenuse <= opposite)
                {
                    errorProvider1.SetError(txthypotenuse, "Hypotenuse must be larger than both adjacent and opposite sides!");
                }
                else
                {
                    errorProvider1.SetError(txthypotenuse, "");
                }
            }
        }
        public void validateAdjacent()
        {
            if (string.IsNullOrEmpty(txtadjacent.Text))
            {
                errorProvider1.SetError(txtadjacent, "Input is empty!");
            }
            else
            {
                adjacent = float.Parse(txtadjacent.Text);
                if (adjacent <= 0)
                {
                    errorProvider1.SetError(txtadjacent, "Input must be positive!");
                }
                else
                {
                    errorProvider1.SetError(txtadjacent, "");
                }
            }
        }
        private void countError()
        {
            errorCount = 0;
            foreach (Control c in errorProvider1.ContainerControl.Controls)
            {
                if (!(string.IsNullOrEmpty(errorProvider1.GetError(c))))
                {
                    errorCount++;
                }
            }
        }

        private void btnsubmit_Click_1(object sender, EventArgs e)
        {
            validateOpposite();
            validateHypotenuse();
            validateAdjacent();
            countError();
            if (errorCount == 0)
            {
                string msg = "";
                if (rbsine.Checked)
                {
                    sine = opposite / hypotenuse;
                    msg = "Sine: " + sine;
                }
                else if (rbcosine.Checked)
                {
                    cosine = adjacent / hypotenuse;
                    msg = "Cosine: " + cosine;
                }
                else if (rbtangent.Checked)
                {
                    tangent = opposite / adjacent;
                    msg = "Tagent: " + tangent;
                }
                else if (rbcompute.Checked)
                {
                    sine = opposite / hypotenuse;
                    cosine = adjacent / hypotenuse;
                    tangent = opposite / adjacent;
                    msg = "Sine: " + sine + "\nCosine: " + cosine + "\nTangent: " + tangent;
                }
                else
                {
                    MessageBox.Show("No option was selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtadjacent.Clear();
            txthypotenuse.Clear();
            txtopposite.Clear();
            rbcompute.Checked = false;
            rbcosine.Checked = false;
            rbsine.Checked = false;
            rbtangent.Checked = false;
            txtopposite.Focus();
            errorProvider1.Clear();
        }

        private void txthypotenuse_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txthypotenuse, "Input must be numeric");
                txthypotenuse.Focus();
            }

            else
            {
                errorProvider1.SetError(txthypotenuse, "");
            }
        }

        private void txtopposite_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtopposite, "Input must be numeric");
                txtopposite.Focus();
            }
            else
            {
                errorProvider1.SetError(txtopposite, "");
            }
        }

        private void txtadjacent_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                errorProvider1.SetError(txtadjacent, "Input must be numeric");
                txtadjacent.Focus();
            }
            else
            {
                errorProvider1.SetError(txtadjacent, "");
            }
        }
    }
}
