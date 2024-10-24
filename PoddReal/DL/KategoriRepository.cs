using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public class KategoriRepository : IRepository<Kategori>
    {
        private List<Kategori> KategoriLista; 
        private SerializeHelper<Kategori> Serializer;

        public KategoriRepository() { 
            KategoriLista = new List<Kategori>();
            Serializer = new SerializeHelper<Kategori>();
            KategoriLista = HamtaAlla();
        }

        public void Skapa(Kategori Kategori)
        {
            KategoriLista.Add(Kategori);
            SparaAndringar();
        }

        public void Radera(int index)
        {
            KategoriLista.RemoveAt(index);
            SparaAndringar();
        }

        public void Uppdatera(int index, Kategori nyKategori)
        {
            KategoriLista[index] = nyKategori;
            SparaAndringar();
        }

        public List<Kategori> HamtaAlla() 
        { 
            return Serializer.laddaIn(@"..\..\kategoriList.xml");
        }

        public void SparaAndringar()
        {
            Serializer.tillXml(KategoriLista, @"..\..\kategoriList.xml");
        }
    }
}
