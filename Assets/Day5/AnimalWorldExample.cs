using UnityEngine;

public class AnimalWorldExample : MonoBehaviour
{
    private void Start()
    {
        Person person1 = new Person("손정휘", 26, 179f, 50, false);
        Cat cat1 = new Cat("삠삐", 30, 10);

        Person person2 = new Person("황유찬", 21, 179f, 45, false);
        Dog dog1 = new Dog("누리", 50, 15);

        Person person3 = new Person("하지호", 28, 170f, 40, true);
        Dog dog2 = new Dog("덕자", 50, 10);
        
        
        person1.Introduce();
        cat1.Introduce();
        
        person2.Introduce();
        dog1.Introduce();
        
        person3.Introduce();
        dog2.Introduce();
        
    }
}
