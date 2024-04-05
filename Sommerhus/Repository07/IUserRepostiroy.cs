using Sommerhus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Repository07
{
    public interface IUserRepostiroy
    {
        User Add(User m);
        User Delete(int id);
        List<User> GetAll();
        User GetById(int id);
        string? ToString();
        User Update(int id, User User);

        public List<User> Search(int? id, string? name, string? team);

    }
}
