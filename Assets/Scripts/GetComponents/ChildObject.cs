using UnityEngine;

public class ChildObject : MonoBehaviour
{
    private void Start()
    {
        GetComponentInParent<ParentObject>().DebugChildObject("child object World");
    }


    public void ParentDebug(string content)
    {
        Debug.Log(content);
    }
}
