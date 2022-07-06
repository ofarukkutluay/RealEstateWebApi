using MediatR;
using RealEstateWebApi.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Client.UpdateClient
{
    public class UpdateClientHandler : IRequestHandler<UpdateClientRequest, UpdateClientResponse>
    {
        private readonly IClientReadRepository _clientReadRepository;
        private readonly IClientWriteRepository _clientWriteRepository;

        public UpdateClientHandler(IClientReadRepository clientReadRepository, IClientWriteRepository clientWriteRepository)
        {
            _clientReadRepository = clientReadRepository;
            _clientWriteRepository = clientWriteRepository;
        }

        public async Task<UpdateClientResponse> Handle(UpdateClientRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Client client = await _clientReadRepository.GetByIdAsync(request.Id);
            if (client == null)
                return new UpdateClientResponse()
                {
                    Message = "Client bulunamadı",
                    Success = false
                };

            client.SummaryInfo = request.SummaryInfo == default ? client.SummaryInfo : request.SummaryInfo;
            client.ContactNumber = request.ContactNumber == default ? client.ContactNumber : request.ContactNumber;
            client.ContactEmail = request.ContactEmail == default ? client.ContactEmail : request.ContactEmail;
            client.About = request.About == default ? client.About : request.About;
            client.Dns = request.Dns == default ? client.Dns : request.Dns;
            client.IsActive = request.IsActive == default ? client.IsActive : request.IsActive;
            client.InstagramUrl = request.InstagramUrl == default ? client.InstagramUrl : request.InstagramUrl;
            client.ContactAddress = request.ContactAddress == default ? client.ContactAddress : request.ContactAddress;
            client.FacebookUrl = request.FacebookUrl == default ? client.FacebookUrl : request.FacebookUrl;
            client.LinkedinUrl = request.LinkedinUrl == default ? client.LinkedinUrl : request.LinkedinUrl;
            client.TwitterUrl = request.TwitterUrl == default ? client.TwitterUrl : request.TwitterUrl;
            client.ViewName = request.ViewName == default ? client.ViewName : request.ViewName;
            var result = await _clientWriteRepository.SaveAsync();
            if(result <= 0)
                return new UpdateClientResponse()
                {
                    Message = "Db ye kayıt edilirken bir haa alındı",
                    Success = false
                };
            return new UpdateClientResponse()
            {
                Message = "Client Güncellendi",
                Success = true
            };
        }
    }
}
