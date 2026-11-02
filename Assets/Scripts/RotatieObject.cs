using UnityEngine;
using DG.Tweening;

public class RotateObject : MonoBehaviour
{
    [SerializeField] private float _rotationAngle = 360f;
    [SerializeField] private float _duration = 3f;

    private void Start()
    {
        transform.DORotate(
            new Vector3(0, _rotationAngle, 0),
            _duration,
            RotateMode.FastBeyond360
        )
        .SetLoops(-1, LoopType.Restart)
        .SetEase(Ease.Linear);
    }
}