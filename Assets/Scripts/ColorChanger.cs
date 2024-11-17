using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : TweenAbstract
{
    [SerializeField] private Color _targetColor;
    [SerializeField] private Image _image;

    private void Start()
    {
        _image.DOColor(_targetColor, Duration)
            .SetLoops(InfinityLoops, LoopType.Yoyo);
    }
}
