using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasapDoner
{
    class Ekstralar
    {
        private string _ekstraIsimler;                  //private ile ekstraislem isimleri 
        private float _ekstrafiyat;                     //private ile ekstra fiyat fieldı tanımladık

        public string EkstraIsimler                     //get set blokları boş olucak şekilde public olarak burada açtık . ***NOT: Normalde içerisinde bir şey yazmayacaksak fieldde private olarak tanımlamaya gerek yok, ama biz manuel bir giriş yapmak yerine seçim olarak tanımladığımız için açma gereği duydum. 
        {
            get
            {
                return _ekstraIsimler;
            }
            set
            {
                _ekstraIsimler = value;
            }
        }
        public float EkstraFiyatlar
        {
            get
            {
                return _ekstrafiyat;
            }
            set
            {
                _ekstrafiyat = value;
            }
        }
    }
}
