namespace Aula02EstruturaDeDados;

public class ArrayUnidimensional
{
public void ExecutarArrayUnidimensional()
    {
        
        Console.WriteLine("Array Unidimensional\n");

        //declaraçao de array
        int []numeros = new int [5];

        string[] nomes = {"ana", "tony","mauro","luis","humberto"};

        for(int i = 0;i < numeros.Length; i++)
        {
            numeros[i]=(i+1)*10;

        }

        //acesso exibiçao
        for(int i =0; i< numeros.Length; i++)
        {
            Console.WriteLine($"Numeros[{i}]= {numeros[i]}\n");

        }


        Console.WriteLine("Array de strings\n");

        foreach(string nome in nomes)
            {
                Console.WriteLine($"Valores no array Nomes: {nome}\n");
            }
            ///////////////////////////////

        Console.WriteLine("Propriedades do Array\n");

        Console.WriteLine($"Propriedade de tamanho: {nomes.Length}\n");

        Console.WriteLine($"Propriedade de dimensoes: {nomes.Rank}\n");

  //METODOS DO ARRAY
        Console.WriteLine("Metodo Sort(): \n");

        Array.Sort(nomes);

       Console.WriteLine("Array ordenado: \n");

       foreach(string item in nomes)
        {
            Console.WriteLine($"Array ordenado: {item}\n");
        }

        int index  = Array.IndexOf(nomes, "mauro");

        Console.WriteLine($"Index: {index}");
        
        }
    }

