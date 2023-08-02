using System;
using System.IO;


class Program
{
    
    static void Main()
    {      
        string tarih = DateTime.Now.ToString("yyyyMMdd_HHmmss");
        string dosyaAdi = "klavye_girdileri_" + tarih + ".txt";

        using (StreamWriter sw = new StreamWriter(dosyaAdi, true))
        {
            while (true)
            {
                var keyInfo = Console.ReadKey(intercept: true);
                var key = keyInfo.Key;

                

                string girdi = GetHarfGirdisi(keyInfo);
                if (girdi == "Spacebar")
                {
                    sw.Write(" ");
                }
                else if (girdi == "Tab")
                {
                    sw.Write("|Tab|");
                }               
                else if (girdi == "Enter")
                {
                    sw.Write("\n");
                }
                else
                {
                    sw.Write(girdi);
                }
                if (key == ConsoleKey.F12)
                {                                       
                    break;
                }
            }                  
        }    
    }

    static string GetHarfGirdisi(ConsoleKeyInfo keyInfo)
    {
        if (char.IsLetterOrDigit(keyInfo.KeyChar))
        {
            return keyInfo.KeyChar.ToString();
        }
        else if (keyInfo.Key == ConsoleKey.Spacebar)
        {
            return " ";
        }
        else
        {
            return keyInfo.Key.ToString();
        }
    }




}
