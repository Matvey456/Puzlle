using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private Color pressButtonColor, defaultButtonColor;
    [SerializeField] private Renderer buttonRenderer;
    
    void Start()
    {
        buttonRenderer.material.color = defaultButtonColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            buttonRenderer.material.color = pressButtonColor;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            buttonRenderer.material.color = defaultButtonColor;
        }
    }
}