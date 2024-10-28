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
            label1 = new Label();
            comboOperador = new ComboBox();
            txtVariavel = new TextBox();
            comboFuncao = new ComboBox();
            label2 = new Label();
            btnAdicionaTermo = new Button();
            txtFuncaoCompleta = new Label();
            txtExpoente = new TextBox();
            SuspendLayout();
            // 
            // txtCoeficiente
            // 
            txtCoeficiente.Location = new Point(82, 88);
            txtCoeficiente.Name = "txtCoeficiente";
            txtCoeficiente.Size = new Size(43, 23);
            txtCoeficiente.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 70);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 1;
            label1.Text = "Coeficiente";
            // 
            // comboOperador
            // 
            comboOperador.FormattingEnabled = true;
            comboOperador.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboOperador.Location = new Point(131, 88);
            comboOperador.Name = "comboOperador";
            comboOperador.Size = new Size(43, 23);
            comboOperador.TabIndex = 3;
            // 
            // txtVariavel
            // 
            txtVariavel.Location = new Point(185, 88);
            txtVariavel.Name = "txtVariavel";
            txtVariavel.Size = new Size(42, 23);
            txtVariavel.TabIndex = 4;
            // 
            // comboFuncao
            // 
            comboFuncao.FormattingEnabled = true;
            comboFuncao.Items.AddRange(new object[] { "sen", "cos", "tan", "exp", "log" });
            comboFuncao.Location = new Point(369, 88);
            comboFuncao.Name = "comboFuncao";
            comboFuncao.Size = new Size(121, 23);
            comboFuncao.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 70);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 6;
            label2.Text = "Operações Especiais";
            // 
            // btnAdicionaTermo
            // 
            btnAdicionaTermo.Location = new Point(523, 70);
            btnAdicionaTermo.Name = "btnAdicionaTermo";
            btnAdicionaTermo.Size = new Size(75, 57);
            btnAdicionaTermo.TabIndex = 7;
            btnAdicionaTermo.Text = "Adicionar Termo";
            btnAdicionaTermo.UseVisualStyleBackColor = true;
            btnAdicionaTermo.Click += btnAdicionaTermo_Click;
            // 
            // txtFuncaoCompleta
            // 
            txtFuncaoCompleta.AutoSize = true;
            txtFuncaoCompleta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFuncaoCompleta.Location = new Point(163, 142);
            txtFuncaoCompleta.Name = "txtFuncaoCompleta";
            txtFuncaoCompleta.Size = new Size(96, 32);
            txtFuncaoCompleta.TabIndex = 8;
            txtFuncaoCompleta.Text = "Função:";
            // 
            // txtExpoente
            // 
            txtExpoente.Location = new Point(233, 88);
            txtExpoente.Name = "txtExpoente";
            txtExpoente.Size = new Size(42, 23);
            txtExpoente.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtExpoente);
            Controls.Add(txtFuncaoCompleta);
            Controls.Add(btnAdicionaTermo);
            Controls.Add(label2);
            Controls.Add(comboFuncao);
            Controls.Add(txtVariavel);
            Controls.Add(comboOperador);
            Controls.Add(label1);
            Controls.Add(txtCoeficiente);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCoeficiente;
        private Label label1;
        private ComboBox comboOperador;
        private TextBox txtVariavel;
        private ComboBox comboFuncao;
        private Label label2;
        private Button btnAdicionaTermo;
        private Label txtFuncaoCompleta;
        private TextBox txtExpoente;
    }
}
