using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MvcAngular;

namespace Sean.FullStack.MvcAngular.API.Dtos
{
    [AngularType]
    public class UserRegisterResponse
    {
        public bool Success { get; set; }
        public LoginToken LoginResult { get; set; }
    }
}
