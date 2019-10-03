using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands
{
    public interface ICommand : IRequest
    {
        void Create();
        void Update();
        void Delete(Guid id);
    }
}
