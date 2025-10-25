using System;

namespace Project19_Constructor_Static;

public class Islemci
{
     public int YapilanIslemSayisi { get; set; }
    public static int ToplamYapilanIslemSayisi { get; set; }
    public int Topla(int a, int b)
    {
        YapilanIslemSayisi++;
        ToplamYapilanIslemSayisi++;
        return a + b;
    }
}
