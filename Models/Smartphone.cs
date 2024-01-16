using System.Runtime.CompilerServices;
using System;        
        
namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        private string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }
       
        public Smartphone(string modelo, string imei, int memoria)
        {
        
            //Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;            
        
        }

        public void Ligar(string numero)
        {
            try
            {
                if (numero != "" )
                {
                   Console.WriteLine("Ligando...");
                }
                else
                {
                    throw new ArgumentNullException("Número de celular não pode ser nulo ou vazio.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Environment.Exit(1);
                
             }                       
                              
        }

        public void ReceberLigacao(string numero)
        {
             try
            {
                if (numero != "" )
                {
                   Console.WriteLine("Recebendo ligação...");
                }
                else
                {
                    throw new ArgumentNullException("Número de celular não pode ser nulo ou vazio.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Environment.Exit(1);
                
             }                       
            
        }

        public virtual void InstalarAplicativo(string numero, string nomeApp)
        {
             try
            {
                if (numero != "" )
                {
                   Console.WriteLine($"Instalando aplicativo {nomeApp} no celular.");
                }
                else
                {
                    throw new ArgumentNullException("O aplicativo não pode ser instalado. Número nulo ou vazio.");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                //Environment.Exit(1);
            }
        }
        
    }
}

