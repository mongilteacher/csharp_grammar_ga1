using UnityEngine;

public class PersonClassExample : MonoBehaviour
{
    private void Start()
    {
        // 자료형 변수명 = 값
        // 클래스 클래스명 = new 클래스

        Chair chair1 = new Chair();
        chair1.Color = "푸른색";
        

        Person person1 = new Person("김상곤", 18, 182.7f, 78d, false);
        
        // Debug.Log(person1.Name); // 현실에서는 불가능
        // person1.Name = "황상곤";  // 현실에서는 불가능 
        // person1.Age = 237;
        
        Debug.Log(person1.HasGlasses);
        
        
        person1.Introduce();
        person1.Run();
        person1.SeatDown(chair1);
        
        Person person2 = new Person("김예찬", 19, 187.7f, 81d, true);
        person2.Introduce();
        person2.Run();
        person2.SeatDown();
        
        
        person1.Punch(person2);
    }
}
