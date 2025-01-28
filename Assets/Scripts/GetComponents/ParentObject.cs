using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObject : MonoBehaviour
{
    public void Start()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).GetComponent<ChildObject>().ParentDebug("New parent");
        }
        //GetComponentInChildren<ChildObject>().ParentDebug("Parent hello");
    }
    public void DebugChildObject(string content)
    {
        Debug.Log(content);
    }
}
