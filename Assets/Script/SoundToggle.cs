using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public GameObject soundOnButton;   
    public GameObject soundOffButton;  
    public AudioSource audioSource;

    public void ToggleSoundOn()
    {
        audioSource.Play();                 // Aktifkan suara
        soundOffButton.SetActive(false);   // Sembunyikan tombol Off
        soundOnButton.SetActive(true);     // Tampilkan tombol On
    }

    // Fungsi ketika tombol SoundOn ditekan (opsional toggle balik)
    public void ToggleSoundOff()
    {
        audioSource.Pause();               // Nonaktifkan suara
        soundOnButton.SetActive(false);    // Sembunyikan tombol On
        soundOffButton.SetActive(true);    // Tampilkan tombol Off
    }
}
