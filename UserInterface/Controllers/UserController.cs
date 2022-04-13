using System.Web.Mvc;
using System.Collections.Generic;
using DataModelLayer;
using BusinessLogicLayer.Users;
using UserInterface.ViewModel;
using Microsoft.AspNet.Identity;

namespace UserInterface.Controllers
{
    public class UserController : Controller
    {
        private readonly ViewProducts _viewProducts;
        public UserController()
        {
            _viewProducts = new ViewProducts();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowProducts()
        {
           var products = _viewProducts.ShowAllProducts();
            return View(products);
        }

      public ActionResult AddAddress(AddAddressViewModel viewModel)
        {
            var user = _viewProducts.GetUser(viewModel.AspNetUser.Id);
            return View(user);
        }

        [HttpPost]
        public ActionResult SaveAddress(AddAddressViewModel viewModel)
        {
            viewModel.DeliveryAddress.UserId = viewModel.AspNetUser.Id;
            _viewProducts.AddAddress(viewModel.DeliveryAddress);
            return RedirectToAction("ShowProducts","User");

        }
    }
}