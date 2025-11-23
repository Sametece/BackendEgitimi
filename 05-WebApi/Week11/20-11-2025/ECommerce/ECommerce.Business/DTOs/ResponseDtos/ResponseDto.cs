using System;

namespace ECommerce.Business.DTOs.ResponseDtos;
// Burada kullandığımız yapı Factory Design Pattern. 
//Yani bu sınıf kendi tipinden nesneler yaratabilme yeteneğine sahip, bir fabrika gibi çalışıyor.
public class ResponseDto<T> //Generic Yapı
{
    public T? Data { get; set; }  //Entityler buraya gelicek
    public string? Error { get; set; } //Hata Mesajı
    public bool IsSucceed { get; set; }  //Başarılı mı ?
    public int StatusCode { get; set; } // Hata kodu -> Apıya Mesaj vericek


    public static ResponseDto<T> Success(T? data, int statusCode) //Kendi Tipinden Dön.
    {
        return new ResponseDto<T>
        {
            Data = data,
            StatusCode = statusCode,
            IsSucceed = true //Başarılı operasyonda true döner.
        };
    }


    public static ResponseDto<T> Success(int statusCode) //Delete-Update Gibi geriye veri dönmeden
    {
        return new ResponseDto<T>
        {
            Data = default,
            StatusCode = statusCode,
            IsSucceed = true
        };
    }

    public static ResponseDto<T> Fail(string error, int statusCode)
    {
        return new ResponseDto<T>
        {
            Error = error,
            StatusCode = statusCode,
            IsSucceed = false
        };
    }
}

























/*

    new ResponseDto{
        Data=product,
        Error=null,
        IsSucceed=true,
        StatusCode=200
    }

    new ResponseDto{
        Data=null,
        Error="İlgili ürün bulunamadığı için silme işlemi gerçekleştirilemedi",
        IsSucceed=false
    }

*/
