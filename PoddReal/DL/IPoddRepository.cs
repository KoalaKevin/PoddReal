using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DL
{
    public interface IPoddRepository<T> : IRepository<T> where T : Podd
    {
        T HamtaPodd(string titel);

        T HamtaPodd(string url, bool arUrl);
    }
}
