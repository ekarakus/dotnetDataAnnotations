using System;
using Microsoft.AspNetCore.Mvc;
using kayit.Models;
public class KayitController:Controller{
    public KayitController()
    {
        
    }
   //form ekranını oluşturan yer
   [HttpGet]
    public IActionResult Index(){
        ViewData["Title"]="Kayıt formu";
        Ogrenci m= new Ogrenci();
        m.ad="Ergün";
        m.soyad="Karakuş";
        m.kayitTarihi=DateTime.Now;
        //oluşturlan model view e gönderiliyor
        return View();
    }
    //formu postalandığı, bilgilerin işleneceği yer
    [HttpPost]
    public IActionResult Index(Ogrenci m){
        if(ModelState.IsValid){
           if(m.okulNumarasi>2000){
               ModelState.AddModelError("okulNumarasi","0-2000 arası giriniz");
               return View(m);
           } 
           if(m.kayitTarihi<DateTime.Now.Date){
               ModelState.AddModelError("kayitTarihi","Geçmiş tarih girmeyiniz..");
               return View(m);
           }
             ViewBag.sonuc="Kayıt tamamlandı";
             Depo.OgrenciListesi.Add(m);
             return  View("Views/Kayit/Tebrikler.cshtml",m);
            
        }else   {              
            return View(m);
        }
        
    }

    public IActionResult Liste(){            
        
        return View(Depo.OgrenciListesi);
    }
    public IActionResult Sil(int no){
      var kayit=  Depo.OgrenciListesi.Find(ogrenci=>ogrenci.okulNumarasi==no);
        if(kayit!=null){
            Depo.OgrenciListesi.Remove(kayit);
            return RedirectToAction(nameof(Liste));
        } else{
            return RedirectToAction("Error","Home");
        }
        
    }
}