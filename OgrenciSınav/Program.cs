using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    // Öğrenci bilgilerini tutan bir yapı
    public class Ogrenci
    {
        public int Sinif { get; set; }
        public int NotOrtalamasi { get; set; }
        public string Lise { get; set; }
    }

    static void Main()
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();
        VeriGirisi(ogrenciler);
        LiseAnalizi(ogrenciler);
        SinifAnalizi(ogrenciler);
    }

    // Öğrencilerin verilerini toplama
    static void VeriGirisi(List<Ogrenci> ogrenciler)
    {
        while (true)
        {
            Console.Write("Sınıf (1-4): ");
            int sinif = int.Parse(Console.ReadLine());

            Console.Write("Genel Not Ortalaması (0-100): ");
            int notOrt = int.Parse(Console.ReadLine());

            Console.Write("Mezun Olduğu Lise: ");
            string lise = Console.ReadLine();

            // Öğrenci bilgilerini listeye ekleme
            ogrenciler.Add(new Ogrenci { Sinif = sinif, NotOrtalamasi = notOrt, Lise = lise });

            // Devam edip etmeme sorusu
            Console.Write("Başka öğrenci var mı? (e/E/h/H): ");
            string devam = Console.ReadLine().ToLower();
            if (devam == "h") break;
        }
    }

    // Her lise için öğrenci sayılarını ve ortalamalarını hesaplama
    static void LiseAnalizi(List<Ogrenci> ogrenciler)
    {
        var liseGruplari = ogrenciler.GroupBy(o => o.Lise);

        Console.WriteLine("\nLise Bazlı Öğrenci Sayıları ve Not Ortalamaları:");
        foreach (var liseGrubu in liseGruplari)
        {
            string liseAdi = liseGrubu.Key;
            int ogrenciSayisi = liseGrubu.Count();
            double ortalamaNot = liseGrubu.Average(o => o.NotOrtalamasi);

            Console.WriteLine($"Lise: {liseAdi}, Öğrenci Sayısı: {ogrenciSayisi}, Not Ortalaması: {ortalamaNot:F2}");
        }
    }

    // Her sınıftaki öğrencilerin sayılarını ve not aralıklarına göre yüzdelerini hesaplama
    static void SinifAnalizi(List<Ogrenci> ogrenciler)
    {
        var sinifGruplari = ogrenciler.GroupBy(o => o.Sinif);

        Console.WriteLine("\nSınıf Bazlı Öğrenci Sayıları ve Not Dağılımları:");
        foreach (var sinifGrubu in sinifGruplari)
        {
            int sinif = sinifGrubu.Key;
            int ogrenciSayisi = sinifGrubu.Count();

            Console.WriteLine($"\nSınıf: {sinif}, Öğrenci Sayısı: {ogrenciSayisi}");

            // Not aralıklarına göre yüzde hesaplama
            var notAralikYuzdeleri = new Dictionary<string, double>
            {
                { "0-9", YuzdeHesapla(sinifGrubu, 0, 9, ogrenciSayisi) },
                { "10-19", YuzdeHesapla(sinifGrubu, 10, 19, ogrenciSayisi) },
                { "20-29", YuzdeHesapla(sinifGrubu, 20, 29, ogrenciSayisi) },
                { "30-39", YuzdeHesapla(sinifGrubu, 30, 39, ogrenciSayisi) },
                { "40-49", YuzdeHesapla(sinifGrubu, 40, 49, ogrenciSayisi) },
                { "50-59", YuzdeHesapla(sinifGrubu, 50, 59, ogrenciSayisi) },
                { "60-69", YuzdeHesapla(sinifGrubu, 60, 69, ogrenciSayisi) },
                { "70-79", YuzdeHesapla(sinifGrubu, 70, 79, ogrenciSayisi) },
                { "80-89", YuzdeHesapla(sinifGrubu, 80, 89, ogrenciSayisi) },
                { "90-100", YuzdeHesapla(sinifGrubu, 90, 100, ogrenciSayisi) }
            };

            foreach (var aralik in notAralikYuzdeleri)
            {
                Console.WriteLine($"Not Aralığı {aralik.Key}: %{aralik.Value:F2}");
            }
        }
    }

    // Yüzde hesaplayan yardımcı fonksiyon
    static double YuzdeHesapla(IEnumerable<Ogrenci> sinifGrubu, int alt, int ust, int toplamOgrenci)
    {
        int aralikSayisi = sinifGrubu.Count(o => o.NotOrtalamasi >= alt && o.NotOrtalamasi <= ust);
        return toplamOgrenci == 0 ? 0 : (double)aralikSayisi / toplamOgrenci * 100;
    }
}
