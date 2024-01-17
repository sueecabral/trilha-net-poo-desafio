namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone (string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
             
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo'{nomeApp}'no Iphone.");
        }

    }
}