using TMPro;
using UnityEngine;

public class ScoresController : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    [SerializeField] private GameObject _win;
    [SerializeField] private TextMeshProUGUI _scoresDisplay;
    private int _currentLevel;
    private int _currentScore;
    private int _scoreToWin;
    public int CurrentScore => _currentScore;
    public int ScoreToWin => _scoreToWin;
    public void Initialize(int level)
    {
        _scoreToWin = level * 30;
        _currentLevel = level;
        RefreshDisplay();
    }
    private void RefreshDisplay()
    {
        _scoresDisplay.text = $"{_currentScore}/{_scoreToWin}";
    }
    public void AddScore()
    {
        _currentScore += 10;
        RefreshDisplay();
        if (_currentScore >= _scoreToWin)
        {
            _levelController.OpenNewLevel(_currentLevel);
            _win.SetActive(true);
        }
    }
}
