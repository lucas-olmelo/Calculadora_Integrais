namespace projeto_pbl
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCoeficiente = new TextBox();
            lblCoeficiente = new Label();
            comboOperador = new ComboBox();
            txtVariavel = new TextBox();
            comboFuncao = new ComboBox();
            lblOpEspeciais = new Label();
            btnAdicionaTermo = new Button();
            txtFuncaoCompleta = new Label();
            txtExpoente = new TextBox();
            lblOperador = new Label();
            lblVariável = new Label();
            lblExpoente = new Label();
            richTextBoxFuncaoCompleta = new RichTextBox();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(397, 114);
            txtCoeficiente.Margin = new Padding(3, 4, 3, 4);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(49, 27);
            txtCoeficiente.TabIndex = 0;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.Location = new Point(383, 90);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(84, 20);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(143, 114);
            comboOperador.Margin = new Padding(3, 4, 3, 4);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(49, 28);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.Location = new Point(502, 115);
            txtVariavel.Margin = new Padding(3, 4, 3, 4);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(23, 27);
            txtVariavel.TabIndex = 4;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // comboFuncao
            // 
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "sen", "cos", "tan", "exp", "log" });
            comboFuncao.Location = new Point(222, 114);
            comboFuncao.Margin = new Padding(3, 4, 3, 4);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(138, 28);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Location = new Point(222, 89);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(144, 20);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.Location = new Point(688, 89);
            btnAdicionaTermo.Margin = new Padding(3, 4, 3, 4);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(86, 76);
            btnAdicionaTermo.TabIndex = 7;
            btnAdicionaTermo.Text = "Adicionar Termo";
            btnAdicionaTermo.UseVisualStyleBackColor = true;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.Location = new Point(186, 189);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(121, 41);
            txtFuncaoCompleta.TabIndex = 8;
            txtFuncaoCompleta.Text = "Função:";
            // 
            // txtExpoente
            // 
            txtExpoente.Location = new Point(586, 115);
            txtExpoente.Margin = new Padding(3, 4, 3, 4);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(47, 27);
            txtExpoente.TabIndex = 9;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(132, 91);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(73, 20);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.Location = new Point(484, 91);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(61, 20);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.Location = new Point(575, 91);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(71, 20);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // richTextBoxFuncaoCompleta
            // 
            richTextBoxFuncaoCompleta.Location = new Point(192, 245);
            richTextBoxFuncaoCompleta.Name = "richTextBoxFuncaoCompleta";
            richTextBoxFuncaoCompleta.Size = new Size(376, 120);
            richTextBoxFuncaoCompleta.TabIndex = 13;
            richTextBoxFuncaoCompleta.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(richTextBoxFuncaoCompleta);
            Controls.Add(lblExpoente);
            Controls.Add(lblVariável);
            Controls.Add(lblOperador);
            Controls.Add(txtExpoente);
            Controls.Add(txtFuncaoCompleta);
            Controls.Add(btnAdicionaTermo);
            Controls.Add(lblOpEspeciais);
            Controls.Add(comboFuncao);
            Controls.Add(txtVariavel);
            Controls.Add(comboOperador);
            Controls.Add(lblCoeficiente);
            Controls.Add(txtCoeficiente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCoeficiente;
        private Label lblCoeficiente;
        private ComboBox comboOperador;
        private TextBox txtVariavel;
        private ComboBox comboFuncao;
        private Label lblOpEspeciais;
        private Button btnAdicionaTermo;
        private Label txtFuncaoCompleta;
        private TextBox txtExpoente;
        private Label lblOperador;
        private Label lblVariável;
        private Label lblExpoente;
        private RichTextBox richTextBoxFuncaoCompleta;
    }
}
