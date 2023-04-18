using UnityEngine;

public class Finish : MonoBehaviour
{
    private FinishMenu _menu;
    private Timer _timer;

    private void Start()
    {
        _menu = FindObjectOfType<FinishMenu>(true);
        _timer = FindObjectOfType<Timer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out SpriteChange player))
        {
            _timer.Stop();
            _menu.gameObject.SetActive(true);
            player.gameObject.SetActive(false);
        }
    }
}
