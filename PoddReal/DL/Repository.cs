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

        public void TaBortPodd(string url)
        {
            foreach (Podd enPodd in PoddLista)
            {
                if (enPodd.Url.Equals(url))
                {
                    PoddLista.Remove(enPodd);
                    break;
                }
            }
        }

        public void RedigeraPodd(int index, Podd nyPodd)
        {
            if(index >= 0 && index < PoddLista.Count)
            {
                PoddLista[index] = nyPodd;
            }
            else
            {
                Console.WriteLine("Ogiltigt index");
            }
            UppdateraLista();
        }

        public void FyllLista(List<Podd> poddLista)
        {
            PoddLista = poddLista;
        }

        public Podd HamtaPoddMedTitel(string titel)
        {
            Podd podd = null;
            foreach(var item in Serializer.laddaIn(@"..\..\poddList.xml"))
            {
                if (item.Titel.Equals(titel))
                {
                    podd = item;
                }
            }
            return podd;
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
