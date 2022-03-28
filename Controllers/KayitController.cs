using System;
using Microsoft.AspNetCore.Mvc;
public class KayitController:Controller{
    public IActionResult Index(){
        Ogrenci m= new Ogrenci();
        m.ad="Ergün";
        m.soyad="Karakuş";
        m.kayitTarihi=DateTime.Now;
        //oluşturlan model view e gönderiliyor
        return View();
    }
}