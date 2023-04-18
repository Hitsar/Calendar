using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void SetToLeaderboard(float value);
    
    [SerializeField] private TMP_Text _text;
    private float _time;

    private bool _isWork = true;

    private void Update()
    {
        if (_isWork)
        {
            _time += Time.deltaTime;
            _text.text = _time.ToString();
        }
    }

    public void Stop()
    {
        _isWork = false;
        if (Progress.Instance.PlayerInfo.Time > _time || Progress.Instance.PlayerInfo.Time < 20)
        {
            Progress.Instance.PlayerInfo.Time = _time;
            SetToLeaderboard(_time);
            Progress.Instance.Save(); 
        }
    }
}
