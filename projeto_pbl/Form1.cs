using System.Text.RegularExpressions;

namespace projeto_pbl
{
    public partial class Form1 : Form
    {
        // Lista que guarda cada termo da função
        private List<string> termos = new List<string>();

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

            // Atualiza o TextBox que exibe a função
            AtualizarFuncao(termo);
        }

        //private void AtualizarFuncao()
        //{
        //    // Atualiza o TextBox para exibir a função completa
        //    txtFuncaoCompleta.Text = string.Join(" ", termos);
        //}

        private void AtualizarFuncao(string termo)
        {
            // Verifica se o termo contém uma fração
            if (termo.Contains("/"))
            {
                // Encontra a posição da fração no termo
                int posicaoBarra = termo.IndexOf('/');
                int inicioFração = termo.LastIndexOf(' ', posicaoBarra) + 1;
                int fimFração = termo.IndexOf(' ', posicaoBarra);

                if (fimFração == -1) fimFração = termo.Length;

                int inicioResto = EncontrarPosicaoPrimeiraLetra(termo);

                // Extrai a fração
                string fracao = termo.Substring(inicioFração, inicioResto - inicioFração);
                string restoTermo = termo.Substring(inicioResto);

                var partes = fracao.Split('/');

                if (partes.Length == 2)
                {
                    // Adiciona a parte antes da fração
                    richTextBoxFuncaoCompleta.AppendText(termo.Substring(0, inicioFração));

                    // Adiciona o numerador
                    richTextBoxFuncaoCompleta.SelectionCharOffset = 5; // Eleva o numerador
                    richTextBoxFuncaoCompleta.AppendText(partes[0]);

                    // Adiciona a barra de fração
                    richTextBoxFuncaoCompleta.SelectionCharOffset = 0; // Reseta a posição
                    richTextBoxFuncaoCompleta.AppendText("/");

                    // Adiciona o denominador
                    richTextBoxFuncaoCompleta.SelectionCharOffset = -5; // Abaixa o denominador
                    richTextBoxFuncaoCompleta.AppendText(partes[1] + " ");

                    // Reseta a posição para o próximo texto
                    richTextBoxFuncaoCompleta.SelectionCharOffset = 0;

                    // Adiciona a parte após a fração
                    richTextBoxFuncaoCompleta.AppendText(restoTermo);
                }
            }
            else
            {
                // Adiciona o termo normalmente
                richTextBoxFuncaoCompleta.AppendText(termo);
            }

            // Adiciona um espaço após o termo
            richTextBoxFuncaoCompleta.AppendText(" ");
        }

        private int EncontrarPosicaoPrimeiraLetra(string input)
        {
            // Define a expressão regular para encontrar qualquer letra
            Regex regex = new Regex("[a-zA-Z]");
            Match match = regex.Match(input);

            // Se encontrar uma letra, retorna a posição; caso contrário, retorna -1
            return match.Success ? match.Index : -1;
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
    }
}
