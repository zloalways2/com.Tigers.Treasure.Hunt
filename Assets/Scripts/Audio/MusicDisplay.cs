using UnityEngine;
using UnityEngine.UI;

public class MusicDisplay : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private void Start()
    {
        _slider.onValueChanged.AddListener(MusicBehaivour.Instance.ChangeVolume);
    }
    private void OnDestroy()
    {
        _slider.onValueChanged.RemoveAllListeners();
    }
    private void OnEnable()
    {
        _slider.value = MusicBehaivour.Instance.VolumeValue;
    }


}
