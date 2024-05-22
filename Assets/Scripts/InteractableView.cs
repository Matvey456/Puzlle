using UnityEngine;

public static class InteractableView
{
    public static void Interact(GameObject firstUI, bool isActive)
    {
        firstUI.SetActive(isActive);
    }

    public static void Interact(GameObject firstUI, GameObject secondUI, bool isActive)
    {
        firstUI.SetActive(isActive);
        secondUI.SetActive(isActive);
    }

    public static void Interact(GameObject firstUI, GameObject secondUI, GameObject thirdUI, bool isActive)
    {
        firstUI.SetActive(isActive);
        secondUI.SetActive(isActive);
        thirdUI.SetActive(isActive);
    }
}