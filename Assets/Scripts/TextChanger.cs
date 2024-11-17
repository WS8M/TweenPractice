using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : TweenAbstract
{
    [SerializeField] private Text _text;
    
    [SerializeField] private string _message;
    [SerializeField] private string _addedMessage;
    [SerializeField] private string _hackMessage;

    private Tween _tween;
    
    private void Start()
    {
        var sequence = DOTween.Sequence();
        sequence.Append(_text.DOText(_message, Duration));
        sequence.Append(_text.DOText(" " + _addedMessage, Duration).SetRelative());
        sequence.Append(_text.DOText(_hackMessage, Duration, false, ScrambleMode.All));
        sequence.SetLoops(InfinityLoops);
    }
}