using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAction : MonoBehaviour
{
    private PlayerController _controller;

    private Vector2 _dirVec = Vector2.zero;

    private void Awake()
    {
        _controller = GetComponent<PlayerController>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Direction;
    }

    private void FixedUpdate()
    {
        //ApplyVector(dirVec);
    }

    private void Direction(Vector2 direction)
    {
       // _dirVec = 
    }

    //private void Move(Vector2 direction)
    //{
    //    _movementDirection = direction;
    //    _animator.SetFloat("VerticalFloat", direction.y);
    //    _animator.SetFloat("HorizontalFloat", direction.x);
    //}

    //private void ApplyVector(Vector2 direction)
    //{
    //    dirVec

    //    _rigidbody.velocity = direction;
    //}

}
