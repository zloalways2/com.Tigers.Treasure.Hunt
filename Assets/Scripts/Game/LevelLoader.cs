using TMPro;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private LevelController _level;
    [SerializeField] private ScoresController _scoreController;
    [SerializeField] private TextMeshProUGUI _levelDisplay;
    private int _currentLevel;
    private void Start()
    {
        _currentLevel = _level.GetChoisetLevel();

        _scoreController.Initialize(_currentLevel);

        _levelDisplay.text = "Level " + _currentLevel;
    }
}
