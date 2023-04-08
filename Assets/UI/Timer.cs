using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
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

    public void Stop() => _isWork = false;
}
