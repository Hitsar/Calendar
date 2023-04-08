using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _startButton;

    private void Start()
    {
        _startButton.transform.DOScale(Vector2.one, 0.8f).SetEase(Ease.OutElastic);
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
