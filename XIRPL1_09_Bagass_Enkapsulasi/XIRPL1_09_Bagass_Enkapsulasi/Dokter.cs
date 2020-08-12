using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace XIRPL1_09_Bagass_Enkapsulasi
{
    class Dokter : User
    {
        public void biodataDokter()
        {
            // Isi
            this.nama = "Bu Dokter";
            this.NomorID = "B09";
            this.Nomor = "08xx";
            base.riwayatpasien = "-";
            this.bangsal = "Bangsal Anggrek";

            // Print
            Console.WriteLine("Nama                   = " + nama);
            Console.WriteLine("Nomor ID               = " + NomorID);
            Console.WriteLine("Nomor HP               = " + Nomor);
            Console.WriteLine("Riwayat Pasien         = " + riwayatpasien);
        }
    }
}
