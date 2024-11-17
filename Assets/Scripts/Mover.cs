using DG.Tweening;
using UnityEngine;

public class Mover : TweenAbstract
{
    [SerializeField] private float _distance = 1f;
    
    private void Start()
    {
        Vector3 targetPosition = transform.position + transform.forward * _distance;
        transform.DOMove(targetPosition, Duration)
            .SetEase(Ease.Linear)
            .SetLoops(InfinityLoops,LoopType.Incremental);
    }
}
