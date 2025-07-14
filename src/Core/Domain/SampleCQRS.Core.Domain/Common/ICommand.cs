using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Core.Domain.Common
{

    public interface ICommand
    {

    }

    public interface IQuery
    {

    }


    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand
        where TResult : class
    {
        Task<TResult> Handle(TCommand command);
    }
    public interface ICommandHandler<TCommand> where TCommand : ICommand
    {
        Task Handle(TCommand command);
    }


    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
        where TResult : class
    {
        Task<TResult> Handle(TQuery query);
    }
}
