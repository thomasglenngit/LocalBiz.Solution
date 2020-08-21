using LocalBiz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocalBiz.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BizsController : ControllerBase
  {
    private LocalBizContext _db;

    public BizsController(LocalBizContext db)
    {
      _db = db;
    }

    [HttpGet("Page")]
    public IActionResult GetAll([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
      var pagedData = _db.Bizs
        .OrderBy(thing => thing.BizId)
        .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
        .Take(validUrlQuery.PageSize);
      return Ok(pagedData);
    }

    // GET api/Bizs
    [HttpGet]
    public ActionResult<IEnumerable<Biz>> Get(string name, string address, string type, string url)
    {
      var query = _db.Bizs.AsQueryable();
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
        return _db.Bizs.FirstOrDefault(entry => entry.BizId == id);
    }

    // PUT api/Bizs/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Biz Biz)
    {
        Biz.BizId = id;
        _db.Entry(Biz).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // POST api/Bizs
    [HttpPost]
    public void Post([FromBody] Biz Biz)
    {
      _db.Bizs.Add(Biz);
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var BizToDelete = _db.Bizs.FirstOrDefault(entry => entry.BizId == id);
      _db.Bizs.Remove(BizToDelete);
      _db.SaveChanges();
    }
  }
}