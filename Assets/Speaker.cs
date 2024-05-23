using UnityEngine;

public class Speaker : MonoBehaviour
{
    [SerializeField] private AudioSource speakerTalk;

    private void OnTriggerEnter(Collider other)
    {
        Speak();
    }

    private void Speak() => speakerTalk.PlayOneShot(speakerTalk.clip);
}
