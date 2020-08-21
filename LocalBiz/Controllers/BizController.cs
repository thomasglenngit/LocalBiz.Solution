using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LocalBiz.Models;
using Microsoft.EntityFrameworkCore;


namespace LocalBiz.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BizController : ControllerBase
  {
    private LocalBizContext _db;

    public BizController(LocalBizContext db)
    {
      _db = db;
    }

    // [HttpGet]
    // public async Task<IActionResult> GetAll([FromQuery] UrlQuery urlQuery)
    // {
    //   var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
    //   var pagedData = _db.Biz
    //     .OrderBy(thing => thing.LocationId)
    //     .Skip((validUrlQuery.PageNumer - 1) * validUrlQuery.PageSize)
    //     .Take(validUrlQuery.PageSize);
    //   return Ok(pagedData);
    // }

    // GET api/Biz
    [HttpGet]
    public ActionResult<IEnumerable<Biz>> Get(string name, string address, string type, string url)
    {
      var query = _db.Biz.AsQueryable();
      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (address != null)
      {
        query = query.Where(entry => entry.Address == address);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      if (url != null)
      {
        query = query.Where(entry => entry.Url == url);
      }

      return query.ToList();
    }
    

    [HttpGet("{id}")]
    public ActionResult<Biz> Get(int id)
    {
        return _db.Biz.FirstOrDefault(entry => entry.BizId == id);
    }

    // PUT api/Biz/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Biz biz)
    {
        biz.BizId = id;
        _db.Entry(Biz).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // POST api/Biz
    [HttpPost]
    public void Post([FromBody] Biz biz)
    {
      _db.biz.Add(Biz);
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var bizToDelete = _db.Biz.FirstOrDefault(entry => entry.BizId == id);
      _db.Biz.Remove(bizToDelete);
      _db.SaveChanges();
    }
  }
}