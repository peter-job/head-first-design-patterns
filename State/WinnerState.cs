using System;

namespace Gumball
{
    public class WinnerState : IState
    {
        GumballMachine gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            this.gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we’re already giving you a gumball");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crank");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn’t get you another gumball!");
        }

        public void Dispense()
        {
            Console.WriteLine("YOU'RE A WINNER! You get two balls for your quarter");
            gumballMachine.ReleaseBall();
            if (gumballMachine.GetCount() == 0)
            {
                gumballMachine.SetState(gumballMachine.GetSoldOutState());
            }
            else
            {
                gumballMachine.ReleaseBall();
                if (gumballMachine.GetCount() > 0)
                {
                    gumballMachine.SetState(gumballMachine.GetNoQuarterState());
                }
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    gumballMachine.SetState(gumballMachine.GetSoldOutState());
                }
            }
        }

        public override string ToString()
        {
            return "just sold 2 gumballs";
        }
    }
}
