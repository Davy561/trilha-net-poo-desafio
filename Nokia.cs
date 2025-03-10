using System;
namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia:Smartphone
    {
        public Nokia(string modelo, string numero, string imei, int memoria)
        : base(modelo, numero, imei, memoria)
        {
            
        }
        public override void InstalarAplicativo(string nomeDEF)
        {
            Console.WriteLine($"Foi instalado{nomeDEF}");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}