internal class Program
{
    private static void Main(string[] args)
    {
        double conta, devendo, troco;
        int aux;

        Console.WriteLine("Digite o valor disponivel: ");
        conta = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite devendo: ");
        devendo = double.Parse(Console.ReadLine());

        troco = conta - devendo;

        if (troco < 0)
        {
            Console.WriteLine("devendo: " + -(troco));
        }
        else if (troco == 0)
        {
            Console.WriteLine("Sem troco");
        }
        else
        {
            aux = (int)troco / 100;
            Console.WriteLine("notas de 100: " + aux);

            troco = troco % 100;
            aux = (int)troco / 50;
            Console.WriteLine("notas de 50: " + aux);

            troco = troco % 50;
            aux = (int)troco / 20;
            Console.WriteLine("notas de 20: " + aux);

            troco = troco % 20;
            aux = (int)troco / 10;
            Console.WriteLine("notas de 10: " + aux);

            troco = troco % 10;
            aux = (int)troco / 5;
            Console.WriteLine("notas de 5: " + aux);

            troco = troco % 5;
            aux = (int)troco / 2;
            Console.WriteLine("notas de 2: " + aux);

            troco = troco % 2;
            aux = (int)troco / 1;
            Console.WriteLine("moedas de 1: " + aux);


        }
    }
}