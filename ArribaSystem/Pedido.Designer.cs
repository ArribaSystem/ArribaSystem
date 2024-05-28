namespace ArribaSystem
{
    partial class frmPedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorPedido = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.cmbTamanhoPedido = new System.Windows.Forms.ComboBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.chkGuacamole = new System.Windows.Forms.CheckBox();
            this.chkNachos = new System.Windows.Forms.CheckBox();
            this.chkPimenta = new System.Windows.Forms.CheckBox();
            this.chkQueijoDerretido = new System.Windows.Forms.CheckBox();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.pbNome = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpOpcionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(106)))), ((int)(((byte)(42)))));
            this.label2.Location = new System.Drawing.Point(416, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor do Opcionais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(106)))), ((int)(((byte)(42)))));
            this.label3.Location = new System.Drawing.Point(238, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor do Pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(627, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total a Pagar";
            // 
            // txtValorPedido
            // 
            this.txtValorPedido.Location = new System.Drawing.Point(244, 50);
            this.txtValorPedido.Name = "txtValorPedido";
            this.txtValorPedido.ReadOnly = true;
            this.txtValorPedido.Size = new System.Drawing.Size(142, 20);
            this.txtValorPedido.TabIndex = 4;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(424, 50);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.ReadOnly = true;
            this.txtValorOpcionais.Size = new System.Drawing.Size(166, 20);
            this.txtValorOpcionais.TabIndex = 5;
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(634, 50);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(116, 20);
            this.txtValorTotal.TabIndex = 7;
            // 
            // cmbTamanhoPedido
            // 
            this.cmbTamanhoPedido.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTamanhoPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbTamanhoPedido.FormattingEnabled = true;
            this.cmbTamanhoPedido.Items.AddRange(new object[] {
            ""});
            this.cmbTamanhoPedido.Location = new System.Drawing.Point(22, 40);
            this.cmbTamanhoPedido.Name = "cmbTamanhoPedido";
            this.cmbTamanhoPedido.Size = new System.Drawing.Size(203, 30);
            this.cmbTamanhoPedido.TabIndex = 8;
            this.cmbTamanhoPedido.Text = "Pedido";
            this.cmbTamanhoPedido.SelectedIndexChanged += new System.EventHandler(this.cmbTamanhoTaco_SelectedIndexChanged);
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkGuacamole);
            this.grpOpcionais.Controls.Add(this.chkNachos);
            this.grpOpcionais.Controls.Add(this.chkPimenta);
            this.grpOpcionais.Controls.Add(this.chkQueijoDerretido);
            this.grpOpcionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOpcionais.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpcionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(106)))), ((int)(((byte)(42)))));
            this.grpOpcionais.Location = new System.Drawing.Point(22, 93);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(203, 134);
            this.grpOpcionais.TabIndex = 9;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "OPCIONAIS";
            this.grpOpcionais.Enter += new System.EventHandler(this.grpOpcionais_Enter);
            // 
            // chkGuacamole
            // 
            this.chkGuacamole.AutoSize = true;
            this.chkGuacamole.Location = new System.Drawing.Point(7, 100);
            this.chkGuacamole.Name = "chkGuacamole";
            this.chkGuacamole.Size = new System.Drawing.Size(134, 26);
            this.chkGuacamole.TabIndex = 3;
            this.chkGuacamole.Text = "Guacamole";
            this.chkGuacamole.UseVisualStyleBackColor = true;
            // 
            // chkNachos
            // 
            this.chkNachos.AutoSize = true;
            this.chkNachos.Location = new System.Drawing.Point(7, 74);
            this.chkNachos.Name = "chkNachos";
            this.chkNachos.Size = new System.Drawing.Size(99, 26);
            this.chkNachos.TabIndex = 2;
            this.chkNachos.Text = "Nachos";
            this.chkNachos.UseVisualStyleBackColor = true;
            // 
            // chkPimenta
            // 
            this.chkPimenta.AutoSize = true;
            this.chkPimenta.Location = new System.Drawing.Point(7, 48);
            this.chkPimenta.Name = "chkPimenta";
            this.chkPimenta.Size = new System.Drawing.Size(104, 26);
            this.chkPimenta.TabIndex = 1;
            this.chkPimenta.Text = "Pimenta";
            this.chkPimenta.UseVisualStyleBackColor = true;
            // 
            // chkQueijoDerretido
            // 
            this.chkQueijoDerretido.AutoSize = true;
            this.chkQueijoDerretido.Location = new System.Drawing.Point(7, 22);
            this.chkQueijoDerretido.Name = "chkQueijoDerretido";
            this.chkQueijoDerretido.Size = new System.Drawing.Size(181, 26);
            this.chkQueijoDerretido.TabIndex = 0;
            this.chkQueijoDerretido.Text = "Queijo Derretido";
            this.chkQueijoDerretido.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.chkQueijoDerretido.UseVisualStyleBackColor = true;
            this.chkQueijoDerretido.CheckedChanged += new System.EventHandler(this.chkChile_CheckedChanged);
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(232, 81);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(518, 262);
            this.dgvPedido.TabIndex = 10;
            // 
            // btnSair
            // 
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSair.FlatAppearance.BorderSize = 3;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Red;
            this.btnSair.Location = new System.Drawing.Point(634, 357);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 51);
            this.btnSair.TabIndex = 14;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatAppearance.BorderSize = 3;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Red;
            this.btnCalcular.Location = new System.Drawing.Point(501, 357);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(116, 51);
            this.btnCalcular.TabIndex = 15;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNovo.FlatAppearance.BorderSize = 3;
            this.btnNovo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Red;
            this.btnNovo.Location = new System.Drawing.Point(232, 357);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(116, 51);
            this.btnNovo.TabIndex = 16;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalvar.FlatAppearance.BorderSize = 3;
            this.btnSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Bisque;
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Red;
            this.btnSalvar.Location = new System.Drawing.Point(366, 357);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 51);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // pbNome
            // 
            this.pbNome.Image = global::ArribaSystem.Properties.Resources.Arriba___Logos__10_1;
            this.pbNome.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pbNome.Location = new System.Drawing.Point(28, 251);
            this.pbNome.Name = "pbNome";
            this.pbNome.Size = new System.Drawing.Size(140, 119);
            this.pbNome.TabIndex = 18;
            this.pbNome.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ArribaSystem.Properties.Resources.Decoracao;
            this.pictureBox3.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pictureBox3.Location = new System.Drawing.Point(-73, -51);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(489, 534);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArribaSystem.Properties.Resources.Decoracao1;
            this.pictureBox1.InitialImage = global::ArribaSystem.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(344, -51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(506, 540);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(767, 439);
            this.Controls.Add(this.pbNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.cmbTamanhoPedido);
            this.Controls.Add(this.txtValorTotal);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.frmPedido_Load);
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtValorPedido;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.ComboBox cmbTamanhoPedido;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.CheckBox chkGuacamole;
        private System.Windows.Forms.CheckBox chkNachos;
        private System.Windows.Forms.CheckBox chkPimenta;
        private System.Windows.Forms.CheckBox chkQueijoDerretido;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.PictureBox pbNome;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}