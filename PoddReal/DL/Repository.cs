using BL;
using Models;

namespace DL
{
    public class Repository
    {
        private List<Podd> PoddLista;
        private SerializeHelper<Podd> Serializer;

        public Repository()
        {
            PoddLista = new List<Podd>();
            Serializer = new SerializeHelper<Podd>();

        }
        public void AddPodd(Podd Podd)
        {
            PoddLista.Add(Podd);
            SparaAndringar();
        }

        public void fyllLista(List<Podd> poddLista)
        {
            PoddLista = poddLista;
        }
        public List<Podd> GetAllPodds()
        {
            return PoddLista;
        }

        public void SparaAndringar()
        {
            Serializer.tillXml(PoddLista, @"..\..\poddList.xml");
        }
    }
}
