using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;

    private int _fitstAnimationDuration = 3;
    private int _secondAnimationDuration = 4;
    private int _hackAnimationDuration = 5;

    private Sequence _sequence;

    void Start()
    {
        _sequence = DOTween.Sequence();

        _sequence.Append(_text.DOText("Теперь тут другой текст?", _fitstAnimationDuration));
        _sequence.Append(_text.DOText("Тут вообще все подругому", _secondAnimationDuration).SetRelative());
        _sequence.Append(_text.DOText("Ну теперь точно другой текст", _hackAnimationDuration, true, ScrambleMode.All));
    }
}
