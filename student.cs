using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Sınıf_Uygulması_Örnek
{
    class student
    {
        string ad;
        string soyad;
        int dogumTarihi;
        int numara;
        int yas;
        string cinsiyet;
        string adres;
        string telefon;


        //public student(string ad, string soyad, int dogumtarihi, int numara, string cinsiyet, string adres, string telefon)
        //{
        //    Console.WriteLine("Ogrencin Oluşturuldu...");
        //}


        // Propertiylerim 
        public string Ad
        {
            get
            {
                return this.ad;
            }
            set
            {
                if (value.Length > 2)
                {
                    this.ad = value;
                }
                else
                {
                    throw new ArgumentException("Ad 2 harfden az olmamalıdır");

                }
            }
        }
        public string Soyad
        {
            get
            {
                return this.soyad;
            }
            set
            {
                if (value.Length > 2)
                {
                    this.soyad = value;

                }
                else
                {
                    throw new ArgumentException("Ad 2 harfden az olmamalıdır");
                }
            }
        }
        public int DogumTarihi
        {
            get
            {
                return this.dogumTarihi;
            }
            set
            {
                if (value > 1950 && value < 2022)
                {
                    throw new ArgumentException("");
                }
                else
                {
                    this.dogumTarihi = value;
                }
            }
        }
        public string Cinsiyet
        {
            get
            {
                if (this.cinsiyet == "E")
                {
                    return "Erkek";
                }
                else
                {
                    return "Kadın";
                }
            }
            set
            {
                if (value.ToUpper() == "E" || value.ToUpper() == "K")
                {
                    this.cinsiyet = value;
                }
                else
                {
                    throw new ArgumentException("E veya E olarak giriş saglanabilir. !  ");

                }
            }
        }
        public string Adres
        {
            get
            {
                return this.adres;
            }
            set
            {
                this.adres = value;
            }
        }
        public string Telefon
        {
            get
            {
                return this.telefon;
            }
            set
            {
                if (value.Length > 3)
                {
                    this.telefon = value;

                }
                else
                {
                    throw new ArgumentException("8 haneden kğcğk olamaz... !");

                }
            }
        }
        public int Numara
        {
            get
            {
                return this.numara;
            }
            set
            {
                if (value == 11)
                {
                    throw new ArgumentException("");
                }
                else
                {
                    this.numara = value;
                }
            }
        }
        // Başlangıcta yazıcak komutlar (Yapıcı metotlar)


        // Metotlarım 
        public void BigileriOku()
        {
            Console.WriteLine("Ad : ");
            Ad = Console.ReadLine();
            Console.WriteLine("Soyad :");
            Soyad = Console.ReadLine();
            Console.WriteLine("Dogum Tarihi : ");
            DogumTarihi = int.Parse(Console.ReadLine());
            Console.WriteLine("Numara :   ");
            numara = int.Parse(Console.ReadLine());
            Console.WriteLine("Cınsıyet : ");
            cinsiyet = Console.ReadLine();
            Console.WriteLine("Adres : ");
            Adres = Console.ReadLine();
            Console.WriteLine("Telefon : ");
            Telefon = Console.ReadLine();



        }

        public void Bilgeriyazdır()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Adı   :{0}", this.Ad);
            Console.WriteLine("Soyad   :{0}", this.Soyad);
            Console.WriteLine("Dogum Tarihi   :{0}", this.DogumTarihi);
            Console.WriteLine("Yaş   :{0}", this.yas);
            Console.WriteLine("Numara   :{0}", this.Numara);
            Console.WriteLine("Cinsiyet    :{0}", this.Cinsiyet);
            Console.WriteLine("Adres    :{0}", this.Adres);
            Console.WriteLine("---------------------------");
        }
        // Başlangıcta yazıcak komutlar (Yapıcı metotlar)

        public student()
        {
            Console.WriteLine("Ogrencin Oluşturuldu...");
        }
    }
}
