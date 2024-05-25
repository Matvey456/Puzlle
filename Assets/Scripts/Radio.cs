using UnityEngine;

public class Radio : MonoBehaviour
{
    [SerializeField] private AudioSource music;
    
    private bool _isOn;
    
    public void RadioMusic()
    {
        _isOn = !_isOn;
        
        if (_isOn)
        {
            music.Play();
        }
        else
        {
            music.Pause();
        }
    }
}