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
            lblCoeficiente = new Label();
            comboOperador = new ComboBox();
            comboFuncao = new ComboBox();
            lblOpEspeciais = new Label();
            txtFuncaoCompleta = new Label();
            lblOperador = new Label();
            lblVariável = new Label();
            lblExpoente = new Label();
            lblIntegral = new Label();
            txtLimiteB = new TextBox();
            txtLimiteA = new TextBox();
            lblNumTrapezios = new Label();
            txtNumTrap = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel2 = new Panel();
            plotView1 = new OxyPlot.WindowsForms.PlotView();
            label3 = new Label();
            fieldsPanel = new Panel();
            btnAdicionaTermo = new RoundedButton();
            txtVariavel = new TextBox();
            txtExpoente = new TextBox();
            txtCoeficiente = new TextBox();
            functionPanel = new Panel();
            btnCalcular = new RoundedButton();
            btnLimpar = new RoundedButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            fieldsPanel.SuspendLayout();
            functionPanel.SuspendLayout();
            SuspendLayout();
            // 
            // lblCoeficiente
            // 
            lblCoeficiente.AutoSize = true;
            lblCoeficiente.BackColor = Color.Transparent;
            lblCoeficiente.Font = new Font("Verdana", 9F);
            lblCoeficiente.ForeColor = SystemColors.ControlLightLight;
            lblCoeficiente.Location = new Point(274, 17);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(90, 18);
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
            // comboFuncao
            // 
            comboFuncao.BackColor = Color.LightSteelBlue;
            comboFuncao.FlatStyle = FlatStyle.Flat;
            comboFuncao.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFuncao.ForeColor = SystemColors.ActiveCaptionText;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "Sqrt", "Sin", "Cos", "Tan", "Exp", "Log" });
            comboFuncao.Location = new Point(118, 37);
            comboFuncao.Margin = new Padding(3, 4, 3, 4);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(138, 32);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Font = new Font("Verdana", 9F);
            lblOpEspeciais.ForeColor = SystemColors.ControlLightLight;
            lblOpEspeciais.Location = new Point(107, 15);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(159, 18);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.ForeColor = SystemColors.ControlLightLight;
            txtFuncaoCompleta.Location = new Point(125, 51);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(0, 41);
            txtFuncaoCompleta.TabIndex = 8;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.BackColor = Color.Transparent;
            lblOperador.Font = new Font("Verdana", 9F);
            lblOperador.ForeColor = SystemColors.ControlLightLight;
            lblOperador.Location = new Point(13, 15);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(78, 18);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.BackColor = Color.Transparent;
            lblVariável.Font = new Font("Verdana", 9F);
            lblVariável.ForeColor = SystemColors.ControlLightLight;
            lblVariável.Location = new Point(377, 17);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(65, 18);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.BackColor = Color.Transparent;
            lblExpoente.Font = new Font("Verdana", 9F);
            lblExpoente.ForeColor = SystemColors.ControlLightLight;
            lblExpoente.Location = new Point(451, 17);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(78, 18);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIntegral
            // 
            lblIntegral.AutoSize = true;
            lblIntegral.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegral.ForeColor = SystemColors.Control;
            lblIntegral.Location = new Point(20, 7);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(88, 106);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteB
            // 
            txtLimiteB.BackColor = Color.LightSteelBlue;
            txtLimiteB.BorderStyle = BorderStyle.None;
            txtLimiteB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimiteB.Location = new Point(80, 26);
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
            txtLimiteA.Location = new Point(80, 88);
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
            lblNumTrapezios.Location = new Point(407, 53);
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
            txtNumTrap.Location = new Point(462, 53);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(53, 31);
            txtNumTrap.TabIndex = 18;
            txtNumTrap.TextAlign = HorizontalAlignment.Center;
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
            // fieldsPanel
            // 
            fieldsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fieldsPanel.BackColor = Color.Transparent;
            fieldsPanel.Controls.Add(btnAdicionaTermo);
            fieldsPanel.Controls.Add(txtVariavel);
            fieldsPanel.Controls.Add(txtExpoente);
            fieldsPanel.Controls.Add(txtCoeficiente);
            fieldsPanel.Controls.Add(comboFuncao);
            fieldsPanel.Controls.Add(lblOpEspeciais);
            fieldsPanel.Controls.Add(lblCoeficiente);
            fieldsPanel.Controls.Add(lblExpoente);
            fieldsPanel.Controls.Add(lblVariável);
            fieldsPanel.Controls.Add(comboOperador);
            fieldsPanel.Controls.Add(lblOperador);
            fieldsPanel.Location = new Point(14, 46);
            fieldsPanel.Name = "fieldsPanel";
            fieldsPanel.Size = new Size(543, 149);
            fieldsPanel.TabIndex = 23;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.BackColor = Color.LightSteelBlue;
            btnAdicionaTermo.BorderColor = Color.Black;
            btnAdicionaTermo.BorderRadius = 20;
            btnAdicionaTermo.BorderSize = 2;
            btnAdicionaTermo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionaTermo.HoverBackColor = Color.LightGray;
            btnAdicionaTermo.Location = new Point(207, 87);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.NormalBackColor = Color.LightSteelBlue;
            btnAdicionaTermo.Size = new Size(124, 38);
            btnAdicionaTermo.TabIndex = 22;
            btnAdicionaTermo.Text = "Adicionar";
            btnAdicionaTermo.UseVisualStyleBackColor = false;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtVariavel
            // 
            txtVariavel.BackColor = Color.LightSteelBlue;
            txtVariavel.BorderStyle = BorderStyle.None;
            txtVariavel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVariavel.Location = new Point(390, 41);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(31, 25);
            txtVariavel.TabIndex = 18;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExpoente
            // 
            txtExpoente.BackColor = Color.LightSteelBlue;
            txtExpoente.BorderStyle = BorderStyle.None;
            txtExpoente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpoente.Location = new Point(476, 41);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(31, 25);
            txtExpoente.TabIndex = 17;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.BackColor = Color.LightSteelBlue;
            txtCoeficiente.BorderStyle = BorderStyle.None;
            txtCoeficiente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeficiente.Location = new Point(306, 41);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.PlaceholderText = " ";
            txtCoeficiente.Size = new Size(31, 25);
            txtCoeficiente.TabIndex = 16;
            txtCoeficiente.TextAlign = HorizontalAlignment.Center;
            // 
            // functionPanel
            // 
            functionPanel.Anchor = AnchorStyles.None;
            functionPanel.BackColor = Color.Transparent;
            functionPanel.Controls.Add(btnCalcular);
            functionPanel.Controls.Add(btnLimpar);
            functionPanel.Controls.Add(txtFuncaoCompleta);
            functionPanel.Controls.Add(lblNumTrapezios);
            functionPanel.Controls.Add(txtNumTrap);
            functionPanel.Controls.Add(txtLimiteA);
            functionPanel.Controls.Add(txtLimiteB);
            functionPanel.Controls.Add(lblIntegral);
            functionPanel.Location = new Point(7, 201);
            functionPanel.Name = "functionPanel";
            functionPanel.Size = new Size(550, 414);
            functionPanel.TabIndex = 24;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.LightSteelBlue;
            btnCalcular.BorderColor = Color.Black;
            btnCalcular.BorderRadius = 20;
            btnCalcular.BorderSize = 2;
            btnCalcular.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.HoverBackColor = Color.LightGray;
            btnCalcular.Location = new Point(190, 307);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.NormalBackColor = Color.LightSteelBlue;
            btnCalcular.Size = new Size(154, 51);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.LightSteelBlue;
            btnLimpar.BorderColor = Color.LightSteelBlue;
            btnLimpar.BorderRadius = 10;
            btnLimpar.BorderSize = 2;
            btnLimpar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.HoverBackColor = Color.LightGray;
            btnLimpar.Location = new Point(214, 374);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NormalBackColor = Color.LightSteelBlue;
            btnLimpar.Size = new Size(91, 29);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1105, 627);
            Controls.Add(functionPanel);
            Controls.Add(fieldsPanel);
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
            fieldsPanel.ResumeLayout(false);
            fieldsPanel.PerformLayout();
            functionPanel.ResumeLayout(false);
            functionPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lblCoeficiente;
        private ComboBox comboOperador;
        private ComboBox comboFuncao;
        private Label lblOpEspeciais;
        private Button btnAdicionaTermo2;
        private Label txtFuncaoCompleta;
        private Label lblOperador;
        private Label lblVariável;
        private Label lblExpoente;
        private Label lblIntegral;
        private TextBox txtLimiteB;
        private TextBox txtLimiteA;
        private Label lblNumTrapezios;
        private TextBox txtNumTrap;
        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Label label1;
        private Panel panel2;
        private Panel fieldsPanel;
        private Label label3;
        private Panel functionPanel;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private RoundedButton btnLimpar;
        private TextBox txtVariavel;
        private TextBox txtExpoente;
        private TextBox txtCoeficiente;
        private RoundedButton btnAdicionaTermo;
        private RoundedButton btnCalcular;
    }
}
