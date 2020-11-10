using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Data
{
    public interface ICommandRepo
    {
        IEnumerable<Command> GetAllCommands();
        Command GetCommand(int id);

        void DeleteCommand(int id);

        void CreateCommand(Command cmd);

        bool SaveChanges();
    }
}
