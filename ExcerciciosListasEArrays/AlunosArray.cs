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
