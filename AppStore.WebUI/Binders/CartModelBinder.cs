using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AppStore.Domain.Entities;
using System.Web.ModelBinding;
using System.Web.Mvc;

namespace AppStore.WebUI.Binders
{
    public class CartModelBinder:System.Web.Mvc.IModelBinder
    {
        private const string session = "Cart";
        public object BindModel(ControllerContext controllerContext, System.Web.Mvc.ModelBindingContext bindingContext)
        {
            Cart cart = (Cart)controllerContext.HttpContext.Session[session];
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session[session] = cart;
            }
            return cart;
        }
    }
}