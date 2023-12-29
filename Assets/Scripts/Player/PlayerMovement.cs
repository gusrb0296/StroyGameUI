using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private PlayerController _controller;

    private Vector2 _movementDirection = Vector2.zero;
    private Vector2 _dirVec = Vector2.zero;
    private Rigidbody2D _rigidbody;
    private Animator _animator;
    private GameObject _scanObject;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponentInChildren<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && _scanObject != null)
        {
            Debug.Log("This is " + _scanObject.name);
        }
    }

    private void FixedUpdate()
    {
        ApplyMovment(_movementDirection);
        Debug.DrawRay(_rigidbody.position, _dirVec * 1.5f, new Color(1, 0, 0));
        RaycastHit2D rayHit = Physics2D.Raycast(_rigidbody.position, _dirVec, 1.5f, LayerMask.GetMask("Object"));

        if(rayHit.collider != null)
        {
            _scanObject = rayHit.collider.gameObject;
        }
        else 
        {
            _scanObject = null; 
        }
    }

    private void Move(Vector2 direction)
    {
        _movementDirection = direction;

        if(direction.magnitude != 0 )
        {
            _dirVec = direction;
        }

        _animator.SetFloat("VerticalFloat", direction.y);
        _animator.SetFloat("HorizontalFloat", direction.x);
    }

    private void ApplyMovment(Vector2 direction)
    {
        direction = direction * 5;

        _rigidbody.velocity = direction;
    }
}
