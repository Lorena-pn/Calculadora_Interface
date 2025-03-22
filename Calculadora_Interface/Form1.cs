using MARS.Models.Operações.Inteiro;
namespace Calculadora_Interface
{
    public partial class Form1 : Form
    {
        private string Resultado { get; set; }
        private float Valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            Adicao,
            Subtracao,
            Multiplicacao,
            Divisao
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void Adicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void Subtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void Multiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void Divisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToInt32(txtResultado.Text);
            txtResultado.Text = "";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Soma_I.Operacao(Convert.ToInt32(Valor), Convert.ToInt32(txtResultado.Text));
                    break;
                case Operacao.Subtracao:
                    break;
                case Operacao.Divisao:
                    break;
                case Operacao.Multiplicacao:
                    break;
            }

            txtResultado.Text = Resultado;
        }
    }
}
