using UnityEngine;
using UnityEngine.UI;

public class LevelsDisplays : MonoBehaviour
{
    [SerializeField] private LevelController _levelController;
    [SerializeField] private Button[] _levels;
    private int _completedLevels;
    private void Start()
    {
        _completedLevels = _levelController.InitializeCompletedLevels();

        for (int i = 0; i < _completedLevels + 1; i++)
        {
            _levels[i].interactable = true;
        }
    }
}
