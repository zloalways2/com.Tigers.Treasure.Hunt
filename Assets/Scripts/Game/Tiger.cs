using UnityEngine;

public class Tiger : MonoBehaviour
{
    [SerializeField] private GameObject _lose;
    [SerializeField] private ScoresController _scoreController;
    private int _direction;
    private bool _isRight;
    private float _moveSpeed = 4f;
    private float _extrem = 1.9f;
    private void Start()
    {
        _isRight = false;
    }
    private void Update()
    {
        if(_direction == 1 && transform.position.x < _extrem)
        {
            transform.Translate(Vector2.right * _moveSpeed * Time.deltaTime);
        }
        else if(_direction == -1 && transform.position.x > -_extrem)
        {
            transform.Translate(Vector2.left * _moveSpeed * Time.deltaTime);
        }
    }
    public void ChangeDirection(int direction)
    {
        _direction = direction;
        if(_direction == 1 && !_isRight)
        {
            _isRight = true;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
        else if(_direction == -1 && _isRight)
        {
            _isRight = false;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Gem")
        {
            _scoreController.AddScore();
            Destroy(collision.gameObject.transform.parent.gameObject);

            SoundBehaivour.Instance.PlaySound(Sounds.Bonus);
        }
        else if(collision.gameObject.tag == "Shuriken")
        {
            _lose.SetActive(true);
        }
    }
}
