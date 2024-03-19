using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ExGameData" ,  fileName = "NewExGameData" , order = 50)]
public class ExGameData : ScriptableObject
{
    //���� ���� ������ �߰� 
    public string gameName;
    public int gameScore;
    public bool isGameActive;

}
