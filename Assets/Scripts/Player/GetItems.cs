using TMPro;
using UnityEngine;

public class GetItems : MonoBehaviour
{
    [SerializeField] private GameObject _barrier;
    [SerializeField] private TMP_Text _text;
    private byte _itemsCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Item item))
        {
            _itemsCount++;
            _text.text = _itemsCount.ToString();
            collision.gameObject.SetActive(false);
            if (_itemsCount == 31)
            {
                _barrier.SetActive(false);
            }
        }
    }
}
