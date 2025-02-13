using SuperTrunfo.model;

namespace SuperTrunfo
{
    public partial class Form1 : Form
    {
        private List<Carta> cartas;
        private Jogador jogador1;
        private Jogador jogador2;

        public Form1()
        {
            InitializeComponent();
            GerarCartas();
            jogador1 = new Jogador();
            jogador2 = new Jogador();
            SortearCartas();
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
                    Defesa = 70,
                    Magia = 80
                }
            };
        }

        private void btnDistribuirCartas_Click(object sender, EventArgs e)
        {
            GerarCartas();
            SortearCartas();
            lstCartasJogador1.Items.Clear();
            lstCartasJogador2.Items.Clear();
            foreach (var carta in jogador1.Cartas)
                lstCartasJogador1.Items.Add(carta.Nome);
            foreach (var carta in jogador2.Cartas)
                lstCartasJogador2.Items.Add(carta.Nome);
        }
    }
}