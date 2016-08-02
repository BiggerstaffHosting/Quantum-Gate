namespace Quantum_Gate
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imagePortal1 = new System.Windows.Forms.PictureBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.mainVidPlayer = new AxAXVLC.AxVLCPlugin2();
            this.upButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePortal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainVidPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePortal1
            // 
            this.imagePortal1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagePortal1.Location = new System.Drawing.Point(12, 12);
            this.imagePortal1.Name = "imagePortal1";
            this.imagePortal1.Size = new System.Drawing.Size(1160, 417);
            this.imagePortal1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagePortal1.TabIndex = 0;
            this.imagePortal1.TabStop = false;
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.leftButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftButton.Location = new System.Drawing.Point(12, 406);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "◀";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.Location = new System.Drawing.Point(1097, 406);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "▶";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // mainVidPlayer
            // 
            this.mainVidPlayer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainVidPlayer.Enabled = true;
            this.mainVidPlayer.Location = new System.Drawing.Point(305, 42);
            this.mainVidPlayer.Name = "mainVidPlayer";
            this.mainVidPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mainVidPlayer.OcxState")));
            this.mainVidPlayer.Size = new System.Drawing.Size(589, 359);
            this.mainVidPlayer.TabIndex = 3;
            this.mainVidPlayer.MediaPlayerPlaying += new System.EventHandler(this.mainVidPlayer_MediaPlayerPlaying);
            this.mainVidPlayer.MediaPlayerEndReached += new System.EventHandler(this.mainVidPlayer_MediaPlayerEndReached);
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Location = new System.Drawing.Point(559, 12);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 4;
            this.upButton.Text = "▲";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 441);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.mainVidPlayer);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.imagePortal1);
            this.Name = "Form1";
            this.Text = "Quantum Gate v0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.imagePortal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainVidPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePortal1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private AxAXVLC.AxVLCPlugin2 mainVidPlayer;
        private System.Windows.Forms.Button upButton;
    }
}

