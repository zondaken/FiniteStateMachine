using System;

namespace FiniteStateMachine.States
{
    public class IdleState : StateBase
    {
        public override void Execute()
        {
            Console.WriteLine("[Idle] working...");
        }

        public override IState GetNewState()
        {
            return S.WalkState;
        }
    }
}