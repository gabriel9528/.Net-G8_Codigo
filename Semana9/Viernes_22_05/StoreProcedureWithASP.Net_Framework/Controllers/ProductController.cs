using StoreProcedureWithASP.Net_Framework.DAL;
using StoreProcedureWithASP.Net_Framework.Models;
using System;
using System.Web.Mvc;

namespace StoreProcedureWithASP.Net_Framework.Controllers
{
    public class ProductController : Controller
    {
        ProductDAL productDAL = new ProductDAL();

        // GET: Product
        public ActionResult Index()
        {
            var productList = productDAL.GetAllProducts();
            if(productList.Count > 0)
            {
                return View(productList);
            }
            return View();
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
            try
            {
                var product = productDAL.GetProductById(id);
                if(product != null)
                {
                    return View(product);
                }
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(ProductModel product)
        {
            try
            {
                bool isInserted = false;
                if (ModelState.IsValid)
                {
                    isInserted = productDAL.InsertProduct(product);
                    if (isInserted)
                        return RedirectToAction("Index");
                    else
                        return View();
                }
                else
                    return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            var product = productDAL.GetProductById(id);
            if(product != null)
                return View(product);
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ProductModel product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bool isUpdate = productDAL.UpdateProduct(product);
                    if (isUpdate)
                        return RedirectToAction("Index");
                    return View();
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            var product = productDAL.GetProductById(id);
            if (product != null)
                return View(product);
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                string result = productDAL.DeleteProduct(id);
                if (result.Contains("eliminado"))
                    return RedirectToAction("Index");
                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}
