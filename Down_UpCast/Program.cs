using DownCast;

public class Program
{
    public static void Main(string[] args)
    {
        Forma formaQualquer = new Quadrado(); // UpCast: do tipo mais especifico para o base (implicito)
        Quadrado quadrado_2 = new Quadrado();
        Quadrado quadrado = (Quadrado)formaQualquer; // Downcast: de um tipo base para um mais especifico (explicito)

        quadrado.Desenhar();
        Console.WriteLine(quadrado.lados);
        Console.WriteLine(formaQualquer == quadrado);
        Console.WriteLine(quadrado_2 == quadrado);

        //Uso do AS e IS
        //O "as" faz o downcast, e se nao for possivel, vai retornar o valor null no lugar da excecao
        Forma f = new();
        Quadrado q = f as Quadrado;

        if(q != null)
        {
            Console.WriteLine(q.lados);
        }
        else
        {
            Console.WriteLine("O valo e null e a conversao nao funcionou");
        }

        //O "is" faz a verificacao, e retorna um booleano, se for true, os tipos sao compativeis
        if(formaQualquer is Quadrado)
        {
            Console.WriteLine(((Quadrado)formaQualquer).lados);
        }
        else
        {
            Console.WriteLine("Nao e compativel os tipos");
        }
    }
}