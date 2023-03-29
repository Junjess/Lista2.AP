namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o texto a ser criptografado: ");
            string texto = Console.ReadLine();

            Console.Write("Digite o número de posições a serem avançadas no alfabeto: ");
            int posicoes = int.Parse(Console.ReadLine());

            string textoCriptografado = "";

            foreach (char letra in texto)
            {
                if (letra >= 'A' && letra <= 'Z')
                {

                    char letraCriptografada = (char)(((letra - 'A' + posicoes) % 26) + 'A');
                    textoCriptografado += letraCriptografada;
                }
                else if (letra >= 'a' && letra <= 'z')
                {
                    char letraCriptografada = (char)(((letra - 'a' + posicoes) % 26) + 'a');
                    textoCriptografado += letraCriptografada;
                }
                else
                {
                    textoCriptografado += letra;
                }
            }
            Console.WriteLine("Texto criptografado: " + textoCriptografado);
        }
    }
}