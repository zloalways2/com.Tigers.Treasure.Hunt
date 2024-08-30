using UnityEngine;

public class Shuricken : MonoBehaviour
{
    private float _speed;
    private void Start()
    {
        _speed = Random.Range(2.0f, 3.5f);
    }

    private void Update()
    {
        transform.Translate(Vector2.down * _speed * Time.deltaTime);
    }
}
