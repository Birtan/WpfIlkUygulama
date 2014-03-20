using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islemler
{
    public class Islem
    {
        string metinAlfabe = "ABCÇDEFGĞHIİJKLMNOÖPRSŞTUÜVYZ";
        public char[] Alfabe { get; set; }
        public string sifreliMetin { get; set; }
        public Islem()
        {
            Alfabe = metinAlfabe.ToCharArray();
            
        }
        public string Sifrele(string metin,byte anahtar) 
        {
            char[] sifrelenecekMetinKaralterleri = metin.ToUpper().ToCharArray();

            for (int j = 0; j < sifrelenecekMetinKaralterleri.Length; j++)
            {
                for (int i = 0; i < Alfabe.Length; i++)
                {
                    if (sifrelenecekMetinKaralterleri[j] == Alfabe[i])
                    {
                        int ilerleme = (i + anahtar) % 29;
                        if (string.IsNullOrEmpty(sifreliMetin))
                        {
                            sifreliMetin = Alfabe[ilerleme].ToString(); 
                        }
                        else
                        {
                            sifreliMetin = sifreliMetin + Alfabe[ilerleme].ToString();
                        }
                        break; 
                    }
                } 
            }
            return sifreliMetin;
        }
    }
}
