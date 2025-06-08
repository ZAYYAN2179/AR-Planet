using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadSampleScene()
    {
        // Ganti "SampleScene" dengan nama persis dari scene-mu
        SceneManager.LoadScene("SampleScene");

        // Atau bisa pakai index scene:
        // SceneManager.LoadScene(1); // jika SampleScene ada di index 1
    }
}
