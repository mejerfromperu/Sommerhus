using Sommerhus.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sommerhus.Repository07
{
    public interface ISommerHouseRepository
    {
        SommerHouse Add(SommerHouse s);
        SommerHouse Delete(int id);
        List<SommerHouse> GetAll();
        SommerHouse GetById(int id);
        string? ToString();
        SommerHouse Update(int id, SommerHouse sommerHouse);

      //  public List<SommerHouse> Search(int? id, string? name, string? team);
    }
}
