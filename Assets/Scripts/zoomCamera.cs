using UnityEngine;

public class zoomCamera : MonoBehaviour
{
    Camera mainCamera;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main;
        Debug.Log("Main camera field of view:" + mainCamera.fieldOfView);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("f"))
        {
            mainCamera.fieldOfView = 100f;
        } else
        {
            mainCamera.fieldOfView = 60f;
        }
    }
}
