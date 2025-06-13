using System;
using System.Security.Cryptography.X509Certificates;
using static BankacilikUygulamasi.ATM_ve_Kart.Program;


namespace BankacilikUygulamasi.ATM_ve_Kart
{
     public  class Program
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Finansal yolculuğunuz burada başlıyor.\nGüvenli. Hızlı. Size özel.\nTek adımda tüm işlemler parmaklarınızın ucunda.");
            Thread.Sleep(2000);
            // Ortak ATM'ler
            OrtakATM ortakATM1 = new OrtakATM() { Adi = "Ortak ATM 1", Konum = "Kadıköy" };
            OrtakATM ortakATM2 = new OrtakATM() { Adi = "Ortak ATM 2", Konum = "Taksim" };

            // Banka ATM'leri
            DisBankATM disBankATM1 = new DisBankATM() { Adi = "DisBank ATM 1", Konum = "Beşiktaş", KrediVerirMi = true, GünlükKullanimLimiti = 7000 };
            DisBankATM disBankATM2 = new DisBankATM() { Adi = "DisBank ATM 2", Konum = "Bakırköy", KrediVerirMi = false, GünlükKullanimLimiti = 4000 };

            KapiKrediATM kapiKrediATM1 = new KapiKrediATM() { Adi = "KapiKredi ATM 1", Konum = "Levent", KrediVerirMi = true, GünlükKullanimLimiti = 6000 };
            KapiKrediATM kapiKrediATM2 = new KapiKrediATM() { Adi = "KapiKredi ATM 2", Konum = "Üsküdar", KrediVerirMi = false, GünlükKullanimLimiti = 3500 };

            TakBankATM takBankATM1 = new TakBankATM() { Adi = "TakBank ATM 1", Konum = "Şişli", KrediVerirMi = true, GünlükKullanimLimiti = 4500 };
            TakBankATM takBankATM2 = new TakBankATM () { Adi = "TakBank ATM 2", Konum = "Maltepe", KrediVerirMi = false, GünlükKullanimLimiti = 3000 };

            ONBATM onbATM1 = new ONBATM () { Adi = "ONB ATM 1", Konum = "Ataşehir", KrediVerirMi = true, GünlükKullanimLimiti = 5500 };
            ONBATM onbATM2 = new ONBATM () { Adi = "ONB ATM 2", Konum = "Bostancı", KrediVerirMi = false, GünlükKullanimLimiti = 2800 };

            // Kartlar
            DisBankKart disBankKart1 = new DisBankKart()
            {
                KullaniciAdi = "Ahmet Yılmaz",
                TCKimlikNo = "12345678901",
                KartSifre = "1234",
                Bakiye = 5000,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "1234-5678-9012-3456",
                GunlukKullanim = 5000m,
            };

            DisBankKart disBankKart2 = new DisBankKart()
            {
                KullaniciAdi = "Elif Demir",
                TCKimlikNo = "23456789012",
                KartSifre = "4321",
                Bakiye = 3500,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "2345-6789-0123-4567",
                GunlukKullanim = 5000m,
            };

            DisBankKrediKart disBankKrediKart1 = new DisBankKrediKart()
            {
                KullaniciAdi = "Mehmet Aksoy",
                TCKimlikNo = "34567890123",
                KartSifre = "1111",
                Bakiye = 1000,
                KrediKartiMi = true,
                KrediLimiti = 10000,
                KartNo = "3456-7890-1234-5678",
                GunlukKullanim = 5000m,
            };

            DisBankKrediKart disBankKrediKart2 = new DisBankKrediKart()
            {
                KullaniciAdi = "Zeynep Kaya",
                TCKimlikNo = "45678901234",
                KartSifre = "2222",
                Bakiye = 1200,
                KrediKartiMi = true,
                KrediLimiti = 8000,
                KartNo = "4567-8901-2345-6789",
                GunlukKullanim = 5000m,
            };

            KapiKrediKart kapiKrediKart1 = new KapiKrediKart()
            {
                KullaniciAdi = "Can Yıldız",
                TCKimlikNo = "56789012345",
                KartSifre = "3333",
                Bakiye = 4000,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "5678-9012-3456-7890",
                GunlukKullanim = 5000m,
            };

