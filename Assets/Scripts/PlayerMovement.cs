using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float ForwardForce = 100f;
    public float SidewayForce = 10f;
 
    void FixedUpdate()
    {

        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }  
    }
}
