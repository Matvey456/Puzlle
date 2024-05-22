using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Animator target;

    [SerializeField] private bool isOpen;

    private void OpenCloseDoor()
    {
        target.SetBool("IsOpen", isOpen);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
           OpenCloseDoor();
        }
    }
}
