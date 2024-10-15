using Models;

namespace DL
{
    public class Class1
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