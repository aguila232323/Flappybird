using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdder : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Score.Instance.UpdateScore();
        }
    }

}
