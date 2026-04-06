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
            
            Console.WriteLine($"AS minhas frutas no forEach: {fruta}");
        }
        


    }
  
}