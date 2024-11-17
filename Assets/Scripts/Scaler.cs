using DG.Tweening;
using UnityEngine;

public class Scaler : TweenAbstract
{   
    [SerializeField] private float _maxScale = 2f;

    private void Start()
    {
        transform.DOScale(Vector3.one * _maxScale, Duration).SetLoops(InfinityLoops, LoopType.Yoyo);
    }
}
