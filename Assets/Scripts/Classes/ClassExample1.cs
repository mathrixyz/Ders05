using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassExample1 : MonoBehaviour
{
    myCalculator myCalculator = new myCalculator();
    Calculator myCalculator2 = new Calculator();
    private void Start()
    {
        myCalculator.Toplama(4, 5);
        myCalculator.Cikarma(4, 5);
        myCalculator.Carpma(4, 5);
        myCalculator.Bolme(4, 5);

        myCalculator2.Toplama(9, 5);
        myCalculator2.Cikarma(9, 5);
        myCalculator2.Carpma(9, 5);
        myCalculator2.Bolme(9, 5);

    }
}

public class myCalculator 
{
    public void Toplama(int x, int y)
    {
        Debug.Log("Toplam : " + (x + y));
    }
    public void Cikarma(int x, int y)
    {
        Debug.Log("Fark : " + (x - y));
    }
    public void Carpma(int x, int y)
    {
        Debug.Log("Çarpım : " + (x * y));
    }
    public void Bolme(int x, int y)
    {
        Debug.Log("Bölüm : " + (x / y));
    }
}