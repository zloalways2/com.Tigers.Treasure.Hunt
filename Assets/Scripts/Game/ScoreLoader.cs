using TMPro;
using UnityEngine;

public class ScoreLoader : MonoBehaviour
{
    [SerializeField] private ScoresController _scoreController;
    [SerializeField] private TextMeshProUGUI _display;
    private void OnEnable()
    {
        _display.text = $"{_scoreController.CurrentScore}/{_scoreController.ScoreToWin}";
    }
}
