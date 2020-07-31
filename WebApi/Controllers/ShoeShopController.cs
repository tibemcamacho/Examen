using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Admin;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    public class ShoeShopController : AdminController
    {
        //   dbContext db = new dbContext();
        private readonly dbContext _context;

        public ShoeShopController(dbContext context)
        {
            _context = context;
        }

        [Route("api/shoe/get")]
        public async Task<ActionResult> get()
        {
            try
            {
                return new JsonResult(new { success = true, articles = _context.articles.ToList() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, error_code = 400, error_msg = ex.Message });
            }
        }

        [Route("api/shoe/getPorId/{id}")]
        public async Task<ActionResult> getPorId(int id)
        {
            try
            {
                var obj = _context.articles.ToList().Where(x => x.id == id).SingleOrDefault();
                if (obj != null)
                    return new JsonResult(new { success = true, article = obj });
                else
                    return new JsonResult(new { success = false, error_code = 404, error_msg = "Registro no encontrado" });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, error_code = 400, error_msg = ex.Message });
            }
        }

        [Route("api/shoe/post")]
        public async Task<ActionResult> post([FromBody] article art)
        {
            try
            {
                var obj = _context.articles.Where(x => x.id == art.id).SingleOrDefault();

                if (obj != null)
                {
                    obj.name = art.name;
                    obj.description = art.description;
                    obj.price = art.price;
                    obj.total_in_shelf = art.total_in_shelf;
                    obj.total_in_vault = art.total_in_vault;
                    obj.store_id = art.store_id;
                }
                else
                    _context.articles.Add(art);
               await _context.SaveChangesAsync();

                return new JsonResult(new { success = true, articles = _context.articles.ToList() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, error_code = 400, error_msg = ex.Message });
            }
        }

        [Route("api/almacen/get")]
        public async Task<ActionResult> getAlmacen()
        {
            try
            {
                return new JsonResult(new { success = true, stores = _context.stores.ToList() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, error_code = 400, error_msg = ex.Message });
            }
        }

        [Route("api/almacen/post")]
        public async Task<ActionResult> postAlmacen([FromBody] store store)
        {
            try
            {
                var obj = _context.stores.Where(x => x.id == store.id).SingleOrDefault();
                if (obj != null)
                {
                    obj.name = store.name;
                    obj.address = store.address;
                }
                else
                    _context.stores.Add(store);
                await _context.SaveChangesAsync();

                return new JsonResult(new { success = true, stores = _context.stores.ToList() });
            }
            catch (Exception ex)
            {
                return new JsonResult(new { success = false, error_code = 400, error_msg = ex.Message });
            }
        }
    }
}
