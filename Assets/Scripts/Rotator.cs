using DG.Tweening;
using UnityEngine;

public class Rotator : TweenAbstract
{
    [SerializeField] private Vector3 _angle;

    private void Start()
    {
        transform.DORotate(_angle, Duration)
            .SetEase(Ease.Linear)
            .SetLoops(InfinityLoops, LoopType.Incremental);
    }
}
