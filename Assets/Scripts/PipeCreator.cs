using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreator : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;
    private float timer;
    void Start()
    {
        createPipe();
    }

    private void Update()
    {
        if (timer > maxTime)
        {
            createPipe();
            timer = 0;
        }

        timer += Time.deltaTime;
    }



    void createPipe()
    {
        Vector3 spawnerPosi = transform.position + new Vector3(0, Random.Range(-heightRange, heightRange));
        GameObject pipe = Instantiate(_pipe,spawnerPosi,Quaternion.identity);
        
        Destroy(pipe,6f);
    }
}
