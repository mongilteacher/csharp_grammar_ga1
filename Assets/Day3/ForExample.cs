using UnityEngine;

public class ForExample : MonoBehaviour
{
    private void Start()
    {
        // 반복문: 설정한 조건이 True일 동안(거짓이 될 때까지) 코드 블록 내부를 반복해서 실행한다.
        
        // for 반복문
        
        /**
         for (초기식, 조건식, 증감연산자)
         {
            반복할 코드들
         }
         // 초기식: 처음 한 번 실행할 식(보통 변수의 선언) : ex. int i = 0;
         // 조건식: 값을 비교해서 결과를 참/거짓인지 판명해주는 연산자
         // 증감연산자: ex. i++
         */

        for (int i = 0; i < 1000; i++)
        {
            Debug.Log($"안녕하세요. {i:4d}");
        }
        
        // 1. 1부터 1,000까지 짝수만 더한 값을 구해보세요.
        // 2. 구구단 2단부터 9단까지 5단을 제외하고 중첩 반복문을 이용해서 출력해보세요. 
        
        
        // while 반복문
        
        
        
        
        
        Debug.Log("안녕하세요.");
        Debug.Log("안녕하세요.");
        
    }
    
}
