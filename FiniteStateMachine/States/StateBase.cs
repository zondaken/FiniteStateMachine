using System;

namespace FiniteStateMachine.States
{
    public abstract class StateBase : IState
    {
        public virtual void Enter()
        {
            Console.WriteLine($"[{GetType().Name}] = Enter");
        }

        public virtual void Exit()
        {
            Console.WriteLine($"[{GetType().Name}] = Exit");
        }

        public virtual void Execute()
        {
            
        }

        public virtual IState GetNewState()
        {
            return this;
        }
    }
}