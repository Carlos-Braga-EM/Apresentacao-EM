using Generics;

public class Program
{
    public static void Main(string[] args)
    {
        List<Produto> listaDeProdutos = [
                                            new("Sabonete", 12.9m, 10),
                                            new("Condicionador", 18.9m, 12),
                                            new("Shampoo", 21.9m, 0),
                                            new("Lâmina de barbear", 4.99m, 16)
                                        ];

        //Produtos disponíveis
        List<Produto> listaDeProdutosDisponiveis = listaDeProdutos.Where(p => p.Quantidade > 0).ToList();
        
        foreach(Produto p in listaDeProdutosDisponiveis)
        {
            Console.WriteLine(p.Nome); //Mostra os produtos disponíveis
        }



    }
}