            KapiKrediKart kapiKrediKart2 = new KapiKrediKart()
            {
                KullaniciAdi = "Emine Çelik",
                TCKimlikNo = "67890123456",
                KartSifre = "4444",
                Bakiye = 3000,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "6789-0123-4567-8901",
                GunlukKullanim = 5000m,
            };

            TakBankKart takBankKart1 = new TakBankKart()
            {
                KullaniciAdi = "Ali Koç",
                TCKimlikNo = "78901234567",
                KartSifre = "5555",
                Bakiye = 4500,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "7890-1234-5678-9012",
                GunlukKullanim = 5000m,
            };

            TakBankKart takBankKart2 = new TakBankKart()
            {
                KullaniciAdi = "Fatma Arslan",
                TCKimlikNo = "89012345678",
                KartSifre = "6666",
                Bakiye = 3800,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "8901-2345-6789-0123",
                GunlukKullanim = 5000m,
            };

            TakBankKrediKart takBankKrediKart1 = new TakBankKrediKart()
            {
                KullaniciAdi = "Burak Deniz",
                TCKimlikNo = "90123456789",
                KartSifre = "7777",
                Bakiye = 1500,
                KrediKartiMi = true,
                KrediLimiti = 12000,
                KartNo = "9012-3456-7890-1234",
                GunlukKullanim = 5000m,
            };

            TakBankKrediKart takBankKrediKart2 = new TakBankKrediKart()
            {
                KullaniciAdi = "Merve Öz",
                TCKimlikNo = "01234567890",
                KartSifre = "8888",
                Bakiye = 900,
                KrediKartiMi = true,
                KrediLimiti = 7000,
                KartNo = "0123-4567-8901-2345",
                GunlukKullanim = 5000m,
            };

            ONBKart onbBKart1 = new ONBKart()
            {
                KullaniciAdi = "Deniz Şahin",
                TCKimlikNo = "11223344556",
                KartSifre = "9999",
                Bakiye = 6000,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "1122-3344-5566-7788",
                GunlukKullanim = 5000m,
            };

            ONBKart onbKart2 = new ONBKart()
            {
                KullaniciAdi = "Serkan Uçar",
                TCKimlikNo = "22334455667",
                KartSifre = "0000",
                Bakiye = 5000,
                KrediKartiMi = false,
                KrediLimiti = 0,
                KartNo = "2233-4455-6677-8899",
                GunlukKullanim = 5000m,

            };
            AdminKart adminKart = new AdminKart();


            //Bu kısım sadece kart katma işlemini simüle etmek için yazıldı.

            List<Kart> tanimliKartlar = new List<Kart> { disBankKart1, disBankKart2, disBankKrediKart1, disBankKrediKart2, kapiKrediKart1, kapiKrediKart2, takBankKart1, takBankKart2, takBankKrediKart1, takBankKrediKart2, onbBKart1, onbKart2, adminKart };

            List<ATM> tanimliATMler = new List<ATM> { ortakATM1, ortakATM2, disBankATM1, disBankATM2, kapiKrediATM1, kapiKrediATM2, takBankATM1, takBankATM2, onbATM1, onbATM2 };

            

            Random rnd1 = new Random();
            Random rnd2 = new Random();

            

            int rastgeleATM = rnd1.Next(0, tanimliATMler.Count);
            int rastgeleKart = rnd2.Next(0, tanimliKartlar.Count);

            var atm = tanimliATMler[rastgeleATM];
            var kart = tanimliKartlar[rastgeleKart];

            while (true)
            {

                if (atm.KullanilabilenKartlar.Contains(kart.GetType()))
                {
                    atm.KartTak(kart, atm);
                }
                else
                {
                    Console.WriteLine($"\n\n-----------\n\nSayın {kart.KullaniciAdi}\n\nKullanılan kart {kart.BankaAdi} kartıdır.\n\nLütfen {atm.Adi} ATM'sine uygun bir kart takınız.\n\n{kart.BankaAdi} kartı bu ATM ile uyumlu değildir.\n\n");
                }

                Console.WriteLine("Başka işlem yapmak için herhangi bir tuşa basın\n\nÇıkmak için 'Q' tuşuna basın.");

                var key = Console.ReadKey(false);

                if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Programdan çıkılıyor. İyi günler dileriz.");

                    Thread.Sleep(2000);

                    Program.Main(null);

                    break;
                }
                else 
                {
                    Program.Main(null);
                }

