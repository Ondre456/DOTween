using UnityEngine;
using DG.Tweening;

[RequireComponent(typeof(Renderer))]
public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color _targetColor = Color.red;
    [SerializeField] private float _duration = 2f;
    
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();    
    }
    private void Start()
    {
        _renderer.material
            .DOColor(_targetColor, _duration)
            .SetLoops(-1, LoopType.Yoyo);
    }
}