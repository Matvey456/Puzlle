using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    
    private bool _isOn;
    
    public void RadioMusic()
    {
        _isOn = !_isOn;
        music.mute = _isOn;
    }
}