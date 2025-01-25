namespace CS311_prelimactivity2_Cabelleza
{
    partial class ProgramB
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramB));
            btnsubmit = new Button();
            btnclear = new Button();
            groupBox1 = new GroupBox();
            cbtangent = new CheckBox();
            cbcosine = new CheckBox();
            cbsine = new CheckBox();
            label3 = new Label();
            txtadjacent = new TextBox();
            label2 = new Label();
            txtopposite = new TextBox();
            label1 = new Label();
            txthypotenuse = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.RosyBrown;
            btnsubmit.Cursor = Cursors.Hand;
            btnsubmit.Font = new Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnsubmit.Location = new Point(510, 302);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(80, 40);
            btnsubmit.TabIndex = 74;
            btnsubmit.Text = "&Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.RosyBrown;
            btnclear.Cursor = Cursors.Hand;
            btnclear.Font = new Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(414, 302);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(80, 40);
            btnclear.TabIndex = 73;
            btnclear.Text = "&Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(cbtangent);
            groupBox1.Controls.Add(cbcosine);
            groupBox1.Controls.Add(cbsine);
            groupBox1.Location = new Point(414, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 143);
            groupBox1.TabIndex = 72;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options:";
            // 
            // cbtangent
            // 
            cbtangent.AutoSize = true;
            cbtangent.Cursor = Cursors.Hand;
            cbtangent.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbtangent.Location = new Point(23, 90);
            cbtangent.Name = "cbtangent";
            cbtangent.Size = new Size(135, 21);
            cbtangent.TabIndex = 2;
            cbtangent.Text = "Compute &Tangent";
            cbtangent.UseVisualStyleBackColor = true;
            // 
            // cbcosine
            // 
            cbcosine.AutoSize = true;
            cbcosine.Cursor = Cursors.Hand;
            cbcosine.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbcosine.Location = new Point(23, 63);
            cbcosine.Name = "cbcosine";
            cbcosine.Size = new Size(127, 21);
            cbcosine.TabIndex = 1;
            cbcosine.Text = "Compute &Cosine";
            cbcosine.UseVisualStyleBackColor = true;
            // 
            // cbsine
            // 
            cbsine.AutoSize = true;
            cbsine.Cursor = Cursors.Hand;
            cbsine.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbsine.Location = new Point(23, 36);
            cbsine.Name = "cbsine";
            cbsine.Size = new Size(112, 21);
            cbsine.TabIndex = 0;
            cbsine.Text = "Compute &Sine";
            cbsine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(85, 259);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 71;
            label3.Text = "Input Adjacent:";
            // 
            // txtadjacent
            // 
            txtadjacent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtadjacent.BackColor = SystemColors.GradientInactiveCaption;
            txtadjacent.Cursor = Cursors.IBeam;
            txtadjacent.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtadjacent.Location = new Point(85, 271);
            txtadjacent.Multiline = true;
            txtadjacent.Name = "txtadjacent";
            txtadjacent.Size = new Size(280, 71);
            txtadjacent.TabIndex = 70;
            txtadjacent.TextAlign = HorizontalAlignment.Right;
            txtadjacent.KeyPress += txtadjacent_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(85, 150);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 69;
            label2.Text = "Input Opposite:";
            // 
            // txtopposite
            // 
            txtopposite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtopposite.BackColor = SystemColors.GradientInactiveCaption;
            txtopposite.Cursor = Cursors.IBeam;
            txtopposite.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtopposite.Location = new Point(85, 164);
            txtopposite.Multiline = true;
            txtopposite.Name = "txtopposite";
            txtopposite.Size = new Size(280, 71);
            txtopposite.TabIndex = 68;
            txtopposite.TextAlign = HorizontalAlignment.Right;
            txtopposite.KeyPress += txtopposite_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(85, 47);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 67;
            label1.Text = "Input Hypotenuse:";
            // 
            // txthypotenuse
            // 
            txthypotenuse.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txthypotenuse.BackColor = SystemColors.GradientInactiveCaption;
            txthypotenuse.Cursor = Cursors.IBeam;
            txthypotenuse.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txthypotenuse.Location = new Point(85, 60);
            txthypotenuse.Multiline = true;
            txthypotenuse.Name = "txthypotenuse";
            txthypotenuse.Size = new Size(280, 71);
            txthypotenuse.TabIndex = 66;
            txthypotenuse.TextAlign = HorizontalAlignment.Right;
            txthypotenuse.KeyPress += txthypotenuse_KeyPress;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ProgramB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1_p2Z_zoNei9BAAMNHTEsnhA;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(674, 388);
            Controls.Add(btnsubmit);
            Controls.Add(btnclear);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(txtadjacent);
            Controls.Add(label2);
            Controls.Add(txtopposite);
            Controls.Add(label1);
            Controls.Add(txthypotenuse);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgramB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trigonometric B";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnsubmit;
        private Button btnclear;
        private GroupBox groupBox1;
        private Label label3;
        private TextBox txtadjacent;
        private Label label2;
        private TextBox txtopposite;
        private Label label1;
        private TextBox txthypotenuse;
        private CheckBox cbsine;
        private ErrorProvider errorProvider1;
        private CheckBox cbtangent;
        private CheckBox cbcosine;
    }
}