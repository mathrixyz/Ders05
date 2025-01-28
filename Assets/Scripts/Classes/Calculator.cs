using UnityEngine;

public class Calculator
{
    public void Toplama(int x, int y)
    {
        Debug.Log("Toplam : " + (x + y));
    }
    public void Cikarma(int x, int y)
    {
        Debug.Log("Fark : " + (x-y));
    }
    public void Carpma(int x, int y)
    {
        Debug.Log("Çarpım : " + (x*y));
    }
    public void Bolme(int x, int y)
    {
        Debug.Log("Bölüm : " + (x/y));
    }
}
