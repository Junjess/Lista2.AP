namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;
            int contador = 1;
            Console.WriteLine("Digite uma frase para saber o número de palavras: ");
            frase = Console.ReadLine();

            char[] palavras = frase.ToCharArray();

            for (int i = 0; i < palavras.Length; i++)
            {
                if (palavras[i].Equals(' '))
                {
                    contador++;
                }
            }
            Console.WriteLine("Número de palavras: " + contador);
        }
    }
}