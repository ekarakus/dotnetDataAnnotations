using System;
using System.ComponentModel.DataAnnotations;
public class Urun{
    [Required(ErrorMessage ="Ürün adı boş bırakılamaz")]
    [Display(Name ="Ürün adı")]
    [MinLength(2,ErrorMessage ="En az 2 karakter")]
    [MaxLength(20,ErrorMessage ="En fazla 20 karakter")]
    public string urunAdi{get;set;}=null!;
    
    
    

     [Required(ErrorMessage ="Ürün ağırlığı boş bırakılamaz")]
    [Display(Name ="Ağırlık ")]
    public double agirlik{get;set;}

    [Required(ErrorMessage ="Email boş bırakılamaz")]
    [Display(Name ="Email ")]
    [EmailAddress(ErrorMessage ="geçerl,i bir email giriniz")]
    public string email { get; set; }=null!;
}