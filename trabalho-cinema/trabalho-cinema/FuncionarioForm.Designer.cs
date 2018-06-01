namespace TRABALHO_CINEMA
{
    partial class FuncionarioForm
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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCurso = new System.Windows.Forms.Label();
            this.lbNacionalidade = new System.Windows.Forms.Label();
            this.lbNumeroCelular = new System.Windows.Forms.Label();
            this.lbNumeroFixo = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbRG = new System.Windows.Forms.Label();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbEstadoCivil = new System.Windows.Forms.Label();
            this.lbEndereso = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbDataDENacimento = new System.Windows.Forms.Label();
            this.mtbcpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.mtbNumeroCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbNumeroFixo = new System.Windows.Forms.MaskedTextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstadoCivil = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.txtEndereso = new System.Windows.Forms.TextBox();
            this.btcancelar = new System.Windows.Forms.Button();
            this.DTFuncinarioCadastroDTNacimento = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewFuncionario = new System.Windows.Forms.DataGridView();
            this.txtFuncionarioNacionalidade = new System.Windows.Forms.TextBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(20, 86);
            this.lbNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(134, 18);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "Nome Completo";
            // 
            // lbCurso
            // 
            this.lbCurso.AutoSize = true;
            this.lbCurso.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurso.Location = new System.Drawing.Point(20, 176);
            this.lbCurso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCurso.Name = "lbCurso";
            this.lbCurso.Size = new System.Drawing.Size(56, 18);
            this.lbCurso.TabIndex = 1;
            this.lbCurso.Text = "Curso";
            // 
            // lbNacionalidade
            // 
            this.lbNacionalidade.AutoSize = true;
            this.lbNacionalidade.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNacionalidade.Location = new System.Drawing.Point(20, 273);
            this.lbNacionalidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNacionalidade.Name = "lbNacionalidade";
            this.lbNacionalidade.Size = new System.Drawing.Size(122, 18);
            this.lbNacionalidade.TabIndex = 2;
            this.lbNacionalidade.Text = "Nacionalidade";
            // 
            // lbNumeroCelular
            // 
            this.lbNumeroCelular.AutoSize = true;
            this.lbNumeroCelular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroCelular.Location = new System.Drawing.Point(20, 367);
            this.lbNumeroCelular.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNumeroCelular.Name = "lbNumeroCelular";
            this.lbNumeroCelular.Size = new System.Drawing.Size(132, 18);
            this.lbNumeroCelular.TabIndex = 3;
            this.lbNumeroCelular.Text = "Numero Celular";
            // 
            // lbNumeroFixo
            // 
            this.lbNumeroFixo.AutoSize = true;
            this.lbNumeroFixo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroFixo.Location = new System.Drawing.Point(20, 451);
            this.lbNumeroFixo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbNumeroFixo.Name = "lbNumeroFixo";
            this.lbNumeroFixo.Size = new System.Drawing.Size(102, 18);
            this.lbNumeroFixo.TabIndex = 4;
            this.lbNumeroFixo.Text = "Numero fixo";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(315, 86);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(56, 18);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "E-mail";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcpf.Location = new System.Drawing.Point(315, 176);
            this.lbcpf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(41, 18);
            this.lbcpf.TabIndex = 6;
            this.lbcpf.Text = "CPF";
            // 
            // lbRG
            // 
            this.lbRG.AutoSize = true;
            this.lbRG.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRG.Location = new System.Drawing.Point(315, 271);
            this.lbRG.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRG.Name = "lbRG";
            this.lbRG.Size = new System.Drawing.Size(33, 18);
            this.lbRG.TabIndex = 7;
            this.lbRG.Text = "RG";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexo.Location = new System.Drawing.Point(315, 451);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(47, 18);
            this.lbSexo.TabIndex = 9;
            this.lbSexo.Text = "Sexo";
            this.lbSexo.Click += new System.EventHandler(this.label10_Click);
            // 
            // lbEstadoCivil
            // 
            this.lbEstadoCivil.AutoSize = true;
            this.lbEstadoCivil.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstadoCivil.Location = new System.Drawing.Point(587, 86);
            this.lbEstadoCivil.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEstadoCivil.Name = "lbEstadoCivil";
            this.lbEstadoCivil.Size = new System.Drawing.Size(101, 18);
            this.lbEstadoCivil.TabIndex = 10;
            this.lbEstadoCivil.Text = "Estado Civil";
            // 
            // lbEndereso
            // 
            this.lbEndereso.AutoSize = true;
            this.lbEndereso.Location = new System.Drawing.Point(587, 176);
            this.lbEndereso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbEndereso.Name = "lbEndereso";
            this.lbEndereso.Size = new System.Drawing.Size(85, 18);
            this.lbEndereso.TabIndex = 11;
            this.lbEndereso.Text = "Endereso";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Location = new System.Drawing.Point(587, 271);
            this.lbCargo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(57, 18);
            this.lbCargo.TabIndex = 12;
            this.lbCargo.Text = "Cargo";
            // 
            // lbDataDENacimento
            // 
            this.lbDataDENacimento.AutoSize = true;
            this.lbDataDENacimento.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDENacimento.Location = new System.Drawing.Point(318, 366);
            this.lbDataDENacimento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbDataDENacimento.Name = "lbDataDENacimento";
            this.lbDataDENacimento.Size = new System.Drawing.Size(162, 18);
            this.lbDataDENacimento.TabIndex = 13;
            this.lbDataDENacimento.Text = "Data De Nacimento";
            // 
            // mtbcpf
            // 
            this.mtbcpf.Location = new System.Drawing.Point(320, 198);
            this.mtbcpf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbcpf.Mask = "000.000.000-00";
            this.mtbcpf.Name = "mtbcpf";
            this.mtbcpf.Size = new System.Drawing.Size(164, 26);
            this.mtbcpf.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(25, 109);
            this.txtNome.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(164, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(25, 198);
            this.txtCurso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(164, 26);
            this.txtCurso.TabIndex = 2;
            // 
            // mtbNumeroCelular
            // 
            this.mtbNumeroCelular.Location = new System.Drawing.Point(25, 390);
            this.mtbNumeroCelular.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbNumeroCelular.Mask = "(99) 000-0000";
            this.mtbNumeroCelular.Name = "mtbNumeroCelular";
            this.mtbNumeroCelular.Size = new System.Drawing.Size(164, 26);
            this.mtbNumeroCelular.TabIndex = 4;
            // 
            // mtbNumeroFixo
            // 
            this.mtbNumeroFixo.Location = new System.Drawing.Point(20, 474);
            this.mtbNumeroFixo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbNumeroFixo.Mask = "(99) 000-0000";
            this.mtbNumeroFixo.Name = "mtbNumeroFixo";
            this.mtbNumeroFixo.Size = new System.Drawing.Size(164, 26);
            this.mtbNumeroFixo.TabIndex = 5;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(320, 295);
            this.mtbRG.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.mtbRG.Mask = "0.000.00";
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(164, 26);
            this.mtbRG.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 109);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(164, 26);
            this.txtEmail.TabIndex = 6;
            // 
            // txtEstadoCivil
            // 
            this.txtEstadoCivil.Location = new System.Drawing.Point(592, 109);
            this.txtEstadoCivil.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEstadoCivil.Name = "txtEstadoCivil";
            this.txtEstadoCivil.Size = new System.Drawing.Size(164, 26);
            this.txtEstadoCivil.TabIndex = 11;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(592, 294);
            this.txtcargo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(164, 26);
            this.txtcargo.TabIndex = 13;
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(27, 544);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(125, 32);
            this.btSalvar.TabIndex = 28;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(320, 472);
            this.cbSexo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(199, 26);
            this.cbSexo.TabIndex = 10;
            // 
            // txtEndereso
            // 
            this.txtEndereso.Location = new System.Drawing.Point(592, 198);
            this.txtEndereso.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEndereso.Name = "txtEndereso";
            this.txtEndereso.Size = new System.Drawing.Size(164, 26);
            this.txtEndereso.TabIndex = 12;
            // 
            // btcancelar
            // 
            this.btcancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.Location = new System.Drawing.Point(320, 544);
            this.btcancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(125, 32);
            this.btcancelar.TabIndex = 33;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // DTFuncinarioCadastroDTNacimento
            // 
            this.DTFuncinarioCadastroDTNacimento.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DTFuncinarioCadastroDTNacimento.AllowDrop = true;
            this.DTFuncinarioCadastroDTNacimento.CustomFormat = "";
            this.DTFuncinarioCadastroDTNacimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFuncinarioCadastroDTNacimento.Location = new System.Drawing.Point(320, 388);
            this.DTFuncinarioCadastroDTNacimento.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DTFuncinarioCadastroDTNacimento.Name = "DTFuncinarioCadastroDTNacimento";
            this.DTFuncinarioCadastroDTNacimento.Size = new System.Drawing.Size(164, 26);
            this.DTFuncinarioCadastroDTNacimento.TabIndex = 9;
            this.DTFuncinarioCadastroDTNacimento.Value = new System.DateTime(2018, 5, 29, 0, 0, 0, 0);
            // 
            // dataGridViewFuncionario
            // 
            this.dataGridViewFuncionario.AllowUserToAddRows = false;
            this.dataGridViewFuncionario.AllowUserToDeleteRows = false;
            this.dataGridViewFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFuncionario.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewFuncionario.Location = new System.Drawing.Point(787, 71);
            this.dataGridViewFuncionario.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridViewFuncionario.Name = "dataGridViewFuncionario";
            this.dataGridViewFuncionario.ReadOnly = true;
            this.dataGridViewFuncionario.Size = new System.Drawing.Size(973, 463);
            this.dataGridViewFuncionario.TabIndex = 35;
            // 
            // txtFuncionarioNacionalidade
            // 
            this.txtFuncionarioNacionalidade.Location = new System.Drawing.Point(25, 294);
            this.txtFuncionarioNacionalidade.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFuncionarioNacionalidade.Name = "txtFuncionarioNacionalidade";
            this.txtFuncionarioNacionalidade.Size = new System.Drawing.Size(164, 26);
            this.txtFuncionarioNacionalidade.TabIndex = 3;
            // 
            // btEditar
            // 
            this.btEditar.Location = new System.Drawing.Point(832, 18);
            this.btEditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(125, 32);
            this.btEditar.TabIndex = 36;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(1032, 18);
            this.btCadastrar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(125, 32);
            this.btCadastrar.TabIndex = 37;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(1242, 18);
            this.btLimpar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(125, 32);
            this.btLimpar.TabIndex = 38;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            // 
            // btAtualizar
            // 
            this.btAtualizar.Location = new System.Drawing.Point(1435, 18);
            this.btAtualizar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(125, 32);
            this.btAtualizar.TabIndex = 39;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click);
            // 
            // FuncionarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 623);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.txtFuncionarioNacionalidade);
            this.Controls.Add(this.dataGridViewFuncionario);
            this.Controls.Add(this.DTFuncinarioCadastroDTNacimento);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.txtEndereso);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtEstadoCivil);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.mtbNumeroFixo);
            this.Controls.Add(this.mtbNumeroCelular);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.mtbcpf);
            this.Controls.Add(this.lbDataDENacimento);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbEndereso);
            this.Controls.Add(this.lbEstadoCivil);
            this.Controls.Add(this.lbSexo);
            this.Controls.Add(this.lbRG);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNumeroFixo);
            this.Controls.Add(this.lbNumeroCelular);
            this.Controls.Add(this.lbNacionalidade);
            this.Controls.Add(this.lbCurso);
            this.Controls.Add(this.lbNome);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FuncionarioForm";
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.Funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCurso;
        private System.Windows.Forms.Label lbNacionalidade;
        private System.Windows.Forms.Label lbNumeroCelular;
        private System.Windows.Forms.Label lbNumeroFixo;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbRG;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbEstadoCivil;
        private System.Windows.Forms.Label lbEndereso;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbDataDENacimento;
        private System.Windows.Forms.MaskedTextBox mtbcpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.MaskedTextBox mtbNumeroCelular;
        private System.Windows.Forms.MaskedTextBox mtbNumeroFixo;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstadoCivil;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txtEndereso;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.DateTimePicker DTFuncinarioCadastroDTNacimento;
        private System.Windows.Forms.DataGridView dataGridViewFuncionario;
        private System.Windows.Forms.TextBox txtFuncionarioNacionalidade;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btAtualizar;
    }
}