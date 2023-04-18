using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;
    private bool _isGround;
    private float _moveInput;

    private void Start()
    {
        _rigidbody = GetComponentInParent<Rigidbody2D>();
    }

    private void Update()
    {
        _moveInput = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.Space) && _isGround)
        {
            _rigidbody.velocity = new Vector2(_moveInput, 0);
            _rigidbody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate() => _rigidbody.velocity = new Vector2(_moveInput * _speed, _rigidbody.velocity.y);

    private void OnCollisionStay2D(Collision2D collision) => _isGround = true;

    private void OnCollisionExit2D(Collision2D collision) => _isGround = false;
}