                    Console.Clear();
            }


        }

        public class ATM
        {
            public ATM()
            {

            }

            private string _adi;
            private string _konum;
            private static List<Type> _kullanilabilenKartlar = new List<Type>();
            private decimal _makinedekiPara;
            private decimal _gunlukKullanimLimiti;
            private decimal _gunlukKrediLimiti;
            private bool _krediVerirMi;
            private bool _kartGecerliMi;

            public string Adi
            {
                get { return _adi.ToUpper().Trim(); }
                set { if (!string.IsNullOrEmpty(value)) _adi = value; }
            }

            public string Konum
            {
                get { return _konum.ToUpper(); }
                set { _konum = value; }
            }



            public decimal MakinedekiPara
            {
                get { return _makinedekiPara; }
                set { _makinedekiPara = value; }
            }

            public decimal GünlükKullanimLimiti
            {
                get { return _gunlukKullanimLimiti; }
                set { _gunlukKullanimLimiti = value; }
            }

            public bool KartGecerliMi
            {
                get { return _kartGecerliMi; }
                set { _kartGecerliMi = value; }
            }

            public bool KrediVerirMi
            {
                get { return _krediVerirMi; }
                set { _krediVerirMi = value; }
            }

            public decimal GünlükKrediLimiti
            {
                get { return _gunlukKrediLimiti; }
                set { _gunlukKrediLimiti = value; }
            }
            public List<Type> KullanilabilenKartlar
            {
                get { return _kullanilabilenKartlar; }

            }

            public void KartEkle(Type kartTipi)
            {
                KullanilabilenKartlar.Add(kartTipi);
            }



            public void KartTak(Kart kart, ATM atm)
            {
                Type atmTipi = atm.GetType();

                Type kartTipi = kart.GetType();

                if (kartTipi == typeof(AdminKart))

                    GosterAdminPaneli(atm);


                    if (kart.KullanilabildigiATMler != null && !kart.KullanilabildigiATMler.Contains(atmTipi))
                {
                    Console.WriteLine($"\n\n-------------------\n\nKullanmış olduğunuz {kart.BankaAdi.ToUpper() } kart  {atm.Adi.ToUpper()} ATM ile uyumlu değildir\n\nLütfen kartınızı alınız.\n\n");

                    Console.ReadLine();

                    Thread.Sleep(3000);

                    static void GeriDon()
                    {
                        Console.Clear();
                        Console.WriteLine("Lütfen başka bir ATM deneyiniz.");
                        Main(null);
                        Console.ReadKey();
                    }
                    GeriDon();
                    return;
                }


                if (kart.KullanilabildigiATMler.Contains(atmTipi) && kart.SonKullanmaTarihi > DateTime.Now)
                {
                    int kalanHak = 3;

                    while (kalanHak > 0)
                    {
                        Console.Clear();
                        Console.WriteLine($"\n{atm.Konum} ---------- {atm.Adi}, {atm.Konum}\n");
                        Console.WriteLine($"Sayın {kart.KullaniciAdi}");
                        Console.Write("Lütfen dört haneli şifrenizi giriniz: ");

                        string girilenSifre = "";

                        while (true)
                        {
                            var key = Console.ReadKey(true);
                            if (key.Key == ConsoleKey.Enter)
                                break;
                            if (key.Key == ConsoleKey.Backspace && girilenSifre.Length > 0)
                            {
                                girilenSifre = girilenSifre.Substring(0, girilenSifre.Length - 1);
                                Console.Write("\b \b");
                            }
                            else if (char.IsDigit(key.KeyChar))
                            {
                                girilenSifre += key.KeyChar;

                                Console.Write("*"); // yıldız göster
                            }
                        }

                        if (girilenSifre == kart.KartSifre)
                        {
                            _kartGecerliMi = true;

                            IslemSec(kart, atm);

                        }

                        kalanHak--;
                        Console.WriteLine($"\n[{DateTime.Now}] Hatalı şifre. Kalan deneme hakkı: {kalanHak}");

                        Console.ReadKey();

                        if (kalanHak == 0)
                        {
                            KartBlokeEt(kart);
                        }
                    }

                }

                // Ek metodlar:

                 void GosterAdminPaneli(ATM atm)
                {
                    Console.Clear();
                    Console.WriteLine("\n----- ATM ADMIN BİLGİ EKRANI -----\n");
                    Console.WriteLine($"ATM Adı: {atm.Adi}");
                    Console.WriteLine($"Konum: {atm.Konum}");
                    Console.WriteLine($"Makinedeki Para: {atm.MakinedekiPara}");
                    Console.WriteLine($"Günlük Kullanım Limiti: {atm.GünlükKullanimLimiti}");
                    Console.WriteLine($"Kredi Veriyor mu: {(atm.KrediVerirMi ? "Evet" : "Hayır")}");
                    Console.WriteLine($"Günlük Kredi Limiti: {atm.GünlükKrediLimiti}");
                    Console.WriteLine($"Rapor Tarihi: {DateTime.Now}");
                    Console.ReadLine();
                }

                void KartBlokeEt(Kart kart)
                {
                    Console.Clear();
                    Console.WriteLine($"Sayın {kart.KullaniciAdi};\nKartınız bloke edilmiştir.");
                    Console.WriteLine($"Lütfen en yakın {kart.BankaAdi} şubesiyle iletişime geçiniz.");
                    kart.KartGecerliMi=false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n=== DİKKAT ===\n{kart.KullaniciAdi},\n\nKARTINIZ BLOKE OLMUŞTUR.\nLütfen en yakın {kart.BankaAdi} şubesiyle iletişime geçiniz.");
                    Console.ResetColor();


                    Console.ReadLine();
                    Program.Main(null);
                    throw new Exception($"Kart bloke edildi.");
                }

            }


            public void IslemSec(Kart kart, ATM atm)
            {
                if (!_kartGecerliMi)
                {
                    Console.WriteLine($"Sayın {kart.KullaniciAdi};\n\nKartınızın son kullanma tarihi dolmuştur\n\nLütfen size en yakın şubemizle temasa geçiniz");
                    return;
                }

                bool devam = true;

                while (devam)
                {
                    Console.Clear();
                    Console.WriteLine($"\n----------\n\nSayın {kart.KullaniciAdi},\nYapmak istediğiniz işlemi seçin:\n\n----------\nC - Para Çek\nY - Para Yatır\nB - Bakiye Sorgula\nQ - Çıkış Yap\n----------\n");

                    string secim = Console.ReadLine().ToUpper().Trim();

                    switch (secim)
                    {
                        case "C":
                            ParaCekIslemi(kart, atm);
                            break;

                        case "Y":
                            ParaYatirIslemi(kart, atm);
                            break;

                        case "B":
                            BakiyeSor(kart, atm);
                            break;

                        case "Q":
                            Console.Clear();
                            Console.WriteLine("Çıkış yapılıyor. Kartınızı almayı unutmayın.");
                            Program.Main(null);
                            devam = false;
                            break;

                        default:
                            Console.WriteLine("Geçersiz seçim.");
                            IslemSec(kart, atm);
                            Console.ReadKey();
                            break;
                    }

                    if (devam)
                    {
                        devam = BaskaIslem();
                    }
                }
            }
            decimal krediIhtiyaci;
            decimal eksiBakiye = 0;
            decimal bugunCekilenPara = 0;
            private void ParaCekIslemi(Kart kart, ATM atm)
            {
                while (true)
                {
                    Console.Write("----------\nÇekmek istediğiniz tutarı giriniz: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal cekTutar) || cekTutar <= 0)
                    {
                        Console.WriteLine("Geçerli bir tutar giriniz.");
                        continue;
                    }



                    if (kart.Bakiye >= cekTutar)
                    {
                        bugunCekilenPara += cekTutar;

                        if (bugunCekilenPara > atm.GünlükKullanimLimiti)
                        {
                            Console.WriteLine($"---------\n\nSayın {kart.KullaniciAdi};\n\nGünlük para çekme limitiniz bu işlem için uygun değildir.\n\nGünlük para çekme limitiniz: {GünlükKullanimLimiti}\n\nLütfen en yakın {kart.BankaAdi} şubemizle temasa geçiniz.");

                            break;
                        }

                        ParaCek(kart, atm, cekTutar);
                        break;
                    }
                    else if (kart.KrediKartiMi && cekTutar <= kart.Bakiye + kart.KrediLimiti)
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"\nBakiye yetersiz.");
                        Console.WriteLine($"\n{kart.BankaAdi} tarafından sağlanan kredi imkanından yararlanmak ister misiniz? (Y/N): ");
                        string cevap = Console.ReadLine().Trim().ToUpper();


                        if (cevap == "Y")
                        {
                            if (kart.Bakiye > 0)
                            {
                                krediIhtiyaci = cekTutar - kart.Bakiye;
                                eksiBakiye -= krediIhtiyaci;
                                kart.KrediLimiti -= krediIhtiyaci;
                                Console.WriteLine("------------------");
                                Console.WriteLine($"Kredi kullanıldı.\n\nHesaptan çekilen para: {kart.Bakiye}\n\nÇekilen kredi: {krediIhtiyaci}\n\nYeni bakiye: {eksiBakiye} TL");
                                Console.WriteLine("-------------------");
                                break;
                            }
                            else
                            {

                                krediIhtiyaci = cekTutar;

                                kart.Bakiye = 0;

                                kart.KrediLimiti -= krediIhtiyaci;

                                eksiBakiye -= krediIhtiyaci;

                                Console.WriteLine("------------------");
                                Console.WriteLine($"Kredi kullanıldı.\n\nHesaptan çekilen para: {kart.Bakiye}\n\nÇekilen kredi: {krediIhtiyaci}\n\nYeni bakiye: {eksiBakiye} TL");
                                Console.WriteLine("-------------------");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("İşlem iptal edildi.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("-------------------");
                        Console.WriteLine($"Sayın {kart.KullaniciAdi}\n\nBakiye yetersiz.\n\nBakiye: {kart.Bakiye} TL");
                        break;
                    }
                }
            }

            public void ParaCek(Kart kart, ATM atm, decimal tutar)
            {
                if (atm.MakinedekiPara >= tutar)
                {
                    kart.Bakiye -= tutar;
                    atm.MakinedekiPara -= tutar;

                    Console.WriteLine("------------------");
                    Console.WriteLine($"İşlem başarılı.\n\nÇekilen miktar: {tutar} TL\n\nKalan bakiye: {kart.Bakiye} TL");
                    Console.WriteLine("------------------");
                }
                else
                {
                    Console.WriteLine($"ATM'de yeterli para yok. Mevcut bakiye: {kart.Bakiye} TL, ATM'deki para: {atm.MakinedekiPara} TL");
                }
            }

            private void ParaYatirIslemi(Kart kart, ATM atm)
            {
                Console.Clear();
                Console.WriteLine("------------------------------");
                Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal yatirTutar) && yatirTutar > 0)
                {
                    ParaYatir(kart, atm, yatirTutar);
                }
                else
                {
                    Console.WriteLine("Geçerli bir tutar giriniz.");
                    Console.ReadKey();
                }
            }

            private bool BaskaIslem()
            {
                while (true)
                {
                    Console.Write("\nBaşka bir işlem yapmak ister misiniz? (E/H): ");
                    string devamMi = Console.ReadLine().Trim().ToUpper();

                    if (devamMi == "E")
                        return true;
                    else if (devamMi == "H")
                    {
                        Console.Clear();
                        Console.WriteLine("Çıkış yapılıyor. Kartınızı almayı unutmayın.");
                        Program.Main(null);
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz giriş. Lütfen sadece 'E' veya 'H' girin.");
                    }
                }
            }


            public void ParaYatir(Kart kart, ATM atm, decimal tutar)
            {
                kart.Bakiye += tutar;
                Console.WriteLine("-----------------");
                Console.WriteLine($"İşlem başarılı.\n\nYatırılan miktar-----{tutar}. \n\nYeni bakiye----- {kart.Bakiye} TL");


            }

            public void BakiyeSor(Kart kart, ATM atm)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine($"{kart.BankaAdi} Bankası\n\nSayın {kart.KullaniciAdi}\n\nMevcut bakiyeniz: {kart.Bakiye} TL");
                if (kart.Bakiye < 0)
                {
                    Console.WriteLine($"\n\nSayın {kart.KullaniciAdi};\n\nKredi ödemeleri için lütfen en yakın {kart.BankaAdi} şubemize başvurunuz. ");
                }


            }

            private static List<Type> _tumATMTurleri = new List<Type>();

            public List<Type> TumATMTurleri
            {
                get { return _tumATMTurleri; }

            }

            public void ATMTurEkle(ATM atm)
            {
                Type yeniATMTipi = atm.GetType();

                if (!_tumATMTurleri.Contains(yeniATMTipi))

                    _tumATMTurleri.Add(yeniATMTipi);


            }


        }

        public class Kart
        {


            private enum _bankalar;
            private string _kullaniciAdi;
            private string _tcKimlikNo;
            private string _bankaAdi;
            private string _kartNo;
            private string _kartSifre;
            private List<Type> _kullanilabildigiATMler = new List<Type>();
            private decimal _bakiye;
            protected bool _krediKartiMi;
            private bool _kartGecerliMi;
            private decimal _krediLimiti;
            private DateTime _sonKullanmaTarihi;
            private bool _adminKartMi;
            private decimal _gunlukKullanim;

            public enum Bankalar 
            {

            }
            public string KullaniciAdi
            {
                get { return _kullaniciAdi; }
                set { _kullaniciAdi = value; }
            }
            public string KartNo
            {
                get { return _kartNo; }
                set { _kartNo = value; }
            }

            public string TCKimlikNo
            {
                get => _tcKimlikNo;
                set
                {
                    if (value.Length != 11)
                        throw new Exception("Geçersiz TC Kimlik No.");

                    else
                        _tcKimlikNo = value;
                }
            }

            public string BankaAdi
            {
                get => _bankaAdi;
                set => _bankaAdi = value;
            }

            public string KartSifre
            {
                get { return _kartSifre; }
                set
                {
                    if (value.Length != 4)
                        throw new Exception("Şifre 4 haneli olmalıdır.");


                    else

                         _kartSifre = value;
                    
                }
            }

            public DateTime SonKullanmaTarihi
            {
                get
                {
                    return _sonKullanmaTarihi;
                }
                set
                {
                    _sonKullanmaTarihi = value;
                }
            }

            public bool KartGecerliMi
            {
                get { return _kartGecerliMi; }
                set
                {
                    if (_sonKullanmaTarihi >= DateTime.Now)
                        _kartGecerliMi = true;

                }

            }

            public List<Type> KullanilabildigiATMler
            {
                get { return _kullanilabildigiATMler; }
            }

            public void ATMekle(Type atmTipi)
            {
                _kullanilabildigiATMler.Add(atmTipi);
            }

            public decimal Bakiye
            {
                get { return _bakiye; }
                set { _bakiye = value; }
            }

            public bool KrediKartiMi
            {
                get { return _krediKartiMi; }
                set { _krediKartiMi = value; }
            }

            public decimal KrediLimiti
            {
                get => _krediLimiti;
                set => _krediLimiti = value;
            }
            public bool AdminKartMi
            {
                get { return _adminKartMi; }
                set { _adminKartMi = value; }
            }
            private DateTime _sonGunTarihi = DateTime.Today;

            public decimal GunlukKullanim
            {
                get
                {
                    if (DateTime.Now.Date > _sonGunTarihi)
                    {
                        _gunlukKullanim = 0;
                        _sonGunTarihi = DateTime.Now.Date;
                    }
                    return _gunlukKullanim;
                }
                set
                {

                    if (DateTime.Now.Date > _sonGunTarihi)
                    {
                        _gunlukKullanim = 0;
                        _sonGunTarihi = DateTime.Now.Date;
                    }
                    _gunlukKullanim += value;
                }
            }
        }


        public class OrtakATM : ATM
        {

            public OrtakATM()
            {
                KartEkle(typeof(DisBankKart));
                KartEkle(typeof(DisBankKrediKart));
                KartEkle(typeof(KapiKrediKart));
                KartEkle(typeof(TakBankKart));
                KartEkle(typeof(TakBankKrediKart));
                KartEkle(typeof(ONBKart));
                GünlükKrediLimiti = 10000;
                GünlükKullanimLimiti = 10000;
                KrediVerirMi = true;
                MakinedekiPara = 1000000m;
                Adi = "Ortak ATM";
                ATMTurEkle(this);


            }

        }

        public class DisBankATM : ATM
        {
            public DisBankATM()
            {
                KartEkle(typeof(DisBankKart));
                KartEkle(typeof(DisBankKrediKart));
                Adi = "DisBank ATM";
                KrediVerirMi = true;
                GünlükKrediLimiti = 10000m;
                GünlükKullanimLimiti = 5000m;
                MakinedekiPara = 1000000m;
                ATMTurEkle(this);

            }

        }
        public class KapiKrediATM : ATM
        {
            public KapiKrediATM()
            {
                KartEkle(typeof(KapiKrediKart));
                Adi = "Kapi Kredi ATM";
                KrediVerirMi = false;
                GünlükKullanimLimiti = 5000m;
                MakinedekiPara = 1000000m;
                ATMTurEkle(this);

            }
        }
        public class TakBankATM : ATM
        {
            public TakBankATM()
            {
                KartEkle(typeof(TakBankKart));
                KartEkle(typeof(TakBankKrediKart));
                Adi = "TakBank ATM";
                KrediVerirMi = true;
                GünlükKrediLimiti = 10000m;
                GünlükKullanimLimiti = 5000m;
                MakinedekiPara = 1000000m;
                ATMTurEkle(this);
            }
        }
        public class ONBATM : ATM
        {
            public ONBATM()
            {
                KartEkle(typeof(ONBKart));
                Adi = "ONB ATM";
                KrediVerirMi = false;
                GünlükKrediLimiti = 10000m;
                GünlükKullanimLimiti = 5000m;
                MakinedekiPara = 1000000m;
                ATMTurEkle(this);
            }
        }

        public class DisBankKart : Kart
        {
            public DisBankKart()
            {
                ATMekle(typeof(DisBankATM));
                ATMekle(typeof(OrtakATM));
                BankaAdi = "DisBank";
                KrediKartiMi = false;
                KartGecerliMi = true;
                BankaAdi = "DisBank";
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici .KartTurEkle(this);



            }
        }
        public class DisBankKrediKart : DisBankKart
        {
            public DisBankKrediKart()
            {

                KrediKartiMi = true;
                KrediLimiti = 10000m;
                KartGecerliMi = true;
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici.KartTurEkle(this);

            }
        }
        public class KapiKrediKart : Kart
        {
            public KapiKrediKart()
            {
                ATMekle(typeof(KapiKrediATM));
                ATMekle(typeof(OrtakATM));
                BankaAdi = "Kapi Kredi";
                KrediKartiMi = false;
                KartGecerliMi = true;
                BankaAdi = "Kapi Kredi";
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici.KartTurEkle(this);
            }
        }
        public class TakBankKart : Kart
        {
            public TakBankKart()
            {
                ATMekle(typeof(TakBankATM));
                ATMekle(typeof(OrtakATM));
                BankaAdi = "TakBank";
                KrediKartiMi = false;
                KartGecerliMi = true;
                BankaAdi = "TakBank";
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici.KartTurEkle(this);
            }
        }

        public class TakBankKrediKart : TakBankKart
        {
            public TakBankKrediKart()
            {
                ATMekle(typeof(TakBankATM));
                ATMekle(typeof(OrtakATM));
                KrediKartiMi = true;
                KrediLimiti = 10000m;
                KartGecerliMi = true;
                BankaAdi = "TakBank";
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici.KartTurEkle(this);
            }
        }
        public class ONBKart : Kart
        {
            public ONBKart()
            {
                ATMekle(typeof(ONBATM));
                ATMekle(typeof(OrtakATM));
                BankaAdi= "ONB";
                KrediKartiMi = false;
                KartGecerliMi = true;
                BankaAdi = "ONB";
                SonKullanmaTarihi = DateTime.Now.AddYears(5);
                AdminKartMi = false;
                KartYonetici.KartTurEkle(this);
            }
        }
        public class AdminKart : Kart
        {
            public AdminKart()
            {
                ATMekle(typeof(DisBankATM));
                ATMekle(typeof(KapiKrediATM));
                ATMekle(typeof(TakBankATM));
                ATMekle(typeof(ONBATM));
                ATMekle(typeof(OrtakATM));
                KullaniciAdi = "ADMIN";
                KrediKartiMi = false;
                KartGecerliMi = true;
                BankaAdi = BankaAdi =" Admin";
                SonKullanmaTarihi = DateTime.MaxValue;
                AdminKartMi = true;
                KartYonetici.KartTurEkle(this);
                
               
            }
        }
        public static class ATMYonetici 
        {
            private static List<Type> _tumATMTurleri = new List<Type>();

            public static List<Type> TumATMTurleri
            {
                get { return _tumATMTurleri; }
            }

            public static void ATMTurEkle(ATM atm)
            {
                Type yeniATMTipi = atm.GetType();

                if (!_tumATMTurleri.Contains(yeniATMTipi))
                {
                    _tumATMTurleri.Add(yeniATMTipi);
                }
            }
            public static void ATMTurSil(ATM atm)
            {
                Type silinecekATMTipi = atm.GetType();
                if (_tumATMTurleri.Contains(silinecekATMTipi))
                {
                    _tumATMTurleri.Remove(silinecekATMTipi);
                }
            }

            public static ATM YeniATMOluştur()
            {
                Console.WriteLine("Lütfen ATM türünü seçiniz:");
                for (int i = 0; i < TumATMTurleri.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {TumATMTurleri[i].Name}");
                }
                int secim = -1;
                while (secim < 1 || secim > TumATMTurleri.Count)
                {
                    Console.Write("Seçiminizi yapınız: ");
                    if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= TumATMTurleri.Count)
                    {
                        Type atmTipi = TumATMTurleri[secim - 1];
                        return (ATM)Activator.CreateInstance(atmTipi);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                        secim = -1;
                    }
                }
                return null;
            }

            public static void KullanilanATMSil(ATM atm)
            {
                Console.WriteLine("ATM SİLME EKRANI");
                Console.WriteLine("Lütfen silmek istediğiniz ATM'nin ADINI giriniz:");
                string silinecekATMAdi = Console.ReadLine().Trim().ToUpper();
                if (TumATMTurleri.Any(t => t.Name.ToUpper() == silinecekATMAdi))
                {
                    Type silinecekATMTipi = TumATMTurleri.First(t => t.Name.ToUpper() == silinecekATMAdi);
                    ATMTurSil((ATM)Activator.CreateInstance(silinecekATMTipi));
                    Console.WriteLine($"{silinecekATMAdi} ATM'si başarıyla silindi.");
                }
                else
                {
                    Console.WriteLine($"ATM bulunamadı: {silinecekATMAdi}");
                }
            }
        }

        public class KartYonetici : Program
        {
            private static List<Type> _tanimliKartTurleri = new List<Type>();

            public KartYonetici()
            {
                
                _tanimliKartTurleri.Add(typeof(DisBankKart));
                _tanimliKartTurleri.Add(typeof(DisBankKrediKart));
                _tanimliKartTurleri.Add(typeof(KapiKrediKart));
                _tanimliKartTurleri.Add(typeof(TakBankKart));
                _tanimliKartTurleri.Add(typeof(TakBankKrediKart));
                _tanimliKartTurleri.Add(typeof(ONBKart));
                _tanimliKartTurleri.Add(typeof(AdminKart));
            }


            public static List<Type> TanimliKartTurleri
            {
                get { return _tanimliKartTurleri; }
            }
            public static void KartTurEkle(Kart kart)
            {
                Type yeniKartTipi = kart.GetType();

                if (!TanimliKartTurleri.Contains(yeniKartTipi))
                {
                    TanimliKartTurleri.Add(yeniKartTipi);
                }
            }
            public static void KartTurSil(Kart kart)
            {
                Type silinecekKartTipi = kart.GetType();
                if (TanimliKartTurleri.Contains(silinecekKartTipi))
                {
                    TanimliKartTurleri.Remove(silinecekKartTipi);
                }
            }
            public static Kart KullaniciKartOluştur()
            {
                Console.WriteLine("Lütfen kart türünü seçiniz:");
                for (int i = 0; i < TanimliKartTurleri.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {TanimliKartTurleri[i].Name}");
                }
                int secim = -1;
                while (secim < 1 || secim > TanimliKartTurleri.Count)
                {
                    Console.Write("Seçiminizi yapınız: ");
                    if (int.TryParse(Console.ReadLine(), out secim) && secim >= 1 && secim <= TanimliKartTurleri.Count)
                    {
                        Type kartTipi = TanimliKartTurleri[secim - 1];
                        return (Kart)Activator.CreateInstance(kartTipi);
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyiniz.");
                        secim = -1;

                    }
                }
                return null;
            }
            



        }
    }
}
