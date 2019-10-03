using Application.Activities.Commands;
using Application.Handlers;
using Domain;
using MediatR;
using Persistance;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Activities
{
    public class CommandHandler<TEntity> : ICommandHandler<Command<TEntity>>
    {
        private readonly DataContext _context;
        public CommandHandler(DataContext context)
        {
            _context = context;
        }
        public Task<Unit> Handle(Command<TEntity> request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
