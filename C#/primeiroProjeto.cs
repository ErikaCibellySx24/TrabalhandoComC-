
//C# fortemente tipada

//1. screen sound
//variaveis camionCase
string mensagemDeBoasVindas = ("Boas vindas ao Scrren Sound");

//Função - reaproveitamento de codigos - PascalCase

//palavra reservada
void ExibirMensagemDeBoasVindas(){
    //se eu colocar o @ = verbatiLiteral ele agrupa todos de dentro do parenteses
    Console.WriteLine(@"
░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░░██████╗
██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗██╔════╝
╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║╚█████╗░
░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║░╚═══██╗
██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝██████╔╝
╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░╚═════╝░");

}

void ExibirOpcoesDoMenu(){
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a media de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");

    // o ! é usado para evitar trabalhar com valores nulos
    string opcaoEscolhida = Console.ReadLine()!;
    //o parse pega um texto e converte para int
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida)
    if(opcaoEscolhidaNumerica == 1 ){
        Console.Write("\nVocê digitou a opção " + opcaoEscolhida);
    }
    
    //usar o switch case
    //switch (opcaoEscolhidaNumerica)
    //{
        case == 1:
        //adicionar comando 
            Console.WriteLine("Voce escolheu a opção: " + opcaoEscolhidaNumerica);
            break;

        case == 2:
        //adicionar comando 
            Console.WriteLine("Voce escolheu a opção: " + opcaoEscolhidaNumerica);
            break;
        
        case == 3:
        //adicionar comando 
            Console.WriteLine("Voce escolheu a opção: " + opcaoEscolhidaNumerica);
            break;

        case == 4:
        //adicionar comando 
            Console.WriteLine("Voce escolheu a opção: " + opcaoEscolhidaNumerica);
            break;

        case == -1:
        //adicionar comando 
            Console.WriteLine("Bye Bye! ");
            break;

        default:
            Console.WriteLine("Não se encaixa nas nossas opções");
            break;
   //}
}

//como exibir
ExibirMensagemDeBoasVindas();
ExibirOpcoesDoMenu();