using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.UseCases.CreateUser
{
    public sealed class CreateUserHandler : IRequestHandler<CreateUserRequest, CreateUserResponse>
    {

        private readonly IUnityOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandler(IUnityOfWork unityOfWork, IUserRepository userRepository, IMapper mapper)
        {
            _unitOfWork = unityOfWork;
            _userRepository = userRepository;
            _mapper = mapper;

        }
        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
            _userRepository.Create(user);
            await _unitOfWork.Commit(cancellationToken);

            return _mapper.Map<CreateUserResponse>(user);


        }
    }
}
