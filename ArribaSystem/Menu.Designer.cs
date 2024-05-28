namespace ArribaSystem
{
    partial class Menu
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
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pbNome = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInicio
            // 
            this.btnInicio.FlatAppearance.BorderSize = 3;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnInicio.Location = new System.Drawing.Point(134, 38);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(156, 38);
            this.btnInicio.TabIndex = 0;
            this.btnInicio.Text = "INÍCIO";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.UseWaitCursor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.FlatAppearance.BorderSize = 3;
            this.btnCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCliente.Location = new System.Drawing.Point(296, 38);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(156, 38);
            this.btnCliente.TabIndex = 1;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.FlatAppearance.BorderSize = 3;
            this.btnPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPedido.Location = new System.Drawing.Point(458, 38);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(156, 38);
            this.btnPedido.TabIndex = 2;
            this.btnPedido.Text = "PEDIDO";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderSize = 3;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.Location = new System.Drawing.Point(620, 38);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(156, 38);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pbNome
            // 
            this.pbNome.Image = global::ArribaSystem.Properties.Resources.img_menu;
            this.pbNome.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pbNome.Location = new System.Drawing.Point(134, 139);
            this.pbNome.Name = "pbNome";
            this.pbNome.Size = new System.Drawing.Size(506, 209);
            this.pbNome.TabIndex = 5;
            this.pbNome.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pbLogo.Image = global::ArribaSystem.Properties.Resources.arriba_sem_fundo2;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(100, 95);
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ArribaSystem.Properties.Resources.Decoracao;
            this.pictureBox3.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(-3, -39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(489, 534);
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArribaSystem.Properties.Resources.Decoracao1;
            this.pictureBox1.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(414, -39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 540);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pbNome);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbNome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}