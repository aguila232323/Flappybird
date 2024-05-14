using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    [SerializeField] private float PipeVolocity = 0.65f;
    [SerializeField] private float timeToLive;
    private float timeLived;


    void Update()
    {
        timeLived += Time.deltaTime;
        transform.position += Vector3.left * PipeVolocity * Time.deltaTime;
        if (timeToLive< timeLived)
        {
            gameObject.SetActive(false);
            timeLived = 0;
        }
    }
}
