namespace DesafioPOO.Models;

 class Iphone : Smartphone
    {
        // Implementação do método InstalarAplicativo para iPhone
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine($"Instalando {nome} na App Store do iPhone.");
        }
    }
