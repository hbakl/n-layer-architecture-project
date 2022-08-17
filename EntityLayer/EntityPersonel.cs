using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private short maas;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value;
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value;
            }
        }

        public string Sehir
        {
            get
            {
                return sehir;
            }

            set
            {
                sehir = value;
            }
        }

        public string Gorev
        {
            get
            {
                return gorev;
            }

            set
            {
                gorev = value;
            }
        }

        public short Maas
        {
            get
            {
                return maas;
            }

            set
            {
                maas = value;
            }
        }
    }
}
