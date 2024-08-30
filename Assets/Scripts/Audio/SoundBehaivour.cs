using UnityEngine;

public class SoundBehaivour : MonoBehaviour
{
    public static SoundBehaivour Instance;
    [SerializeField] private AudioClip _click;
    [SerializeField] private AudioClip _bonus;
    private AudioSource _soundSource;
    private string _privateKey = "Sound";
    public float VolumeValue { get; private set; }
    private void Awake()
    {
        _soundSource = GetComponent<AudioSource>();

        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        Initialize();
    }
    private void OnDestroy()
    {
        PlayerPrefs.SetFloat(_privateKey, VolumeValue);
    }
    public void Initialize()
    {
        if (!PlayerPrefs.HasKey(_privateKey))
            PlayerPrefs.SetFloat(_privateKey, 0);

        VolumeValue = PlayerPrefs.GetFloat(_privateKey);
        ChangeVolume(VolumeValue);
    }
    public void ChangeVolume(float newValue)
    {
        VolumeValue = newValue;
        _soundSource.volume = newValue;
    }
    public void PlayClick()
    {
        PlaySound(Sounds.Click);
    }
    public void PlaySound(Sounds sound)
    {
        _soundSource.clip = null;
        switch (sound)
        {
            case Sounds.Click:
                _soundSource.clip = _click;
                break;
            case Sounds.Bonus:
                _soundSource.clip = _bonus;
                break;
        }
        _soundSource.Play();
    }
}

public enum Sounds
{
    Click,
    Bonus,
}
