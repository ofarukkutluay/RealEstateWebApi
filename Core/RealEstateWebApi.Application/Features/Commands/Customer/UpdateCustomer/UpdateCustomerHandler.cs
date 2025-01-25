using MediatR;
using RealEstateWebApi.Application.Features.Commands.Customer.CreateCustomer;
using RealEstateWebApi.Application.Features.Commands.User.RegisterUser;
using RealEstateWebApi.Application.Repositories;
using RealEstateWebApi.Application.Validators.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RealEstateWebApi.Application.Features.Commands.Customer.UpdateCustomer
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerRequest, UpdateCustomerResponse>
    {
        private readonly ICustomerReadRepository _customerReadRepository;
        private readonly ICustomerWriteRepository _customerWriteRepository;

        public UpdateCustomerHandler(ICustomerWriteRepository customerWriteRepository, ICustomerReadRepository customerReadRepository)
        {
            _customerWriteRepository = customerWriteRepository;
            _customerReadRepository = customerReadRepository;
        }

        public async Task<UpdateCustomerResponse> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            Domain.Entities.Customer customer = await _customerReadRepository.GetByIdAsync(request.Id);
            if (customer is null)
                return new UpdateCustomerResponse()
                {
                    Message = "Müşteri bulunamadı",
                    Success = false
                };

            if (customer.MobileNumber != request.MobileNumber && !String.IsNullOrEmpty(request.MobileNumber))
            {
                Domain.Entities.Customer searchCustomer = await _customerReadRepository.GetSingleAsync(e => e.MobileNumber == request.MobileNumber);
                if (searchCustomer is not null)
                    return new UpdateCustomerResponse()
                    {
                        Message = "Bu numaraya ait data bulunmakatadır.",
                        Success = false
                    };
            }

            request.MobileNumber = request.MobileNumber.Trim().Replace(" ", "");
            request.MobileNumber2 = request.MobileNumber2?.Trim().Replace(" ", "");

            UpdateCustomerValidator validationRules = new UpdateCustomerValidator();
            var validateResult = await validationRules.ValidateAsync(request);
            if (!validateResult.IsValid)
            {
                return new UpdateCustomerResponse
                {
                    Message = validateResult.ToString(","),
                    Success = false
                };
            }

            customer.MobileNumber = request.MobileNumber;

            customer.FirstName = String.IsNullOrEmpty(request.FirstName) ? customer.FirstName : request.FirstName;
            customer.LastName = String.IsNullOrEmpty(request.LastName) ? customer.LastName : request.LastName;
            customer.FullName = $"{customer.FirstName} {customer.LastName}";
            customer.PhoneNumber = String.IsNullOrEmpty(request.PhoneNumber) ? customer.PhoneNumber : request.PhoneNumber;
            customer.PhoneNumber2 = String.IsNullOrEmpty(request.PhoneNumber2) ? customer.PhoneNumber2 : request.PhoneNumber2;
            customer.Email = String.IsNullOrEmpty(request.Email) ? customer.Email : request.Email;
            customer.MobileNumber2 = String.IsNullOrEmpty(request.MobileNumber2) ? customer.MobileNumber2 : request.MobileNumber2;
            customer.BirthDay = request.BirthDay == null ? customer.BirthDay : request.BirthDay;
            customer.CitizenNumber = request.CitizenNumber == default ? customer.CitizenNumber : request.CitizenNumber;
            customer.CityId = request.CityId == default ? customer.CityId : request.CityId;
            customer.DistrictId = request.DistrictId == default ? customer.DistrictId : request.DistrictId;
            customer.NeighborhoodId = request.NeighborhoodId;
            customer.RegisterUserId = request.RegisterUserId == default ? customer.RegisterUserId : request.RegisterUserId;
            customer.AssignedUserId = request.AssignedUserId == default ? customer.AssignedUserId : request.AssignedUserId;
            customer.StatusKey= request.StatusKey;
            customer.IsActive = request.IsActive;

            var result = await _customerWriteRepository.SaveAsync();
            if (result < 0)
                return new UpdateCustomerResponse()
                {
                    Message = "Db ye kayıt edilirken bir hata alındı",
                    Success = false
                };

            return new UpdateCustomerResponse()
            {
                Message = "Müşteri güncellendi",
                Success = true
            };
        }
    }
}
