using trilha_net_poo_desafio.Models;


namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de uso
            Nokia nokia = new Nokia("123456", "Nokia G60", "123ABC", 64);
            Iphone iphone = new Iphone("654321", "iPhone 12", "ABC123", 128);

            nokia.Ligar();
            nokia.ReceberLigacao();
            nokia.InstalarAplicativo("WhatsApp");

            iphone.Ligar();
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Instagram");
        }
    }
}
