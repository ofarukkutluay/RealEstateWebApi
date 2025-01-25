using MediatR;
using RealEstateWebApi.Application.Repositories;


namespace RealEstateWebApi.Application.Features.Commands.Front.DeleteFront
{
    public class DeleteFrontHandler : IRequestHandler<DeleteFrontRequest, DeleteFrontResponse>
    {
        private readonly IFrontReadRepository _frontReadRepository;
        private readonly IFrontWriteRepository _frontWriteRepository;

        public DeleteFrontHandler(IFrontReadRepository frontReadRepository, IFrontWriteRepository frontWriteRepository)
        {
            _frontReadRepository = frontReadRepository;
            _frontWriteRepository = frontWriteRepository;
        }

        public async Task<DeleteFrontResponse> Handle(DeleteFrontRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Front front = await _frontReadRepository.GetByIdAsync(request.Id);
            if(front == null)
                return new DeleteFrontResponse()
                {
                    Message = "Kayıt bulunamadı",
                    Success = false
                };
            front.IsDeleted = true;
            var result = await _frontWriteRepository.SaveAsync();
            if(result<0)
                return new DeleteFrontResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata oluştu",
                    Success = false
                };
            return new DeleteFrontResponse()
            {
                Message = "Data silindi",
                Success = true
            };
        }
    }
}
