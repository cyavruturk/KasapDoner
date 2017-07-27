using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasapDoner
{
    class Kasap                     //base class oluşturduk
    {

        public Menu menu{get;set;}      //menu classını boyut classını ve ekstralar classını tanımladık
        public Boyut boyut{get;set;}
        public Ekstralar ekstra { get; set; }

       
        private float _toplamtutar;        //toplamtutar fieldı tanımladık 


        public float ToplamTutar
        {
            get                                     //sadece okuma işlemi yapacağımız için okuma işlemlerini burada yaptırttık 
            {
                _toplamtutar = 0;                    // 0 ataması yaptık
                _toplamtutar =(float)boyut.BoyutFiyati + menu.MenuFiyati + ekstra.EkstraFiyatlar;            //float tipindeki değişkene boyutun fiyatını, menunun fiyatını ve ekstranın fiyatını atadık
                return _toplamtutar;                                                                   //return ile değer döndürdük
            }   
            set
            {
                _toplamtutar = value;                       //set ile value değerini toplam tutar değerine aradık
            }
        }

           
    }
}
