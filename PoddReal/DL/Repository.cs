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
        public List<Podd> GetAllPodds()
        {
            return PoddLista;
        }
    }
}
//Test
//Test2