* Dotner CLI ile proje oluşturmak :
 - dotnet new console (içinde bulunulan klasörün adıyla oraya console projesi oluşturur.)
 - dotnet new console -o ProjeAdı (içinde bulunulnan klasörün içine ProjeAdı adıyla bir klasör oluşuturup, projeyi bu klasörün içine bu adla oluşturur.)
 - dotnet new console -o Project02_HelloWorld  --use-program-main (içinde bulunulnan klasörün içine ProjeAdı adıyla bir klasör oluşuturup, projeyi bu klasörün içine , bu adla ve main metodunu kullanarak oluşturur. yani top level statement özelliğini kullanmaz)

- 3ü kullanıcaz

Değişkenler : 
- Değişkenler içerisinde veri tutmaya yarayan yapılardır.
- Bellekte(Ram) Tutulurlar. 01010100
- Veri Tipleri : int, short , string vb.
- byte = 255 e kadar sayılır gelir 8 bit 
- int için max value komutu kullan 

Değişken tanımlama : 

 - değiken_tipi değişken_adi = degisken_degeri ;
 -   int yas = 42; 

 Değişken Tanımlama Kural Ve ilkeleri ;

  - C# BÜYÜK/küçük harf duyarlıdır. Örneğin yas ile Yas biribirinden farklı değerlendirilir.
  - Değişken adlarının içerisinde özel karakterler olamaz ( _ Hariç tutulur)
  - Değişken adları C#'ın özel kelimelerinden biri olamaz . 
  - Değişkenleri anlamlı olarak adlandırmalıyız.
             - örn: sayi yerine yas gibi ...
  - Türkçe karakterler kullanmamaya çalışın.
             - örn : yaş yerine age , ad_soyad yerine fullname gibi
  - Değişken isimlendirirken camelCase tekniği kullanın 
            - Yani ; değişken adı tek kelimeden oluşuyorsa tamamen küçük harfle , birden fazla kelimeden oluşuyoesa ilk kelime tamamen küçük
                    diğer kelimelerin ilk harfi büyük , kalan harfleri küçük olacak şekilde.
            -Örn: name, age ,studentNumber,date0fBirth 