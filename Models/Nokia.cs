

namespace Models.Nokia
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            // Implementação específica do construtor da classe Nokia
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando App para Nokia. Nome do App: {nomeApp}");
        }
    }
}
