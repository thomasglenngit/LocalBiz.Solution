using LocalBiz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LocalBiz.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RestosController : ControllerBase
  {
    private LocalBizContext _db;

    public RestosController(LocalBizContext db)
    {
      _db = db;
    }

    [HttpGet("Page")]
    public IActionResult GetAll([FromQuery] UrlQuery urlQuery)
    {
      var validUrlQuery = new UrlQuery(urlQuery.PageNumber, urlQuery.PageSize);
      var pagedData = _db.Restos
        .OrderBy(thing => thing.RestoId)
        .Skip((validUrlQuery.PageNumber - 1) * validUrlQuery.PageSize)
        .Take(validUrlQuery.PageSize);
      return Ok(pagedData);
    }

    // GET api/Restos
    [HttpGet]
    public ActionResult<IEnumerable<Resto>> Get(string rname, string raddress, string rtype, string rurl)
    {
      var query = _db.Restos.AsQueryable();
      if (rname != null)
      {
        query = query.Where(entry => entry.RName == rname);
      }
      if (raddress != null)
      {
        query = query.Where(entry => entry.RAddress == raddress);
      }
      if (rtype != null)
      {
        query = query.Where(entry => entry.RType == rtype);
      }
      if (rurl != null)
      {
        query = query.Where(entry => entry.RUrl == rurl);
      }
      
      return query.ToList();
    }
    

    [HttpGet("{id}")]
    public ActionResult<Resto> Get(int id)
    {
        return _db.Restos.FirstOrDefault(entry => entry.RestoId == id);
    }

    // PUT api/Restos/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Resto Resto)
    {
        Resto.RestoId = id;
        _db.Entry(Resto).State = EntityState.Modified;
        _db.SaveChanges();
    }

    // POST api/Restos
    [HttpPost]
    public void Post([FromBody] Resto Resto)
    {
      _db.Restos.Add(Resto);
      _db.SaveChanges();
    }
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var RestoToDelete = _db.Restos.FirstOrDefault(entry => entry.RestoId == id);
      _db.Restos.Remove(RestoToDelete);
      _db.SaveChanges();
    }
  }
}