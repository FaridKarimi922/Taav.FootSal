using Librari.Entitis;
using Library.Services.Teams.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Persistence.Ef.Teams
{
    internal class EfTeamRepository : TeamRepository
    {
        private readonly EfDataContext _context;
        public EfTeamRepository(EfDataContext context)
        {
                _context = context;
        }



        public void Add(Team team)
        {
            _context.Add(team);
        }

        public void Delete(Team team)
        {
            throw new NotImplementedException();
        }

        public void Get(Team team)
        {
            throw new NotImplementedException();
        }

        public void Update(Team team)
        {
            throw new NotImplementedException();
        }
    }
}
