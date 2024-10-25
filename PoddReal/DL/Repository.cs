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
        public void LaggTillPodd(Podd Podd)
        {
            PoddLista.Add(Podd);
            UppdateraLista();
        }

        public void TaBortPodd(Podd podd)
        {
            PoddLista.Remove(podd);
            UppdateraLista();
        }

        public void RedigeraPodd(int index, Podd nyPodd)
        {
            PoddLista[index] = nyPodd;
            UppdateraLista();
        }

        public void FyllLista(List<Podd> poddLista)
        {
            PoddLista = poddLista;
        }

        public Podd HamtaMedTitel(string titel)
        {
            return GetAllPodds().FirstOrDefault(p => p.Titel.Equals(titel));
        }

        public List<Podd> GetAllPodds()
        {
            return PoddLista;
        }

        public void UppdateraLista()
        {
            Serializer.tillXml(PoddLista, @"..\..\poddList.xml");
        }
    }
}
