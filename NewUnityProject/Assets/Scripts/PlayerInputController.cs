using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownCharacterController
{
    private Camera _camera;

    [SerializeField] private SpriteRenderer characterRender;
    private bool isFacingRight = true;


    private void Awake()
    {
        _camera = Camera.main; 
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveInput = value.Get<Vector2>().normalized; // nomalrize & nomalized차이와 정확한 의미 찾아 보기 
        CallMoveEvent(moveInput);
    }

    //public void OnLook(InputValue value)
    //{
    //    Vector2 newAim = value.Get<Vector2>();
    //    Vector2 wolrdPos = _camera.ScreenToWorldPoint(newAim);
    //    newAim = (wolrdPos - (Vector2)transform.position).normalized;

    //    if (newAim.magnitude >= .9f) // magnitude가 뭔지 찾아보기 
    //    {
    //        CallLookEvent(newAim);
    //    }
    //} // 지금 사용 안함

    private void Update()
    {
        float flipInput = Input.GetAxis("Horizontal");

        if (flipInput < 0 && isFacingRight) // 왼쪽으로 가는 입력을 감지하면서 현재 오른쪽을 보고 있을 때
        {
            Flip();
        }
        else if (flipInput > 0 && !isFacingRight) // 오른쪽으로 가는 입력을 감지하면서 현재 왼쪽을 보고 있을 때
        {
            Flip();
        }
    }
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        characterRender.flipX = !isFacingRight;
    }
}
