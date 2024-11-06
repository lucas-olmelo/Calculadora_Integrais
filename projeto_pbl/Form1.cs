using System;
using System.Text.RegularExpressions;
using NCalc;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;


namespace projeto_pbl
{
    public partial class Form1 : Form
    {
        // Lista que guarda cada termo da função
        private List<string> termos = new List<string>();
        private List<string> termosCalculo = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboOperador.Enabled = false;

            CentralizarBotoesHorizontalmente();
        }


        private void btnAdicionaTermo_Click(object sender, EventArgs e)
        {
            // Captura os valores da interface
            string coeficiente = txtCoeficiente.Text;
            string operador = comboOperador.Text;
            string funcao = comboFuncao.Text;
            string variavel = txtVariavel.Text;
            string expoente = txtExpoente.Text;

            // Verifica se é o primeiro termo
            if (termos.Count == 0)
            {
                // Se for o primeiro termo, ignora o operador e desabilita o ComboBox
                operador = "";
                comboOperador.Enabled = true;
            }
            else
            {
                // Se não for o primeiro termo, verifica se o operador está vazio
                if (string.IsNullOrEmpty(operador))
                {
                    MessageBox.Show("Operador obrigatório para termos subsequentes.");
                    return;
                }
            }

            // Interpreta o coeficiente para lidar com frações e assume 1 se vazio
            string valorCoeficiente = InterpretarCoeficiente(coeficiente);

            //Transforma um expoente vazio em 1
            string expoenteCalculo = (string.IsNullOrEmpty(expoente)) ? "1" : expoente;

            //Transforma a função seno em Sin para o NCalc
            string funcaoCalc = (funcao == "sen") ? "Sin" : funcao;

            //Caso não tenha variável, substitui por 1 para não alterar o cálculo
            string variavelCalc = (string.IsNullOrEmpty(variavel)) ? "1" : variavel;

            //Constroi o termo que será calculado pelo NCalc
            string termoCalculo = operador + funcaoCalc + "(" + valorCoeficiente + " * Pow(" + variavelCalc + ", " + expoenteCalculo + "))";

            //Adiciona na lista de termos
            termosCalculo.Add(termoCalculo);

            //Constrói a versão visual da integral
            ConstroiFuncaoVisual(valorCoeficiente, operador, funcao, variavel, expoente);

            //Limpa os campos após a inserção
            LimparCampos();
        }

