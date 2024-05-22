using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Camera interactableCamera;
    [SerializeField] private GameObject interactableTextObject;
    [SerializeField] private GameObject interactableMouseObject;
    [SerializeField] private GameObject interactableMouseUIContextObject;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask mask;

    [SerializeField] private Transform hand;
    private GameObject _objectToPickUp;
    private bool _canPickUp = false;
    [SerializeField] private float dropSpeed;
    [SerializeField] private float rotateSpeed = 5;

    private void Update() => InteractableItem();

    private void InteractableItem()
    {
        Ray ray = new Ray(interactableCamera.transform.position, interactableCamera.transform.forward);
        RaycastHit hit;
        var cast = Physics.Raycast(ray, out hit, distance, mask);

        if (Input.GetMouseButtonDown(1) && _canPickUp)
        {
            RotateItem();
            DropItem();
            InteractableView.Interact(interactableMouseUIContextObject, false);
        }
        
        if (cast)
        {
            InteractableView.Interact(interactableMouseObject, true);


            if (Input.GetMouseButtonDown(0) && !_canPickUp)
            {
                PickUp(hit);
                
                InteractableView.Interact(interactableMouseUIContextObject, true);
            }

            if (hit.transform.CompareTag("Radio"))
            {
                interactableMouseObject.SetActive(false);
                interactableTextObject.SetActive(true);

                if (Input.GetKeyDown(KeyCode.E))
                    hit.transform.GetComponent<Radio>().RadioMusic();
            }
        }
        else
        {
            InteractableView.Interact(interactableTextObject, interactableMouseObject, false);
        }
    }

    private void PickUp(RaycastHit hit)
    {
        _objectToPickUp = hit.transform.gameObject;
        _objectToPickUp.GetComponent<Rigidbody>().isKinematic = true;
        _objectToPickUp.transform.parent = hand.transform;
        _objectToPickUp.transform.position = hand.position;
        _canPickUp = true;
    }
    
    private void DropItem()
    {
        _objectToPickUp.GetComponent<Rigidbody>().isKinematic = false;
        _objectToPickUp.GetComponent<Rigidbody>().AddForce(hand.transform.forward * dropSpeed, ForceMode.Impulse);
        _objectToPickUp.transform.parent = null;
        _objectToPickUp = null;
        _canPickUp = false;
    }

    private void RotateItem()
    {
        if (Input.mouseScrollDelta.y > 0.01f)
        {
            _objectToPickUp.transform.rotation *= Quaternion.Euler(0, rotateSpeed, 0);
        }
        else if (Input.mouseScrollDelta.y < 0.01f)
        {
            _objectToPickUp.transform.rotation *= Quaternion.Euler(0, -rotateSpeed, 0);
        }
    }
}
