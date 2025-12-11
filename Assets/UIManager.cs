using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI lifeText;
    private ScoreManager scoreManager;
    private TimeManager timeManager;
    private LifeManager lifeManager;

    // Start is called before the first frame update

    private void Start()
    {
        scoreManager = GameManager.Instance.ScoreManager;
        timeManager = GameManager.Instance.TimeManager;
        lifeManager = GameManager.Instance.LifeManager;
        scoreManager.OnScoreChange += UpdateScore;
        lifeManager.OnlivesChange += UpdateLife;
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

    private void UpdateLife(long newlife)
    {
        lifeText.text = newlife.ToString();
    }
}
