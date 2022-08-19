using FiniteStateMachine.States;

namespace FiniteStateMachine
{
    public static class S
    {
        public static IState NullState = new NullState();
        public static IState IdleState = new IdleState();
        public static IState WalkState = new WalkState();
        public static IState RunState = new RunState();
    }
}