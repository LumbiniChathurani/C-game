namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            lblscore = new Label();
            lblmissedshots = new Label();
            lbltotalshots = new Label();
            btnexit = new Button();
            btnrestart = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(449, 275);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(131, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.BackColor = Color.Gold;
            lblscore.Font = new Font("Playbill", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscore.ForeColor = Color.Black;
            lblscore.Location = new Point(63, 21);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(111, 48);
            lblscore.TabIndex = 1;
            lblscore.Text = "Score=0";
            // 
            // lblmissedshots
            // 
            lblmissedshots.AutoSize = true;
            lblmissedshots.BackColor = Color.Gold;
            lblmissedshots.Font = new Font("Playbill", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmissedshots.ForeColor = Color.Black;
            lblmissedshots.Location = new Point(63, 69);
            lblmissedshots.Name = "lblmissedshots";
            lblmissedshots.Size = new Size(193, 48);
            lblmissedshots.TabIndex = 2;
            lblmissedshots.Text = "Missed shots=0";
            // 
            // lbltotalshots
            // 
            lbltotalshots.AutoSize = true;
            lbltotalshots.BackColor = Color.Gold;
            lbltotalshots.Font = new Font("Playbill", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbltotalshots.ForeColor = Color.Black;
            lbltotalshots.Location = new Point(63, 117);
            lbltotalshots.Name = "lbltotalshots";
            lbltotalshots.Size = new Size(175, 48);
            lbltotalshots.TabIndex = 3;
            lbltotalshots.Text = "Total shots=0";
            // 
            // btnexit
            // 
            btnexit.BackColor = Color.FromArgb(255, 255, 128);
            btnexit.Font = new Font("Playbill", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.FromArgb(192, 0, 0);
            btnexit.Location = new Point(622, 12);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(94, 56);
            btnexit.TabIndex = 4;
            btnexit.Text = "Exit";
            btnexit.UseVisualStyleBackColor = false;
            // 
            // btnrestart
            // 
            btnrestart.BackColor = Color.FromArgb(255, 255, 128);
            btnrestart.Font = new Font("Playbill", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnrestart.ForeColor = Color.FromArgb(192, 0, 0);
            btnrestart.Location = new Point(598, 74);
            btnrestart.Name = "btnrestart";
            btnrestart.Size = new Size(139, 56);
            btnrestart.TabIndex = 5;
            btnrestart.Text = "Restart";
            btnrestart.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(786, 451);
            Controls.Add(btnrestart);
            Controls.Add(btnexit);
            Controls.Add(lbltotalshots);
            Controls.Add(lblmissedshots);
            Controls.Add(lblscore);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            MaximumSize = new Size(804, 498);
            MinimumSize = new Size(804, 498);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblscore;
        private Label lblmissedshots;
        private Label lbltotalshots;
        private Button btnexit;
        private Button btnrestart;
        private System.Windows.Forms.Timer timer1;
    }
}
