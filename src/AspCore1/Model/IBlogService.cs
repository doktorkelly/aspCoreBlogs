using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspCore1.Model
{
    public interface IBlogService
    {
        IEnumerable<Blog> FindAll();
        Blog FindByName(string name);
    }
}
