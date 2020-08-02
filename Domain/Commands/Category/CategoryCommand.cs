using Infrastructure.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands.Category
{
    public abstract class CategoryCommand : Command
    {
        public int Id { get; protected set; }
        public string Name { get; protected set; }

    }
}
