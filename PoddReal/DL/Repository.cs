using Models;

namespace DL
{
    public class Repository
    {
        private List<Podd> PoddLista = new List<Podd>();
        public void AddPodd(Podd Podd)
        {
            PoddLista
                .Add(Podd);
        }
        public void fyllLista(List<Podd> poddLista)
        {
            PoddLista = poddLista;
        }
        public List<Podd> GetAllPodds()
        {
            return PoddLista;
        }
    }
}
