using System.Collections;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _display;
    private int _seconds;
    public int Seconds => _seconds;
    private void Start()
    {
        _seconds = 0;
        StartCoroutine(StartTimer());
    }

    private IEnumerator StartTimer()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            _seconds++;
            int minutes = _seconds / 60;
            int seconds = _seconds % 60;
            _display.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
