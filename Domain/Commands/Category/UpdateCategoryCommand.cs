using Domain.Commands.Category;

namespace Domain.Commands
{
    public class UpdateCategoryCommand : CategoryCommand
    {
        public UpdateCategoryCommand(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
