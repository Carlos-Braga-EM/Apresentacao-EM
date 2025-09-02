public class Program
{
    public static void Main(string[] args)
    {
        int i = 20;
        double j = i;

        double k = 29.90;
        //int z = (int)k; Usado quando tiver certeza de que a conversao vai funcionar, pode falhar de forma imprevista caso a entrada esteja errada

        //Metodos estaticos da classe Convert, sendo mais seguros pois eles tratam erros e evitam o retorno de um valor nulo
        //int z = Convert.ToInt16(k);
        //int z = Convert.ToInt32(k);
        //int z = Convert.ToInt64(k); //A excecao é de excecao, mostrando que deu overflow ao tentar converter um numero double
                                    //em um numero long

        //O parse serve para converter valores string para o tipo desejado
        int y = int.Parse("3");

        //O TryParse vai analisar uma sequencia de strings e converter esses numeros com base em tentativas
        int l;
        bool m = int.TryParse("20", out l);

        if (m)
        {
            Console.WriteLine($"20 -> {l}");
        }

        // do mais rapido pro mais devagar: cast -> parse -> convert -> tryparse
        
    }
}