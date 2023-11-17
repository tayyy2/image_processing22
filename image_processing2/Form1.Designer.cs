namespace image_processing2
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
            btnOrigin = new Button();
            btnGrey1 = new Button();
            btnGrey2 = new Button();
            btnOpen = new Button();
            pictureBox1 = new PictureBox();
            btnBW = new Button();
            textBox1 = new TextBox();
            btnInvert = new Button();
            btnNegative = new Button();
            btnLogtransformations = new Button();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrigin
            // 
            btnOrigin.FlatStyle = FlatStyle.Popup;
            btnOrigin.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOrigin.Location = new Point(55, 12);
            btnOrigin.Name = "btnOrigin";
            btnOrigin.Size = new Size(114, 61);
            btnOrigin.TabIndex = 0;
            btnOrigin.Text = "origin";
            btnOrigin.UseVisualStyleBackColor = true;
            btnOrigin.Click += button1_Click;
            // 
            // btnGrey1
            // 
            btnGrey1.FlatStyle = FlatStyle.Popup;
            btnGrey1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrey1.Location = new Point(202, 12);
            btnGrey1.Name = "btnGrey1";
            btnGrey1.Size = new Size(131, 61);
            btnGrey1.TabIndex = 1;
            btnGrey1.Text = "Grey scale1";
            btnGrey1.UseVisualStyleBackColor = true;
            btnGrey1.Click += btnGrey1_Click;
            // 
            // btnGrey2
            // 
            btnGrey2.FlatStyle = FlatStyle.Popup;
            btnGrey2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnGrey2.Location = new Point(369, 12);
            btnGrey2.Name = "btnGrey2";
            btnGrey2.Size = new Size(128, 61);
            btnGrey2.TabIndex = 2;
            btnGrey2.Text = "Grey scale2";
            btnGrey2.UseVisualStyleBackColor = true;
            btnGrey2.Click += btnGrey2_Click;
            // 
            // btnOpen
            // 
            btnOpen.FlatStyle = FlatStyle.Popup;
            btnOpen.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpen.Location = new Point(556, 12);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(125, 61);
            btnOpen.TabIndex = 3;
            btnOpen.Text = "open picture";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 377);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnBW
            // 
            btnBW.FlatStyle = FlatStyle.Popup;
            btnBW.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnBW.Location = new Point(556, 179);
            btnBW.Name = "btnBW";
            btnBW.Size = new Size(125, 61);
            btnBW.TabIndex = 5;
            btnBW.Text = "black_white";
            btnBW.UseVisualStyleBackColor = true;
            btnBW.Click += btnBW_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(556, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            textBox1.Text = "100";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // btnInvert
            // 
            btnInvert.FlatStyle = FlatStyle.Popup;
            btnInvert.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnInvert.Location = new Point(556, 283);
            btnInvert.Name = "btnInvert";
            btnInvert.Size = new Size(125, 61);
            btnInvert.TabIndex = 8;
            btnInvert.Text = "invert";
            btnInvert.UseVisualStyleBackColor = true;
            btnInvert.Click += btnInvert_Click;
            // 
            // btnNegative
            // 
            btnNegative.FlatStyle = FlatStyle.Popup;
            btnNegative.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNegative.Location = new Point(556, 388);
            btnNegative.Name = "btnNegative";
            btnNegative.Size = new Size(125, 61);
            btnNegative.TabIndex = 12;
            btnNegative.Text = "Negative";
            btnNegative.UseVisualStyleBackColor = true;
            btnNegative.Click += btnNegative_Click;
            // 
            // btnLogtransformations
            // 
            btnLogtransformations.Location = new Point(776, 181);
            btnLogtransformations.Name = "btnLogtransformations";
            btnLogtransformations.Size = new Size(138, 61);
            btnLogtransformations.TabIndex = 13;
            btnLogtransformations.Text = "Log transformations";
            btnLogtransformations.UseVisualStyleBackColor = true;
            btnLogtransformations.Click += btnLogtransformations_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(776, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 27);
            textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 499);
            Controls.Add(textBox2);
            Controls.Add(btnLogtransformations);
            Controls.Add(btnNegative);
            Controls.Add(btnInvert);
            Controls.Add(textBox1);
            Controls.Add(btnBW);
            Controls.Add(pictureBox1);
            Controls.Add(btnOpen);
            Controls.Add(btnGrey2);
            Controls.Add(btnGrey1);
            Controls.Add(btnOrigin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrigin;
        private Button btnGrey1;
        private Button btnGrey2;
        private Button btnOpen;
        private PictureBox pictureBox1;
        private Button btnBW;
        private TextBox textBox1;
        private Button btnInvert;
        private Button btnNegative;
        private Button btnLogtransformations;
        private TextBox textBox2;
    }
}