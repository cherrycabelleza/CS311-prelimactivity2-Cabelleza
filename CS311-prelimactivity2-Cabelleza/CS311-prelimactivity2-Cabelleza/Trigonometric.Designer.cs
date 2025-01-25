namespace CS311_prelimactivity2_Cabelleza
{
    partial class ProgramA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramA));
            errorProvider1 = new ErrorProvider(components);
            btnsubmit = new Button();
            btnclear = new Button();
            groupBox1 = new GroupBox();
            rbcompute = new RadioButton();
            rbtangent = new RadioButton();
            rbcosine = new RadioButton();
            rbsine = new RadioButton();
            label3 = new Label();
            txtadjacent = new TextBox();
            label2 = new Label();
            txtopposite = new TextBox();
            label1 = new Label();
            txthypotenuse = new TextBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnsubmit
            // 
            btnsubmit.BackColor = Color.RosyBrown;
            btnsubmit.Cursor = Cursors.Hand;
            btnsubmit.Font = new Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnsubmit.Location = new Point(479, 289);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(80, 40);
            btnsubmit.TabIndex = 65;
            btnsubmit.Text = "&Submit";
            btnsubmit.UseVisualStyleBackColor = false;
            btnsubmit.Click += btnsubmit_Click_1;
            // 
            // btnclear
            // 
            btnclear.BackColor = Color.RosyBrown;
            btnclear.Cursor = Cursors.Hand;
            btnclear.Font = new Font("Kristen ITC", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(383, 289);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(80, 40);
            btnclear.TabIndex = 64;
            btnclear.Text = "&Clear";
            btnclear.UseVisualStyleBackColor = false;
            btnclear.Click += btnclear_Click_1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.InactiveBorder;
            groupBox1.Controls.Add(rbcompute);
            groupBox1.Controls.Add(rbtangent);
            groupBox1.Controls.Add(rbcosine);
            groupBox1.Controls.Add(rbsine);
            groupBox1.Location = new Point(383, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(176, 143);
            groupBox1.TabIndex = 63;
            groupBox1.TabStop = false;
            groupBox1.Text = "Options:";
            // 
            // rbcompute
            // 
            rbcompute.AutoSize = true;
            rbcompute.Cursor = Cursors.Hand;
            rbcompute.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbcompute.Location = new Point(20, 103);
            rbcompute.Name = "rbcompute";
            rbcompute.Size = new Size(99, 21);
            rbcompute.TabIndex = 3;
            rbcompute.TabStop = true;
            rbcompute.Text = "Compute &All";
            rbcompute.UseVisualStyleBackColor = true;
            // 
            // rbtangent
            // 
            rbtangent.AutoSize = true;
            rbtangent.Cursor = Cursors.Hand;
            rbtangent.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbtangent.Location = new Point(20, 76);
            rbtangent.Name = "rbtangent";
            rbtangent.Size = new Size(134, 21);
            rbtangent.TabIndex = 2;
            rbtangent.TabStop = true;
            rbtangent.Text = "Compute &Tangent";
            rbtangent.UseVisualStyleBackColor = true;
            // 
            // rbcosine
            // 
            rbcosine.AutoSize = true;
            rbcosine.Cursor = Cursors.Hand;
            rbcosine.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbcosine.Location = new Point(20, 49);
            rbcosine.Name = "rbcosine";
            rbcosine.Size = new Size(126, 21);
            rbcosine.TabIndex = 1;
            rbcosine.TabStop = true;
            rbcosine.Text = "Compute &Cosine";
            rbcosine.UseVisualStyleBackColor = true;
            // 
            // rbsine
            // 
            rbsine.AutoSize = true;
            rbsine.Cursor = Cursors.Hand;
            rbsine.Font = new Font("Yu Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            rbsine.Location = new Point(20, 22);
            rbsine.Name = "rbsine";
            rbsine.Size = new Size(111, 21);
            rbsine.TabIndex = 0;
            rbsine.TabStop = true;
            rbsine.Text = "Compute &Sine";
            rbsine.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(54, 246);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 62;
            label3.Text = "Input Adjacent:";
            // 
            // txtadjacent
            // 
            txtadjacent.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtadjacent.BackColor = SystemColors.GradientInactiveCaption;
            txtadjacent.Cursor = Cursors.IBeam;
            txtadjacent.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtadjacent.Location = new Point(54, 258);
            txtadjacent.Multiline = true;
            txtadjacent.Name = "txtadjacent";
            txtadjacent.Size = new Size(280, 71);
            txtadjacent.TabIndex = 61;
            txtadjacent.TextAlign = HorizontalAlignment.Right;
            txtadjacent.KeyPress += txtadjacent_KeyPress_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.IndianRed;
            label2.Location = new Point(54, 137);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 60;
            label2.Text = "Input Opposite:";
            // 
            // txtopposite
            // 
            txtopposite.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtopposite.BackColor = SystemColors.GradientInactiveCaption;
            txtopposite.Cursor = Cursors.IBeam;
            txtopposite.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtopposite.Location = new Point(54, 151);
            txtopposite.Multiline = true;
            txtopposite.Name = "txtopposite";
            txtopposite.Size = new Size(280, 71);
            txtopposite.TabIndex = 59;
            txtopposite.TextAlign = HorizontalAlignment.Right;
            txtopposite.KeyPress += txtopposite_KeyPress_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.IndianRed;
            label1.Location = new Point(54, 34);
            label1.Name = "label1";
            label1.Size = new Size(134, 20);
            label1.TabIndex = 58;
            label1.Text = "Input Hypotenuse:";
            // 
            // txthypotenuse
            // 
            txthypotenuse.BackColor = SystemColors.GradientInactiveCaption;
            txthypotenuse.Cursor = Cursors.IBeam;
            txthypotenuse.Font = new Font("Yu Gothic", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            txthypotenuse.Location = new Point(54, 47);
            txthypotenuse.Multiline = true;
            txthypotenuse.Name = "txthypotenuse";
            txthypotenuse.Size = new Size(280, 71);
            txthypotenuse.TabIndex = 57;
            txthypotenuse.TextAlign = HorizontalAlignment.Right;
            txthypotenuse.KeyPress += txthypotenuse_KeyPress_1;
            // 
            // ProgramA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources._1_p2Z_zoNei9BAAMNHTEsnhA;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(613, 363);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ProgramA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trigonometric A";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private Button btnsubmit;
        private Button btnclear;
        private GroupBox groupBox1;
        private RadioButton rbcompute;
        private RadioButton rbtangent;
        private RadioButton rbcosine;
        private RadioButton rbsine;
        private Label label3;
        private TextBox txtadjacent;
        private Label label2;
        private TextBox txtopposite;
        private Label label1;
        private TextBox txthypotenuse;
    }
}