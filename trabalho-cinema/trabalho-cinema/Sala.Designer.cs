using System;

namespace TRABALHO_CINEMA
{
    partial class Sala
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
            this.lbNumeroDaSala = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbHorarioDisponivel = new System.Windows.Forms.Label();
            this.lbQuantidadeDeSalas = new System.Windows.Forms.Label();
            this.lbQuantidadeDeAcentos = new System.Windows.Forms.Label();
            this.lbTiposDeAcentos = new System.Windows.Forms.Label();
            this.lbLarguraDaSala = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbDataDisponivel = new System.Windows.Forms.Label();
            this.cbNumeroSala = new System.Windows.Forms.ComboBox();
            this.cbsetor = new System.Windows.Forms.ComboBox();
            this.cbHorarioDisponinel = new System.Windows.Forms.ComboBox();
            this.cbTipoDeAcento = new System.Windows.Forms.ComboBox();
            this.cbDataDisponivel = new System.Windows.Forms.ComboBox();
            this.txtQuantidadeDeSalas = new System.Windows.Forms.TextBox();
            this.txtQuantidadeAcentos = new System.Windows.Forms.TextBox();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btCatastra = new System.Windows.Forms.Button();
            this.btAtualizar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btLimpar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btCanceral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumeroDaSala
            // 
            this.lbNumeroDaSala.AutoSize = true;
            this.lbNumeroDaSala.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumeroDaSala.Location = new System.Drawing.Point(44, 44);
            this.lbNumeroDaSala.Name = "lbNumeroDaSala";
            this.lbNumeroDaSala.Size = new System.Drawing.Size(134, 18);
            this.lbNumeroDaSala.TabIndex = 0;
            this.lbNumeroDaSala.Text = "Numero da Sala";
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSetor.Location = new System.Drawing.Point(44, 140);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(52, 18);
            this.lbSetor.TabIndex = 1;
            this.lbSetor.Text = "Setor";
            // 
            // lbHorarioDisponivel
            // 
            this.lbHorarioDisponivel.AutoSize = true;
            this.lbHorarioDisponivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorarioDisponivel.Location = new System.Drawing.Point(44, 253);
            this.lbHorarioDisponivel.Name = "lbHorarioDisponivel";
            this.lbHorarioDisponivel.Size = new System.Drawing.Size(152, 18);
            this.lbHorarioDisponivel.TabIndex = 2;
            this.lbHorarioDisponivel.Text = "Horario disponivel";
            // 
            // lbQuantidadeDeSalas
            // 
            this.lbQuantidadeDeSalas.AutoSize = true;
            this.lbQuantidadeDeSalas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeDeSalas.Location = new System.Drawing.Point(297, 44);
            this.lbQuantidadeDeSalas.Name = "lbQuantidadeDeSalas";
            this.lbQuantidadeDeSalas.Size = new System.Drawing.Size(173, 18);
            this.lbQuantidadeDeSalas.TabIndex = 3;
            this.lbQuantidadeDeSalas.Text = "Quantidade de Salas";
            // 
            // lbQuantidadeDeAcentos
            // 
            this.lbQuantidadeDeAcentos.AutoSize = true;
            this.lbQuantidadeDeAcentos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantidadeDeAcentos.Location = new System.Drawing.Point(297, 140);
            this.lbQuantidadeDeAcentos.Name = "lbQuantidadeDeAcentos";
            this.lbQuantidadeDeAcentos.Size = new System.Drawing.Size(196, 18);
            this.lbQuantidadeDeAcentos.TabIndex = 4;
            this.lbQuantidadeDeAcentos.Text = "Quantidade de Acentos";
            // 
            // lbTiposDeAcentos
            // 
            this.lbTiposDeAcentos.AutoSize = true;
            this.lbTiposDeAcentos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTiposDeAcentos.Location = new System.Drawing.Point(297, 253);
            this.lbTiposDeAcentos.Name = "lbTiposDeAcentos";
            this.lbTiposDeAcentos.Size = new System.Drawing.Size(146, 18);
            this.lbTiposDeAcentos.TabIndex = 5;
            this.lbTiposDeAcentos.Text = "Tipos de Acentos";
            // 
            // lbLarguraDaSala
            // 
            this.lbLarguraDaSala.AutoSize = true;
            this.lbLarguraDaSala.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLarguraDaSala.Location = new System.Drawing.Point(297, 346);
            this.lbLarguraDaSala.Name = "lbLarguraDaSala";
            this.lbLarguraDaSala.Size = new System.Drawing.Size(135, 18);
            this.lbLarguraDaSala.TabIndex = 6;
            this.lbLarguraDaSala.Text = "Largura da Sala";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(533, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // lbDataDisponivel
            // 
            this.lbDataDisponivel.AutoSize = true;
            this.lbDataDisponivel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDataDisponivel.Location = new System.Drawing.Point(44, 346);
            this.lbDataDisponivel.Name = "lbDataDisponivel";
            this.lbDataDisponivel.Size = new System.Drawing.Size(132, 18);
            this.lbDataDisponivel.TabIndex = 8;
            this.lbDataDisponivel.Text = "Data Disponivel";
            // 
            // cbNumeroSala
            // 
            this.cbNumeroSala.FormattingEnabled = true;
            this.cbNumeroSala.Items.AddRange(new object[] {
            "Sala 1",
            "Sala 2",
            "Sala 3",
            "Sala 4",
            "Sala 5"});
            this.cbNumeroSala.Location = new System.Drawing.Point(38, 60);
            this.cbNumeroSala.Name = "cbNumeroSala";
            this.cbNumeroSala.Size = new System.Drawing.Size(121, 21);
            this.cbNumeroSala.TabIndex = 9;
            // 
            // cbsetor
            // 
            this.cbsetor.FormattingEnabled = true;
            this.cbsetor.Items.AddRange(new object[] {
            "Setor A",
            "Setor B",
            "Setor C",
            "Setor D",
            "Setor E"});
            this.cbsetor.Location = new System.Drawing.Point(38, 170);
            this.cbsetor.Name = "cbsetor";
            this.cbsetor.Size = new System.Drawing.Size(121, 21);
            this.cbsetor.TabIndex = 10;
            // 
            // cbHorarioDisponinel
            // 
            this.cbHorarioDisponinel.FormattingEnabled = true;
            this.cbHorarioDisponinel.Items.AddRange(new object[] {
            "8:30",
            "11:10",
            "13:18",
            "14:20",
            "15:07",
            "17:00"});
            this.cbHorarioDisponinel.Location = new System.Drawing.Point(38, 284);
            this.cbHorarioDisponinel.Name = "cbHorarioDisponinel";
            this.cbHorarioDisponinel.Size = new System.Drawing.Size(121, 21);
            this.cbHorarioDisponinel.TabIndex = 11;
            // 
            // cbTipoDeAcento
            // 
            this.cbTipoDeAcento.FormattingEnabled = true;
            this.cbTipoDeAcento.Items.AddRange(new object[] {
            "Normal",
            "Infantil",
            "Cadeirante"});
            this.cbTipoDeAcento.Location = new System.Drawing.Point(300, 284);
            this.cbTipoDeAcento.Name = "cbTipoDeAcento";
            this.cbTipoDeAcento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoDeAcento.TabIndex = 12;
            // 
            // cbDataDisponivel
            // 
            this.cbDataDisponivel.FormattingEnabled = true;
            this.cbDataDisponivel.Items.AddRange(new object[] {
            "Segunda",
            "Tersa",
            "Quarta",
            "Quinta",
            "Sexta",
            "Sabado"});
            this.cbDataDisponivel.Location = new System.Drawing.Point(38, 394);
            this.cbDataDisponivel.Name = "cbDataDisponivel";
            this.cbDataDisponivel.Size = new System.Drawing.Size(121, 21);
            this.cbDataDisponivel.TabIndex = 13;
            // 
            // txtQuantidadeDeSalas
            // 
            this.txtQuantidadeDeSalas.Location = new System.Drawing.Point(300, 72);
            this.txtQuantidadeDeSalas.Name = "txtQuantidadeDeSalas";
            this.txtQuantidadeDeSalas.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeDeSalas.TabIndex = 14;
            // 
            // txtQuantidadeAcentos
            // 
            this.txtQuantidadeAcentos.Location = new System.Drawing.Point(300, 171);
            this.txtQuantidadeAcentos.Name = "txtQuantidadeAcentos";
            this.txtQuantidadeAcentos.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidadeAcentos.TabIndex = 15;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(300, 394);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(100, 20);
            this.txtLargura.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(501, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(435, 226);
            this.dataGridView1.TabIndex = 17;
            // 
            // btCatastra
            // 
            this.btCatastra.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCatastra.Location = new System.Drawing.Point(486, 29);
            this.btCatastra.Name = "btCatastra";
            this.btCatastra.Size = new System.Drawing.Size(95, 33);
            this.btCatastra.TabIndex = 18;
            this.btCatastra.Text = "Cadastrar";
            this.btCatastra.UseVisualStyleBackColor = true;
            this.btCatastra.Click += new System.EventHandler(this.btCatastra_Click);
            // 
            // btAtualizar
            // 
            this.btAtualizar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizar.Location = new System.Drawing.Point(611, 28);
            this.btAtualizar.Name = "btAtualizar";
            this.btAtualizar.Size = new System.Drawing.Size(91, 34);
            this.btAtualizar.TabIndex = 19;
            this.btAtualizar.Text = "Atualizar";
            this.btAtualizar.UseVisualStyleBackColor = true;
            this.btAtualizar.Click += new System.EventHandler(this.btAtualizar_Click_1);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(738, 29);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(75, 33);
            this.btEditar.TabIndex = 20;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            // 
            // btLimpar
            // 
            this.btLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimpar.Location = new System.Drawing.Point(839, 29);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 33);
            this.btLimpar.TabIndex = 21;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.Location = new System.Drawing.Point(536, 415);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(75, 23);
            this.btSalvar.TabIndex = 22;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btCanceral
            // 
            this.btCanceral.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCanceral.Location = new System.Drawing.Point(700, 415);
            this.btCanceral.Name = "btCanceral";
            this.btCanceral.Size = new System.Drawing.Size(75, 23);
            this.btCanceral.TabIndex = 23;
            this.btCanceral.Text = "Cancelar";
            this.btCanceral.UseVisualStyleBackColor = true;
            this.btCanceral.Click += new System.EventHandler(this.btCanceral_Click);
            // 
            // Sala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.btCanceral);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btAtualizar);
            this.Controls.Add(this.btCatastra);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.txtQuantidadeAcentos);
            this.Controls.Add(this.txtQuantidadeDeSalas);
            this.Controls.Add(this.cbDataDisponivel);
            this.Controls.Add(this.cbTipoDeAcento);
            this.Controls.Add(this.cbHorarioDisponinel);
            this.Controls.Add(this.cbsetor);
            this.Controls.Add(this.cbNumeroSala);
            this.Controls.Add(this.lbDataDisponivel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbLarguraDaSala);
            this.Controls.Add(this.lbTiposDeAcentos);
            this.Controls.Add(this.lbQuantidadeDeAcentos);
            this.Controls.Add(this.lbQuantidadeDeSalas);
            this.Controls.Add(this.lbHorarioDisponivel);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.lbNumeroDaSala);
            this.Name = "Sala";
            this.Text = "Sala";
            this.Load += new System.EventHandler(this.Sala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btAtualizar_Click_1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            SalaObeserver.atualivarGrid();
        }

        #endregion

        private System.Windows.Forms.Label lbNumeroDaSala;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbHorarioDisponivel;
        private System.Windows.Forms.Label lbQuantidadeDeSalas;
        private System.Windows.Forms.Label lbQuantidadeDeAcentos;
        private System.Windows.Forms.Label lbTiposDeAcentos;
        private System.Windows.Forms.Label lbLarguraDaSala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbDataDisponivel;
        private System.Windows.Forms.ComboBox cbNumeroSala;
        private System.Windows.Forms.ComboBox cbsetor;
        private System.Windows.Forms.ComboBox cbHorarioDisponinel;
        private System.Windows.Forms.ComboBox cbTipoDeAcento;
        private System.Windows.Forms.ComboBox cbDataDisponivel;
        private System.Windows.Forms.TextBox txtQuantidadeDeSalas;
        private System.Windows.Forms.TextBox txtQuantidadeAcentos;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btCatastra;
        private System.Windows.Forms.Button btAtualizar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btCanceral;
    }
}