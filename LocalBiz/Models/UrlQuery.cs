using LocalBiz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;


namespace LocalBiz.Models
{
    public class UrlQuery
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public UrlQuery()
        {
            this.PageNumber = 1;
            this.PageSize = 3;
        }

        public UrlQuery(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 3 ? 3 : pageSize;
        }
    }
}

