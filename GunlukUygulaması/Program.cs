namespace GunlukUygulaması
{
    internal class Program
    {
        class Gunluk
        {
            public string Ekle { get; set; }
            public DateTime Tarih { get; set; }

        }
        static string Sor(string soru)
        {
            Console.WriteLine(soru);
            return Console.ReadLine();
        }
        static List<string> kullanicilar = new List<string>();
        static List<int> sifreler = new List<int>();


        static void Main(string[] args)
        {
            List<Gunluk>gunlukler = new List<Gunluk>();


                
            while(true)
            {

                Console.WriteLine("Yapmak istediğiniz işlemi seçin.");
                Console.WriteLine("1-Yeni kullanıcı kaydı.");
                Console.WriteLine("2-Giriş yap.");
                Console.WriteLine("3-Çıkış");

                int inputSecim = int.Parse(Sor("Seçiminiz:  "));

                if (inputSecim == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Kayıt Ekrarnına Hoş geldiniz");
                    Console.WriteLine("Yeni kullanıcı adı ve sifreyi belitleyiniz");

                    string newKullanici = Sor("Kullanıcı adı:  ");
                    int newSifre = int.Parse(Sor("Şifre: "));

                    kullanicilar.Add(newKullanici);
                    sifreler.Add(newSifre);

                    Console.WriteLine("Kayıt işlemi başarılı.");
                }
                else if (inputSecim == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Giriş ekranına Hoş geldiniz.");
                    Console.WriteLine("Kullanıcı adı ve şifreyi girerek giriş yapabilirsiniz");

                    string kayitliKullanici = Sor("\nAdınız:  ");
                    int kayitliSifre = int.Parse(Sor("Sifreniz:  "));
                    bool kullaniciVarMi = false;

                    for (int i = 0; i < kullanicilar.Count; i++)
                    {
                        if (kullanicilar[i] == kayitliKullanici && sifreler[i] == kayitliSifre)
                        {
                            kullaniciVarMi = true;
                            break;
                        }
                    }
                    if (kullaniciVarMi)
                    {
                        Console.WriteLine("Giriş başarılı");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz kullanıcı adı veya şifre. Tekrar deneyiniz.");
                    }


                    if (kullaniciVarMi==true)
                    {
                        Console.Clear();
                        Console.WriteLine("1-Günlük yazmaya başla");
                        Console.WriteLine("2-Günlük oku");
                        Console.WriteLine("3-Çıkış");

                        int kullanıcıSecimi = int.Parse(Sor("Hangi işlemi yapmak istiyorusunuz: "));

                        if (kullanıcıSecimi == 1)
                        {
                            Gunluk gunluk = new Gunluk();
                            gunluk.Tarih = DateTime.Now;
                            gunluk.Ekle = Sor("Yeni günlük metni girin:  ");

                            gunlukler.Add(gunluk);
                        }
                        else if (kullanıcıSecimi == 2)
                        {
                            foreach (var gunluk in gunlukler)
                            {
                                Console.WriteLine($"{gunluk.Tarih}");
                                Console.WriteLine($"\n{gunluk.Ekle}");
                            }
                        }
                        else { return; }







                    }
                
                    
                }



            }



        }

    }
}
