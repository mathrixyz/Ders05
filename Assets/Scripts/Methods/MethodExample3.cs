using UnityEngine;

public class MethodExample3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Toplama(4, 7);
        Cikarma(9, 6);
        Carpma(10, 5);
        Bolme(11, 4);
    }
    private void Toplama(int number1 = 0, int number2 = 0)
    {
        int result = number1 + number2;
        Debug.Log("Toplam : " + result);
    }
    private void Cikarma(int number1 = 0, int number2 = 0)
    {
        int result = number1 - number2;
        Debug.Log("Fark : " + result);
    }
    private void Carpma(int number1 = 0, int number2 = 0)
    {
        int result = number1 * number2;
        Debug.Log("Çarpım : " + result);
    }
    private void Bolme(int number1 = 0, int number2 = 0)
    {
        float result = number1 / number2;
        Debug.Log("Bölüm : " + result);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
