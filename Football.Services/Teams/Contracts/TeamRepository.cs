using Librari.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services.Teams.Contracts
{
    public interface TeamRepository
    {
        void Add(Team team);
        void Get(Team team);
        void Update(Team team);
        void Delete(Team team);


    }
}
