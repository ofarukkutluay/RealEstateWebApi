using FluentValidation;
using RealEstateWebApi.Application.Features.Commands.Blog.CreateBlog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Validators.Blog
{
    public class CreateBlogValidator : AbstractValidator<CreateBlogRequest>
    {
        public CreateBlogValidator()
        {
            RuleFor(e=>e.Title).NotEmpty().MinimumLength(3);
            RuleFor(e=>e.Author).NotEmpty().MinimumLength(3);
            RuleFor(e=>e.Content).NotEmpty().MinimumLength(15);
            RuleFor(e => e.ClientId).NotEmpty();
            RuleFor(e=> e.BlogTypeId).NotEmpty();
            RuleFor(e=>e.CompanyId).NotEmpty();

        }
    }
}
