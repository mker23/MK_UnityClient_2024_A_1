using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlayer : MonoBehaviour
{

    private int health = 100;       //�÷��̾��� ü��

    //�÷��̾ ���ظ� ���� �� ȣ��Ǵ� �Լ�

    public void TakeDamage(int damage)
    {
        //�÷��̾��� ü�� ����
        health -= damage;

        Debug.Log("�÷��̾� �ǰ�. ���� ü�� : " + health);

        //ü���� 0 ���Ϸ� �������� �� �÷��̾� ��� ó��
        if(health <= 0)
        {
            Die();
        }
    }

    //�÷��̾ ������� �� ȣ��Ǵ� �Լ�
    private void Die()
    {
        Debug.Log("�÷��̾ ����߽��ϴ�.");
        //��� ó�� ���� �߰� 
    }
}
