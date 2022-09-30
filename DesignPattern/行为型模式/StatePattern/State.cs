using System;

namespace DesignPattern.StatePattern
{
    public abstract class StateModel
    {
        public abstract void Enter();
        public abstract void Exit();
    }

    public class StateModelA : StateModel
    {
        public override void Enter()
        {
            Console.WriteLine("进入 A 状态.");
        }

        public override void Exit()
        {
            Console.WriteLine("离开 A 状态.");
        }
    }

    public class StateModelB : StateModel
    {
        public override void Enter()
        {
            Console.WriteLine("进入 B 状态.");
        }

        public override void Exit()
        {
            Console.WriteLine("离开 B 状态.");
        }
    }

    public class StateController
    {
        private StateModel state;

        public StateController(StateModel state)
        {
            this.state = state;
        }

        public void Enter()
        {
            state.Enter();
        }

        public void Change(StateModel state)
        {
            this.state.Exit();
            this.state = state;
            this.state.Enter();
        }

        public void Exit()
        {
            state.Exit();
        }
    }
}
