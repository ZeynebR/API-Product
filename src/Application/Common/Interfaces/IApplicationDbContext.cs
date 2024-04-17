using Microsoft.EntityFrameworkCore;
using Solution1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        public  DbSet<Product> Products{ get;  }
        public DbSet<Category> Categories { get; }
        Task<int> SaveChageAsync(CancellationToken cancellationToken =default);
    }
}
