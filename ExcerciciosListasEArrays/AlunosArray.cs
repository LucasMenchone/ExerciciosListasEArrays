using ExcerciciosListasEArrays;
using System.Numerics;
using System.Xml;

namespace ExcerciciosListasEArrays
{
public class AlunosArray
    {
        public static string?[] nomes = new string[5];
        public static double[] notas = new double[5];

        public void CadastraAlunos()
        {
            Console.WriteLine("###Bem vindo, cadastre o nome e a nota de 5 alunos ao digitar o nome abaixo###");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"\nAluno {i + 1}: ");
                nomes[i] = Console.ReadLine();

                Console.Write($"\nNota do aluno {i + 1}: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("\n----------------------------");
            }
        }

        public void ExibeAlunos()
        {
            Console.WriteLine("Os alunos cadastrados e suas respectivas notas são os seguintes: ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Aluno: {nomes[i]}");
                Console.WriteLine($"Nota: {notas[i]}");
            }
        }

        public void MediaNotas()
        {
            Console.WriteLine("################################################################");
            Console.WriteLine($"A média das notas de todos os alunos é {notas.Average()}");
           
        }
    }
}

public class AlunosMatriz
{
    private static string?[,] matrizAlunos = 
        {
            {"Maria","Paulo","Marta","Pedro","Carlos"},
            {"Silvia","Amanda","Manoel","Paula","Alicia"}
        };


    public void CadastrarAlunos()
    {
        Console.WriteLine("###Bem vindo, cadastre o nome e a nota de 10 alunos ao digitar o nome abaixo###");
        for (int i = 0; i < matrizAlunos.GetLength(0); i++)
        {
            for(int j = 0; j < matrizAlunos.GetLength(1); j++)
            {
                Console.WriteLine($"Digite o nome do aluno para ser cadastrado no indice " +
                    $"{i},{j}: ");
                matrizAlunos[i,j] = Console.ReadLine();
            }
        }
    }

    public void ExibirAlunos()
    {
        for (int i = 0; i< matrizAlunos.GetLength(0); i++)
        {
            for( int j = 0; j< matrizAlunos.GetLength(1); j++)
            {
                Console.Write($"[{i}][{j}] = {matrizAlunos[i, j]}\t     ");
            }
            Console.WriteLine();
        }
    }
}

public class AlunosList
{
    public static List<Aluno> listaAlunos = new()
    {
      new Aluno{Nome= "MARIA",Nota=8.75 },
      new Aluno{Nome= "MANOEL",Nota=6.95 },
      new Aluno{Nome= "AMANDA",Nota=7.25 },
      new Aluno{Nome= "CARLOS",Nota=6.55 },
      new Aluno{Nome= "JAIME",Nota=8.50 },
      new Aluno{Nome= "DEBORA",Nota=5.95 },
      new Aluno{Nome= "ALICIA",Nota=9.25 },
      new Aluno{Nome= "SANDRA",Nota=5.55 },
      new Aluno{Nome= "MARTA",Nota=7.85 },
      new Aluno{Nome= "SUELI",Nota=9.15 }

    };  

    public static List<Aluno> GetAlunos()
    {
        return listaAlunos;
    }

    public static void ExibeAlunos()
    {
        foreach (var item in listaAlunos)
        {
            Console.WriteLine($"Nome: {item.Nome},\t Nota: {item.Nota.ToString("f")}");
        }
    }
    public void CadastraNovoAluno(string? nome, double nota)
    {
        listaAlunos.Add(new Aluno { Nome = nome.ToUpper(), Nota = nota });
    }

    public static void MediaNotas()
    {
        double media = 0.0;

        foreach (var item in listaAlunos)
        {
            media += item.Nota;
        }

        int totalAlunos = listaAlunos.Count;
        Console.WriteLine($"O Número total de alunos é: {totalAlunos}" +
            $"\nA média das notas de todos os alunos é: {(media / totalAlunos).ToString("f")}");

    }

    public void PesquisaAluno(int escolha, string dado)
    {
        List<Aluno> listaDeAlunos = GetAlunos();
        Aluno? alunoEncontrado;

        switch (escolha)
        {

            case 1:
                alunoEncontrado = listaDeAlunos.Find(f=> f.Nome.Equals(dado.ToUpper()));
                Console.WriteLine($"Cadastro Encontrado " +
                    $"\nAluno: {alunoEncontrado.Nome ?? "Nome não encontrado"}" +
                    $"\nNota: {alunoEncontrado.Nota}");
                break;

            case 2:
                alunoEncontrado = listaAlunos.Find(f => f.Nome.StartsWith(dado.ToUpper()));
                Console.WriteLine($"Cadastro Encontrado " +
                    $"\nAluno: {alunoEncontrado.Nome ?? "Nome não encontrado"}" +
                    $"\nNota: {alunoEncontrado.Nota}");
                break;

            default:
                Console.WriteLine("Escolha somente 1 ou 2");
                break;
        }
    }


}