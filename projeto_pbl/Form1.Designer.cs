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
            lblCoeficiente.Location = new Point(240, 13);
            lblCoeficiente.Name = "lblCoeficiente";
            lblCoeficiente.Size = new Size(77, 14);
            lblCoeficiente.TabIndex = 1;
            lblCoeficiente.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.BackColor = Color.Lavender;
            comboOperador.FlatStyle = FlatStyle.Flat;
            comboOperador.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboOperador.ForeColor = SystemColors.ActiveCaptionText;
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "", "+", "-", "*", "/" });
            comboOperador.Location = new Point(16, 28);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(55, 27);
            comboOperador.TabIndex = 3;
            // 
            // comboFuncao
            // 
            comboFuncao.BackColor = Color.Lavender;
            comboFuncao.FlatStyle = FlatStyle.Flat;
            comboFuncao.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboFuncao.ForeColor = SystemColors.ActiveCaptionText;
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "", "Sqrt", "Sin", "Cos", "Tan", "Exp", "Log" });
            comboFuncao.Location = new Point(103, 28);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(121, 27);
            comboFuncao.TabIndex = 5;
            // 
            // lblOpEspeciais
            // 
            lblOpEspeciais.AutoSize = true;
            lblOpEspeciais.Font = new Font("Verdana", 9F);
            lblOpEspeciais.ForeColor = SystemColors.ControlLightLight;
            lblOpEspeciais.Location = new Point(94, 11);
            lblOpEspeciais.Name = "lblOpEspeciais";
            lblOpEspeciais.Size = new Size(137, 14);
            lblOpEspeciais.TabIndex = 6;
            lblOpEspeciais.Text = "Operações Especiais";
            lblOpEspeciais.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.ForeColor = SystemColors.ControlLightLight;
            txtFuncaoCompleta.Location = new Point(109, 38);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(0, 32);
            txtFuncaoCompleta.TabIndex = 8;
            // 
            // lblOperador
            // 
            lblOperador.AutoSize = true;
            lblOperador.BackColor = Color.Transparent;
            lblOperador.Font = new Font("Verdana", 9F);
            lblOperador.ForeColor = SystemColors.ControlLightLight;
            lblOperador.Location = new Point(11, 11);
            lblOperador.Name = "lblOperador";
            lblOperador.Size = new Size(67, 14);
            lblOperador.TabIndex = 10;
            lblOperador.Text = "Operador";
            // 
            // lblVariável
            // 
            lblVariável.AutoSize = true;
            lblVariável.BackColor = Color.Transparent;
            lblVariável.Font = new Font("Verdana", 9F);
            lblVariável.ForeColor = SystemColors.ControlLightLight;
            lblVariável.Location = new Point(330, 13);
            lblVariável.Name = "lblVariável";
            lblVariável.Size = new Size(56, 14);
            lblVariável.TabIndex = 11;
            lblVariável.Text = "Variável";
            // 
            // lblExpoente
            // 
            lblExpoente.AutoSize = true;
            lblExpoente.BackColor = Color.Transparent;
            lblExpoente.Font = new Font("Verdana", 9F);
            lblExpoente.ForeColor = SystemColors.ControlLightLight;
            lblExpoente.Location = new Point(395, 13);
            lblExpoente.Name = "lblExpoente";
            lblExpoente.Size = new Size(67, 14);
            lblExpoente.TabIndex = 12;
            lblExpoente.Text = "Expoente";
            lblExpoente.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblIntegral
            // 
            lblIntegral.AutoSize = true;
            lblIntegral.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIntegral.ForeColor = SystemColors.ControlLightLight;
            lblIntegral.Location = new Point(18, 5);
            lblIntegral.Name = "lblIntegral";
            lblIntegral.Size = new Size(72, 86);
            lblIntegral.TabIndex = 14;
            lblIntegral.Text = "∫";
            // 
            // txtLimiteB
            // 
            txtLimiteB.BackColor = Color.Lavender;
            txtLimiteB.BorderStyle = BorderStyle.None;
            txtLimiteB.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimiteB.Location = new Point(70, 20);
            txtLimiteB.Margin = new Padding(3, 2, 3, 2);
            txtLimiteB.Name = "txtLimiteB";
            txtLimiteB.PlaceholderText = "b";
            txtLimiteB.Size = new Size(27, 20);
            txtLimiteB.TabIndex = 15;
            txtLimiteB.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLimiteA
            // 
            txtLimiteA.BackColor = Color.Lavender;
            txtLimiteA.BorderStyle = BorderStyle.None;
            txtLimiteA.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLimiteA.ForeColor = SystemColors.ControlText;
            txtLimiteA.Location = new Point(70, 66);
            txtLimiteA.Margin = new Padding(3, 2, 3, 2);
            txtLimiteA.Name = "txtLimiteA";
            txtLimiteA.PlaceholderText = "a";
            txtLimiteA.Size = new Size(27, 20);
            txtLimiteA.TabIndex = 16;
            txtLimiteA.TextAlign = HorizontalAlignment.Center;
            // 
            // lblNumTrapezios
            // 
            lblNumTrapezios.AutoSize = true;
            lblNumTrapezios.BackColor = Color.Transparent;
            lblNumTrapezios.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNumTrapezios.ForeColor = SystemColors.ControlLightLight;
            lblNumTrapezios.Location = new Point(356, 40);
            lblNumTrapezios.Name = "lblNumTrapezios";
            lblNumTrapezios.Size = new Size(41, 25);
            lblNumTrapezios.TabIndex = 17;
            lblNumTrapezios.Text = "n =";
            // 
            // txtNumTrap
            // 
            txtNumTrap.BackColor = Color.Lavender;
            txtNumTrap.BorderStyle = BorderStyle.None;
            txtNumTrap.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumTrap.Location = new Point(404, 40);
            txtNumTrap.Margin = new Padding(3, 2, 3, 2);
            txtNumTrap.Name = "txtNumTrap";
            txtNumTrap.Size = new Size(46, 25);
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
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1920, 30);
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
            nightControlBox1.Location = new Point(1781, 0);
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
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(plotView1);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(961, 30);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 1050);
            panel2.TabIndex = 23;
            // 
            // plotView1
            // 
            plotView1.BackColor = Color.GhostWhite;
            plotView1.Location = new Point(92, 187);
            plotView1.Margin = new Padding(3, 2, 3, 2);
            plotView1.Name = "plotView1";
            plotView1.PanCursor = Cursors.Hand;
            plotView1.Size = new Size(800, 800);
            plotView1.TabIndex = 25;
            plotView1.Text = "plotView1";
            plotView1.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView1.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView1.ZoomVerticalCursor = Cursors.SizeNS;            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 56);
            label3.Name = "label3";
            label3.Size = new Size(173, 23);
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
            fieldsPanel.Location = new Point(12, 34);
            fieldsPanel.Margin = new Padding(3, 2, 3, 2);
            fieldsPanel.Name = "fieldsPanel";
            fieldsPanel.Size = new Size(487, 116);
            fieldsPanel.TabIndex = 23;
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.BackColor = Color.Lavender;
            btnAdicionaTermo.BorderColor = Color.Black;
            btnAdicionaTermo.BorderRadius = 20;
            btnAdicionaTermo.BorderSize = 2;
            btnAdicionaTermo.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdicionaTermo.HoverBackColor = Color.LightGray;
            btnAdicionaTermo.Location = new Point(181, 65);
            btnAdicionaTermo.Margin = new Padding(3, 2, 3, 2);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.NormalBackColor = Color.LightSteelBlue;
            btnAdicionaTermo.Size = new Size(108, 28);
            btnAdicionaTermo.TabIndex = 22;
            btnAdicionaTermo.Text = "Adicionar";
            btnAdicionaTermo.UseVisualStyleBackColor = false;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtVariavel
            // 
            txtVariavel.BackColor = Color.Lavender;
            txtVariavel.BorderStyle = BorderStyle.None;
            txtVariavel.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtVariavel.Location = new Point(341, 31);
            txtVariavel.Margin = new Padding(3, 2, 3, 2);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(27, 20);
            txtVariavel.TabIndex = 18;
            txtVariavel.Text = "x";
            txtVariavel.TextAlign = HorizontalAlignment.Center;
            // 
            // txtExpoente
            // 
            txtExpoente.BackColor = Color.Lavender;
            txtExpoente.BorderStyle = BorderStyle.None;
            txtExpoente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtExpoente.Location = new Point(416, 31);
            txtExpoente.Margin = new Padding(3, 2, 3, 2);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(27, 20);
            txtExpoente.TabIndex = 17;
            txtExpoente.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.BackColor = Color.Lavender;
            txtCoeficiente.BorderStyle = BorderStyle.None;
            txtCoeficiente.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCoeficiente.Location = new Point(268, 31);
            txtCoeficiente.Margin = new Padding(3, 2, 3, 2);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.PlaceholderText = " ";
            txtCoeficiente.Size = new Size(27, 20);
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
            functionPanel.Location = new Point(415, 456);
            functionPanel.Margin = new Padding(3, 2, 3, 2);
            functionPanel.Name = "functionPanel";
            functionPanel.Size = new Size(481, 310);
            functionPanel.TabIndex = 24;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Lavender;
            btnCalcular.BorderColor = Color.Black;
            btnCalcular.BorderRadius = 20;
            btnCalcular.BorderSize = 2;
            btnCalcular.Font = new Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCalcular.HoverBackColor = Color.LightGray;
            btnCalcular.Location = new Point(166, 230);
            btnCalcular.Margin = new Padding(3, 2, 3, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.NormalBackColor = Color.LightSteelBlue;
            btnCalcular.Size = new Size(135, 38);
            btnCalcular.TabIndex = 23;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.Lavender;
            btnLimpar.BorderColor = Color.LightSteelBlue;
            btnLimpar.BorderRadius = 10;
            btnLimpar.BorderSize = 2;
            btnLimpar.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLimpar.HoverBackColor = Color.LightGray;
            btnLimpar.Location = new Point(187, 280);
            btnLimpar.Margin = new Padding(3, 2, 3, 2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.NormalBackColor = Color.LightSteelBlue;
            btnLimpar.Size = new Size(80, 22);
            btnLimpar.TabIndex = 21;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(1920, 1080);
            Controls.Add(functionPanel);
            Controls.Add(fieldsPanel);
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
