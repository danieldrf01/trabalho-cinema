namespace trabalho_cinema
{
    partial class ListaEquipamento
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
            this.dgvListaEquipamento = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipamento)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEquipamento
            // 
            this.dgvListaEquipamento.AllowUserToAddRows = false;
            this.dgvListaEquipamento.AllowUserToDeleteRows = false;
            this.dgvListaEquipamento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEquipamento.Location = new System.Drawing.Point(12, 63);
            this.dgvListaEquipamento.Name = "dgvListaEquipamento";
            this.dgvListaEquipamento.ReadOnly = true;
            this.dgvListaEquipamento.Size = new System.Drawing.Size(855, 492);
            this.dgvListaEquipamento.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.White;
            this.btnAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.Color.Black;
            this.btnAtualizar.Image = global::trabalho_cinema.Properties.Resources.refresh_button;
            this.btnAtualizar.Location = new System.Drawing.Point(12, 9);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(121, 48);
            this.btnAtualizar.TabIndex = 4;
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
            this.btnCadastrar.Location = new System.Drawing.Point(139, 9);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(129, 48);
            this.btnCadastrar.TabIndex = 5;
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
            this.btnEditar.Location = new System.Drawing.Point(274, 9);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 48);
            this.btnEditar.TabIndex = 6;
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
            this.btnApagar.Location = new System.Drawing.Point(392, 9);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(121, 48);
            this.btnApagar.TabIndex = 7;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnApagar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Busca";
            // 
            // txtBusca
            // 
            this.txtBusca.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusca.Location = new System.Drawing.Point(556, 31);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(311, 20);
            this.txtBusca.TabIndex = 9;
            // 
            // ListaEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 567);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvListaEquipamento);
            this.Name = "ListaEquipamento";
            this.Text = "ListaEquipamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEquipamento;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusca;
    }
}