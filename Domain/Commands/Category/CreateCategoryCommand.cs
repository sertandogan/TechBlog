using Domain.Commands.Category;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Commands
{
    public class CreateCategoryCommand : CategoryCommand
    {
        public CreateCategoryCommand(string name)
        {
            Name = name;
        }
    }
}
