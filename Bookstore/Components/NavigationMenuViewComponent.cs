using System;
using System.Linq;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IBookRepository repository;

        //controller
        public NavigationMenuViewComponent (IBookRepository r)
        {
            repository = r;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedClass = RouteData?.Values["category"];

            return View(repository.Books
                .Select(x => x.Class)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
