using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using BL;

namespace DL
{
    public class KategoriRepository
    {
        private List<Kategori> KategoriLista; 
        private SerializeHelper<Kategori> Serializer;

        public KategoriRepository() { 
            KategoriLista = new List<Kategori>();
            Serializer = new SerializeHelper<Kategori>();
        }

        public void AddKategori(Kategori Kategori)
        {
            KategoriLista.Add(Kategori);
            SparaAndringar();
        }

        public List<Kategori> GetAllKategorier() 
        { 
            return KategoriLista;
        }

        public void fyllLista(List<Kategori> kategoriLista)
        {
           KategoriLista = kategoriLista;
        }
        public void SparaAndringar()
        {
            Serializer.tillXml(KategoriLista, @"..\..\kategoriList.xml");
        }
    }
}
