using UnityEngine;

public class Animal
{
    // protected : 외부에서는 접근 불가능하지만, 내부 혹은
    //             자식 클래스에서는 접근 가능
    protected string _name = string.Empty;
    protected float _height = 0f;
    protected double _weight = 0f;
    
    public void Introduce()
    {
        Debug.Log($"냐옹~ 내 이름은 {_name}이다 냥~");
    }

    public void Run()
    {
        Debug.Log($"[{_name} 뛰는 중!] 속도: {100 - (_height / _weight)}");
    }
}
