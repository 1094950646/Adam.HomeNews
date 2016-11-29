using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeNews.Api.Index
{
   public interface INews
    {
       string NewId { get; set; }
       DateTime NewCreateTime { get; set; }
       string NewTitle { get; set; }
       string NewContent { get; set; }
    }
}
