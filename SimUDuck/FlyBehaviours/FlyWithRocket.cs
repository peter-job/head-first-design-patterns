﻿using System;

namespace SimUDuck.FlyBehaviours
{
    public class FlyWithRocket : IFlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with a rocket!");
        }
    }
}
