using DG.Tweening;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void Start()
    {
        transform.DOScale(new Vector2(0.8f, 0.8f), 0.7f).SetEase(Ease.InOutCubic).SetLoops(-1, LoopType.Yoyo);
    }
}
