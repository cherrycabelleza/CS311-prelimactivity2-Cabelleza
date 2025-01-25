using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace CS311_prelimactivity2_Cabelleza
{
    public partial class ProgramB : Form
    {
        public ProgramB()
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

        private void btnclear_Click_1(object sender, EventArgs e)
        {
            txtadjacent.Clear();
            txthypotenuse.Clear();
            txtopposite.Clear();
            cbsine.Checked = false;
            cbcosine.Checked = false;
            cbtangent.Checked = false;
            txtopposite.Focus();
            errorProvider1.Clear();
        }

        private void txthypotenuse_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtopposite_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtadjacent_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            validateOpposite();
            validateHypotenuse();
            validateAdjacent();
            countError();
            if (errorCount == 0)
            {
                string msg = "";
                if (cbsine.Checked || cbcosine.Checked || cbtangent.Checked)
                {
                    if (cbsine.Checked)
                    {
                        sine = opposite / hypotenuse;
                        msg += "Sine: " + sine + Environment.NewLine; ;
                    }
                    if (cbcosine.Checked)
                    {
                        cosine = adjacent / hypotenuse;
                        msg += "Cosine: " + cosine + Environment.NewLine; ;
                    }
                    if (cbtangent.Checked)
                    {
                        tangent = opposite / adjacent;
                        msg += "Tagent: " + tangent + Environment.NewLine; ;
                    }
                    MessageBox.Show(msg, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No option was selected", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }
    }
}
