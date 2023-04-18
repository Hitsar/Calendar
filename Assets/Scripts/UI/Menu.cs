using System.Runtime.InteropServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ShowAdv();
    
    [SerializeField] private GameObject _startButton;
    [SerializeField] private TMP_Text _recordText; 

    private void Start()
    {
        _recordText.text = Progress.Instance.PlayerInfo.Time.ToString();
        _startButton.transform.DOScale(Vector2.one, 1).SetEase(Ease.OutElastic).OnComplete(() =>
        {
            _startButton.transform.DOScale(new Vector2(1.1f, 1.1f), 0.7f).SetEase(Ease.InOutCubic)
                .SetLoops(-1, LoopType.Yoyo);
        });
        _recordText.transform.DOLocalMoveY(-150, 1).SetEase(Ease.OutBack);
        ShowAdv();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
