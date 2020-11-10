using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class CommandRepository : ICommandRepo
    {
        private readonly CommandDataContext _commandContext;

        public CommandRepository(CommandDataContext commandContext)
        {
            _commandContext = commandContext;
        }

        public void CreateCommand(Command cmd)
        {
            if (cmd == null)
                throw new ArgumentNullException();  
            _commandContext.Commands.Add(cmd);
        }

        public void DeleteCommand(int id)
        {
            _commandContext.Commands.Remove(GetCommand(id));
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _commandContext.Commands.ToList();
        }

        public Command GetCommand(int id)
        {
            return _commandContext.Commands.FirstOrDefault(x => x.Id == id);
        }

        public bool SaveChanges()
        {
            return _commandContext.SaveChanges() >= 0;
        }
    }
}
