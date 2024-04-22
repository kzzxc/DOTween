using DG.Tweening;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private Vector3 _direction;
    [SerializeField] private int _duration = 3;
    [SerializeField] private int _loops = -1;

    private void Start()
    {
        transform.DOMove(_direction, _duration).SetLoops(_loops, LoopType.Yoyo);
    }
}
