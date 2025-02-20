using SuperTrunfo.model;

namespace SuperTrunfo
{
    public partial class Form1 : Form
    {
        private List<Carta> cartas;
        private Jogador jogador1;
        private Jogador jogador2;
        private bool Auto;

        public Form1()
        {
            InitializeComponent();
            GerarCartas();
            jogador1 = new Jogador();
            jogador2 = new Jogador();
            SortearCartas();
        }

        private void GerarCartas()
        {
            cartas = new List<Carta>()
            {
                new()
                {
                    Nome = "Batata",
                    Ataque = 70,
                    Defesa = 70,
                    Magia = 90
                },
                new()
                {
                    Nome = "Cenoura",
                    Ataque = 70,
                    Defesa = 90,
                    Magia = 70
                },
                new()
                {
                    Nome = "Aipim",
                    Ataque = 80,
                    Defesa = 60,
                    Magia = 80,
                },
                new()
                {
                    Nome = "Cebola",
                    Ataque = 60,
                    Defesa = 75,
                    Magia = 80
                }
            };
        }

        private void SortearCartas()
        {
            int numAleatorio;
            jogador1.Cartas = new List<Carta>();
            jogador2.Cartas = new List<Carta>();

            for (int i = 0; i < 2; i++)
            {
                numAleatorio = (int)new Random().NextInt64(0, cartas.Count);
                jogador1.Cartas.Add(cartas[numAleatorio]);
                cartas.RemoveAt(numAleatorio);
                numAleatorio = (int)new Random().NextInt64(0, cartas.Count);
                jogador2.Cartas.Add(cartas[numAleatorio]);
                cartas.RemoveAt(numAleatorio);
            }
        }

        private void ExibirCartaJogador(Jogador jog)
        {
            ListBox lista;
            if (jog == jogador1) lista = lstCartasJogador1;
            else if (jog == jogador2) lista = lstCartasJogador2;
            else return;

            lista.Items.Clear();
            lista.Items.Add(jog.Cartas[0].Nome);
            lista.Items.Add("Ataque: " + jog.Cartas[0].Ataque);
            lista.Items.Add("Defesa: " + jog.Cartas[0].Defesa);
            lista.Items.Add("Magia: " + jog.Cartas[0].Magia);
        }

        private void btnDistribuirCartas_Click(object sender, EventArgs e)
        {
            GerarCartas();
            SortearCartas();
            ModificarCores();
            lstCartasJogador1.Items.Clear();
            lstCartasJogador2.Items.Clear();
            ExibirCartaJogador(jogador1);
            LblTotalCartasJogador1.Text = jogador1.Cartas.Count.ToString();
            LblTotalCartasJogador2.Text = jogador2.Cartas.Count.ToString();
            BtnDesafiar.Enabled = true;
        }

        private void BtnDesafiar_Click(object sender, EventArgs e)
        {
            Carta jog1 = jogador1.Cartas[0], jog2 = jogador2.Cartas[0];

            if (RdoAtaque.Checked)
            {
                if (jog1.Ataque > jog2.Ataque) jogador1.VencedorRodada = true;
                else jogador2.VencedorRodada = true;
            }

            if (RdoDefesa.Checked)
            {
                if (jog1.Defesa > jog2.Defesa) jogador1.VencedorRodada = true;
                else jogador2.VencedorRodada = true;
            }

            if (RdoMagia.Checked)
            {
                if (jog1.Magia > jog2.Magia) jogador1.VencedorRodada = true;
                else jogador2.VencedorRodada = true;
            }

            FecharRodada();
            RodadaAutomatica();
        }

        private void FecharRodada()
        {
            ExibirCartaJogador(jogador2);
            AtualizarTotalCartas();
            ModificarCores();
            jogador1.VencedorRodada = jogador2.VencedorRodada = false;
            BtnDesafiar.Enabled = false;

            if (jogador1.Cartas.Count == 0 || jogador2.Cartas.Count == 0)
            {
                BtnNovaRodada.Enabled = false;
                string vencedor = (jogador1.Cartas.Count == 0 ? "Jogador 2" : "Jogador 1");
                MessageBox.Show("O vencedor foi " + vencedor, "Fim de Jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            BtnNovaRodada.Enabled = true;
        }

        private void AtualizarTotalCartas()
        {
            if (jogador1.VencedorRodada)
            {
                jogador1.Cartas.Insert(jogador1.Cartas.Count - 1, jogador2.Cartas[0]);
                jogador2.Cartas.RemoveAt(0);
                jogador1.Cartas.Insert(jogador1.Cartas.Count - 1, jogador1.Cartas[0]);
                jogador1.Cartas.RemoveAt(0);
            }
            else
            {
                jogador2.Cartas.Insert(jogador2.Cartas.Count - 1, jogador1.Cartas[0]);
                jogador1.Cartas.RemoveAt(0);
                jogador2.Cartas.Insert(jogador2.Cartas.Count - 1, jogador2.Cartas[0]);
                jogador2.Cartas.RemoveAt(0);
            }
            LblTotalCartasJogador1.Text = jogador1.Cartas.Count.ToString();
            LblTotalCartasJogador2.Text = jogador2.Cartas.Count.ToString();
        }

        private void BtnNovaRodada_Click(object sender, EventArgs e)
        {
            ExibirCartaJogador(jogador1);
            lstCartasJogador2.Items.Clear();
            BtnNovaRodada.Enabled = false;
            BtnDesafiar.Enabled = true;
        }

        private void ModificarCores()
        {
            int jog1 = jogador1.Cartas.Count, jog2 = jogador2.Cartas.Count;

            if (jog1 == jog2)
            {
                LblTotalCartasJogador1.ForeColor = Color.Black;
                LblTotalCartasJogador2.ForeColor = Color.Black;
                return;
            }

                if (jog1 > jog2)
            {
                LblTotalCartasJogador1.ForeColor = Color.Green;
                LblTotalCartasJogador2.ForeColor = Color.Red;
                return;
            }

            if (jog1 < jog2)
            {
                LblTotalCartasJogador1.ForeColor = Color.Red;
                LblTotalCartasJogador2.ForeColor = Color.Green;
                return;
            }
        }

        private void RodadaAutomatica()
        {
            if (Auto == true)
            {
                Auto = false;
                return;
            }

            if (BtnNovaRodada.Enabled == false) return;

            BtnNovaRodada.PerformClick();

            int numAleatorio = (int)new Random().NextInt64(1, 3);
            if (numAleatorio == 1) RdoAtaque.PerformClick();
            if (numAleatorio == 2) RdoDefesa.PerformClick();
            if (numAleatorio == 3) RdoMagia.PerformClick();

            Auto = true;
            BtnDesafiar.PerformClick();
        }
    }
}