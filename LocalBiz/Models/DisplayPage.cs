using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

public abstract class PagedResultBase
{
    public int CurrentPage { get; set; } 
    public int PageCount { get; set; } 
    public int PageSize { get; set; } 
    public int RowCount { get; set; }
 
    public int FirstRowOnPage
    {
 
        get { return (CurrentPage - 1) * PageSize + 1; }
    }
 
    public int LastRowOnPage
    {
        get { return Math.Min(CurrentPage * PageSize, RowCount); }
    }
}
 
public static class PagedResult<T> : PagedResultBase where T : class
{
    public IList<T> Results { get; set; }
 
    public static PagedResult<Biz> GetPaged<Biz> (this IQueryable<Biz> query, 
                                         int page, int pageSize) where Biz : class
    {
        var result = new PagedResult<Biz>();
        result.CurrentPage = page;
        result.PageSize = pageSize;
        result.RowCount = query.Count();


        var pageCount = (double)result.RowCount / pageSize;
        result.PageCount = (int)Math.Ceiling(pageCount);
    
        var skip = (page - 1) * pageSize;     
        result.Results = query.Skip(skip).Take(pageSize).ToList();

        Results = new List<Biz>();
    }
}