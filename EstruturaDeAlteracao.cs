namespace Aula02EstruturaDeDados;

class EstruturaDeAlteracao
{
    public  void ExecutarFor ()
    {
         Console.WriteLine("Ciclo/loop FOR\n"); 

         for (int i =0;i <= 5; i++)
        {
           Console.WriteLine($"Interaçao: {i}"); 

        }
        


    }
    //forEach
    public  void ExecutarForEach()
    {
         Console.WriteLine("Ciclo/loop FOREACH\n"); 

         string [] frutas = ["maça", "banana", "laranja", "abacaxi", "1", "true"];
         string [] frutas2 = {"maça", "banana", "laranja", "abacaxi", "1", "true"};

         foreach(string fruta in frutas)
        {
            
            Console.WriteLine($"AS minhas frutas no forEach: {fruta}\n");
        }
        


    }
//BREAK AND CONTINUE
   public  void ExecutarForBreakContinue()
    {
         Console.WriteLine("Break & Continua\n"); 

    
         for( int k = 0;k < 10; k++)
        {

           if(k==3)continue;
            


            if(k == 8)
            {
                break;

            }

            Console.WriteLine ($"Numero: {k}\n");
               
               
            }
        }
        
     public  void ExecutarWhile()
    {
         Console.WriteLine("loop WHILE\n"); 

        int contador = 1;

        while (contador <= 5){

            Console.WriteLine ($"Numero: {contador}\n");

            contador++;
    }
    }
//DO WHILE
      public  void ExecutarDoWhile()
    {
         Console.WriteLine("loop DOWHILE\n"); 

        int num;

        do
        {
            
        Console.WriteLine("Insira um numero");
        
        num = 5;//simula entrada

        Console.WriteLine($"Numero: {num}");
        }
        while(num <= 0);

        
    }
    }
               
        
              
        



  
