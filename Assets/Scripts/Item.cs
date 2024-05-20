using System;
using TMPro;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private Camera interactableCamera;
    [SerializeField] private TMP_Text interactableText;
    [SerializeField] private GameObject interactableTextObject;
    [SerializeField] private AudioSource music;
    
    private bool _isOn;
    [SerializeField] private float distance;
    [SerializeField] private LayerMask mask;

    private void Update() => InteractableItem();

    private void InteractableItem()
    {
        Ray ray = new Ray(interactableCamera.transform.position, interactableCamera.transform.forward);
        RaycastHit hit;
        var cast = Physics.Raycast(ray, out hit, distance, mask);

        if (cast)
        {
            interactableTextObject.SetActive(true);
            interactableText.text = "E";

            if (Input.GetKeyDown(KeyCode.E))
            {
                _isOn = !_isOn;
                music.mute = _isOn;
            }
        }
        else
        {
            interactableText.text = "";
            interactableTextObject.SetActive(false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(interactableCamera.transform.position, interactableCamera.transform.forward);
    }
}
