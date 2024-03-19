using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExConstructor : MonoBehaviour              //생성자 예제
{
    private int value;                                  //사용자 변수 설정

    public ExConstructor(int _value)
    {
        value = _value;                                     //생성자를 호출할 떄 받은 변수를 메인 변수애 입력
        Debug.Log("객체가 생성되었습니다. 초기값: " + value);        //객체가 생성되었을때 디버로그로 받은 값 출력
    }
    
    
    // Start is called before the first frame update
    void Start()
    {       //생성자 호출
        ExConstructor ex = new ExConstructor(10);
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))             //스페이스키를 눌렀을 때 이 객체 파괴
        {
            Destroy(this.gameObject);
        }
    }
    //Unity에서는 명시적으로 소멸자를 호출하는것이 아니라 OnDestroy()메서드를 활용하여 객체 파괴될때 필요한 작업 수행 
    void OnDestroy()
    {
        Debug.Log("객체가 파괴되었습니다");
    }
}
