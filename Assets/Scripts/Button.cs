using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Renderer buttonRenderer;
    [SerializeField] private Color defaultColor, pressedColor;
    [SerializeField] private Animator door;

    private void Update()
    {
        ChangeButton();
    }

    private void ChangeButton()
    {
        Ray ray = new Ray(gameObject.transform.position, transform.up);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 20))
        {
            buttonRenderer.material.color = pressedColor;
            door.SetBool("IsOpen", true);
        }
        else
        {
            buttonRenderer.material.color = defaultColor;
            door.SetBool("IsOpen", false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.up);
    }
}