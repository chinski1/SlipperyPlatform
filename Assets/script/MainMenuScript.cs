using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   
    public string sceneName;

    
    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);
        }
        else
        {
            Debug.LogWarning("Scene name needs to be set.");
        }
    }

    
    public void CloseGame()
    {
        Application.Quit();
    }
}
