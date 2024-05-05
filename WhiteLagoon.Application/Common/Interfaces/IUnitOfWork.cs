using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Application.Common.Interfaces
{
    public interface IUnitOfWork
    {
        public IVillaRepository Villa { get; }
        public IVillaNumberRepository VillaNumber { get; }
        public IAmenityRepository Amenity { get; }
        public IEnumerable<Member> members { get; }
        void Save();

    }
}
