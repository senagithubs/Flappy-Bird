namespace FLAPPY_BİRD
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
            flappybird = new PictureBox();
            borualt = new PictureBox();
            zemin = new PictureBox();
            boruust = new PictureBox();
            scoretext = new Label();
            gametimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)flappybird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)borualt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)boruust).BeginInit();
            SuspendLayout();
            // 
            // flappybird
            // 
            flappybird.Image = (Image)resources.GetObject("flappybird.Image");
            flappybird.Location = new Point(161, 302);
            flappybird.Name = "flappybird";
            flappybird.Size = new Size(125, 62);
            flappybird.SizeMode = PictureBoxSizeMode.StretchImage;
            flappybird.TabIndex = 0;
            flappybird.TabStop = false;
            flappybird.Click += pictureBox1_Click;
            // 
            // borualt
            // 
            borualt.Image = (Image)resources.GetObject("borualt.Image");
            borualt.Location = new Point(483, 399);
            borualt.Name = "borualt";
            borualt.Size = new Size(81, 182);
            borualt.SizeMode = PictureBoxSizeMode.StretchImage;
            borualt.TabIndex = 2;
            borualt.TabStop = false;
            // 
            // zemin
            // 
            zemin.Image = (Image)resources.GetObject("zemin.Image");
            zemin.Location = new Point(39, 587);
            zemin.Name = "zemin";
            zemin.Size = new Size(825, 62);
            zemin.SizeMode = PictureBoxSizeMode.StretchImage;
            zemin.TabIndex = 3;
            zemin.TabStop = false;
            // 
            // boruust
            // 
            boruust.Image = (Image)resources.GetObject("boruust.Image");
            boruust.Location = new Point(746, 12);
            boruust.Name = "boruust";
            boruust.Size = new Size(92, 217);
            boruust.SizeMode = PictureBoxSizeMode.StretchImage;
            boruust.TabIndex = 4;
            boruust.TabStop = false;
            // 
            // scoretext
            // 
            scoretext.AutoSize = true;
            scoretext.FlatStyle = FlatStyle.Popup;
            scoretext.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point);
            scoretext.Location = new Point(35, 664);
            scoretext.Name = "scoretext";
            scoretext.Size = new Size(126, 45);
            scoretext.TabIndex = 5;
            scoretext.Text = "score:0";
            scoretext.Click += label1_Click;
            // 
            // gametimer
            // 
            gametimer.Enabled = true;
            gametimer.Interval = 20;
            gametimer.Tick += gameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(876, 751);
            Controls.Add(flappybird);
            Controls.Add(scoretext);
            Controls.Add(boruust);
            Controls.Add(zemin);
            Controls.Add(borualt);
            Name = "Form1";
            Text = "FLAPPY BİRD";
            Load += Form1_Load;
            KeyDown += gamekeyisdown;
            KeyUp += gamekeyisup;
            ((System.ComponentModel.ISupportInitialize)flappybird).EndInit();
            ((System.ComponentModel.ISupportInitialize)borualt).EndInit();
            ((System.ComponentModel.ISupportInitialize)zemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)boruust).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox flappybird;
        private PictureBox borualt;
        private PictureBox zemin;
        private PictureBox boruust;
        private Label scoretext;
        private System.Windows.Forms.Timer gametimer;
    }
}