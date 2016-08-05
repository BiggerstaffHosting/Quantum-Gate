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
            this.mainVidPlayer = new AxAXVLC.AxVLCPlugin2();
            this.forwardsHotSpot = new System.Windows.Forms.PictureBox();
            this.rightHotSpot = new System.Windows.Forms.PictureBox();
            this.leftHotSpot = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagePortal1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainVidPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardsHotSpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHotSpot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHotSpot)).BeginInit();
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
            // forwardsHotSpot
            // 
            this.forwardsHotSpot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forwardsHotSpot.BackColor = System.Drawing.Color.Lime;
            this.forwardsHotSpot.Cursor = System.Windows.Forms.Cursors.PanNorth;
            this.forwardsHotSpot.Location = new System.Drawing.Point(461, 112);
            this.forwardsHotSpot.Name = "forwardsHotSpot";
            this.forwardsHotSpot.Size = new System.Drawing.Size(280, 208);
            this.forwardsHotSpot.TabIndex = 5;
            this.forwardsHotSpot.TabStop = false;
            this.forwardsHotSpot.Click += new System.EventHandler(this.forwardsHotSpot_Click);
            // 
            // rightHotSpot
            // 
            this.rightHotSpot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightHotSpot.BackColor = System.Drawing.Color.Lime;
            this.rightHotSpot.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.rightHotSpot.Location = new System.Drawing.Point(1022, 12);
            this.rightHotSpot.Name = "rightHotSpot";
            this.rightHotSpot.Size = new System.Drawing.Size(150, 417);
            this.rightHotSpot.TabIndex = 6;
            this.rightHotSpot.TabStop = false;
            this.rightHotSpot.Click += new System.EventHandler(this.rightHotSpot_Click);
            // 
            // leftHotSpot
            // 
            this.leftHotSpot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.leftHotSpot.BackColor = System.Drawing.Color.Lime;
            this.leftHotSpot.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.leftHotSpot.Location = new System.Drawing.Point(12, 12);
            this.leftHotSpot.Name = "leftHotSpot";
            this.leftHotSpot.Size = new System.Drawing.Size(150, 417);
            this.leftHotSpot.TabIndex = 7;
            this.leftHotSpot.TabStop = false;
            this.leftHotSpot.Click += new System.EventHandler(this.leftHotSpot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1184, 441);
            this.Controls.Add(this.leftHotSpot);
            this.Controls.Add(this.rightHotSpot);
            this.Controls.Add(this.forwardsHotSpot);
            this.Controls.Add(this.mainVidPlayer);
            this.Controls.Add(this.imagePortal1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Quantum Gate v0.0.1";
            ((System.ComponentModel.ISupportInitialize)(this.imagePortal1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainVidPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardsHotSpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightHotSpot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftHotSpot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePortal1;
        private AxAXVLC.AxVLCPlugin2 mainVidPlayer;
        private System.Windows.Forms.PictureBox forwardsHotSpot;
        private System.Windows.Forms.PictureBox rightHotSpot;
        private System.Windows.Forms.PictureBox leftHotSpot;
    }
}

