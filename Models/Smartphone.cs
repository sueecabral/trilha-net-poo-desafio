using System.Runtime.CompilerServices;
using System;        
        
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
       
        public Smartphone(string modelo, string imei, int memoria)
        {
        
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;            
        
        }

        //Verificando se o numero de celular é vazio
         public void VerificarNumero(string numero)
        {
            
            if (string.IsNullOrEmpty(numero))
            {
                throw new ArgumentNullException("Número de celular não pode ser vazio.");
            } 
            
        }
        
        public void Ligar(string numero)
        {
            VerificarNumero(numero);
            
            Console.WriteLine("Ligando...");            
                              
        }
       
        public void ReceberLigacao(string numero)
        {
            VerificarNumero(numero);
            Console.WriteLine("Recebendo ligação...");
            
        }

        public abstract void InstalarAplicativo(string nomeApp);
                
    }
}

