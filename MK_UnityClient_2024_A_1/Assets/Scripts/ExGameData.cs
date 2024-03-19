using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ExGameData" ,  fileName = "NewExGameData" , order = 50)]
public class ExGameData : ScriptableObject
{
    //게임 관련 변수들 추가 
    public string gameName;
    public int gameScore;
    public bool isGameActive;

}
