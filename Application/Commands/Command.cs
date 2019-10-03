using Application.Commands;
using Domain;
using System;

namespace Application.Activities.Commands
{
    public class Command<TEntity> : ICommand
    {
        private TEntity entity { get; set; }

        public void Create()
        {
            if (entity is Activity)
            {
                
            }
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
