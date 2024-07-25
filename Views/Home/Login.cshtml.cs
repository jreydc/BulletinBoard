using BulletinBoard.Data;
using BulletinBoard.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;

namespace BulletinBoard.Views.Home
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDBContext _applicationDBContext;
        public IEnumerable<Category> Categories { get; set; }
        public LoginModel(ApplicationDBContext applicationDBContext)
        {
            _applicationDBContext = applicationDBContext;
        }
        public void OnGet()
        {
            Categories = _applicationDBContext.Category;
        }
    }
}
