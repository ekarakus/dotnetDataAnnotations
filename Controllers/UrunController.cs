using Microsoft.AspNetCore.Mvc;
using kayit.Models;
public class UrunController:Controller{
    public IActionResult Index(string isim){
        //isim eğer boş değil ise filtrele
        if(!string.IsNullOrEmpty(isim)){
            return View(Depo.UrunListesi
            .Where(u=>u.urunAdi.ToLower().StartsWith(isim.ToLower()))
            .ToList());
        } else{
            // isim boş ise filtreleme yapma
            return View(Depo.UrunListesi);
        }
        
    }
}