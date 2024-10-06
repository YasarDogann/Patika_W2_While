namespace question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

            string sentence = "Kendime inanıyorum, ben bu yazılım işini hallederim!";
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine(sentence);
                i++;
            }
        }
    }
}
