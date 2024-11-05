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
            panel1 = new Panel();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel2 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.BackColor = Color.LightSteelBlue;
            txtCoeficiente.BorderStyle = BorderStyle.FixedSingle;
            txtCoeficiente.Location = new Point(227, 29);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(43, 23);
            txtCoeficiente.TabIndex = 0;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.BackColor = Color.Transparent;
            lblCoeficiente.ForeColor = SystemColors.ControlLightLight;
            lblCoeficiente.Location = new Point(214, 11);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(67, 15);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.BackColor = Color.LightSteelBlue;
            comboOperador.FlatStyle = FlatStyle.Flat;
            comboOperador.ForeColor = SystemColors.ControlLightLight;
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(26, 28);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(43, 23);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.BackColor = Color.LightSteelBlue;
            txtVariavel.BorderStyle = BorderStyle.None;
            txtVariavel.Font = new Font("Segoe UI", 12F);
            txtVariavel.ForeColor = SystemColors.ControlText;
            txtVariavel.Location = new Point(316, 31);
            txtVariavel.MaximumSize = new Size(26, 25);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(26, 22);
            txtVariavel.TabIndex = 4;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // comboFuncao
            // 
            comboFuncao.BackColor = Color.LightSteelBlue;
            comboFuncao.FlatStyle = FlatStyle.Flat;
            comboFuncao.ForeColor = SystemColors.ControlLightLight;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "Sqrt", "Sin", "Cos", "Tan", "Exp", "Log" });
            comboFuncao.Location = new Point(86, 28);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(121, 23);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.ForeColor = SystemColors.ControlLightLight;
            lblOpEspeciais.Location = new Point(86, 10);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(113, 15);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.BackColor = Color.LightSteelBlue;
            btnAdicionaTermo.FlatAppearance.BorderSize = 0;
            btnAdicionaTermo.FlatStyle = FlatStyle.Flat;
            btnAdicionaTermo.ForeColor = SystemColors.ControlText;
            btnAdicionaTermo.ImageKey = "(nenhum)";
            btnAdicionaTermo.Location = new Point(245, 45);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(88, 26);
            btnAdicionaTermo.TabIndex = 7;
            btnAdicionaTermo.Text = "Adicionar Termo";
            btnAdicionaTermo.UseVisualStyleBackColor = false;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.ForeColor = SystemColors.ControlLightLight;
            txtFuncaoCompleta.Location = new Point(136, 145);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(0, 32);
            txtFuncaoCompleta.TabIndex = 8;
            // 
            // txtExpoente
            // 
            txtExpoente.BackColor = Color.LightSteelBlue;
            txtExpoente.BorderStyle = BorderStyle.FixedSingle;
            txtExpoente.Location = new Point(382, 29);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(43, 23);
            txtExpoente.TabIndex = 9;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            txtExpoente.TextChanged += txtExpoente_TextChanged;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.BackColor = Color.Transparent;
            lblOperador.ForeColor = SystemColors.ControlLightLight;
            lblOperador.Location = new Point(15, 11);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(57, 15);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.BackColor = Color.Transparent;
            lblVariável.ForeColor = SystemColors.ControlLightLight;
            lblVariável.Location = new Point(303, 13);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(47, 15);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.BackColor = Color.Transparent;
            lblExpoente.ForeColor = SystemColors.ControlLightLight;
            lblExpoente.Location = new Point(377, 11);
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
            lblIntegral.ForeColor = SystemColors.ControlLightLight;
            lblIntegral.Location = new Point(40, 126);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(54, 65);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteB
            // 
            txtLimiteB.BackColor = Color.LightSteelBlue;
            txtLimiteB.BorderStyle = BorderStyle.None;
            txtLimiteB.Location = new Point(99, 133);
            txtLimiteB.Margin = new Padding(3, 2, 3, 2);
            txtLimiteB.Name = "txtLimiteB";
            txtLimiteB.Size = new Size(27, 16);
            txtLimiteB.TabIndex = 15;
            // 
            // txtLimiteA
            // 
            txtLimiteA.BackColor = Color.LightSteelBlue;
            txtLimiteA.BorderStyle = BorderStyle.None;
            txtLimiteA.ForeColor = SystemColors.ControlText;
            txtLimiteA.Location = new Point(99, 172);
            txtLimiteA.Margin = new Padding(3, 2, 3, 2);
            txtLimiteA.Name = "txtLimiteA";
            txtLimiteA.Size = new Size(27, 16);
            txtLimiteA.TabIndex = 16;
            // 
            // lblNumTrapezios
            // 
            lblNumTrapezios.AutoSize = true;
            lblNumTrapezios.BackColor = Color.Transparent;
            lblNumTrapezios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTrapezios.ForeColor = SystemColors.ControlLightLight;
            lblNumTrapezios.Location = new Point(438, 133);
            lblNumTrapezios.Name = "lblNumTrapezios";
            lblNumTrapezios.Size = new Size(41, 25);
            lblNumTrapezios.TabIndex = 17;
            lblNumTrapezios.Text = "n =";
            // 
            // txtNumTrap
            // 
            txtNumTrap.BackColor = Color.LightSteelBlue;
            txtNumTrap.BorderStyle = BorderStyle.None;
            txtNumTrap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTrap.Location = new Point(484, 133);
            txtNumTrap.Margin = new Padding(3, 2, 3, 2);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(46, 25);
            txtNumTrap.TabIndex = 18;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSteelBlue;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(235, 228);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 38);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightSteelBlue;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatStyle = FlatStyle.Flat;
            btnLimpar.ForeColor = SystemColors.ControlText;
            btnLimpar.Location = new Point(442, 175);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(88, 21);
            btnLimpar.TabIndex = 20;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(14, 30);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 30);
            lblResultado.TabIndex = 21;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 30);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 4);
            label1.Name = "label1";
            label1.Size = new Size(176, 20);
            label1.TabIndex = 23;
            label1.Text = "Calculadora de integrais";
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.GhostWhite;
            nightControlBox1.CloseHoverColor = Color.FromArgb(255, 128, 128);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(820, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSteelBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(599, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 420);
            panel2.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 111);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 24;
            label3.Text = "Gráfico da área: ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSlateBlue;
            panel6.Location = new Point(15, 143);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(326, 268);
            panel6.TabIndex = 23;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label2);
            panel3.Controls.Add(lblResultado);
            panel3.Location = new Point(15, 24);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(335, 63);
            panel3.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(11, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 20);
            label2.TabIndex = 23;
            label2.Text = "Resultado: ";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(comboFuncao);
            panel4.Controls.Add(lblOpEspeciais);
            panel4.Controls.Add(txtCoeficiente);
            panel4.Controls.Add(txtVariavel);
            panel4.Controls.Add(lblCoeficiente);
            panel4.Controls.Add(lblExpoente);
            panel4.Controls.Add(lblVariável);
            panel4.Controls.Add(comboOperador);
            panel4.Controls.Add(txtExpoente);
            panel4.Controls.Add(lblOperador);
            panel4.Location = new Point(66, 79);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(467, 58);
            panel4.TabIndex = 23;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.DarkSlateBlue;
            panel5.Controls.Add(btnLimpar);
            panel5.Controls.Add(txtFuncaoCompleta);
            panel5.Controls.Add(lblNumTrapezios);
            panel5.Controls.Add(txtNumTrap);
            panel5.Controls.Add(btnCalcular);
            panel5.Controls.Add(lblIntegral);
            panel5.Controls.Add(btnAdicionaTermo);
            panel5.Controls.Add(txtLimiteA);
            panel5.Controls.Add(txtLimiteB);
            panel5.Location = new Point(3, 141);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(593, 268);
            panel5.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(959, 450);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
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
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label3;
        private Panel panel6;
        private Panel panel5;
    }
}
