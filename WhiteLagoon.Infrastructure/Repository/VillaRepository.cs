
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WhiteLagoon.Application.Common.Interfaces;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Infrastructure.Repository
{
    public class VillaRepository :Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public VillaRepository(ApplicationDbContext context): base(context) 
        {
            _dbContext = context;
        }
        


        public void Update(Villa villa)
        {
            _dbContext.Villas.Update(villa);
        }
    }
}
