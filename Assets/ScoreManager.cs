using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private long totalScore;
    public long TotalScore => totalScore;

    // Start is called before the first frame update
    public event Action<long> OnScoreChange;


    void Start()
    {
        ResetScore();
    }

    public void ResetScore()
    {
        totalScore = 0;
        OnScoreChange?.Invoke(totalScore);
    }

    public void AddScore(int score)
    {
        totalScore += score;
        OnScoreChange?.Invoke(totalScore);
    }
}
