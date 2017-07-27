using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasapDoner
{
    class Temizle
    {
        public void TemizleMethot(Control form)               //Temizke classının içerisinde temizleMethodu oluşturduk control parametresi alacak
        {
            foreach(Control item in form.Controls)              //foreach ile form parametresinin kontrol değerlerini döndürmesini söyledik
            {
                if(item is TextBox)                             //eğer textboxsa
                {
                    TextBox txt = item as TextBox;              //textbox nesnesinden txt tanımladık ve hespni temizle komutu verdik.
                    txt.Clear();
                }
                else if (item is ComboBox)                      //eğer seçilen comboboxsa
                {
                    ComboBox cmb = item as ComboBox;            //combobox nesnesinden cmb tanımladık ve index değeri -1 olduğunda içinde bir şey olmayacak
                    cmb.SelectedIndex = -1;
                }
                else if (item is GroupBox)                      //eğer seçilen groupboxa
                {
                    GroupBox grp = item as GroupBox;             //groupbox nesnesinden grp tanımladık ve groupboxın içerisinde temizlemmethodunu çağırdık
                    TemizleMethot(grp);
                }
                else if (item is RadioButton)                  //eğer seçilen radiobuttonsa
                {
                    RadioButton rdb = item as RadioButton;      //radbutton nesnesinden rdb tanımladık ve ve default değerni false yaptık
                    rdb.Checked = false;
                }
                else  if (item is NumericUpDown)                  //eğer seçilen numericse
                {
                    NumericUpDown nmd = item as NumericUpDown;       //radbutton nesnesinden nmd tanımladık ve ve default değerlerini en küçük ve en büyük yaptık
                    nmd.Value=nmd.Minimum;
                }
                else if (item is CheckBox)                      //eğer seçilen chechkboxsa
                {
                    CheckBox cb = item as CheckBox;             //chechkbox nesnesinden cb tanımladık ve ve default değerleri false tanımladık
                    cb.Checked=false;

                }
                
            }
        }
    }
}
