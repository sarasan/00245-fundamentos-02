namespace Aula02EstruturaDeDados;

public class AlunoIteracao
{
    
    public void Executar()
    {
        
        Console.WriteLine("EXERCÍCIOS DE ESTRUTURAS DE ITERAÇÃO\n");

        Console.WriteLine("===================================================\n");

        Console.WriteLine("EXERCÍCIO 1: Tabuada com for\n");

        Console.WriteLine("===================================================\n");   

        Console.WriteLine("Insira um numero:\n");

        int num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Numero: {num}\n");

         Console.WriteLine($"Tabuada do : {num }\n");

        for(int i = 1; i <= 10; i++)
        {
         Console.WriteLine($" {num} x {i} = {num * i}\n");   

        }
        Console.WriteLine();

        Console.WriteLine("===================================================\n");

        Console.WriteLine("EXERCÍCIO 2:Soma de numeros com While");

        Console.WriteLine("===================================================\n"); 
  
    }

}