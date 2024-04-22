using DG.Tweening;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private int _duration = 3;
    [SerializeField] private int _loops = -1;
    [SerializeField] private Vector3 _direction = new Vector3(180,360,180);

    private void Start()
    {
        transform.DORotate(_direction, _duration).SetLoops(_loops, LoopType.Incremental);
    }
}
