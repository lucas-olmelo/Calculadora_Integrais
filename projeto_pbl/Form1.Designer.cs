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
            txtLimiteB = new TextBox();
            txtLimiteA = new TextBox();
            lblNumTrapezios = new Label();
            txtNumTrap = new TextBox();
            btnCalcular = new Button();
            btnLimpar = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(265, 80);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(43, 23);
            txtCoeficiente.TabIndex = 0;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.Location = new Point(253, 62);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(67, 15);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(43, 80);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(43, 23);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.Location = new Point(357, 81);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(21, 23);
            txtVariavel.TabIndex = 4;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // comboFuncao
            // 
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "sen", "cos", "tan", "exp", "log" });
            comboFuncao.Location = new Point(112, 80);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(121, 23);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Location = new Point(112, 62);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(113, 15);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.Location = new Point(508, 63);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(154, 39);
            btnAdicionaTermo.TabIndex = 7;
            btnAdicionaTermo.Text = "Adicionar Termo";
            btnAdicionaTermo.UseVisualStyleBackColor = true;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.Location = new Point(109, 165);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(0, 32);
            txtFuncaoCompleta.TabIndex = 8;
            // 
            // txtExpoente
            // 
            txtExpoente.Location = new Point(430, 81);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(42, 23);
            txtExpoente.TabIndex = 9;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.Location = new Point(33, 63);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(57, 15);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.Location = new Point(341, 63);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(47, 15);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.Location = new Point(421, 63);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(56, 15);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIntegral
            // 
            lblIntegral.AutoSize = true;
            lblIntegral.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegral.Location = new Point(33, 142);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(54, 65);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteB
            // 
            txtLimiteB.Location = new Point(76, 151);
            txtLimiteB.Margin = new Padding(3, 2, 3, 2);
            txtLimiteB.Name = "txtLimiteB";
            txtLimiteB.Size = new Size(28, 23);
            txtLimiteB.TabIndex = 15;
            // 
            // txtLimiteA
            // 
            txtLimiteA.Location = new Point(76, 190);
            txtLimiteA.Margin = new Padding(3, 2, 3, 2);
            txtLimiteA.Name = "txtLimiteA";
            txtLimiteA.Size = new Size(28, 23);
            txtLimiteA.TabIndex = 16;
            // 
            // lblNumTrapezios
            // 
            lblNumTrapezios.AutoSize = true;
            lblNumTrapezios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTrapezios.Location = new Point(430, 171);
            lblNumTrapezios.Name = "lblNumTrapezios";
            lblNumTrapezios.Size = new Size(41, 25);
            lblNumTrapezios.TabIndex = 17;
            lblNumTrapezios.Text = "n =";
            // 
            // txtNumTrap
            // 
            txtNumTrap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTrap.Location = new Point(472, 169);
            txtNumTrap.Margin = new Padding(3, 2, 3, 2);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(38, 32);
            txtNumTrap.TabIndex = 18;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(576, 171);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(82, 22);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(682, 171);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(82, 22);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(54, 255);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 37);
            lblResultado.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnLimpar);
            Controls.Add(btnCalcular);
            Controls.Add(txtNumTrap);
            Controls.Add(lblNumTrapezios);
            Controls.Add(txtLimiteA);
            Controls.Add(txtLimiteB);
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
        private TextBox txtLimiteB;
        private TextBox txtLimiteA;
        private Label lblNumTrapezios;
        private TextBox txtNumTrap;
        private Button btnCalcular;
        private Button btnLimpar;
        private Label lblResultado;
    }
}
