using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class MethodExample5 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public List<string> myEnemies = new List<string>();
    
    
    
    void Start()
    {
        if (CheckEnemyCount(myEnemies))
        {
            Debug.Log("LEVEL COMPLETED");
        }
        else
        {
            Debug.Log("LEVEL CONTINUE");
        }
        Debug.Log(Result(10, 9));
    }

    private bool CheckEnemyCount(List<string> enemyList)
    {
        bool state;
        if (enemyList.Count < 1)
        {
            state = true;
        }
        else
        {
            state = false;
        }
        return state;
    }
    
    private int Result(int number1, int number2)
        { return number1 + number2; }
    // Update is called once per frame
    void Update()
    {
        
    }
}
