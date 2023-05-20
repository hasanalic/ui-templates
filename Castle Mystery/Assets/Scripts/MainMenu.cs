using UnityEngine;
using UnityEngine.SceneManagement; // to switch between scenes

public class MainMenu : MonoBehaviour
{
    public AudioSource audioSource;

    public void PlayClickedSound()
    {
        audioSource.Play();
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Application has quit.");
    }
}
