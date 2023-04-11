using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.city.commands.AddCity;
>>>>>>> add city and country and continent
=======
>>>>>>> country,continent,city
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using FluentValidation;

namespace BookingClone.Application.Features.continent.commands.AddContinent;
public class AddContinentCommmandValidator : AbstractValidator<AddContinentCommmand>
   
{
    public AddContinentCommmandValidator()
    {
        RuleFor(a => a.Name)
               .NotEmpty().WithMessage(a => "Name is empty.")
               .NotNull().WithMessage(a => "Name is required.")

               .MaximumLength(200).WithMessage(a => "name must not exceed 200 characters.");


    }


}

