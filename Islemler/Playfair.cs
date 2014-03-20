using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Islemler
{
    public class Playfair
    {
        string metinAlfabe = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public char[] Alfabe { get; set; }
        public string sifreliMetin { get; set; }
        public string[,] playfairMatris { get; set; }
        public Playfair()
        {
            Alfabe = metinAlfabe.ToCharArray();
        }
        public string PlayfairMatris(string metin,string anahtar)
        {
            char[] sifreKarakter = metin.ToUpper().ToCharArray();
            char[] anahtarKarakter = anahtar.ToUpper().ToCharArray();
            char[,] matris = new char[5, 5];
            byte item = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    if (item<anahtarKarakter.Length)
                    {
                        matris[i,j] = anahtarKarakter[item];
                        item++; 
                    }
                    else
                    {
                        foreach (char i1 in anahtarKarakter)
                        {
                            foreach (char i2 in Alfabe)
                            {
                                if (i1 == i2 && matris[i, j] != 0)
                                {
                                    break;
                                }
                                else
                                    matris[i, j] = i2;
                            }
                        }

                    }
                }
            }
            byte indexer = 0;
            
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (indexer == 0)
                            sifreliMetin = matris[i,j].ToString();
                        else
                            sifreliMetin += matris[i,j];
                        indexer++;  
                    }
                }
            
            return sifreliMetin;
        }

       
    }
}
