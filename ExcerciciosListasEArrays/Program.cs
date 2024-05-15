using ExcerciciosListasEArrays;
using System.Threading.Channels;

//EXERCÍCIO DE CADASTRO DE ALUNOS
//Console.WriteLine("### CADASTRO DE ALUNOS ###\n");

//cadastro de 5 alunos por array
//AlunosArray alunos = new AlunosArray();

//alunos.CadastraAlunos();
//alunos.ExibeAlunos();
//alunos.MediaNotas();
//*/


//Console.WriteLine("#######################################");

//cadastro de 10 alunos via matriz (OBS: já possui dados iniciais para teste
//                                  O cadastro é opcional)

//AlunosMatriz alunosMatriz = new AlunosMatriz();

//alunosMatriz.CadastrarAlunos();
//alunosMatriz.ExibirAlunos();
//*/

//AlunosList lista = new AlunosList();

//AlunosList.ExibeAlunos();
//AlunosList.MediaNotas();

//Console.WriteLine("#######################################");

//Console.WriteLine("Seja bem vindo ao banco de alunos cadastrados\nDigite 1 para procurar por um aluno por nome, e 2 para procurar por um aluno por inicial");
//int escolha = Convert.ToInt32(Console.ReadLine());

//string? dadoFornecido = "";

//if (escolha == 1)
//{
//    Console.WriteLine("digite o nome do aluno para verificar se há cadastro:");
//    dadoFornecido = Console.ReadLine();
//}
//else if (escolha == 2)
//{
//    Console.WriteLine("digite a inicial do aluno para verificar se há cadastro:");
//    dadoFornecido = Console.ReadLine();
//}

//lista.PesquisaAluno(escolha, dadoFornecido);


//EXERCICIO DE MANIPULAÇÃO DE ARRAY DE STRINGS
//ArrayFruits array = new();

//Console.WriteLine("Frutas cadastradas em ArrayFruits <Via Foreach>\n");
//foreach (var item in array.Frutas)
//{
//    Console.WriteLine($"{item}");
//}

//Console.WriteLine("=====================================");
//Console.WriteLine("Frutas cadastradas em ArrayFruits <Via For>\n");
//for (int i = 0;i < array.Frutas.Length; i++)
//{
//    Console.WriteLine($"{array.Frutas[i]}");
//}

//Console.WriteLine("=====================================");

//Console.WriteLine($"Segunda fruta da lista {array.Frutas[1]}" +
//                $"\nPenúltima fruta {array.Frutas[array.Frutas.Length-2]}");

//Console.WriteLine("=====================================");

//array.Frutas[2] = "Kiwi"; //terceira fruta
//array.Frutas[array.Frutas.Length - 1] = "Caqui";//ultima fruta

//Console.WriteLine("Terceira fruta torna-se KIWI e a ultima torna-se CAQUI\n");
//foreach (var item in array.Frutas)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("=====================================");
//Console.WriteLine("Frutas em Ordem Alfabética\n");

//Array.Sort(array.Frutas);

//foreach (var item in array.Frutas)
//{
//    Console.WriteLine(item);
//}

//EXERCÍCIO DE MANIPULAÇÃO DE ARRAY DE INTEIROS

Console.WriteLine("### BEM VINDO ###" +
    "            \nDigite o número de entradas de valores que deseja cadastrar:");
int tamanhoArray = Convert.ToInt32(Console.ReadLine());
int[] arrayDeInteiros = new int[tamanhoArray];

for (int i = 0; i < tamanhoArray; i++)
{
    Console.WriteLine($"digite o valor n°{i}: ");
    arrayDeInteiros[i] = Convert.ToInt32(Console.ReadLine());
}

int escolha;
do
{
    Console.WriteLine("-------------------------------------------");
    Console.WriteLine("\nAgora escolha uma das opções:" +
                    "\n1 - Exibir todos os números cadastrados" +
                    "\n2 - Pesquisar um n° dentro da lista" +
                    "\n3 - Sair");

    escolha = Convert.ToInt32(Console.ReadLine());

    switch (escolha)
    {
        case 1:
            Console.WriteLine("\nos valores cadastrados são:");
            foreach (int i in arrayDeInteiros)
            {
                Console.WriteLine(i);
            }
            break;

        case 2:
            Console.WriteLine("Digite o número de deseja procurar na lista");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (arrayDeInteiros.Contains(numero))
            {
                Console.WriteLine("\nValor Encontrado\n");
            }
            else
            {
                Console.WriteLine("\nvalor Não Encontrado\n");
            }
                break;
            default:
                Console.WriteLine("\nescolha uma opção válida\n");
                break;
    }
} while (escolha != 3);

