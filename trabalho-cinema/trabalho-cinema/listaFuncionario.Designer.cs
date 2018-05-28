namespace trabalho_cinema
{
    partial class listaFuncionario
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
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btCadastar = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2Nicionalidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataDeNacimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5Idade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Busca = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(12, 12);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btAtualizar.TabIndex = 0;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btCadastar
            // 
            this.btCadastar.Location = new System.Drawing.Point(93, 12);
            this.btCadastar.Name = "btCadastar";
            this.btCadastar.Size = new System.Drawing.Size(75, 23);
            this.btCadastar.TabIndex = 0;
            this.btCadastar.Text = "Cadastrar";
            this.btCadastar.UseVisualStyleBackColor = true;
            this.btCadastar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(255, 12);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(75, 23);
            this.btApagar.TabIndex = 0;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(174, 12);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 23);
            this.btEditar.TabIndex = 0;
            this.btEditar.Text = "Edetar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1Nome,
            this.Column2Nicionalidade,
            this.DataDeNacimento,
            this.Column4gmail,
            this.Column5Idade});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(792, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1Nome
            // 
            this.Column1Nome.HeaderText = "Nome";
            this.Column1Nome.Name = "Column1Nome";
            this.Column1Nome.ReadOnly = true;
            // 
            // Column2Nicionalidade
            // 
            this.Column2Nicionalidade.HeaderText = "Nacionalidade";
            this.Column2Nicionalidade.Name = "Column2Nicionalidade";
            this.Column2Nicionalidade.ReadOnly = true;
            // 
            // DataDeNacimento
            // 
            this.DataDeNacimento.HeaderText = "Data Nacimento";
            this.DataDeNacimento.Name = "DataDeNacimento";
            this.DataDeNacimento.ReadOnly = true;
            // 
            // Column4gmail
            // 
            this.Column4gmail.HeaderText = "E-mail";
            this.Column4gmail.Name = "Column4gmail";
            this.Column4gmail.ReadOnly = true;
            // 
            // Column5Idade
            // 
            this.Column5Idade.HeaderText = "Idade";
            this.Column5Idade.Name = "Column5Idade";
            this.Column5Idade.ReadOnly = true;
            // 
            // Busca
            // 
            this.Busca.AutoSize = true;
            this.Busca.Location = new System.Drawing.Point(575, 12);
            this.Busca.Name = "Busca";
            this.Busca.Size = new System.Drawing.Size(40, 13);
            this.Busca.TabIndex = 2;
            this.Busca.Text = "Buscar";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(578, 39);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(206, 20);
            this.txtBusca.TabIndex = 3;
            // 
            // listaFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 493);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.Busca);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btCadastar);
            this.Controls.Add(this.btAtualizar);
            this.Name = "listaFuncionario";
            this.Text = "listaFuncionario";
            this.Load += new System.EventHandler(this.listaFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btCadastar;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Nicionalidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataDeNacimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5Idade;
        private System.Windows.Forms.Label Busca;
        private System.Windows.Forms.TextBox txtBusca;
    }
}