using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Interfaces
{
    public interface ICommand<TRequest, TResponse>
    {
        TResponse Execute(TRequest request);
    }

    public interface ICommandRequest<TRequest>
    {
        void Execute(TRequest request);
    }

    public interface ICommandResponse<TResponse>
    {
        TResponse Execute();
    }
}
