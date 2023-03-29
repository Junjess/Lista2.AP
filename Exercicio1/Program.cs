namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String frase;

            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            String[] palavras = frase.Split(' ');

            String novaFrase = "";
            foreach (string palavra in palavras)
            {
                novaFrase += char.ToUpper(palavra[0]) + palavra.Substring(1) + " ";
            }
            Console.WriteLine(novaFrase);
        }
    }
}