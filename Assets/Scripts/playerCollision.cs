using UnityEngine;

public class playerCollision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public playerMovement movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        //Debug.Log("We hit something:" + collisionInfo.collider.name);

        if (collisionInfo.collider.tag == "obstacle")
        {
            Debug.Log("We hit an obstacle! Ouch!");
            movement.enabled = false;
            gameManager gm = FindObjectOfType<gameManager>();
            gm.GetComponent<gameManager>().EndLevel();
        }
        if (collisionInfo.collider.name == "Floor")
        {
            //Debug.Log("We hit the floor!");
            //is
        }
    }
}
