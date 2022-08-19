using System;

namespace FiniteStateMachine.States
{
    public interface IState
    {
        void Enter();
        void Exit();
        void Execute();
        IState GetNewState();
    }
}