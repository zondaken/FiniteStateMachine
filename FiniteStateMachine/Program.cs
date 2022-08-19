using System;
using FiniteStateMachine.States;

namespace FiniteStateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            IState state = S.NullState;

            // game loop
            while (true)
            {
                IState oldState;

                do
                {
                    oldState = state;
                    state = state.GetNewState();

                    if (oldState != state)
                    {
                        oldState.Exit();
                        state.Enter();
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                try
                {
                    state.Execute(); // execute code of current state in the current game loop step
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"[{state.GetType().Name}] = {ex.Message}");
                }
            }
        }
    }
}