using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasapDoner
{
    class Menu
    {
       private string _menuAdi;                         //menu classında menuadi fieldı tanımladık
       private int _fiyati;                             //yine menu classında fiyatı fieldı tanımladık


       public string MenuAdi                        //get set blokları boş olucak şekilde public olarak burada açtık . ***NOT: Normalde içerisinde bir şey yazmayacaksak fieldde private olarak tanımlamaya gerek yok, ama biz manuel bir giriş yapmak yerine seçim olarak tanımladığımız için açma gereği duydum. 
       {
           get
           {
               return _menuAdi;
           }
           set
           {
               _menuAdi = value;
           }
       }

       public int MenuFiyati
       {
           get
           {
               return _fiyati;
           }
           set
           {
               _fiyati = value;

           }
       }

       public override string ToString()
       {
           return MenuAdi;
       }
    
    }
 }
