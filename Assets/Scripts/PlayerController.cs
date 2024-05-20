using UnityEngine;  
  
[RequireComponent(typeof(CharacterController))]  
public class PlayerController : MonoBehaviour  
{  
    private CharacterController _controller;  
    private float _horizontalMove, _verticalMove;  
    private Vector3 _direction;  
  
    private const float _gravity = 9.81f;
    
    [SerializeField] private float speed = 5;  
    [SerializeField] private float jumpForce = 9;  
  
    private void Start() => _controller = GetComponent<CharacterController>();
    
    private void FixedUpdate() => Move();  
  
    private void Move()  
    {
	    _horizontalMove = Input.GetAxis("Horizontal");  
        _verticalMove = Input.GetAxis("Vertical");  
  
        if (_controller.isGrounded)  
        {
	        _direction = new Vector3(_horizontalMove, 0, _verticalMove);  
            _direction = transform.TransformDirection(_direction);  
        }
        
        if (_controller.isGrounded && Input.GetKeyDown(KeyCode.Space))  
        {
	        _direction.y = jumpForce;  
        }  
        _direction.y -= _gravity * Time.deltaTime;  
        _controller.Move(_direction * speed * Time.deltaTime);  
    }
}