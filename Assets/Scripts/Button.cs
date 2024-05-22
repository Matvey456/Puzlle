using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Renderer buttonRenderer;
    [SerializeField] private Color defaultColor, pressedColor;

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
        }
        else
        {
            buttonRenderer.material.color = defaultColor;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawRay(transform.position, transform.up);
    }
}