using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Models;
using DL;

namespace BL
{
    public class KategoriHanterare
    {
        private IKategoriRepository<Kategori> kategoriRepository;

        public KategoriHanterare() {
            kategoriRepository = new KategoriRepository();
        }
        
        public void SkapaKategori(string name)
        {
            Kategori nyKategori = new Kategori(name);
            kategoriRepository.Skapa(nyKategori);
        }

        public List<Kategori> HamtaKategorier()
        {
            return kategoriRepository.HamtaAlla();
        }

        public void UppdateraKategoriNamn(string gammaltNamn, string nyttNamn)
        {    

            if (!Validering.StrangHarVarde(gammaltNamn) || !Validering.StrangHarVarde(nyttNamn))
            {
                throw new ArgumentException("Både det gamla och nya namnet måste anges.");
            }

            Kategori kategori = kategoriRepository.HamtaMedNamn(gammaltNamn);

            if (kategori == null)
            {
                throw new KeyNotFoundException("Kategorin kunde inte hittas");
            }

            kategori.Namn = nyttNamn;

            int index = kategoriRepository.HamtaIndex(gammaltNamn);

            kategoriRepository.Uppdatera(index, kategori);
        }

        
        public void RaderaKategori(string namn)
        {
            int index = kategoriRepository.HamtaIndex(namn);
            kategoriRepository.Radera(index);
        }
    }
}
