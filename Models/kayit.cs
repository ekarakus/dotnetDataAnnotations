using System;
using System.ComponentModel.DataAnnotations;
public class Ogrenci
{
    [MinLength(2,ErrorMessage ="en az 2 karakter")]
    [MaxLength(50,ErrorMessage ="lütfen 50 karaktere kadar... ")]
    [Required(ErrorMessage = "Ad boş bırakılamaz.")]
    [Display(Name ="Adınız")]
    public string ad{get;set;}=null!;
    
    [Required(ErrorMessage = "Soyad boş bırakılamaz.")]
    [Display(Name ="Soyadınız")]
    public string soyad{get;set;}=null!;
    
    [Required(ErrorMessage = "Email boş bırakılamaz.")]
    [Display(Name ="Email adresi")]
    [EmailAddress(ErrorMessage = "Geçerli bir email adresi giriniz")]

    public string email{get;set;}=null!;

   [Display(Name = "Not ortalaması")]      
   [Range(0,100,ErrorMessage ="1-100 arası ortalama giriniz")]
[Required(ErrorMessage = "not ortalaması boş bırakılamaz.")]
    public double notOrtalamasi{get;set;}
    
    [Display(Name ="Geçti mi?")]
    public bool gectiMi{get;set;}
   
   [Display(Name ="Kayıt tarihi")]
   [DataType(DataType.Date)]
   [Required(ErrorMessage = "Kayıt tarihi boş bırakılamaz.")]
    public DateTime kayitTarihi{get;set;}
    
    [Required(ErrorMessage = "Okul numarası boş bırakılamaz.")]
    [Display(Name ="Okul Numarası")]
    public int okulNumarasi{get;set;}

    [DataType(DataType.Password)]
    [Display(Name ="Şifre")]
    [MinLength(8)]
    [MaxLength(12)]
    [Required(ErrorMessage = "Şifre boş bırakılamaz.")]
    
    public string sifre{get;set;}=null!;

    [Compare("sifre",ErrorMessage ="şifre takrarlama hatası")]
    [Display(Name ="Şifre tekrarı")]
   [Required(ErrorMessage = "Şifre  tekrarı boş bırakılamaz.")]
   [DataType(DataType.Password)]
    public string sifreTekrari{get;set;}=null!;
}
