
int FimDoPrograma = 1;
                              
void ExibirLogo()
{

    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");

}

List<String> ListaBanda = new List<string>{"BTS","Black Pink","Test"};


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
        case 1:
        RegistrarBanda();
            break;
        case 2:
        ExibirBandas();
            break;
        case 3:
        AvaliarBanda();
            break;
        case 4:
        ExibirAvaliacaoBandas();
            break;
        case 0:
            FimDoPrograma = 0;
            Console.WriteLine("tchau tchau :)");
            break;
        default:
            Console.Error.WriteLine("Opção Digitada invalida!");
            break;

    }
    
}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registo de bandas");
    Console.Write("Digite o nome da banda que deseja registra: ");
    String NomeDaBanda = Console.ReadLine()!;
    ListaBanda.Add(NomeDaBanda);
    Console.WriteLine($"A banda {NomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(1000);
    Console.Clear();
}
void ExibirBandas()
{
    Console.Clear();
    Console.WriteLine("Exibir todas as bandas resgistada!\n");
    foreach(String Banda in ListaBanda){
        Console.WriteLine($"Banda: {Banda}");
    }
    Console.WriteLine("\nAperte qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
}
void AvaliarBanda()
{

}
void ExibirAvaliacaoBandas()
{

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

