using System;

namespace Gumball
{
    public class HasQuarterState : IState
    {
        Random random = new Random();
        GumballMachine gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can’t insert another quarter");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            gumballMachine.SetState(gumballMachine.GetNoQuarterState());
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            var winner = random.Next(0, 10);
            if (winner == 0 && gumballMachine.GetCount() > 1)
            {
                gumballMachine.SetState(gumballMachine.GetWinnerState()) ;
            }
            else
            {
                gumballMachine.SetState(gumballMachine.GetSoldState());
            }
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public override string ToString()
        {
            return "being inserted with a quarter";
        }
    }
}
