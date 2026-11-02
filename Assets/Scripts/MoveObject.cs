using UnityEngine;
using DG.Tweening;
using static UnityEditor.MaterialProperty;

public class MoveObject : MonoBehaviour
{
    [SerializeField] private float _distance = 3f;
    [SerializeField] private float _duration = 2f;

    private void Start()
    {
        transform.DOMoveX(
            transform.position.x + _distance,
            _duration
        )
        .SetLoops(-1, LoopType.Yoyo)
        .SetEase(Ease.InOutSine);
    }
}