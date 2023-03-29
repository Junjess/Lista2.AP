namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase, novaFrase = " ";
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            letrasMaiusculas(frase);
            letrasMinusculas(frase);
            quantCaracter(frase);
            primeiraPalavra(frase);
            ultimaPalavra(frase);

        }
        static void letrasMaiusculas(String frase)
        {
            Console.WriteLine(frase.ToUpper());
        }
        static void letrasMinusculas(String frase)
        {
            Console.WriteLine(frase.ToLower());
        }
        static void quantCaracter(String frase)
        {
            Console.WriteLine(frase.Length);
        }
        static void primeiraPalavra(String frase)
        {
            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i].Equals(' '))
                {
                    break;
                }
                else
                {
                    Console.Write(frase[i]);
                }

            }
            Console.WriteLine(" ");
        }
        static void ultimaPalavra(String frase)
        {
            string[] palavras = frase.Split();

            string ultimaPalavra = palavras[palavras.Length - 1];

            Console.WriteLine(ultimaPalavra);
        }
    }
}