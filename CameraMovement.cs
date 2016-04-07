using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CameraMovement : MonoBehaviour
{

    private Vector3 view1 = new Vector3(-4.46f, 3.09f, -4.35f);
    private Vector3 view2 = new Vector3(4.27f, 3.09f, 4.25f);

    Vector3 mainCam;
    public Camera mainCamera;

    bool cam1 = true;
    bool cam2 = false;

    void Start()
    {
        mainCamera = Camera.main;
        mainCam = Camera.main.gameObject.transform.position;
    }

    void OnTriggerEnter(Collider ChangeCamera)
    {
        if (ChangeCamera.name == "CameraChange (1)" && cam1 == false)
        {
            cam1 = true;
            cam2 = false;
            Camera.main.gameObject.transform.position = view1;
            Camera.main.gameObject.transform.Rotate(0, 180, 0, Space.World);
        }
        else if (ChangeCamera.name == "CameraChange" && cam2 == false)
        {
            cam1 = false;
            cam2 = true;
            Camera.main.gameObject.transform.position = view2;
            Camera.main.gameObject.transform.Rotate(0, 180, 0, Space.World);
        }
    }
}