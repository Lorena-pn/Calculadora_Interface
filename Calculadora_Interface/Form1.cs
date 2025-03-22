using MARS.Models.Operações.Inteiro;
using MARS.Models.Operações.Float;
using MARS.Models.Temperatura;
namespace Calculadora_Interface
{
    public partial class Calculadora : Form
    {
        private float Resultado { get; set; }
        private float Valor { get; set; }
        private Ope OperacaoSelecionada { get; set; }
        private enum Ope
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        private Temperatura TemperaturaSelecionada { get; set; }
        private enum Temperatura
        {
            Celsius,
            Fahrenheit,
            Kelvin
        }
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
            txtResultado_T.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
            txtResultado_T.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
            txtResultado_T.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
            txtResultado_T.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
            txtResultado_T.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
            txtResultado_T.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
            txtResultado_T.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
            txtResultado_T.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
            txtResultado_T.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
            txtResultado_T.Text += "9";
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Adicao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "+";
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Subtracao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "-";
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Multiplicacao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "*";
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Ope.Divisao;
            Valor = float.Parse(txtResultado.Text);
            txtResultado.Text = "";
            Logica.Text = "/";
        }
        private void btVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            {
                txtResultado.Text += ",";
                txtResultado_T.Text += ",";
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtResultado_T.Text = "";
            Logica.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            float SegundoValor = float.Parse(txtResultado.Text);


            switch (OperacaoSelecionada)
            {
                case Ope.Adicao:
                    Resultado = Soma_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Subtracao:
                    Resultado = Diminuição_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Divisao:
                    Resultado = Divisão_F.Operacao(Valor, SegundoValor);
                    break;
                case Ope.Multiplicacao:
                    Resultado = Multiplicação_F.Operacao(Valor, SegundoValor);
                    break;
            }

            Logica.Text = "=";
            txtResultado.Text = Resultado.ToString("0.##");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCelsius_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Celsius;
            Cel.Text = "|Cº";
            Fa.Text = "Fº";
            Kel.Text = "Kº";
        }

        private void btFahrenheit_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Fahrenheit;
            Cel.Text = "Cº";
            Fa.Text = "|Fº";
            Kel.Text = "Kº";
        }

        private void btKelvin_Click(object sender, EventArgs e)
        {
            TemperaturaSelecionada = Temperatura.Kelvin;
            Cel.Text = "Cº";
            Fa.Text = "Fº";
            Kel.Text = "|Kº";
        }

        private void btIgual_T_Click(object sender, EventArgs e)
        {
            switch (TemperaturaSelecionada)
            {
                case Temperatura.Celsius:
                    Celsius.Text = txtResultado_T.Text;
                    Fahrenheit.Text = Celsius_Fahrenheit.Operacao(float.Parse(txtResultado_T.Text));
                    Kelvin.Text = Celsius_Kelvin.Operacao(float.Parse(txtResultado_T.Text));
                    break;
                case Temperatura.Kelvin:
                    Celsius.Text = Kelvin_Celsius.Operacao(float.Parse(txtResultado_T.Text));
                    Fahrenheit.Text = Kelvin_Fahrenheit.Operacao(float.Parse(txtResultado_T.Text));
                    Kelvin.Text = txtResultado_T.Text;
                    break;
                case Temperatura.Fahrenheit:
                    Celsius.Text = fahrenheit_celsius.Operacao(float.Parse(txtResultado_T.Text));
                    Fahrenheit.Text = txtResultado_T.Text;
                    Kelvin.Text = fahrenheit_kelvin.Operacao(float.Parse(txtResultado_T.Text));
                    break;
            }
        }
    }
}
