using OksaMachineLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OksaMachineLayer
{
    class Kullanicilar
    {

        public int uyeID { get; set; }
        public string uyeadi { get; set; }
        public string parola { get; set; }
        public string isim { get; set; }
        public string ceptelefonu { get; set; }
        public string  uyetipi { get; set; }
        public bool durum { get; set; }


        oksaDalDataContext dal = new oksaDalDataContext();
        public Kullanicilar(string username  , string pass)
        {

            List<tblUye> user = (from k in dal.tblUyes
                                 where k.kullaniciAdi== username && k.sifre==parola
                                 select k).ToList();

            foreach (var item in user)
            {

                this.isim = item.kullaniciAdi;
                this.parola = item.sifre;
                this.durum = (bool)item.status;
                this.uyetipi = item.uyeTipi;
                this.uyeID = item.uyeID;
                this.ceptelefonu = item.cepTel;
            }


        }

    

    
    }
}
