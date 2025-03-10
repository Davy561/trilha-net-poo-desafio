using System;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone:Smartphone
    {
    
    public Iphone(string modelo, string numero, string imei, int memoria)
        : base(modelo, numero, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeDEF)
        {
            Console.WriteLine($"Instalando{nomeDEF}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"

    }
}