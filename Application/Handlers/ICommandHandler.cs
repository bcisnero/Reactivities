using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Handlers
{
    internal interface ICommandHandler<TRequest> : IRequestHandler<TRequest> where TRequest : IRequest<Unit>
    {

    }
}
