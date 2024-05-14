using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FliyingBird : MonoBehaviour
{
    [SerializeField] private float speed = 1.5f;
    [SerializeField] private float rotationSpeed = 10f;
    private Rigidbody2D rigidbody2;
    private void Start()
    {
        rigidbody2 = GetComponent<Rigidbody2D>();
    }
  

   private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            rigidbody2.velocity = Vector2.up * speed;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.EulerRotation(0, 0, rigidbody2.velocity.y * rotationSpeed);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.Instance.GameOver();
    }
}
