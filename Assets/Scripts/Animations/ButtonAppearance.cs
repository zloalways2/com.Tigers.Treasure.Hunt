using DG.Tweening;
using UnityEngine;

public class ButtonAppearance : MonoBehaviour
{
    [SerializeField] private Transform[] _buttons;

    private float _startX  = -Screen.width * 1.5f;
    private float _timeDuration = 0.25f;

    private void OnEnable()
    {
        foreach (Transform button in _buttons)
        {
            button.DOKill();
            button.transform.localPosition = new Vector3(_startX, button.transform.localPosition.y, button.transform.localPosition.z);
        }

        Sequence sequence = DOTween.Sequence().SetUpdate(true);
        foreach(Transform button in _buttons)
        {
            sequence.Append(button.DOLocalMoveX(0, _timeDuration));
        }
    }
}
