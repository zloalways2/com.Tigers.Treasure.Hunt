using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void SwitchScene(string newSceneName)
    {
        SceneManager.LoadScene(newSceneName);
    }
}
