﻿using Cmms.Core.Models;
using Cmms.Domain.Entities;
using MediatR;

namespace Cmms.Core.Commands.UserProfileCommands
{
    public class UpdateUserProfileCommand : IRequest<OperationResult<UserProfile>>
    {
        public Guid UserProfileId { get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CurrentCity { get; set; }
    }
}
