using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace XIRPL1_09_Bagass_Enkapsulasi
{
    class Pasien : User
    {
        public void biodataPasien()
        {
            this.nama = "Pasien";
            this.NomorID = "N25";
            this.Nomor = "08xx324";
            base.riwayatpasien = "Demam";
            this.bangsal = "Bangsal Melati";

            // Print
            Console.WriteLine("Nama                   = " + nama);
            Console.WriteLine("Nomor ID               = " + NomorID);
            Console.WriteLine("Nomor HP               = " + Nomor);
            Console.WriteLine("Riwayat Sakit Pasien   = " + riwayatpasien);
        }
    }
}
