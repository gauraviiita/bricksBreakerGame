namespace bricsBreaker
{
    partial class frmAranoid
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
            picBall = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picBall).BeginInit();
            SuspendLayout();
            // 
            // picBall
            // 
            picBall.BackColor = Color.Transparent;
            picBall.Image = Properties.Resources.images_ball;
            picBall.Location = new Point(328, 134);
            picBall.Name = "picBall";
            picBall.Size = new Size(20, 20);
            picBall.SizeMode = PictureBoxSizeMode.AutoSize;
            picBall.TabIndex = 0;
            picBall.TabStop = false;
            picBall.Visible = false;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            // 
            // frmAranoid
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(picBall);
            Name = "frmAranoid";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Arakonoid";
            Load += Form1_Load;
            KeyDown += Key_Down;
            ((System.ComponentModel.ISupportInitialize)picBall).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picBall;
        private System.Windows.Forms.Timer timer;
    }
}
