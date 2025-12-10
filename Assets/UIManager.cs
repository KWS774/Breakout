using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    private ScoreManager scoreManager;
    private TimeManager timeManager;

    // Start is called before the first frame update

    private void Start()
    {
        scoreManager = GameManager.Instance.ScoreManager;
        timeManager = GameManager.Instance.TimeManager;
        scoreManager.OnScoreChange += UpdateScore;
    }

    private void Update()
    {
        timeText.text = ((int)timeManager.TotalTime).ToString();

    }

    private void OnDestroy()
    {
        if (scoreManager != null)
            scoreManager.OnScoreChange -= UpdateScore;
    }

    private void UpdateScore(long newscore)
    {
        scoreText.text = newscore.ToString();
    }

}
