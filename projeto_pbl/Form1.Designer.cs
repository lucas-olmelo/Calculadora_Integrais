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
            panel1 = new Panel();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel2 = new Panel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label3 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            btnLimpar = new RoundedButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.BackColor = Color.LightSteelBlue;
            txtCoeficiente.BorderStyle = BorderStyle.FixedSingle;
            txtCoeficiente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeficiente.Location = new Point(259, 39);
            txtCoeficiente.Margin = new Padding(3, 4, 3, 4);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.PlaceholderText = "n";
            txtCoeficiente.Size = new Size(39, 34);
            txtCoeficiente.TabIndex = 0;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.BackColor = Color.Transparent;
            lblCoeficiente.Font = new Font("Verdana", 10.2F);
            lblCoeficiente.ForeColor = SystemColors.ControlLightLight;
            lblCoeficiente.Location = new Point(245, 15);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(104, 20);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.BackColor = Color.LightSteelBlue;
            comboOperador.FlatStyle = FlatStyle.Flat;
            comboOperador.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboOperador.ForeColor = SystemColors.ActiveCaptionText;
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(18, 37);
            comboOperador.Margin = new Padding(3, 4, 3, 4);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(62, 32);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.BackColor = Color.LightSteelBlue;
            txtVariavel.BorderStyle = BorderStyle.None;
            txtVariavel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVariavel.ForeColor = SystemColors.ControlText;
            txtVariavel.Location = new Point(361, 40);
            txtVariavel.Margin = new Padding(3, 4, 3, 4);
            txtVariavel.MaximumSize = new Size(30, 25);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(30, 25);
            txtVariavel.TabIndex = 4;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // comboFuncao
            // 
            comboFuncao.BackColor = Color.LightSteelBlue;
            comboFuncao.FlatStyle = FlatStyle.Flat;
            comboFuncao.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFuncao.ForeColor = SystemColors.ActiveCaptionText;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "Sqrt", "Sin", "Cos", "Tan", "Exp", "Log" });
            comboFuncao.Location = new Point(98, 37);
            comboFuncao.Margin = new Padding(3, 4, 3, 4);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(138, 32);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Font = new Font("Verdana", 10.2F);
            lblOpEspeciais.ForeColor = SystemColors.ControlLightLight;
            lblOpEspeciais.Location = new Point(98, 13);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(183, 20);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.BackColor = Color.LightSteelBlue;
            btnAdicionaTermo.FlatAppearance.BorderSize = 0;
            btnAdicionaTermo.FlatStyle = FlatStyle.Flat;
            btnAdicionaTermo.Font = new Font("Lucida Sans", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionaTermo.ForeColor = SystemColors.ControlText;
            btnAdicionaTermo.ImageKey = "(nenhum)";
            btnAdicionaTermo.Location = new Point(207, 89);
            btnAdicionaTermo.Margin = new Padding(3, 4, 3, 4);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(131, 35);
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
            txtFuncaoCompleta.Location = new Point(131, 35);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(362, 41);
            txtFuncaoCompleta.TabIndex = 8;
            txtFuncaoCompleta.Text = "A função irá aparecer aqui";
            // 
            // txtExpoente
            // 
            txtExpoente.BackColor = Color.LightSteelBlue;
            txtExpoente.BorderStyle = BorderStyle.FixedSingle;
            txtExpoente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpoente.Location = new Point(437, 38);
            txtExpoente.Margin = new Padding(3, 4, 3, 4);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.PlaceholderText = "2";
            txtExpoente.Size = new Size(49, 32);
            txtExpoente.TabIndex = 9;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            txtExpoente.TextChanged += txtExpoente_TextChanged;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.BackColor = Color.Transparent;
            lblOperador.Font = new Font("Verdana", 10.2F);
            lblOperador.ForeColor = SystemColors.ControlLightLight;
            lblOperador.Location = new Point(17, 15);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(88, 20);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.BackColor = Color.Transparent;
            lblVariável.Font = new Font("Verdana", 10.2F);
            lblVariável.ForeColor = SystemColors.ControlLightLight;
            lblVariável.Location = new Point(346, 17);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(77, 20);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.BackColor = Color.Transparent;
            lblExpoente.Font = new Font("Verdana", 10.2F);
            lblExpoente.ForeColor = SystemColors.ControlLightLight;
            lblExpoente.Location = new Point(431, 15);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(89, 20);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIntegral
            // 
            lblIntegral.AutoSize = true;
            lblIntegral.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegral.ForeColor = SystemColors.Control;
            lblIntegral.Location = new Point(7, 12);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(67, 81);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteB
            // 
            txtLimiteB.BackColor = Color.LightSteelBlue;
            txtLimiteB.BorderStyle = BorderStyle.None;
            txtLimiteB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimiteB.Location = new Point(80, 22);
            txtLimiteB.Name = "txtLimiteB";
            txtLimiteB.PlaceholderText = "b";
            txtLimiteB.Size = new Size(31, 25);
            txtLimiteB.TabIndex = 15;
            txtLimiteB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLimiteA
            // 
            txtLimiteA.BackColor = Color.LightSteelBlue;
            txtLimiteA.BorderStyle = BorderStyle.None;
            txtLimiteA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimiteA.ForeColor = SystemColors.ControlText;
            txtLimiteA.Location = new Point(80, 73);
            txtLimiteA.Name = "txtLimiteA";
            txtLimiteA.PlaceholderText = "a";
            txtLimiteA.Size = new Size(31, 25);
            txtLimiteA.TabIndex = 16;
            txtLimiteA.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumTrapezios
            // 
            lblNumTrapezios.AutoSize = true;
            lblNumTrapezios.BackColor = Color.Transparent;
            lblNumTrapezios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTrapezios.ForeColor = SystemColors.ControlLightLight;
            lblNumTrapezios.Location = new Point(25, 139);
            lblNumTrapezios.Name = "lblNumTrapezios";
            lblNumTrapezios.Size = new Size(49, 31);
            lblNumTrapezios.TabIndex = 17;
            lblNumTrapezios.Text = "n =";
            // 
            // txtNumTrap
            // 
            txtNumTrap.BackColor = Color.LightSteelBlue;
            txtNumTrap.BorderStyle = BorderStyle.None;
            txtNumTrap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTrap.Location = new Point(80, 139);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(53, 31);
            txtNumTrap.TabIndex = 18;
            txtNumTrap.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSteelBlue;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ControlText;
            btnCalcular.Location = new Point(204, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(123, 51);
            btnCalcular.TabIndex = 19;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GhostWhite;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1105, 40);
            panel1.TabIndex = 22;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(217, 25);
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
            nightControlBox1.Location = new Point(966, 0);
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
            panel2.Controls.Add(plotView1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(563, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(542, 587);
            panel2.TabIndex = 23;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.GhostWhite;
            plotView1.Location = new Point(15, 59);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(505, 505);
            plotView1.TabIndex = 25;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 19);
            label3.Name = "label3";
            label3.Size = new Size(208, 28);
            label3.TabIndex = 24;
            label3.Text = "Gráfico da área: ";
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
            panel4.Controls.Add(btnAdicionaTermo);
            panel4.Controls.Add(lblVariável);
            panel4.Controls.Add(comboOperador);
            panel4.Controls.Add(txtExpoente);
            panel4.Controls.Add(lblOperador);
            panel4.Location = new Point(14, 46);
            panel4.Name = "panel4";
            panel4.Size = new Size(543, 149);
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
            panel5.Controls.Add(txtLimiteA);
            panel5.Controls.Add(txtLimiteB);
            panel5.Location = new Point(7, 201);
            panel5.Name = "panel5";
            panel5.Size = new Size(550, 414);
            panel5.TabIndex = 24;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightSteelBlue;
            btnLimpar.BorderColor = Color.LightSteelBlue;
            btnLimpar.BorderRadius = 10;
            btnLimpar.BorderSize = 2;
            btnLimpar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.Location = new Point(214, 374);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(91, 29);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1105, 627);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
        private Panel panel5;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private RoundedButton btnLimpar;
    }
}
