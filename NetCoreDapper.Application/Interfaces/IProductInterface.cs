using NetCoreDapper.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDapper.Application.Interfaces
{
    public interface IProductInterface : IGenericRepository<Product>
    {
    }
}
