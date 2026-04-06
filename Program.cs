namespace Aula02EstruturaDeDados;

    
class Program
{
    static void Main(string [] args)
    {
        
        Console.WriteLine("UC606 Estrutura de dados\n");

        EstruturaDeAlteracao estruturaDeAlteracao = new EstruturaDeAlteracao ();

        estruturaDeAlteracao.ExecutarFor();

        estruturaDeAlteracao.ExecutarForEach();
    }

}