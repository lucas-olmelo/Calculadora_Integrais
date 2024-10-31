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
            lblIntegral = new Label();
            txtLimiteA = new TextBox();
            txtLimiteB = new TextBox();
            lblNumTrapezios = new Label();
            txtNumTrap = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(303, 107);
            txtCoeficiente.Margin = new Padding(3, 4, 3, 4);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(49, 27);
            txtCoeficiente.TabIndex = 0;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.Location = new Point(289, 83);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(84, 20);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(49, 107);
            comboOperador.Margin = new Padding(3, 4, 3, 4);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(49, 28);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.Location = new Point(408, 108);
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
            comboFuncao.Location = new Point(128, 107);
            comboFuncao.Margin = new Padding(3, 4, 3, 4);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(138, 28);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Location = new Point(128, 82);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(144, 20);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.Location = new Point(580, 84);
            btnAdicionaTermo.Margin = new Padding(3, 4, 3, 4);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(176, 52);
            btnAdicionaTermo.TabIndex = 7;
            btnAdicionaTermo.Text = "Adicionar Termo";
            btnAdicionaTermo.UseVisualStyleBackColor = true;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.Location = new Point(125, 220);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(0, 41);
            txtFuncaoCompleta.TabIndex = 8;
            // 
            // txtExpoente
            // 
            txtExpoente.Location = new Point(492, 108);
            txtExpoente.Margin = new Padding(3, 4, 3, 4);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(47, 27);
            txtExpoente.TabIndex = 9;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(38, 84);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(73, 20);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.Location = new Point(390, 84);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(61, 20);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.Location = new Point(481, 84);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(71, 20);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIntegral
            // 
            lblIntegral.AutoSize = true;
            lblIntegral.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegral.Location = new Point(38, 190);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(67, 81);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteA
            // 
            txtLimiteA.Location = new Point(87, 201);
            txtLimiteA.Name = "txtLimiteA";
            txtLimiteA.Size = new Size(32, 27);
            txtLimiteA.TabIndex = 15;
            // 
            // txtLimiteB
            // 
            txtLimiteB.Location = new Point(87, 253);
            txtLimiteB.Name = "txtLimiteB";
            txtLimiteB.Size = new Size(32, 27);
            txtLimiteB.TabIndex = 16;
            // 
            // lblNumTrapezios
            // 
            lblNumTrapezios.AutoSize = true;
            lblNumTrapezios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTrapezios.Location = new Point(491, 228);
            lblNumTrapezios.Name = "lblNumTrapezios";
            lblNumTrapezios.Size = new Size(49, 31);
            lblNumTrapezios.TabIndex = 17;
            lblNumTrapezios.Text = "n =";
            // 
            // txtNumTrap
            // 
            txtNumTrap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTrap.Location = new Point(539, 225);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(43, 38);
            txtNumTrap.TabIndex = 18;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(658, 228);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(779, 228);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(94, 29);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(62, 340);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 20);
            lblResultado.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumTrap);
            Controls.Add(lblNumTrapezios);
            Controls.Add(txtLimiteB);
            Controls.Add(txtLimiteA);
            Controls.Add(lblIntegral);
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
        private Label lblIntegral;
        private TextBox txtLimiteA;
        private TextBox txtLimiteB;
        private Label lblNumTrapezios;
        private TextBox txtNumTrap;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblResultado;
    }
}
