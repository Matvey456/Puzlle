using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private GameObject player;
    [SerializeField] private float sensivity;
    private float _xRotation, _yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update() => RotateCamera();

    private void RotateCamera()
    {
        _xRotation += Input.GetAxis("Mouse X") * sensivity;
        _yRotation += Input.GetAxis("Mouse Y") * sensivity;

        _yRotation = Mathf.Clamp(_yRotation, -90, 90); 
        playerCamera.transform.rotation = Quaternion.Euler(-_yRotation, _xRotation, 0);
        player.transform.rotation = Quaternion.Euler(0, _xRotation, 0);
    }
}
