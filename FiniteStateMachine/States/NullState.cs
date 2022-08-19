namespace FiniteStateMachine.States
{
    public class NullState : StateBase
    {
        public override IState GetNewState()
        {
            return S.IdleState;
        }
    }
}