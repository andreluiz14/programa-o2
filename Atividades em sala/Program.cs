using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_em_sala
{
    class Program
    {
        public class TesteLampada
        {
            static void Main(string[] args)
            {
                Lampada lampada1 = new Lampada();
                bool valorAtual = lampada1.verEstadoLampada();
                Console.WriteLine(valorAtual);
                lampada1.acenderLampada();
                Console.WriteLine(lampada1.verEstadoLampada());
                lampada1.apagarLampada();
                Console.WriteLine(lampada1.verEstadoLampada());
            }
        }
        public class Lampada
        {
            public bool estadoLampada = false;
            public void acenderLampada()
            {
                estadoLampada = true;
            }
            public void apagarLampada()
            {
                estadoLampada = false;
            }
            public bool verEstadoLampada()
            {
                return estadoLampada;
            }
        }
    }
}
