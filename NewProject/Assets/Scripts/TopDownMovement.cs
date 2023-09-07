using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;
    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }

    
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection); // 이 코드는 어디에 이용되는 것인가.
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
}
