using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasapDoner
{
    public partial class KasapDonerForm : Form
    {
        public KasapDonerForm()
        {
            InitializeComponent();
        }
      
        private void KasapDonerForm_Load(object sender, EventArgs e)
        {
            comboBoxDoldur();
            Ekstra();          

        }
        private void btnsiparisver_Click(object sender, EventArgs e)
        {
            SiparisMesaj();
        }
        private void btnhesapla_Click(object sender, EventArgs e)
        {
            Hesapla();
        }
        private void btnekle_Click(object sender, EventArgs e)
        {
            SiparisEkle();
        }
        private void comboBoxDoldur()
        {
            Menu etMenu = new Menu { MenuAdi = "Et Menü", MenuFiyati = 16 };              // etmenu nesnesi oluşturduk ve classına uygun sınıflamalar tanımladık menu adını ve fiyatını belirttil
            Menu tavukMenu = new Menu { MenuAdi = "Tavuk Menü", MenuFiyati = 10 };        //tavukmenu nesnesi oluiturduk classına uygun sınıflamalar tanumkadık..
            Menu vjMenu = new Menu { MenuAdi = "Vejeteryan Menü", MenuFiyati = 8 };        //vejeteryan nesnesi oluiturduk classına uygun sınıflamalar tanumkadık..
            Menu satirMenu = new Menu { MenuAdi = "Satır Menü", MenuFiyati = 22 };          //satırmenu nesnesi oluiturduk classına uygun sınıflamalar tanumkadık

            cmbmenu.Items.Add(etMenu);          //içerisinde hem string hem int ifadeler olduğu için normalde diziye atmıştım tip farklılığından kabul etmedi tek tek comboboxa atamak zorunda kaldık
            cmbmenu.Items.Add(tavukMenu);
            cmbmenu.Items.Add(vjMenu);
            cmbmenu.Items.Add(satirMenu);
           
        }
        private void Ekstra()
        {
            Ekstralar domates = new Ekstralar { EkstraIsimler = "Domates", EkstraFiyatlar = 1 };        //ekstra classı üzerinde, domates vb. ekstratip seçenekleri oluşturduk ve classındaki tiplere uygun isimler tanımladık
            cbdomates.Tag = domates;                                                                    //herbir chechboxın tagini nesnelereimize atadık.....

            Ekstralar patates = new Ekstralar { EkstraIsimler = "Patates", EkstraFiyatlar = 3 };
            cbpatates.Tag = patates;

            Ekstralar ketcap = new Ekstralar { EkstraIsimler = "Ketçap", EkstraFiyatlar = 050 };
            cbketcap.Tag = ketcap;

            Ekstralar salatalik = new Ekstralar { EkstraIsimler = "Salatalık", EkstraFiyatlar = 2 };
            cbsalataık.Tag = salatalik;

            Ekstralar tursu = new Ekstralar { EkstraIsimler = "Turşu", EkstraFiyatlar = 1 };
            cbtursu.Tag = tursu;

            Ekstralar mayonez = new Ekstralar { EkstraIsimler = "Mayonez", EkstraFiyatlar = 050 };
            cbmayonez.Tag = mayonez;

            Ekstralar sogan = new Ekstralar { EkstraIsimler = "Sogan", EkstraFiyatlar = 050 };
            cbsogan.Tag = sogan;

            Ekstralar barbeku = new Ekstralar { EkstraIsimler = "Barbeku", EkstraFiyatlar = 025 };
            cbbarbeku.Tag = barbeku;

            Ekstralar tuz = new Ekstralar { EkstraIsimler = "Tuz", EkstraFiyatlar = 025 };
            cbtuz.Tag = tuz;

            Ekstralar hardal = new Ekstralar { EkstraIsimler = "Hardal", EkstraFiyatlar = 050 };
            cbhardal.Tag = hardal;
        }
        private void TamDoldur()
        {
            Boyut tam = new Boyut { BoyutTipi = "Tam", BoyutFiyati = 2 };       //Boyut sınıfın üzerinde tam nesnesi oluşturudk ve classına uygun atamalar yaptık
            rdtam.Tag = tam;                                                    //radiobutonun etiketine nesnesi atadık
        }
       
        private void YarimDoldur()
        {
            Boyut yarim = new Boyut { BoyutTipi = "Yarim", BoyutFiyati = 1 };       //Boyut sınıfın üzerinde yarım nesnesi oluşturudk ve classına uygun atamalar yaptık
            rdyarim.Tag = yarim;                                                    //radiobutonun etiketine nesnesi atadık
        }
        private void Hesapla()
        {
           
            double toplam = 0;              //double ve int tipinde değişkenler tanımladık
            int adet = 0;

            adet = Convert.ToInt32(nadet.Value);                //numerikupdown int değerine çevirdik ve adet değişkenine atadık

            if(cmbmenu.SelectedIndex>-1)                        //eğer comboboxın seçilen değeri -1den büyükse (yani bir değer seçildiyse)
            {
                if(rdtam.Checked==true || rdyarim.Checked==true)            //eğer radiobuton olarak tanımlanan yarım ya da tam porsiyonu trueya çevrildiyse
                {
                    int menuFiyati = ((Menu)cmbmenu.SelectedItem).MenuFiyati;       //comboboxda seçilen değerini menu classındaki fiyatını, int olarak tanımladığımız menudiyatına ata.
                  
                    if(rdtam.Checked)                                           //eğer tam aktifse
                    {
                        foreach(CheckBox ekstra in grpekstra.Controls)          //foreach ile döngüye gir ve ekstra groupboxın kontrolunu 
                        {
                            if(ekstra.Checked)                                  //eğer ekstra seçiliyse..
                            {
                                TamDoldur();                                   //tam doldur olarak ayarla                                                                 
                                                                                                                                    
                            }
                        }
                    }
                    else if(rdyarim.Checked)                                //eğer yarım aktifse..
                    {

                        foreach (CheckBox ekstra in grpekstra.Controls)     //foreach ile döngüye gir ve ekstra groupboxın kontrolunu 
                        {
                            if (ekstra.Checked)                              //eğer ekstra seçiliyse..
                            {
                                YarimDoldur();                              //yarim doldur olarak ayarla
                            }
                        }
                    }

                    toplam = (toplam + menuFiyati) * adet;              //toplam ve menufiyatını topla adet ile çarp ve tanımladığımız toplam değişkenine ata
                    txttoplam.Text = toplam.ToString();                 //toplam değerni stringe çevir ve textboxa yazdır
                    btnekle.Enabled = true;                             //butonekleyi aktifleştir
                }
                else
                {
                    MessageBox.Show("Boyutunu seçiniz!");               //eğer boyut seçimi yapılmadıysa (yani rdyarım ve rdtam aktif değilse) mesaj yazdır
                }
            }
            else 
            {
                MessageBox.Show("Menu Seçiniz!");               //eğer menu seçili değilse (yani selectedındex 1den küçükse) mesaj yazdır
            }
        }

  
        private void SiparisEkle()
        {
            
            float tutar=0;                                              //float olarak 0 değeri tanımla
            string seciliCheckbox = "";                                 //string tipi tanımla
            string menuAdi = ((Menu)cmbmenu.SelectedItem).MenuAdi;            //comboboxda seçilen değerini menu classındaki adını, string olarak tanımladığımız menuadına ata.
            string boyutu = " ";                                    //boyut tipi tanımla
            string adet = nadet.Value.ToString();                   //numerikupdown string değerine çevirdik ve adet değişkenine atadık

            foreach(CheckBox ekstraekle in grpekstra.Controls)          //foreach ile döngü kurduk groupboxdaki ekstranın kontrolleri 
            {
                if(ekstraekle.Checked)                                      //eğerekstraekle aktifse
                {
                   seciliCheckbox = seciliCheckbox + " " + ((Ekstralar)ekstraekle.Tag).EkstraIsimler;           //seciliolan ekstra sos ve ekstralar classındaki isim tagini al secilichechkboxa at
                }
            }

            if(rdtam.Checked)                                   //eğer yarım aktifse
            {
                boyutu = "Tam";                                 //tam yazdır
            }

            else if (rdyarim.Checked)                           //eğer yarımsa
            {
                boyutu = "Yarim";                               //yarım yazdır
            }

            string siparis = "adeti:" + adet + "boyutu:" + boyutu + "Menu Adi:" + menuAdi + "(" + seciliCheckbox + ")" + "Fiyat" + txttoplam.Text;       //sipariş değişkenine adetini boyutunu menuadını seciliolan chechboxını ve toplamtutar değerini yazan textboxı ata
           
            tutar += float.Parse(txttoplam.Text);                       //textbox değerini floata donustur et ve tutara ata
            lstsiparis.Items.Add(siparis);                              //siparis değişkenini listboxa ekle
            btnsiparisver.Enabled = true;                               //sipariş ver butonunu aktifleştir
           
        }
      
        private void SiparisMesaj()
        {
            Temizle temizle = new Temizle();                    //temizle nesnesi oluştur

            if(btnekle.Enabled==true)               //eğğer butonekle true ise
            {
                MessageBox.Show("Siparişiniz onaylanmıştır. İyi Günler Dileriz!" + " " + DateTime.Now.ToShortDateString()+" " + DateTime.Now.ToShortTimeString());          //mesajı yazdır tarih saat ekle
                temizle.TemizleMethot(this);                //sipariş alındıktan dolu olan veri giriş yerlerini temizle. 
            }
            else
            {
                MessageBox.Show("Seçili bir siparişiniz yoktur! Lütfen seçim işleminden sonra deneyiniz!");    //eğer butonekle aktif değilse mesajı yazdır
            }
        }
      
    }
}
