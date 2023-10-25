namespace Atividade4_YagoAguiarMelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double valorPrincipal = double.Parse(txt_ValorPrincipal.Text);
            double taxaAnual = double.Parse(txt_JurosAnual.Text);
            int numeroParcelas = int.Parse(txt_Parcelas.Text);

            double taxaDeJurosMensal = (taxaAnual / 100) / 12;
            double valorDaParcela = valorPrincipal * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, -numeroParcelas)));

            double totalDeJuros = (valorDaParcela * numeroParcelas) - valorPrincipal;
            double totalPago = valorPrincipal + totalDeJuros;


            lbl_valorDaParcela.Text = "Valor da parcela: R$" +  valorDaParcela.ToString("N2");
            lbl_TotalJuros.Text = "Total em juros: R$" + totalDeJuros.ToString("N2");
            lbl_TotalPago.Text = "Total pago: R$" + totalPago.ToString("N2");




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_TotalJuros_Click(object sender, EventArgs e)
        {

        }
    }
}