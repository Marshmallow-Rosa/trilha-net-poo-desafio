

namespace Models.Iphone
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Implementação específica do construtor da classe Iphone
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando App para Iphone. Nome do App {nomeApp}");
        }
    }
}
