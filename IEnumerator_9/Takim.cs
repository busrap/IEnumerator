using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_9
{
    class Takim:IEnumerable,IEnumerator
    {
        public Takim()
        {
            Oyuncular = new List<Oyuncu>();
        }
        public string Adi { get; set; }
        public DateTime KurulusYili { get; set; }
        public string StadAdi { get; set; }
        public List<Oyuncu> Oyuncular { get; set; }

        object IEnumerator.Current => throw new NotImplementedException();

        public IEnumerator GetEnumerator()
        {
            return this;
        }
        int sayac = -1;

        bool IEnumerator.MoveNext()
        {
            throw new NotImplementedException();
        }

        void IEnumerator.Reset()
        {
            throw new NotImplementedException();
        }
    }
}
