using ExcerciciosListasEArrays;

//Console.WriteLine("### CADASTRO DE ALUNOS ###\n");

//cadastro de 5 alunos por array
/*
AlunosArray alunos = new AlunosArray();

alunos.CadastraAlunos();
alunos.ExibeAlunos();
alunos.MediaNotas();
*/


Console.WriteLine("#######################################");

//cadastro de 10 alunos via matriz (OBS: já possui dados iniciais para teste
//                                  O cadastro é opcional)

/*
AlunosMatriz alunosMatriz = new AlunosMatriz();

alunosMatriz.CadastrarAlunos();
alunosMatriz.ExibirAlunos();
*/

AlunosList lista = new AlunosList();
Console.WriteLine("Seja bem vindo ao banco de alunos cadastrados\nDigite 1 para procurar por um aluno por nome, e 2 para procurar por um aluno por inicial");
int escolha = Convert.ToInt32(Console.ReadLine());

string? dadoFornecido = "";

if (escolha == 1)
{
    Console.WriteLine("digite o nome do aluno para verificar se há cadastro:");
    dadoFornecido = Console.ReadLine();
}
else if (escolha == 2)
{
    Console.WriteLine("digite a inicial do aluno para verificar se há cadastro:");
    dadoFornecido = Console.ReadLine();
}

lista.PesquisaAlunos(escolha, dadoFornecido);