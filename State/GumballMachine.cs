using System;

namespace Gumball
{
    public class GumballMachine
    {

        private IState soldOutState;
        private IState noQuarterState;
        private IState hasQuarterState;
        private IState winnerState;
        private IState soldState;

        private IState state;
        private int count = 0;

        public GumballMachine(int numberOfGumballs)
        {
            soldOutState = new SoldOutState(this);
            noQuarterState = new NoQuarterState(this);
            hasQuarterState = new HasQuarterState(this);
            winnerState = new WinnerState(this);
            soldState = new SoldState(this);
            count = numberOfGumballs;
            if (numberOfGumballs > 0)
            {
                state = noQuarterState;
            }
            else
            {
                state = soldOutState;
            }
        }

        public void InsertQuarter()
        {
            state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            state.EjectQuarter();
        }

        public void TurnCrank()
        {
            state.TurnCrank();
            state.Dispense();
        }

        public void SetState(IState state)
        {
            this.state = state;
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (count != 0)
            {
                count = count - 1;
            }
        }

        public int GetCount()
        {
            return count;
        }

        public void Refill(int numberOfGumballs)
        {
            this.count += numberOfGumballs;
        }

        public IState GetSoldOutState()
        {
            return soldOutState;
        }

        public IState GetSoldState()
        {
            return soldState;
        }

        public IState GetNoQuarterState()
        {
            return noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return hasQuarterState;
        }

        public IState GetWinnerState()
        {
            return winnerState;
        }

        public override string ToString()
        {
            return String.Format("\nMighty Gumball, Inc.\nC#-enabled Standing Gumball Model #2019\nInventory: {0} gumballs\nThe machine {1}\n", count, state);
        }
    }
}
