internal class Program
{
    private static void Main(string[] args)
    {
        //dizi tanımlama
        string [] renkler=new string[5];
        string [] hayvanlar={"kedi","köpek","kuş","maymun"};

        int[]dizi;
        dizi= new int[5];

        //dizilere değer atama
        dizi[3]=10;
        renkler[0]="mavi";
        Console.WriteLine(hayvanlar[1]);
        Console.WriteLine(dizi[3]);
        Console.WriteLine(renkler[0]);

            // döngüler dizi kullanımı
            //kalvyeden girilen n tane sayının ortalamasını hesaplama
            Console.WriteLine("lütfen bir sayı giriniz:");
            int diziuzunlugu=int.Parse(Console.ReadLine());
            int [] sayi= new int[diziuzunlugu];

            for(int i=0;i<diziuzunlugu;i++)
            {
                Console.Write("lütfen {0}. sayıyı giriniz:",i+1);
                sayi[i]=int.Parse(Console.ReadLine());

            }
            int toplam=0;
            foreach(var item in sayi)
            {           
                toplam+=item;
            }
                Console.WriteLine("Dizi ortalaması:"+toplam/diziuzunlugu);

    }
}