namespace DesafioPOO.Models
{
    // Classe abstrata Smartphone
    abstract class Smartphone
    {
        // Propriedades
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        // Método abstrato InstalarAplicativo
        public abstract void InstalarAplicativo(string nome);

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine($"{Modelo} ligado.");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{Modelo} recebendo ligação...");
        }
    }
}