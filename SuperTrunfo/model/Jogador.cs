using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperTrunfo.model
{
    internal class Jogador
    {
        public string Nome { get; set; }
        public int Pontos { get; set; }
        public List<Carta> Cartas { get; set; }
        public bool VencedorRodada { get; set; }
    }
}
