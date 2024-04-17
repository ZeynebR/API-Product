using Microsoft.EntityFrameworkCore;
using Solution1.Application.Common.Interfaces;
using Solution1.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1.Infrastructure.Persistance
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public DbSet<Product> Products => Set<Product>();

        public DbSet<Category> Categories => Set<Category>();

        public Task<int> SaveChageAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
