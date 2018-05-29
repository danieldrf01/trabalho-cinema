namespace trabalho_cinema
{
    partial class Salas
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
            this.lbNumeroSala = new System.Windows.Forms.Label();
            this.lbSetor = new System.Windows.Forms.Label();
            this.lbHorarioDisponivel = new System.Windows.Forms.Label();
            this.lbDataDisponivel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comcbNumeroSala = new System.Windows.Forms.ComboBox();
            this.cbSetor = new System.Windows.Forms.ComboBox();
            this.cbHorarioDisponivel = new System.Windows.Forms.ComboBox();
            this.cbDataDisponivel = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNumeroSala
            // 
            this.lbNumeroSala.AutoSize = true;
            this.lbNumeroSala.Location = new System.Drawing.Point(111, 38);
            this.lbNumeroSala.Name = "lbNumeroSala";
            this.lbNumeroSala.Size = new System.Drawing.Size(83, 13);
            this.lbNumeroSala.TabIndex = 0;
            this.lbNumeroSala.Text = "Numero da Sala";
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Location = new System.Drawing.Point(112, 118);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(32, 13);
            this.lbSetor.TabIndex = 1;
            this.lbSetor.Text = "Setor";
            // 
            // lbHorarioDisponivel
            // 
            this.lbHorarioDisponivel.AutoSize = true;
            this.lbHorarioDisponivel.Location = new System.Drawing.Point(111, 216);
            this.lbHorarioDisponivel.Name = "lbHorarioDisponivel";
            this.lbHorarioDisponivel.Size = new System.Drawing.Size(93, 13);
            this.lbHorarioDisponivel.TabIndex = 2;
            this.lbHorarioDisponivel.Text = "Horario Disponivel";
            // 
            // lbDataDisponivel
            // 
            this.lbDataDisponivel.AutoSize = true;
            this.lbDataDisponivel.Location = new System.Drawing.Point(112, 336);
            this.lbDataDisponivel.Name = "lbDataDisponivel";
            this.lbDataDisponivel.Size = new System.Drawing.Size(82, 13);
            this.lbDataDisponivel.TabIndex = 3;
            this.lbDataDisponivel.Text = "Data Disponivel";
            this.lbDataDisponivel.UseMnemonic = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(486, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantidade de Salas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantadade de Acentos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(489, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Largura Da Sale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(486, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Tipo De Acentos";
            // 
            // comcbNumeroSala
            // 
            this.comcbNumeroSala.FormattingEnabled = true;
            this.comcbNumeroSala.Location = new System.Drawing.Point(114, 68);
            this.comcbNumeroSala.Name = "comcbNumeroSala";
            this.comcbNumeroSala.Size = new System.Drawing.Size(121, 21);
            this.comcbNumeroSala.TabIndex = 0;
            // 
            // cbSetor
            // 
            this.cbSetor.FormattingEnabled = true;
            this.cbSetor.Location = new System.Drawing.Point(114, 156);
            this.cbSetor.Name = "cbSetor";
            this.cbSetor.Size = new System.Drawing.Size(121, 21);
            this.cbSetor.TabIndex = 1;
            // 
            // cbHorarioDisponivel
            // 
            this.cbHorarioDisponivel.FormattingEnabled = true;
            this.cbHorarioDisponivel.Location = new System.Drawing.Point(114, 250);
            this.cbHorarioDisponivel.Name = "cbHorarioDisponivel";
            this.cbHorarioDisponivel.Size = new System.Drawing.Size(121, 21);
            this.cbHorarioDisponivel.TabIndex = 2;
            this.cbHorarioDisponivel.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // cbDataDisponivel
            // 
            this.cbDataDisponivel.FormattingEnabled = true;
            this.cbDataDisponivel.Location = new System.Drawing.Point(115, 373);
            this.cbDataDisponivel.Name = "cbDataDisponivel";
            this.cbDataDisponivel.Size = new System.Drawing.Size(121, 21);
            this.cbDataDisponivel.TabIndex = 3;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(488, 171);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 5;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(492, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(492, 276);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(489, 373);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Image = global::trabalho_cinema.Properties.Resources.diskette;
            this.button2.Location = new System.Drawing.Point(618, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 47);
            this.button2.TabIndex = 26;
            this.button2.Text = "Salvar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Image = global::trabalho_cinema.Properties.Resources.x_button;
            this.button1.Location = new System.Drawing.Point(435, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Salas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 535);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbDataDisponivel);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.cbHorarioDisponivel);
            this.Controls.Add(this.cbSetor);
            this.Controls.Add(this.comcbNumeroSala);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDataDisponivel);
            this.Controls.Add(this.lbHorarioDisponivel);
            this.Controls.Add(this.lbNumeroSala);
            this.Name = "Salas";
            this.Text = "Salas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumeroSala;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.Label lbHorarioDisponivel;
        private System.Windows.Forms.Label lbDataDisponivel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comcbNumeroSala;
        private System.Windows.Forms.ComboBox cbSetor;
        private System.Windows.Forms.ComboBox cbHorarioDisponivel;
        private System.Windows.Forms.ComboBox cbDataDisponivel;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}