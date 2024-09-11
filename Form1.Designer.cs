namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnShow = new Button();
            btnHide = new Button();
            btnExit = new Button();
            lbl1 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl4 = new Label();
            lbl5 = new Label();
            lbl = new Label();
            lbl7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(77, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(667, 376);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(134, 388);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 50);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show Star Names";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += button1_Click;
            // 
            // btnHide
            // 
            btnHide.Location = new Point(359, 388);
            btnHide.Name = "btnHide";
            btnHide.Size = new Size(94, 50);
            btnHide.TabIndex = 2;
            btnHide.Text = "Hide Star Names";
            btnHide.UseVisualStyleBackColor = true;
            btnHide.Click += btnHide_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.Location = new Point(594, 388);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 50);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(155, 9);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(0, 20);
            lbl1.TabIndex = 4;
            lbl1.Click += lbl1_Click;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(223, 178);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(0, 20);
            lbl3.TabIndex = 5;
            lbl3.Click += lbl3_Click;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(155, 290);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(0, 20);
            lbl2.TabIndex = 6;
            lbl2.Click += lbl2_Click;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(343, 142);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(0, 20);
            lbl4.TabIndex = 7;
            lbl4.Click += lbl4_Click;
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Location = new Point(557, 54);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(0, 20);
            lbl5.TabIndex = 8;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(486, 159);
            lbl.Name = "lbl";
            lbl.Size = new Size(0, 20);
            lbl.TabIndex = 9;
            lbl.Click += lbl_Click;
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Location = new Point(557, 290);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(0, 20);
            lbl7.TabIndex = 10;
            lbl7.Click += lbl7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl7);
            Controls.Add(lbl);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl2);
            Controls.Add(lbl3);
            Controls.Add(lbl1);
            Controls.Add(btnExit);
            Controls.Add(btnHide);
            Controls.Add(btnShow);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnShow;
        private Button btnHide;
        private Button btnExit;
        private Label lbl1;
        private Label lbl3;
        private Label lbl2;
        private Label lbl4;
        private Label lbl5;
        private Label lbl;
        private Label lbl7;
    }
}
