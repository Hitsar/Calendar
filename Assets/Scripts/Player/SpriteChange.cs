using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    [SerializeField] private List<Sprite> _sprites = new List<Sprite>();
    private SpriteRenderer _spriteRenderer;

    private int _sprite;
    private FinishMenu _menu;
    private Timer _timer;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(Change());

        _menu = FindObjectOfType<FinishMenu>(true);
        _timer = FindObjectOfType<Timer>();
    }

    private IEnumerator Change()
    {
        var second = new WaitForSeconds(1.95f);
        while (_sprite <= 30)
        {
            yield return second;
            _spriteRenderer.sprite = _sprites[_sprite];
            _sprite++;
        }
        _menu.gameObject.SetActive(true);
        _timer.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
