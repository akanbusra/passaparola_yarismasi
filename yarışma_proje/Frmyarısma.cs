using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yarışma_proje
{
    public partial class Frmyarısma : Form
    {
        public Frmyarısma()
        {
            InitializeComponent();
        }

        int soruno = 0, dogrusayisi = 0, yanlissayisi = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                switch (soruno)
                {
                 case 1:
                        if (textBox1.Text=="AKDENİZ")
                        {
                            btnA.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnA.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 2:
                        if (textBox1.Text == "BURSA")
                        {
                            btnB.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnB.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 3:
                        if (textBox1.Text == "CACIK")
                        {
                            btnC.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnC.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 4:
                        if (textBox1.Text == "DAR")
                        {
                            btnD.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnD.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 5:
                        if (textBox1.Text == "EDİRNE")
                        {
                            btnE.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnE.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 6:
                        if (textBox1.Text == "FATSA")
                        {
                            btnF.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnF.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 7:
                        if (textBox1.Text == "GÜNEY")
                        {
                            btnG.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnG.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 8:
                        if (textBox1.Text == "HAYIR")
                        {
                            btnH.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnH.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 9:
                        if (textBox1.Text == "ISLAK")
                        {
                            btnI.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnI.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 10:
                        if (textBox1.Text == "İSTANBUL")
                        {
                            btnİ.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnİ.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 11:
                        if (textBox1.Text == "JAGUAR")
                        {
                            btnJ.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnJ.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 12:
                        if (textBox1.Text == "KÜBA")
                        {
                            btnK.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();                        }
                        else
                        {
                            btnK.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 13:
                        if (textBox1.Text == "LEMAN")
                        {
                            btnL.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnL.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 14:
                        if (textBox1.Text == "MUTASYON")
                        {
                            btnM.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnM.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 15:
                        if (textBox1.Text == "NAFTALİN")
                        {
                            btnN.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnN.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 16:
                        if (textBox1.Text == "OSMANLI")
                        {
                            btnO.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnO.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 17:
                        if (textBox1.Text == "PIRASA")
                        {
                            btnP.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnP.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 18:
                        if (textBox1.Text == "RAMAZAN")
                        {
                            btnR.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnR.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 19:
                        if (textBox1.Text == "SÖZCÜK")
                        {
                            btnS.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnS.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 20:
                        if (textBox1.Text == "TRABZON")
                        {
                            btnT.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnT.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 21:
                        if (textBox1.Text == "UMUT")
                        {
                            btnU.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnU.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 22:
                        if (textBox1.Text == "VAN")
                        {
                            btnV.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnV.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                 case 23:
                        if (textBox1.Text == "YATSI")
                        {
                            btnY.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnY.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;

                 case 24:
                        if (textBox1.Text == "ZEYTİN")
                        {
                            btnZ.BackColor = Color.Green;
                            dogrusayisi++;
                            LblDoğru.Text = dogrusayisi.ToString();
                        }
                        else
                        {
                            btnZ.BackColor = Color.Red;
                            yanlissayisi++;
                            LblYanlış.Text = yanlissayisi.ToString();
                        }
                        break;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno==1)
            {
                richTextBox1.Text = "ÜLKEMİZİN GÜNEYİNDE YER ALAN KIYI BÖLGESİ NERESİDİR ?";
                btnA.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "A";
            }
            if (soruno ==2)
            {
                richTextBox1.Text = "MARMARADA BULUNAN YEŞİLLİĞİ İLE ÜNLÜ ŞEHRİMİZ HANGİSİDİR ?";
                btnB.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "B";
            }
            if (soruno ==3)
            {
                richTextBox1.Text = "SALATALIK,YOĞURT VE SARIMSAKTAN YAPILAN YİYECEĞİN ADI NEDİR ?";
                btnC.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "C";
            }
            if (soruno ==4)
            {
                richTextBox1.Text = "GENİŞ KELİMSESİNİN ZIT ANLAMLISI NEDİR ?";
                btnD.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "D";
       
            }
            if (soruno ==5)
            {
                richTextBox1.Text = "TEKİRDAĞ İLİNE KOMŞU İLLERİMİZDEN BİR TANESİ HANGİSİDİR ?";
                btnE.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "E";
            }
            if (soruno ==6)
            {
                richTextBox1.Text = "ORDUNUN BİR İLÇESİ ?";
                btnF.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "F";
            }
            if (soruno ==7)
            {
                richTextBox1.Text = "KUZEYİN TAM KARŞISINDA BULUNAN YÖN HANGİSİDİR ?";
                btnG.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "G";
            }
            if (soruno ==8)
            {
                richTextBox1.Text = "BİR DURUMA EVET DEMEK İSTEMEYEN BİR KİŞİ NE DER ?";
                btnH.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "H";
            }
            if (soruno ==9)
            {
                richTextBox1.Text = "KURUNUN ZIT ANLAMLISI NEDİR ?";
                btnI.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "I";
            }
            if (soruno ==10)
            {
                richTextBox1.Text = "34 PLAKALI İLİMİZ HANGİSİDİR ?";
                btnİ.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "İ";
            }
            if (soruno ==11)
            {
                richTextBox1.Text = "KEDİGİLLER FAMİLYASINDAN VE PANTHERA CİNSİNİN DÖRT BÜYÜK KEDİSİNDEN BİRİ OLAN BİR YENİ DÜNYA MEMELİSİ OLAN HAYVAN HANGİSİDİR ?";
                btnJ.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "J";
            }
            if (soruno ==12)
            {
                richTextBox1.Text = "HAVANA ŞEHRİ HANGİ ÜLKENİN BAŞKENTİDİR  ?";
                btnK.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "K";
            }
            if (soruno ==13)
            {
                richTextBox1.Text = "1991 YILINDAN  BERİ YAYINLANMAKTA OLAN HAFTALIK MİZAH DERGİSİNİN İSMİ NEDİR ?";
                btnL.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "L";
            }
            if (soruno ==14)
            {
                richTextBox1.Text = "SÖZLÜKTEKİ KARŞILIĞI 'DEĞİŞİNİM' OLAN BİYOLOJİK TERİM NEDİR ?";
                btnM.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "M";
            }
            if (soruno ==15)
            {
                richTextBox1.Text = "GÜVELERİ UZAKLAŞTMAK İÇİN YÜNLÜ KUMAŞ VE KÜRKLERİ KORUMAKTA KULLANILAN MADDE NEDİR ?";
                btnN.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "N";
            }
            if (soruno ==16)
            {
                richTextBox1.Text = "OSMAN GAZİNİN KURDUĞU MÜSLÜMAN DEVLETİN ADI NEDİR ?";
                btnO.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "O";
            }
            if (soruno ==17)
            {
                richTextBox1.Text = " YILIN HER MEVSİMİNDE VEYA İKİ SENEDE BİR YETİŞEN VE GENELLİKLE YAPRAKLARI İÇİN YETİŞTİRİLEN BİR BİTKİ?";
                btnP.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "P";
            }
            if (soruno ==18)
            {
                richTextBox1.Text = "11 AYIN SULATANI ?";
                btnR.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "R";
            }
            if (soruno ==19)
            {
                richTextBox1.Text = "BİR YA DA BİRDEN ÇOK HECEDEN OLUŞAN ,BELLİ BİR ANLAMI OLAN,TÜMCE KURMAYA YARAYAN VE TÜMCE KURULUŞUNDA ÖZEL GÖREVİ OLAN DİL ÖGESİ?";
                btnS.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "S";
            }
            if (soruno ==20)
            {
                richTextBox1.Text = "DOĞU KARADENİZ BÖLGESİNDE YER ALAN BİR İLİMİZ ?";
                btnT.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "T";
            }
            if (soruno ==21)
            {
                richTextBox1.Text = "UMMAKTAN DOĞAN İÇ ERİNCİ,GÜVEN DUYGUSU ? ";
                btnU.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "U";
            }
            if (soruno ==22)
            {
                richTextBox1.Text = "GÖZ RENKLERİ DEĞİŞİK KEDİSİYLE ÜNLÜ İLİMİZ HANGİSİDİR ?";
                btnV.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "V";
            }
            if (soruno ==23)
            {
                richTextBox1.Text = "AKŞAM NAMAZINDAN SONRA KILINAN GÜNÜN SON NAMAZI NEDİR?";
                btnY.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "Y";
            }
            if (soruno ==24)
            {
                richTextBox1.Text = "MEYVESİ YENEN VE GELENEKSEL OLARAK AKDENİZ İKLİMİNE UYGUN BİR AĞAÇ TÜRÜ ?";
                btnZ.BackColor = Color.Yellow;
                BtnSoruHarfi.Text = "Z";
            }
            if (soruno>=25)
            {
                linkLabel1.Text = "BİTTİ";
                MessageBox.Show("Doğru Sayısı :" + dogrusayisi + " " + "Yanlış Sayısı :" + yanlissayisi);   
            }
        }
    }
}
