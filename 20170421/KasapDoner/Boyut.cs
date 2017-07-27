using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasapDoner
{
    class Boyut
    {
        private string _boyutTipi;                  //boyut classında field olarak boyut tipi tanımladık
        private float _boyutFiyati;                 //yine fieldde boyut fiyatı açtık.

        public string BoyutTipi                     //get set blokları boş olucak şekilde public olarak burada açtık . ***NOT: Normalde içerisinde bir şey yazmayacaksak fieldde private olarak tanımlamaya gerek yok, ama biz manuel bir giriş yapmak yerine seçim olarak tanımladığımız için açma gereği duydum. 
        {
            get
            {
                return _boyutTipi;
            }
            set
            {
                _boyutTipi = value;
            }
        }
        public float BoyutFiyati
        {
            get
            {
                return _boyutFiyati;
            }
            set
            {
                _boyutFiyati = value;
            }
        }
    }
}
