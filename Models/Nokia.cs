namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia (string modelo, string imei, int memoria) : base(modelo, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string numero, string nomeApp) 
        {
            base.InstalarAplicativo(numero, nomeApp);
            //Console.WriteLine($"Instalando o aplicativo'{nomeApp}'no Nokia.");
        }

    }
}