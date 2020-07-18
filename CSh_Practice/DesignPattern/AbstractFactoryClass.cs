using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSh_Practice_App_1.Design_Pattern
{
    class AbstractFactoryClass
    {
        static public void Run() {

            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();


            Console.ReadKey();
        }
    }

    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
    // this is the ConcreteFactory that produces the product object
    class AfricaFactory : ContinentFactory
    {

        public override Herbivore CreateHerbivore()
        {
            return new WildBeast();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }
    // this is another ConcreteFactory that produces different product
    class AmericaFactory : ContinentFactory
    {

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }
    // abstract products
    // abstract class for Product Type A
    abstract class Herbivore { }
    // abstract class for Product Type B
    abstract class Carnivore{
        public abstract void Eat(Herbivore h);
    }

    // ProductA1
    class WildBeast : Herbivore { }
    // ProductB1
    class Lion: Carnivore {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine( this.GetType().Name + " eats " + h.GetType().Name );
        }
    }
    // this is the product A2
    class Bison : Herbivore{}
    // this is the product B2
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;
        public AnimalWorld(ContinentFactory factory) {
            this._herbivore = factory.CreateHerbivore();
            this._carnivore = factory.CreateCarnivore();
        }
        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }

}
