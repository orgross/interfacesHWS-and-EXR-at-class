using System;

namespace interfacesHWS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region exr IFlyable
            //Crow c1 = new Crow();
            //Plane p1 = new Plane();
            //IFlayable c2=new Crow();
            //IFlayable p2 = new Plane();

            //LetsFly(c1);
            //LetsFly(p1);
            //LetsFly(p2);
            //LetsFly(c2);
            #endregion

            #region exr HWS

            IAnimal fish=new Fish("fish");
            IAnimal cat = new Cat("cat");
            IAnimal dog = new Dog("dog");

            AnimallsHungry(dog);
            AnimallsHungry(cat);
            AnimallsHungry(fish);

            AnimallsTired(dog);
            AnimallsTired(cat);
            AnimallsTired(fish);
            #endregion

        }
        static void LetsFly(IFlayable flayable) //exr IFlyable
        {
            flayable.Fly();
            flayable.GetAltitude(5);
        }
        static void AnimallsHungry(IAnimal animal)//exr HWS
        {
            IAnimal animal1 = animal;
            IMakeSoundable sound = animal1 as IMakeSoundable;
            if (animal is Dog) 
            {
               sound.MakeSoundBeforeEAting();
               animal.eat();    
            } 
            else if(animal is Cat)
            {
                sound.MakeSoundBeforeEAting();
                animal.eat();
            }
            else
            {
                animal.eat();
            }  
        }
        static void AnimallsTired(IAnimal animal)//exr HWS
        {
            animal.sleep();
        }
    }
}