        private void AtualizarFuncao()
        {
            // Atualiza o TextBox para exibir a função completa
            txtFuncaoCompleta.Text = string.Join(" ", termos) + " * dx";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // Captura os valores dos limites e subintervalos

            if (!double.TryParse(txtLimiteA.Text, out double a))
            {
                MessageBox.Show("Limite inferior inválido!");
                return;
            }

            if (!double.TryParse(txtLimiteB.Text, out double b))
            {
                MessageBox.Show("Limite superior inválido!");
                return;
            }

            if (!int.TryParse(txtNumTrap.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Número de subintervalos inválido!");
                return;
            }

            // Constrói a função a partir da expressão do usuário
            Func<double, double> func = ConstruirFuncaoUsuario();


            // Calcula a integral usando a regra dos trapézios
            double resultado = RegraDosTrapeziosRepetidos(func, a, b, n);
            //lblResultado.Text = " " + resultado.ToString();

            // Gera o gráfico da função e dos trapezoides
            MostrarGrafico(func, a, b, n);
        }

        public double RegraDosTrapeziosRepetidos(Func<double, double> func, double a, double b, int n)
        {
            double h = (b - a) / n;
            double soma = 0.5 * (func(a) + func(b));

            for (int i = 1; i < n; i++)
            {
                double x = a + i * h;
                soma += func(x);
            }

            return soma * h;
        }

        private Func<double, double> ConstruirFuncaoUsuario()
        {
            // Junta os termos em uma expressão final
            string expressaoFinal = string.Join(" ", termosCalculo);

            return x =>
            {
                // Cria a expressão dinâmica usando NCalc
                Expression expressao = new Expression(expressaoFinal);
                expressao.Parameters["x"] = x; // Define x como o valor a ser substituído na expressão
                return Convert.ToDouble(expressao.Evaluate());
            };
        }

        private void MostrarGrafico(Func<double, double> func, double a, double b, int n)
        {
            var modelo = new PlotModel { Title = "Integral pela Regra do Trapézio Repetido", TitleFontSize = 14 };

            // Série da função original baseada na expressão do usuário
            var funcaoSerie = new LineSeries { Title = "Função", Color = OxyColors.Red };
            for (double x = a; x <= b; x += 0.1)
            {
                funcaoSerie.Points.Add(new DataPoint(x, func(x)));
            }
            modelo.Series.Add(funcaoSerie);

            // Série para os trapezoides
            var areaSerie = new LineSeries { Title = "Área dos Trapezoides", Color = OxyColors.Blue, LineStyle = LineStyle.Solid };
            double h = (b - a) / n;

            for (int i = 0; i < n; i++)
            {
                double x0 = a + i * h;
                double x1 = x0 + h;
                double y0 = func(x0);
                double y1 = func(x1);

                // Adiciona pontos para desenhar cada trapezoide
                areaSerie.Points.Add(new DataPoint(x0, 0));  // Ponto inicial no eixo X
                areaSerie.Points.Add(new DataPoint(x0, y0)); // Ponto inicial na função
                areaSerie.Points.Add(new DataPoint(x1, y1)); // Ponto final na função
                areaSerie.Points.Add(new DataPoint(x1, 0));  // Ponto final no eixo X
                areaSerie.Points.Add(new DataPoint(x0, 0));  // Fecha o trapezoide
            }

            modelo.Series.Add(areaSerie);

            // Adiciona o valor da integral como subtítulo do gráfico
            modelo.Subtitle = $"Aproximação da Integral = {RegraDosTrapeziosRepetidos(func, a, b, n)}";

            // Define o modelo no plotView e adiciona ao formulário
            plotView1.Model = modelo;
        }

        private void ConstroiFuncaoVisual(string coeficiente, string operador, string funcao, string variavel, string expoente)
        {
            // Converte o expoente para superíndice, se aplicável
            string expoenteSuperindice = (expoente == "1" || string.IsNullOrEmpty(expoente)) ? "" : ConverterParaSuperindice(expoente);

            // Monta o termo: se o coeficiente é 1, ele não aparece visualmente
            string termo;
            if (coeficiente == "1")
            {
                termo = string.IsNullOrEmpty(funcao)
                    ? $"{variavel}{expoenteSuperindice}"      // Sem função, sem parênteses
                    : $"{funcao}({variavel}{expoenteSuperindice})"; // Com função, variável entre parênteses
            }
            else
            {
                termo = string.IsNullOrEmpty(funcao)
                    ? $"{coeficiente}{variavel}{expoenteSuperindice}" // Sem função
                    : $"{coeficiente}{funcao}({variavel}{expoenteSuperindice})"; // Com função
            }

            // Adiciona o operador antes do termo, se não for o primeiro
            if (!string.IsNullOrEmpty(operador))
            {
                termo = $"{operador} {termo}";
            }

            // Adiciona o termo à lista de termos
            termos.Add(termo);

            // Atualiza o label que exibe a função
            AtualizarFuncao();
        }

        private string InterpretarCoeficiente(string coeficiente)
        {
            // Se o coeficiente estiver vazio, retorna 1 por padrão
            if (string.IsNullOrEmpty(coeficiente))
            {
                return "1";
            }

            // Verifica se o coeficiente contém uma barra, indicando uma fração
            if (coeficiente.Contains("/"))
            {
                var partes = coeficiente.Split('/');

                // Tenta converter o numerador e o denominador em números
                if (partes.Length == 2 &&
                    double.TryParse(partes[0], out double numerador) &&
                    double.TryParse(partes[1], out double denominador) &&
                    denominador != 0)  // Verifica se o denominador não é zero
                {
                    return coeficiente;  // Retorna o valor da fração
                }
                else
                {
                    MessageBox.Show("Fração inválida! Certifique-se de que está no formato 'numerador/denominador'.");
                    return "1";  // Retorna 1 em caso de erro
                }
            }
            else
            {
                // Tenta converter o coeficiente diretamente para decimal
                if (double.TryParse(coeficiente, out double valor))
                {
                    return valor.ToString();
                }
                else
                {
                    MessageBox.Show("Coeficiente inválido!");
                    return "1";  // Retorna 1 se o valor não for numérico
                }
            }
        }

        private string ConverterParaSuperindice(string expoente)
        {
            // Dicionário para mapear números para superíndice
            var superindiceMap = new Dictionary<char, char>
            {
                {'0', '⁰'}, {'1', '¹'}, {'2', '²'}, {'3', '³'}, {'4', '⁴'},
                {'5', '⁵'}, {'6', '⁶'}, {'7', '⁷'}, {'8', '⁸'}, {'9', '⁹'}
            };

            string resultado = "";
            foreach (char c in expoente)
            {
                // Converte cada dígito para seu equivalente em superíndice
                if (superindiceMap.ContainsKey(c))
                {
                    resultado += superindiceMap[c];
                }
                else
                {
                    MessageBox.Show("Expoente inválido! Utilize apenas números.");
                    return "";
                }
            }
            return resultado;
        }

        private void comboOperador_TextChanged(object sender, EventArgs e)
        {
            // Se não for o primeiro termo e o operador estiver vazio, exibe mensagem de erro
            if (termos.Count > 0 && string.IsNullOrEmpty(comboOperador.Text))
            {
                MessageBox.Show("Operador obrigatório para termos subsequentes.");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }

        private void LimparCampos()
        {
            txtCoeficiente.Text = "";
            comboOperador.Text = "";
            comboFuncao.Text = "";
            txtExpoente.Text = "";
        }

        private void LimparTudo()
        {
            txtFuncaoCompleta.Text = "";
            txtLimiteB.Text = "";
            txtLimiteA.Text = "";
            txtNumTrap.Text = "";
            comboOperador.Enabled = false;
            termos.Clear();
            termosCalculo.Clear();
        }

        // Método para centralizar o botão horizontalmente e posicioná-lo acima do fundo
        private void CentralizarBotoesHorizontalmente()
        {
            int posX = (fieldsPanel.ClientSize.Width - btnAdicionaTermo.Width) / 2;
            int posY = fieldsPanel.ClientSize.Height - btnAdicionaTermo.Height - 10;

            btnAdicionaTermo.Location = new Point(posX, posY);

            int posCalcX = (functionPanel.ClientSize.Width - btnCalcular.Width) / 2;
            int posCalcY = functionPanel.ClientSize.Height - btnCalcular.Height - 50;

            btnCalcular.Location = new Point(posCalcX, posCalcY);

            int posLimparX = (functionPanel.ClientSize.Width - btnLimpar.Width) / 2;
            int posLimparY = functionPanel.ClientSize.Height - btnLimpar.Height - 10;

            btnLimpar.Location = new Point(posLimparX, posLimparY);
        }

        private void txtExpoente_TextChanged(object sender, EventArgs e)
        {
            /*
            mudar a fonte
            programar o gráfico
            */
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragCursorPoint = Cursor.Position;  // Get current mouse position
            dragFormPoint = this.Location;       // Get current window location

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                // Calculate the difference in position from the cursor's initial position
                Point dif = Cursor.Position - new Size(dragCursorPoint);
                this.Location = new Point(dragFormPoint.X + dif.X, dragFormPoint.Y + dif.Y);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            {
                dragging = false;
            }

        }
    }
}
