using UnityEngine;

public class ExitApp : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();

        // Ini hanya untuk debug di editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
