namespace question3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

            int i = 1;

            while (i <= 20)
            {
                Console.WriteLine(i % 2 == 0 ? i : ""); //ternany if ile yazdırdım fakat çıktı olarak 1 satır boşluk olacaktır.
                i++;
            }
        }
    }
}
