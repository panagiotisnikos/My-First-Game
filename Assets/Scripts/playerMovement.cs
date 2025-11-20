using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float jumpForce = 2f;
    void Start()
    {
        //rb.useGravity = false;
 
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //συνεχής κίνηση προς τα εμπρός
        rb.AddForce(0, 0, forwardForce); // (x,y,z)
        //αυτό το ξεχνάμε
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
       if (Input.GetKey("a"))
         {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if (Input.GetKey("space"))
         {
            rb.AddForce(0, jumpForce, 0, ForceMode.Impulse);
        }
    }
}
