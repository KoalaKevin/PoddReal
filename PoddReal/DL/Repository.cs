using Models;

namespace DL
{
    public class Repository : IPoddRepository<Podd>
    {
        private List<Podd> PoddLista;
        private SerializeHelper<Podd> Serializer;

        public Repository()
        {
            PoddLista = new List<Podd>();
            Serializer = new SerializeHelper<Podd>();
            PoddLista = HamtaAlla();
        }
        public void Skapa(Podd Podd)
        {
            PoddLista.Add(Podd);
            SparaAndringar();
        }

        public void Radera(int index)
        {
            PoddLista.RemoveAt(index);
            SparaAndringar();
        }

        public void Uppdatera(int index, Podd nyPodd)
        {
            PoddLista[index] = nyPodd;
            SparaAndringar();
        }

        public Podd HamtaMedTitel(string titel)
        {
            return HamtaAlla().FirstOrDefault(p => p.Titel.Equals(titel));
        }

        public Podd HamtaMedUrl(string url)
        {
            return HamtaAlla().FirstOrDefault(p => p.Url.Equals(url));
        }

        public int HamtaIndex(string url)
        {
            return HamtaAlla().FindIndex(p => p.Url.Equals(url));
        }

        public List<Podd> HamtaAlla()
        {
            return Serializer.laddaIn(@"..\..\poddList.xml");
        }

        public void SparaAndringar()
        {
            Serializer.tillXml(PoddLista, @"..\..\poddList.xml");
        }
    }
}
