using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDowmAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRender; //무기 없이 캐릭터만 움직이게 할 것이니까 하나만 달아주기 

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        _controller.OnMoveEvent += OnAim;
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotz = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // 무슨의미일까 찾아보기 .
        characterRender.flipX = Mathf.Abs(rotz) > 90f;
    }

}
