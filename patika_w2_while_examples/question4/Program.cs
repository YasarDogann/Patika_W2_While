namespace question4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

            int sum = 0, i =50; //tek satırda birden fazla int değişkeni tanımladım.

            while (i <= 150)
            {
                sum += i; // i değerindeki sayıyı sum değiişkenindeki ile toplayım sum değişkenine atadık
                i++;
            }
            Console.WriteLine(sum);


        }
    }
}
