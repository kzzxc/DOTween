using DG.Tweening;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private Vector3 _direction = new Vector3(2, 2, 2);
    [SerializeField] private int _duration = 2;
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        transform.DOScale(_direction, _duration).SetLoops(_loops, LoopType.Yoyo);
    }
}
