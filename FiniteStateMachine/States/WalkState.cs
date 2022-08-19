using System;

namespace FiniteStateMachine.States
{
    public class WalkState : StateBase
    {
        public override void Execute()
        {
            Console.WriteLine("[Walk] working...");
        }
    }
}