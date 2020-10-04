﻿using Commander.Models;
using System.Collections.Generic;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil an agg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command { Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "Knife & Chopping board" },
                new Command { Id = 2, HowTo = "Make cup of tea", Line = "Place teabag in cup", Platform = "Kettle & Cup" }
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command { Id = 0, HowTo = "Boil an agg", Line = "Boil water", Platform = "Kettle & Pan" };
        }

        public void CreateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}
