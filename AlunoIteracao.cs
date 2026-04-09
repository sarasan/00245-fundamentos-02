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

        Console.WriteLine("Insira um numero: (até inserir 0 para parar)");

        int nb;

        if (int.TryParse(Console.ReadLine(), out nb))
        {

            soma += nb;

            Console.WriteLine($"Numero inserido: \n" + nb);

            Console.WriteLine("Soma actual: \n" + soma);
        }
        
        if (nb == 0) {

                break;
        }


        }
        Console.WriteLine("Soma final: \n" + soma);

        Console.WriteLine();

////////////////////////////////////////////////////////////////

   Console.WriteLine("===================================================\n");

    Console.WriteLine("EXERCÍCIO 3:Validação de senha com do-while");

    Console.WriteLine("===================================================\n"); 

    string password = "12345A+";

    string pwd;

    do{
        Console.WriteLine("Insira a palavra-passe:\n ");

        pwd = Console.ReadLine();

        Console.WriteLine("Palavra-passe errada\n");
 
        }

        while (pwd != password);

      
          if (pwd == password)
            {
            
                Console.WriteLine("Senha correcta: " +  new string('*', pwd.Length));

                Console.WriteLine("Acesso permitido");


     
            }

///////////////////////////////////////////////////////////////////////////////////
Console.WriteLine("===================================================\n");

Console.WriteLine("EXERCÍCIO 4: Nomes em Maiúsculas");

Console.WriteLine("===================================================\n"); 

 Console.WriteLine("Nomes em maiusculas: \n");


    string [] nomes=["Ana", "Clara", "Pedro", "Miguel"];

    foreach (string name in nomes)
        {
        
           
           Console.WriteLine(name.ToUpper());
        }

            

    }
   
}


            

  
    

