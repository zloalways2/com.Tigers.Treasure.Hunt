using UnityEngine;
using UnityEngine.UI;

public class SoundDisplay : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    private void Start()
    {
        _slider.onValueChanged.AddListener(SoundBehaivour.Instance.ChangeVolume);
    }
    private void OnDestroy()
    {
        _slider.onValueChanged.RemoveAllListeners();
    }
    private void OnEnable()
    {
        _slider.value = SoundBehaivour.Instance.VolumeValue;
    }

}
