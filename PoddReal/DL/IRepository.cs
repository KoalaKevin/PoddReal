using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public interface IRepository<T> where T : class
    {
        void Skapa(T entitet);

        void Radera(int index);

        void Uppdatera(int index, T entitet);

        void SparaAndringar();

        List<T> HamtaAlla();
    }
}
