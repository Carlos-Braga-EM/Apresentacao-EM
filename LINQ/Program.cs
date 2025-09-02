using LINQ;

public class Program
{
    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = [
                                  new Pessoa("Carlos", 20, "masculino", "12345678910"),
                                  new Pessoa("Alexandre", 17, "masculino", "10987654321"),
                                  new Pessoa("Ayla", 15, "feminino", "1234888910"),
                                  new Pessoa("Nicole", 24, "feminino", "73819038401")
                               ];

        // Maiores de idade
        IEnumerable<Pessoa> PessoasQueSaoMaioreDeIdade = from p in pessoas
                                                  where p.Idade >= 18
                                                  select p;

        foreach(Pessoa p in PessoasQueSaoMaioreDeIdade)
        {
            Console.WriteLine(p.Nome); // Mostra os nomes dos maiores de idade
        }

        // Pessoas ordenadas pela idade
        IEnumerable<Pessoa> PessoasOrdenadasPorIdade = from p in pessoas
                                                     orderby p.Idade
                                                     select p;

        foreach (Pessoa p in PessoasOrdenadasPorIdade)
        {
            Console.WriteLine($"{p.Nome}, {p.Idade}"); // Mostra o nome e a idade em ordem crescente
        }

        // Pessoas que o nome possuem a mesma quantidade de letras
        List<Pessoa> PessoasComNomesComMesmoTamanho = pessoas.GroupBy(p => p.Nome.Length)
                                                        .Where(g => g.Count() > 1) // Apenas grupos com mais de uma pessoa
                                                        .SelectMany(g => g) // Junta todos os grupos em uma lista única
                                                        .ToList(); 

        foreach(Pessoa p in PessoasComNomesComMesmoTamanho)
        {
            Console.WriteLine(p.Nome);
        }

    }
}
