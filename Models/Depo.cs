namespace kayit.Models
{
    public  class Depo
    {
     public Depo()
     {
         Doldur();
     }
     public static void Doldur(){

    OgrenciListesi.Add(new Ogrenci(){
        ad="Ali",
        soyad="Kaya",
        notOrtalamasi=90,
        okulNumarasi=100,
        kayitTarihi=DateTime.Parse("2022/04/04")
    });
    OgrenciListesi.Add(new Ogrenci(){
        ad="Aliye",
        soyad="Çelik",
        notOrtalamasi=80,
        okulNumarasi=200,
        kayitTarihi=DateTime.Parse("2021/04/04")
    });
     }
     public static List<Ogrenci>  OgrenciListesi = new List<Ogrenci>();
    }
}