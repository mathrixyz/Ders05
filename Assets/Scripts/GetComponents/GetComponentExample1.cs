using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponentExample1 : MonoBehaviour
{
    public float jumpPower;
    public bool isTrigger;
    private BoxCollider myCollider;
    private Rigidbody myRigidbody;

    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
        myCollider = GetComponent<BoxCollider>();

        myRigidbody.AddForce(Vector3.up * jumpPower);

        if (isTrigger)
        {
            Invoke("ChangeTrigger", 1f);
        }
    }



    private void ChangeTrigger()
    {
        myCollider.isTrigger = true;
    }
}

