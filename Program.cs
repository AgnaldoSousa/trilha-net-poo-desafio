using DesafioPOO.Models;


  partial class Program
  {
  static void Main(string[] args)
  {
    Smartphone nokia = new Nokia
    {Numero = "1146674747", Modelo = "Nokia 8", IMEI = "IMEI5555", Memoria = 64};
    nokia.Ligar();
    nokia.ReceberLigacao();
    nokia.InstalarAplicativo("Youtube");

    Smartphone Iphone = new Iphone
    {Numero = "1146674747",Modelo = "Iphone 10",IMEI = "IMEI5555", Memoria = 200};
    Iphone.Ligar();
    Iphone.ReceberLigacao();
    Iphone.InstalarAplicativo("Youtube");
    }
  }
  