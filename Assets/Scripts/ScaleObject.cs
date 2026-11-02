using UnityEngine;
using DG.Tweening;

public class ScaleObject : MonoBehaviour
{
    [SerializeField] private float _scaleMultiplier = 2f;
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        transform.DOScale(
            transform.localScale * _scaleMultiplier,
            _duration
        )
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);
    }
}