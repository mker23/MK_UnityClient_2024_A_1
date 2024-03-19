using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{

    private int health = 100;       //플레이어의 체력

    //플레이어가 피해를 받을 때 호출되는 함수

    public void TakeDamage(int damage)
    {
        //플레이어의 체력 감소
        health -= damage;

        Debug.Log("플레이어 피격. 남은 체력 : " + health);

        //체려깅 0 이하로 떨어졌을 떄 플레이어 사망 처리
        if(health <= 0)
        {
            Die();
        }
    }

    //플레이어가 사망했을 때 호출되는 함수
    private void Die()
    {
        Debug.Log("플레이어가 사망했습니다.");
        //사망 처리 로직 추가 
    }
}
