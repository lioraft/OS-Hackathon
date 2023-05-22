namespace Hackathon
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            hallTickets1 = new HallTickets();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 27.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(56, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(658, 46);
            label1.TabIndex = 0;
            label1.Text = "Studentfest Tickets Purchasing";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(104, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(325, 24);
            label2.TabIndex = 1;
            label2.Text = "Number of available tickets";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(104, 153);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(235, 24);
            label3.TabIndex = 2;
            label3.Text = "Number of students";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Snow;
            label4.Location = new Point(104, 228);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(139, 24);
            label4.TabIndex = 3;
            label4.Text = "Tickets rate";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Aharoni", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Snow;
            label5.Location = new Point(104, 312);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(162, 24);
            label5.TabIndex = 4;
            label5.Text = "Students rate";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLightLight;
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkOrange;
            button1.Location = new Point(263, 391);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(120, 31);
            button1.TabIndex = 13;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(448, 231);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(62, 23);
            textBox2.TabIndex = 16;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(448, 312);
            textBox3.Margin = new Padding(2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(62, 23);
            textBox3.TabIndex = 17;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(448, 156);
            textBox4.Margin = new Padding(2);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(62, 23);
            textBox4.TabIndex = 18;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(448, 89);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(62, 23);
            textBox1.TabIndex = 19;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // hallTickets1
            // 
            hallTickets1.BackColor = Color.White;
            hallTickets1.BackgroundImage = (Image)resources.GetObject("hallTickets1.BackgroundImage");
            hallTickets1.Location = new Point(-9, -22);
            hallTickets1.Margin = new Padding(2);
            hallTickets1.Name = "hallTickets1";
            hallTickets1.RightToLeft = RightToLeft.No;
            hallTickets1.Size = new Size(1158, 504);
            hallTickets1.TabIndex = 20;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(875, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            errorProvider1.Icon = (Icon)resources.GetObject("errorProvider1.Icon");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1114, 608);
            Controls.Add(pictureBox1);
            Controls.Add(hallTickets1);
            Controls.Add(textBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private HallTickets hallTickets1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private ErrorProvider errorProvider1;
    }
}