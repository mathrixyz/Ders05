using UnityEngine;

public class MethodExample2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Toplama(4, 7);
    }
    private void Toplama(int number1=0, int number2=0)
    {
        int result=number1 + number2;
        Debug.Log(result);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
