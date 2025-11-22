using UnityEngine;

public class betterJump : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float gravityScale = 3f;
    public Rigidbody rb;
    [SerializeField]
    private float distancetoCheck = 0.9f;
    [SerializeField]
    private bool isGrounded;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (rb.linearVelocity.y > 0)
        {
           //Debug.Log("Upward");
        }
        else if (rb.linearVelocity.y < 0)
        {
            //Debug.Log("Downward");
            rb.AddForce(Physics.gravity * (gravityScale - 1) * rb.mass);
        }
        //Έλεγχος για επαφή με το έδαφος
        if (Physics.Raycast(transform.position, Vector3.down, distancetoCheck))
        {
            Debug.Log("Grounded");
            isGrounded = true;
        }
        else
        {
            Debug.Log("Not Grounded");
            //we're flying
            isGrounded = false;
        }
    }
}
