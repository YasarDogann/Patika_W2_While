namespace question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

            int i = 1, sumOdd = 0, sumEven = 0; //satırda int türlerini tanımladım. 

            while (i <= 120)
            {
                #region if Else ile çözüm
                if (i % 2 == 0)
                {
                    sumOdd += i;
                }
                else
                {
                    sumEven += i;
                }
                i++;



                #endregion

                #region Ternany if
                int d =(i%2==0? sumOdd+=i: sumEven+=i); //Console.WriteLine ile sürekli sayı yazacağı için değişkene atadım.
                i++;
                #endregion
            }

            Console.WriteLine("Tek Sayıların Toplamı: {0}",sumOdd);
            Console.WriteLine("Çift Sayıların Toplamı: {0}", sumEven);

        }
    }
}
