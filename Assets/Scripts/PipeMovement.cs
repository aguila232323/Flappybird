using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float PipeVolocity = 0.65f;
    [SerializeField] private float timeToLive;
    private Rigidbody2D rigidbody;


    void Update()
    {
        transform.position += Vector3.left * PipeVolocity * Time.deltaTime;
        if (timeToLive< Time.deltaTime)
        {
            gameObject.SetActive(false);
        }
    }
}
