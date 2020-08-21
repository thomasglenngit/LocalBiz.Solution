  
namespace LocalBiz.Models
{
  public class BizResto
  {
    public int BizRestoId {get; set;}
    public int BizId {get; set;}
    public int RestoId {get; set;}
    public virtual Biz Biz {get; set;}
    public virtual Resto Resto {get; set;}
  }
}