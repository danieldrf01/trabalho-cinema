namespace trabalho_cinema
{
    partial class ListaProgramacao
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
            this.dgvListaProgramacao = new System.Windows.Forms.DataGridView();
            this.Filme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mês = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classificação = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Áudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dimensão = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duração = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramacao)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProgramacao
            // 
            this.dgvListaProgramacao.AllowUserToAddRows = false;
            this.dgvListaProgramacao.AllowUserToDeleteRows = false;
            this.dgvListaProgramacao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaProgramacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProgramacao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Filme,
            this.Mês,
            this.Classificação,
            this.Áudio,
            this.Dimensão,
            this.Duração,
            this.Sala});
            this.dgvListaProgramacao.Location = new System.Drawing.Point(12, 73);
            this.dgvListaProgramacao.Name = "dgvListaProgramacao";
            this.dgvListaProgramacao.ReadOnly = true;
            this.dgvListaProgramacao.Size = new System.Drawing.Size(855, 492);
            this.dgvListaProgramacao.TabIndex = 0;
            // 
            // Filme
            // 
            this.Filme.HeaderText = "Filme";
            this.Filme.Name = "Filme";
            this.Filme.ReadOnly = true;
            // 
            // Mês
            // 
            this.Mês.HeaderText = "Mês";
            this.Mês.Name = "Mês";
            this.Mês.ReadOnly = true;
            // 
            // Classificação
            // 
            this.Classificação.HeaderText = "Classificação";
            this.Classificação.Name = "Classificação";
            this.Classificação.ReadOnly = true;
            // 
            // Áudio
            // 
            this.Áudio.HeaderText = "Áudio";
            this.Áudio.Name = "Áudio";
            this.Áudio.ReadOnly = true;
            // 
            // Dimensão
            // 
            this.Dimensão.HeaderText = "Dimensão";
            this.Dimensão.Name = "Dimensão";
            this.Dimensão.ReadOnly = true;
            // 
            // Duração
            // 
            this.Duração.HeaderText = "Duração";
            this.Duração.Name = "Duração";
            this.Duração.ReadOnly = true;
            // 
            // Sala
            // 
            this.Sala.HeaderText = "Sala";
            this.Sala.Name = "Sala";
            this.Sala.ReadOnly = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Image = global::trabalho_cinema.Properties.Resources.refresh_button;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 12);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 48);
            this.btnAtualizar.TabIndex = 2;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Blue;
            this.btnCadastrar.Image = global::trabalho_cinema.Properties.Resources.plus_symbol_in_a_rounded_black_square;
            this.btnCadastrar.Location = new System.Drawing.Point(139, 12);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 48);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Green;
            this.btnEditar.Image = global::trabalho_cinema.Properties.Resources.clipboard_with_pencil_;
            this.btnEditar.Location = new System.Drawing.Point(274, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(106, 48);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.White;
            this.btnApagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.ForeColor = System.Drawing.Color.Red;
            this.btnApagar.Image = global::trabalho_cinema.Properties.Resources.delete;
            this.btnApagar.Location = new System.Drawing.Point(386, 12);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(121, 48);
            this.btnApagar.TabIndex = 5;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Busca";
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Location = new System.Drawing.Point(548, 40);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(319, 20);
            this.txtBusca.TabIndex = 7;
            // 
            // ListaProgramacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 577);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvListaProgramacao);
            this.Name = "ListaProgramacao";
            this.Text = "ListaProgramacao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProgramacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProgramacao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Filme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mês;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classificação;
        private System.Windows.Forms.DataGridViewTextBoxColumn Áudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dimensão;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duração;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sala;
    }
}