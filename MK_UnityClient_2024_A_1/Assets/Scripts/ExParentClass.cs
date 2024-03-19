using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour  //상속: 유니티 오브젝트에서 동작하게
{
    //protected로 선언된 변수는 같은 클래스 및 파생 클래스에서 접근 가능
    protected int protectedValue;
}

public class ExChildClass : ExParentClass   //ExParentClass를 상속
{
    void start()
    {
        //ExParnetClass의 Protected 변수에 접근 가능
        Debug.Log("Protected Value from Child Class :" + protectedValue);
    }
}
