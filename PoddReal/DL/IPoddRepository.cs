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
        T HamtaMedTitel(string titel);

        T HamtaMedUrl(string url);

        int HamtaIndex(string url);


    }
}
