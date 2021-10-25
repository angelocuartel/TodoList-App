using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TodoList_App.Models;

namespace TodoList_App.Model_Validations
{
    public class TodoValidation : AbstractValidator<Todo>
    {
        public TodoValidation()
        {
            RuleFor(x => x.TodoTask)
                .NotEmpty()
                .WithMessage("Please put some Task you lazy!")
                .MaximumLength(20)
                .WithMessage("you only have 20 max characters");
                
        }
    }
}
