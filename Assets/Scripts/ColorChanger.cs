using DG.Tweening;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Material _material;
    private int _loops = -1;
    private int _duration = 1;

    private Color _target = Color.blue;

    private void Start()
    {
        _material = GetComponent<Renderer>().material;

        _material.DOColor(_target, _duration).SetLoops(_loops, LoopType.Yoyo);
    }
}

