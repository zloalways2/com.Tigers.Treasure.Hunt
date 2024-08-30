using UnityEngine;

public class MusicBehaivour : MonoBehaviour
{
    public static MusicBehaivour Instance;

    private AudioSource _musicSource;
    private string _privateKey = "Volume";
    public float VolumeValue { get; private set; }
    private void Awake()
    {
        _musicSource = GetComponent<AudioSource>();

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
    private void Start()
    {
        Initialize();
    }
    private void OnApplicationQuit()
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
        _musicSource.volume = newValue;
    }
}
