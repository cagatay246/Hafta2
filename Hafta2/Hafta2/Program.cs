class Program
{
    // 1. Soru
    static void Main(string[] args)
    {
        // 1. Aşağıdaki çıktıyı yazan bir program.
        Console.WriteLine("Merhaba");
        Console.WriteLine("Nasılsın ?");
        Console.WriteLine("İyiyim");
        Console.WriteLine("Sen nasılsın ?");

        // 2. Bir adet metinsel, bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız.
        string metin = "Merhaba Dünya!";
        int sayi = 10;
        Console.WriteLine($"Metin: {metin}, Sayı: {sayi}");

        // 3. Rastgele bir sayı üretip, ekrana yazdırınız.
        Random rand = new Random();
        int rastgeleSayi = rand.Next();
        Console.WriteLine($"Rastgele Sayi: {rastgeleSayi}");

        // 4. Rastgele bir sayı üretip, bunun 3'e bölümünden kalanı ekrana yazdırınız.
        int sayi4 = rand.Next();
        Console.WriteLine($"Rastgele sayi4'nin 3'e bölümünden kalan: {sayi4 % 3}");

        // 5. Kullanıcıya yaşını sorup, 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
        Console.Write("Yaşınızı giriniz: ");
        int yas = int.Parse(Console.ReadLine());
        if (yas > 18)
        {
            Console.WriteLine("+");
        }
        else
        {
            Console.WriteLine("-");
        }

        // 6. Ekrana 10 defa "Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
        }

        // 7. Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel", "Demet Evgar", bunların yerlerini değiştiriniz.
        Console.Write("Birinci ismi giriniz: ");
        string isim1 = Console.ReadLine();
        Console.Write("İkinci ismi giriniz: ");
        string isim2 = Console.ReadLine();
        string temp = isim1;
        isim1 = isim2;
        isim2 = temp;
        Console.WriteLine($"İsim1: {isim1}, İsim2: {isim2}");

        // 8. Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız.
        BenDegerDondurmem();

        // 9. İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
        int toplam = Topla(5, 7);
        Console.WriteLine($"Toplam: {toplam}");

        // 10. Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
        Console.Write("True ya da False giriniz: ");
        bool boolDeger = bool.Parse(Console.ReadLine());
        string sonuc = DegerDondur(boolDeger);
        Console.WriteLine($"Metinsel Değer: {sonuc}");

        // 11. 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
        Console.Write("Birinci kişinin yaşını giriniz: ");
        int yas1 = int.Parse(Console.ReadLine());
        Console.Write("İkinci kişinin yaşını giriniz: ");
        int yas2 = int.Parse(Console.ReadLine());
        Console.Write("Üçüncü kişinin yaşını giriniz: ");
        int yas3 = int.Parse(Console.ReadLine());
        int enYasli = EnYasli(yas1, yas2, yas3);
        Console.WriteLine($"En yaşlı kişi: {enYasli}");

        // 12. Kullanıcıdan sınırsız sayıda sayı alıp, bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
        int enBuyukSayi = EnBuyukSayi();
        Console.WriteLine($"En büyük sayı: {enBuyukSayi}");

        // 13. Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
        Console.Write("Birinci ismi giriniz: ");
        string isim3 = Console.ReadLine();
        Console.Write("İkinci ismi giriniz: ");
        string isim4 = Console.ReadLine();
        YerDegistir(ref isim3, ref isim4);
        Console.WriteLine($"İsimler değiştirildi: {isim3}, {isim4}");

        // 14. Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
        Console.Write("Bir sayı giriniz: ");
        int sayi5 = int.Parse(Console.ReadLine());
        bool tekMi = TekMi(sayi5);
        Console.WriteLine($"Sayı tek mi: {tekMi}");

        // 15. Kullanıcıdan alınan hız ve zaman bilgileriyle, gidilen yolu hesaplayan bir metot yazınız.
        Console.Write("Hız (km/s): ");
        double hiz = double.Parse(Console.ReadLine());
        Console.Write("Zaman (saat): ");
        double zaman = double.Parse(Console.ReadLine());
        double yol = YolHesapla(hiz, zaman);
        Console.WriteLine($"Gidilen yol: {yol} km");

        // 16. Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
        Console.Write("Yarıçapı giriniz: ");
        double yaricap = double.Parse(Console.ReadLine());
        double alan = AlanHesapla(yaricap);
        Console.WriteLine($"Dairenin Alanı: {alan}");

        // 17. "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harf ile yazdırınız.
        string cumle = "Zaman bir GeRi SayIm";
        Console.WriteLine(cumle.ToUpper());
        Console.WriteLine(cumle.ToLower());

        // 18. "    Selamlar   " metnini bir değişkene atayıp, başındaki ve sonundaki boşlukları siliniz.
        string metin2 = "    Selamlar   ";
        metin2 = metin2.Trim();
        Console.WriteLine($"Trimlenmiş Metin: '{metin2}'");
    }
}