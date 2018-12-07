using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcAngular;

namespace Sean.FullStack.MvcAngular.API.Dtos
{
    [AngularType]
    public class LoginRequest
    {
        public RoleEnum UserType { get; set; }
        public string Id { get; set; }
        public string PasswordHash { get; set; }
    }
}
