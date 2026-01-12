using System.Collections;

//var diasDaSemana = new ArrayList() 
//{
//    "Domingo", 
//    "Segunda-feira", 
//    "Terça-feira", 
//    "Quarta-feira", 
//    "Quinta-feira", 
//    "Sexta-feira", 
//    "Sábado" 
//};

//var diasDaSemana = new string[]
//{
//    "Domingo",
//    "Segunda-feira",
//    "Terça-feira",
//    "Quarta-feira",
//    "Quinta-feira",
//    "Sexta-feira",
//    "Sábado"
//};

//var carrinho = new ArrayList()
//{
//    new Produto() { Nome = "Caneta", Preco = 3.45 },
//    new Produto() { Nome = "Caderno", Preco = 23.90 },
//    new Produto() { Nome = "Borracha", Preco = 1.50 },
//    new Produto() { Nome = "Estojo", Preco = 15.00 }
//};

var carrinho = new List<Produto>()
{
    new Produto() { Nome = "Caneta", Preco = 3.45 },
    new Produto() { Nome = "Caderno", Preco = 23.90 },
    new Produto() { Nome = "Borracha", Preco = 1.50 },
    new Produto() { Nome = "Estojo", Preco = 15.00 }
};

var diasDaSemana = new DiasDaSemana();



//PercorrendoComForEach();
//PercorrendoComEnumerator();
PercorrendoDiasComForEach();

void PercorrendoComEnumerator()
{
    Console.WriteLine("-----------------------------------------------");
    var enumerator = diasDaSemana.GetEnumerator();
    while (enumerator.MoveNext())
    {
        var dia = enumerator.Current;
        Console.WriteLine(dia);
    }
}

void PercorrendoDiasComForEach()
{
    foreach (string item in diasDaSemana)
    {
        Console.WriteLine(item);
    }
}

void PercorrendoComFor()
{
    Console.WriteLine("-----------------------------------------------");

    for (int i = 0; i < carrinho.Count; i++)
    {
        Console.WriteLine($"Produto: {carrinho[i].Nome}");
    }
}

void PercorrendoComForEach()
{    
    Console.WriteLine("-----------------------------------------------");

    foreach (var produto in carrinho)
    {
        Console.WriteLine($"Produto: {produto.Nome}");
    }
}

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiasDaSemanaEnumerator : IEnumerator<string>
{
    private int posicao = -1;

    private string[] dias = new string[]
    {
        "Domingo",
        "Segunda-feira",
        "Terça-feira",
        "Quarta-feira",
        "Quinta-feira",
        "Sexta-feira",
        "Sábado"
    };

    public string Current => dias[posicao];

    object IEnumerator.Current => Current;

    public void Dispose() {}

    public bool MoveNext()
    {
        posicao++;

        return posicao < dias.Length;
    }

    public void Reset()
    {
        posicao = -1;
    }
}

class DiasDaSemana : IEnumerable<string>
{
    public IEnumerator<string> GetEnumerator()
    {
        yield return "Domingo";
        yield return "Segunda-feira";
        yield return "Terça-feira";
        yield return "Quarta-feira";
        yield return "Quinta-feira";
        yield return "Sexta-feira";
        yield return "Sábado";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}