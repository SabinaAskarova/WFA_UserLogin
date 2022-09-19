# Login Form

[![N|Solid](https://www.bilgeadam.com/akademi/SiteAssets/BilgeAdam/Images/LogoAkademi.png)](https://www.bilgeadam.com/akademi/) 



![2019-11-09 12_00_54-New Text Document txt - Notepad](https://user-images.githubusercontent.com/13505194/68526222-94c89e80-02ea-11ea-8e5c-dbdd0e9fc8d6.png)


* Form açıldığında, ( * ) ibareli alana toplamda 8 karakterden oluşan rastgele sayısal bir değer yazdırınız.
* Kullanıcı, Label'üzerinde yer alan sayısal değerleri, TextBox içerisine girerek login olma işlemlerini yapacaktır.
* Kullanıcı, yanlış girerse, 
  1) Yeni bir 8 haneden oluşan rastgele sayısal değer yazdırılacak
  2) TextBox temizlenecek
  3) Imlec TextBox üzerinde beliriyor olacak
  4) Ekranda yer alan yıldızlardan bir adet eksiltilecek
  
* Kullanıcı toplamda 5 defa giriş hakkı olacak, Eğer kullanıcı 5 defa yanlış girerse,
  1) TextBox temizlenecek
  2) 5 adet yıldız görünüyor olacak
  3) TextBox ve Button'un aktiflik özelliği kapatılacak
  4) Rastgele sayı eklenen Label' default değerine dönecek ( * * * * * * * * )
  5) Kullanıcıya Giriş Sağlanamadı mesajı verdirilecek
  
* Kullanıcı, Giriş sağlar ise, Hoşgeldiniz uyarısı verdirilecek


* NOT : proje ui kısmı hata veriyor ise, MetroUI dll'i hatalı olabilir. Yapmanız gereken paketi kaldırıp tekrar yüklemeniz olacaktır.
  1) Tools > NuGet Package Manager > Package Manager Console
  2) uninstall-package MetroModernUI
  3) install-package MetroModernUI
  4) Projeyi build ediniz
