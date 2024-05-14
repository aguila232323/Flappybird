using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour

{
    public static Score Instance;

    [SerializeField] private TextMeshProUGUI currentScore;
    [SerializeField] private TextMeshProUGUI highScore;
    private int score;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }
    private void Start()
    {
        currentScore.text = score.ToString();
        highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
        UpdateHighScore();
    }
    private void UpdateHighScore()
    {
        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore",score);
            highScore.text=score.ToString();
        }
    }
    public void UpdateScore()
    {
        score++;
        currentScore.text = score.ToString();
        UpdateHighScore();
    }

}
