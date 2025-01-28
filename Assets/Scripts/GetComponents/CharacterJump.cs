using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    [SerializeField] private Rigidbody myrigidbody;

    public void JumpAction(Vector3 direction,float jumpPower)
    {
        myrigidbody.AddForce(direction*jumpPower);
    }
}
