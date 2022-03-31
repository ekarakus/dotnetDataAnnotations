using System;
using Microsoft.AspNetCore.Mvc;
public class KayitController:Controller{
   [HttpGet]
    public IActionResult Index(){
        Ogrenci m= new Ogrenci();
        m.ad="Ergün";
        m.soyad="Karakuş";
        m.kayitTarihi=DateTime.Now;
        //oluşturlan model view e gönderiliyor
        return View();
    }
    [HttpPost]
    public IActionResult Index(Ogrenci m){
    if(ModelState.IsValid){
        ViewBag.sonuc="Kayıt tamamlandı";
        return  View("Views/Kayit/Tebrikler.cshtml",m);
    }else   {
        return View(m);
    }
    }
}