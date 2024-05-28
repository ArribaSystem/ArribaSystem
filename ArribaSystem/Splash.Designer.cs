namespace ArribaSystem
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.pbSlpash = new System.Windows.Forms.PictureBox();
            this.pgrSplash = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlpash)).BeginInit();
            this.SuspendLayout();
            // 
            // pbSlpash
            // 
            this.pbSlpash.Image = global::ArribaSystem.Properties.Resources.arriba;
            this.pbSlpash.Location = new System.Drawing.Point(1, -45);
            this.pbSlpash.Name = "pbSlpash";
            this.pbSlpash.Size = new System.Drawing.Size(644, 356);
            this.pbSlpash.TabIndex = 0;
            this.pbSlpash.TabStop = false;
            // 
            // pgrSplash
            // 
            this.pgrSplash.Location = new System.Drawing.Point(1, 306);
            this.pgrSplash.Name = "pgrSplash";
            this.pgrSplash.Size = new System.Drawing.Size(644, 68);
            this.pgrSplash.TabIndex = 1;
            this.pgrSplash.Click += new System.EventHandler(this.pgrSplash_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 374);
            this.Controls.Add(this.pgrSplash);
            this.Controls.Add(this.pbSlpash);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            ((System.ComponentModel.ISupportInitialize)(this.pbSlpash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlpash;
        private System.Windows.Forms.ProgressBar pgrSplash;
        private System.Windows.Forms.Timer timer1;
    }
}