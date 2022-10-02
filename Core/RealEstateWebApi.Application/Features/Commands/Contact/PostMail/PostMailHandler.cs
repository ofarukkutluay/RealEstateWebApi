using MediatR;
using RealEstateWebApi.Application.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Contact.PostMail
{
    public class PostMailHandler : IRequestHandler<PostMailRequest, PostMailResponse>
    {
        private readonly IMailService _mailService;

        public PostMailHandler(IMailService mailService)
        {
            _mailService = mailService;
        }

        public async Task<PostMailResponse> Handle(PostMailRequest request, CancellationToken cancellationToken)
        {
            await _mailService.SendMailAsync(new string[] { request.To, "kutluaynet@outlook.com" }, request.Subject, request.Body);
            return new PostMailResponse()
            {
                Message = "Mail Gönderildi",
                Success = true
            };
        }
    }
}
