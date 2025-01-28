using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class MethodExample4 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    public List<int> myNumbers = new List<int>();
    public List<int> myNumbers2 = new List<int>();
    
    
    void Start()
    {
        ForLoopExample(myNumbers);
        ForLoopExample(myNumbers2);
        WhileLoopExample();
    }

    private void ForLoopExample(List<int> list)
    {
        for (int i = 0; i < list.Count; i +=1)
        {
            Debug.Log("For Loop Index : " + i + " For Loop Value : " + list[i]);
        }
        Debug.Log("List Length : " + list.Count);
    }

    private void WhileLoopExample()
    {
        int counter = 0;
        while (counter < 10)
        {
            counter++;
            Debug.Log("While Loop : " + counter);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
