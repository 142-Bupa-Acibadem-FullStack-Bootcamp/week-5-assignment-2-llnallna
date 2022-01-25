using NorthwindBupa.Entity.IBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Entity.Base
{
    public class Response : IResponse
    {
        // public int a; --> üye degisken
        public string Message { get; set; } // --> üye property. Bunu kapsülleme yapma ihtimalinden dolayı olusturuyoruz. 
        public int StatusCode { get; set; } // --> Api calistiginda geri döndürülecek kodlar için.
        public object Data { get; set; } // --> Her tipte datayı alabilmesini istediğimiz için nesne tercih ettik.

    }

    //generic interface'ten de generic class'a kalıtım veriyoruz:
    public class Response<T> : IResponse<T>
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public T Data { get; set; } // --> Liste geldiğinde burası çalışır. String, int gelirse de üstteki Response sınıfı çalışır.
    }
}
