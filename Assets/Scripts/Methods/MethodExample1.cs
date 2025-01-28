using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Toplama();
    }

    private void Toplama()
    {
        int number1 = 5;
        int number2 = 2;
        int result = number1 + number2;

        Debug.Log(result);
    }
}
