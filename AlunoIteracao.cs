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
        /////////////////////////////////////////////////////////

        Console.WriteLine("===================================================\n");

        Console.WriteLine("EXERCÍCIO 2:Soma de numeros com While");

        Console.WriteLine("===================================================\n"); 

        
         int soma = 0;

         while (true) {

        Console.WriteLine("Insira um numero: ");

        int nb;

        if (int.TryParse(Console.ReadLine(), out nb)){

            soma += nb;

        Console.WriteLine($"Numero inserido: \n" + nb);

        Console.WriteLine("Soma actual: \n" + soma);
        }
        
            if (nb == 0) {
                break;
            }
 
        }


        
    }
   
}


            

  
    

