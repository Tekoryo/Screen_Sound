string mensagemDeBoasVindas = "Boas vindas ao Screen_sound!";
int FimDoPrograma = 1;
                              
void ExibirMensagemDeBoasVindas()
{

    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀");
    Console.WriteLine(mensagemDeBoasVindas);
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
    
    Console.WriteLine("Você digitou a opcão " + opcaoEscolhidaNumerica);

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

}
void ExibirBandas()
{

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

ExibirMensagemDeBoasVindas();

do{
ExibirOpcoesDoMenu();

}while(!acabou());

