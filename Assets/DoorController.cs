using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator door;

    private bool _isOpen;

    public void Door()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            _isOpen = !_isOpen;
            door.SetBool("isOpen", _isOpen);
        }
    }
}