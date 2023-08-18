
int FimDoPrograma = 1;
                              
void ExibirLogo()
{

    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");

}

//List<String> ListaBanda = new List<string>{"BTS","Black Pink","Test"};

Dictionary<String,List<int>> BandasRegistrada = new Dictionary<String,List<int>>();

BandasRegistrada.Add("BTS",new List<int>{10,8,6,9});
BandasRegistrada.Add("Black Pink",new List<int>());
BandasRegistrada.Add("Momoland",new List<int>());

void ExibirTituloMenu(string titulo)
{
    int QuantidadeDeLetraNoTitulo = titulo.Length;
    String asteristico = string.Empty.PadLeft(QuantidadeDeLetraNoTitulo,'*');

    Console.WriteLine(asteristico);
    Console.WriteLine(titulo);
    Console.WriteLine(asteristico + "\n");
}

void ExibirOpcoesDoMenu()
{

    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as banda");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite 0 para Sair");

    Console.WriteLine("\nDigite a sua opção: ");
    string opcaoEscolhida  = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch(opcaoEscolhidaNumerica){
        case 1: RegistrarBanda();
            break;
        case 2: ExibirBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirAvaliacaoBandas();
            break;
        case 0: FimDoPrograma = 0;
            Console.WriteLine("tchau tchau :)");
            break;
        default: Console.Error.WriteLine("Opção Digitada invalida!");
            break;

    }
    
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloMenu("Registo de bandas");
    Console.Write("Digite o nome da banda que deseja registra: ");
    String NomeDaBanda = Console.ReadLine()!;
    BandasRegistrada.Add(NomeDaBanda,new List<int>());
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
}
void ExibirBandas()
{
    Console.Clear();
    ExibirTituloMenu("Exibir todas as bandas resgistada!");
    
    foreach(String Banda in BandasRegistrada.Keys){
        Console.WriteLine($"Banda: {Banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
}
void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloMenu("Avaliar a Banda!");

    Console.Write("Qual banda quer avaliar: ");
    String NomeDaBanda = Console.ReadLine()!;

    if(BandasRegistrada.ContainsKey(NomeDaBanda)){
        Console.Write($"Qual a nota a banda {NomeDaBanda} merece: ");
        int Nota = int.Parse( Console.ReadLine()!);

        BandasRegistrada[NomeDaBanda].Add(Nota);

        Thread.Sleep(1000);
        Console.WriteLine($"A nota foi Registrada com sucesso!");
        Thread.Sleep(2500);
        Console.Clear();

    }else{
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada!");
        Console.WriteLine("\nAperte qualquer tecla para voltar ao menu:");
        Console.ReadKey();
        Console.Clear();
    }


}
void ExibirAvaliacaoBandas()
{
    Console.Clear();
    ExibirTituloMenu("Exibir avaliação de Banda!");

    Console.Write("Qual banda quer ver a avalição: ");
    String NomeDaBanda = Console.ReadLine()!;

    if(BandasRegistrada.ContainsKey(NomeDaBanda)){

        double MediaDaNotaRegistrada = BandasRegistrada[NomeDaBanda].Average();
        
        Console.WriteLine($"Esta é a media da banda {NomeDaBanda}: {MediaDaNotaRegistrada} ");
        
        Thread.Sleep(2500);
        Console.Clear();

    }else{
        Console.WriteLine($"A banda {NomeDaBanda} não foi encontrada!");
        Thread.Sleep(2500);
        Console.Clear();
    }
}

bool acabou()
{
    if(FimDoPrograma == 0)return true;
    return false;
}


do{
ExibirLogo();
ExibirOpcoesDoMenu();

}while(!acabou());

