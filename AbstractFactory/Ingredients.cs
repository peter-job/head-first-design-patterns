using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaFactory
{
    public interface ICheese { }
    public class Mozzarella : ICheese { }
    public class ReggianoCheese : ICheese { }

    public interface ISauce { }
    public class MarinaraSauce : ISauce { }
    public class PlumTomatoSauce : ISauce { }

    public interface IDough { }
    public class ThinCrustDough : IDough { }
    public class ThickCrustDough : IDough { }

    public interface IPepperoni { }
    public class SlicedPepperoni : IPepperoni { }

    public interface IClams { }
    public class FreshClams : IClams { }
    public class FrozenClams : IClams { }

    public interface IVeggies { }
    public class Garlic : IVeggies { }
    public class Onion : IVeggies { }
    public class Mushroom : IVeggies { }
    public class RedPepper : IVeggies { }
    public class BlackOlives : IVeggies { }
    public class Spinach : IVeggies { }
    public class EggPlant : IVeggies { }
}
