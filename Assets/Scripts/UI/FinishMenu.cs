using System.Runtime.InteropServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishMenu : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();
    
    [SerializeField] private GameObject _restartButton, _exitButton;
    [SerializeField] private Image _image;

    private void OnEnable()
    {
        _image.DOFade(0.7f, 0.4f).SetEase(Ease.InOutCubic);
        _restartButton.transform.DOScale(Vector2.one, 0.6f).SetEase(Ease.OutCubic);
        _exitButton.transform.DOLocalMoveY(-100, 0.4f).SetEase(Ease.OutBack).SetDelay(1);
        ShowAdv();
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        SceneManager.LoadScene(0);
    }

}
