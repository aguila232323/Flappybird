using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePool : MonoBehaviour
{
    public static PipePool instance;
    private int sizePool = 5;
    private List<GameObject> pooledObjects = new List<GameObject>();
    [SerializeField] private GameObject pipePrefab;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    void Start()
    {
        for (int i = 0; i < sizePool; i++)
        {
            GameObject @object = Instantiate(pipePrefab);
            @object.SetActive(false);
            pooledObjects.Add(@object);
        }
    }

    public GameObject GetObjectPooled()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }
        return null;
    }
}
