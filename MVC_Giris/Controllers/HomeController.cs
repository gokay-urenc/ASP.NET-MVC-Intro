using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Giris.Controllers
{
    public class HomeController : Controller
    {
        public int Index()
        {
            return 2 + 2;
        }

        public string Mesaj()
        {
            return "Hello World.";
        }
    }
}
// Proje içerisinde birden fazla Controller olabilir.
// Default olarak kullanıcıyı karşılayan controller, HomeController'dir.
// Home, default tetiklenen method(action) index'tir.
// Controller içinde birden fazla method barınabilir.
// MVC'de kullanıcı isteğini web sayfası üzerinden link(url) ile yapar.
// Yapılan istek MVC mantığında mutlaka bir controller'da bulunan methoda iletilmelidir.
// Yani direkt olarak web sayfası adı kullanılarak görüntülenemez.