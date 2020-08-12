using System;
using System.Collections.Generic;
using System.Text;

namespace XIRPL1_09_Bagass_Enkapsulasi
{
    class User
    {
        // Public
        public string nama;
        public string NomorID;
        // Private
        private string Nomorhp;
        //protected
        protected string riwayatpasien;
        //Internal
        internal string bangsal;

        // Abstraksi
        public string getNomor()
        {
            return this.Nomorhp;
        }
        public string setNomor(string newNomor)
        {
            this.Nomorhp = newNomor;
            return this.Nomorhp;
        }

        // Property
        public string Nomor 
        {
            get { return this.Nomorhp; }
            set { this.Nomorhp = value; }
        }
    }
}
