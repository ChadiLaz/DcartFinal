using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DcartFinal.Data;


namespace DcartFinal.Models
{
    public class CartsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private List<Cart> listOfCart;
        public CartsController(ApplicationDbContext context)
        {
            _context = context;
          
            listOfCart = new List<Cart>();
        }

        // GET: Carts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cart.ToListAsync());
        }

        public ActionResult ShoppingCart()
        {
            listOfCart = new List<Cart>();
            return View(listOfCart);
        }

        //public JsonResult Index(int ProductId)
        //{
        //    //HttpContext.Session.SetString("CartCounter", "Null");
        //    Cart objlistOfCart = new Cart();
        //    Product product = _context.Products.Single(model => model.ProductId == ProductId);

        //    if (Session["CartCounter"] != null)
        //    {

        //    }
        //    if (listOfCart.Any(model => model.ProductId == ProductId))
        //    {
        //        objlistOfCart = listOfCart.Single(model => model.ProductId == ProductId);
        //        objlistOfCart.Quantity = objlistOfCart.Quantity +1;
        //        objlistOfCart.Total = objlistOfCart.Quantity * objlistOfCart.UnitPrice;
        //    }
        //    else
        //    {
        //        objlistOfCart.ProductId = ProductId;
        //        objlistOfCart.MainImageURL = product.MainImageURL;
        //        objlistOfCart.ImageFile = product.ImageFile;
        //        objlistOfCart.Quantity = 1;
        //        objlistOfCart.UnitPrice = product.Price;
        //        listOfCart.Add(objlistOfCart);
        //    }
        //    //Session["CartCounter"] = listOfCart.Count;
        //    //Session["CartItem"] = listOfCart;
        //    return Json(listOfCart);
        //    return Json(data:new {Success= true, Counter = listOfCart.Count }/*, JsonRequestBehavior.AllowGet*/);
           
        //}

        // GET: Carts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // GET: Carts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Carts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CartId,CustomerId,SessionId,ProductId,RecurringId,Option,Quantity,DateAdded")] Cart cart)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cart);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cart);
        }

        // GET: Carts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart.FindAsync(id);
            if (cart == null)
            {
                return NotFound();
            }
            return View(cart);
        }

        // POST: Carts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("CartId,CustomerId,SessionId,ProductId,RecurringId,Option,Quantity,DateAdded")] Cart cart)
        {
            if (id != cart.CartId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cart);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CartExists(cart.CartId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cart);
        }

        // GET: Carts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cart = await _context.Cart
                .FirstOrDefaultAsync(m => m.CartId == id);
            if (cart == null)
            {
                return NotFound();
            }

            return View(cart);
        }

        // POST: Carts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var cart = await _context.Cart.FindAsync(id);
            _context.Cart.Remove(cart);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CartExists(long id)
        {
            return _context.Cart.Any(e => e.CartId == id);
        }



       
      
    }
}
