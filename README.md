# Patika Week2 While Döngüsü ile Alıştırma Uygulaması
Merhaba,
Bu proje C# ile While Döngüsü kullanarak alıştırma için yapılmış bir uygulamadır.

## 📚 Bilgi
Her ödev farklı dosyalarda yapılmıştır. Tek sayfa değildir kontrollerinizde dikkat etmenizi rica ederim.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- `while` yapısını anlamak

## 🚀 Kod
```csharp
SORU1:
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
ÇIKTI:
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!
Kendime inanıyorum, ben bu yazılım işini hallederim!

*************************************************************************************************

//SORU 2
 static void Main(string[] args)
 {
     //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
     int i = 1;

     while (i <= 20)
     {
         Console.WriteLine(i);
         i++;
     }

     Console.Read();
 }

ÇIKTI :
1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20



*************************************************************************************************

SORU 3:
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
ÇIKTI:

2

4

6

8

10

12

14

16

18

20
*************************************************************************************************

SORU 4:
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

ÇIKTI:
10100

*************************************************************************************************

SORU 5:
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
ÇIKTI:
Tek Sayıların Toplamı: 3660
Çift Sayıların Toplamı: 3600
