using TMPro;
using UnityEngine;

public class TimeLoader : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    [SerializeField] private TextMeshProUGUI _timeDisplay;
    private void OnEnable()
    {
        int minutes = _timer.Seconds / 60;
        int seconds = _timer.Seconds % 60;
        _timeDisplay.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
