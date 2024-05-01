using System.Diagnostics;
using DesafioPOO.Models;

namespace DesafioPOO.Models;

 class Nokia : Smartphone
    {
        // Implementação do método InstalarAplicativo para Nokia
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} na loja de aplicativos da Nokia.");
        }
    }