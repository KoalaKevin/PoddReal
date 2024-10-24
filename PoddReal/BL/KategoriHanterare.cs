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
        private KategoriRepository kategoriRepository;
        private SerializeHelper<Kategori> serializeHelper;

        public KategoriHanterare() {
            kategoriRepository = new KategoriRepository();
            serializeHelper = new SerializeHelper<Kategori>();
            kategoriRepository.fyllLista(serializeHelper.laddaIn(@"..\..\kategoriList.xml"));
        }
        private String? utKategoriText;
        public List<Kategori> getAllKategorier()
        {
            return kategoriRepository.GetAllKategorier();
        }
        
        public void SkapaKategori(string name)
        {
            Kategori nyKategori = new Kategori(name);
            kategoriRepository.AddKategori(nyKategori);
        }

        public List<Kategori> HamtaKategorier()
        {
            return kategoriRepository.GetAllKategorier();
        }

        public void UppdateraKategoriNamn(string gammaltNamn, string nyttNamn)
        {
            if (string.IsNullOrWhiteSpace(gammaltNamn) || string.IsNullOrWhiteSpace(nyttNamn))
            {
                throw new ArgumentException("Både det gamla och nya namnet måste anges.");
            }

            Kategori kategori = kategoriRepository.GetAllKategorier()
                                                   .FirstOrDefault(k => k.Name == gammaltNamn);


            if (kategori == null)
            {
                throw new KeyNotFoundException("Kategorin kunde inte hittas");
            }

            kategori.Name = nyttNamn;

            kategoriRepository.SparaAndringar();
        }


    }
}
