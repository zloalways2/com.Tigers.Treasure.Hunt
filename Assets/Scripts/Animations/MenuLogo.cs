using DG.Tweening;
using UnityEngine;

public class MenuLogo : MonoBehaviour
{
    private float _timeDuration = 0.5f;
    private void OnEnable()
    {
        transform.DOKill();
        transform.localScale = Vector3.zero;
        Sequence sequence = DOTween.Sequence();
        sequence.Join(transform.DORotate(new Vector3(0, 0, -360 * 4), _timeDuration, RotateMode.FastBeyond360))
            .Join(transform.DOScale(Vector3.one, _timeDuration));
    }
}
