using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeCreator : MonoBehaviour
{
    [SerializeField] private float maxTime = 1.5f;
    [SerializeField] private float heightRange = 0.45f;
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
        GameObject pipe2 = PipePool.instance.GetObjectPooled();

        if (pipe2 != null )
        {
            Debug.Log("HOLAAAA");
            pipe2.transform.position = spawnerPosi;
            pipe2.SetActive(true);
        }
    }
}
