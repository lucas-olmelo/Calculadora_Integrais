using System;
using System.Text.RegularExpressions;
using NCalc;

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

            // Converte o expoente para superíndice, se aplicável
            string expoenteSuperindice = (expoente == "1" || string.IsNullOrEmpty(expoente)) ? "" : ConverterParaSuperindice(expoente);

            string expoenteCalculo = (string.IsNullOrEmpty(expoente)) ? "1" : expoente;

            string funcaoCalc = (funcao == "sen") ? "Sin" : funcao;

            string variavelCalc = (string.IsNullOrEmpty(variavel)) ? "1" : variavel;

            string termoCalculo = operador + funcaoCalc + "(" + valorCoeficiente + " * Pow(" + variavelCalc + ", " + expoenteCalculo + "))";

            // Monta o termo: se o coeficiente é 1, ele não aparece visualmente
            string termo;
            if (valorCoeficiente == "1")
            {
                termo = string.IsNullOrEmpty(funcao)
                    ? $"{variavel}{expoenteSuperindice}"      // Sem função, sem parênteses
                    : $"{funcao}({variavel}{expoenteSuperindice})"; // Com função, variável entre parênteses
            }
            else
            {
                termo = string.IsNullOrEmpty(funcao)
                    ? $"{valorCoeficiente}{variavel}{expoenteSuperindice}" // Sem função
                    : $"{valorCoeficiente}{funcao}({variavel}{expoenteSuperindice})"; // Com função
            }

            // Adiciona o operador antes do termo, se não for o primeiro
            if (!string.IsNullOrEmpty(operador))
            {
                termo = $"{operador} {termo}";
            }

            // Adiciona o termo à lista de termos
            termos.Add(termo);
            termosCalculo.Add(termoCalculo);

            // Atualiza o TextBox que exibe a função
            //AtualizarFuncao(termo);
            AtualizarFuncao();

            txtCoeficiente.Text = "";
            comboOperador.Text = "";
            comboFuncao.Text = "";
            txtExpoente.Text = "";
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
            lblResultado.Text = "Resultado: " + resultado.ToString();
            //MessageBox.Show($"A integral aproximada é {resultado}");
        }

        private Func<double, double> ConstruirFuncaoUsuario()
        {
            // Junta os termos em uma expressão final
            string expressaoFinal = string.Join(" ", termosCalculo);
            MessageBox.Show(expressaoFinal);

            return x =>
            {
                // Cria a expressão dinâmica usando NCalc
                Expression expressao = new Expression(expressaoFinal);
                expressao.Parameters["x"] = x; // Define x como o valor a ser substituído na expressão
                return Convert.ToDouble(expressao.Evaluate());
            };
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
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCoeficiente.Text = "";
            comboOperador.Text = "";
            comboFuncao.Text = "";
            txtExpoente.Text = "";
            txtFuncaoCompleta.Text = "";
            txtLimiteA.Text = "";
            txtLimiteB.Text = "";
            txtNumTrap.Text = "";
            comboOperador.Enabled = false;
            lblResultado.Text = "";
            termos.Clear();
            termosCalculo.Clear();
        }
    }
}
