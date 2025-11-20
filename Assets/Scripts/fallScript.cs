using UnityEngine;

public class fallScript : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.name + "has fallen off the platform!");
    }
}
