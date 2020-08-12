using System;

namespace XIRPL1_09_Bagass_Enkapsulasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Object
            Dokter d1 = new Dokter();
            Pasien p1 = new Pasien();

            // Memanggil Class
            Console.WriteLine("Biodata Dokter");
            d1.biodataDokter();
            Console.WriteLine(" ");
            Console.WriteLine("Biodata Pasien");
            p1.biodataPasien();

            // Data Internal
            Console.WriteLine("Dokter Ini Ada Di " + d1.bangsal);
            Console.WriteLine("Dokter Ini Ada Di " + p1.bangsal);
        }
    }
}
