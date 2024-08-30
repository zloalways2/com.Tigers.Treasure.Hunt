using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private string _levelsCompletedKey = "LCK1";
    private string _choisenLevelKey = "CLK2";
    
    public int InitializeCompletedLevels()
    {
        if(!PlayerPrefs.HasKey(_levelsCompletedKey))
            PlayerPrefs.SetInt(_levelsCompletedKey, 0);

        return PlayerPrefs.GetInt(_levelsCompletedKey);
    }
    public void LoadLevel(int level)
    {
        PlayerPrefs.SetInt(_choisenLevelKey, level);
        SceneManager.LoadScene("GameScene");
    }
    public void OpenNewLevel(int currentLevel)
    {
        if(currentLevel > PlayerPrefs.GetInt(_levelsCompletedKey) && currentLevel != 6)
        {
            PlayerPrefs.SetInt(_levelsCompletedKey, currentLevel);
        }
    }
    public void LoadNextLevel()
    {
        int currentLevel = PlayerPrefs.GetInt(_choisenLevelKey);
        if(currentLevel != 6)
        {
            PlayerPrefs.SetInt(_choisenLevelKey, currentLevel + 1);
            SceneManager.LoadScene("GameScene");
        }
        else
        {
            SceneManager.LoadScene("GameScene");
        }
    }
    public int GetChoisetLevel()
    {
        return PlayerPrefs.GetInt(_choisenLevelKey);
    }
}
