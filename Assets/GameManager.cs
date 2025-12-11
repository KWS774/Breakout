using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//したいこと
//ballcount周りの扱い
//blockのcount
//


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TimeManager timeManager;
    [SerializeField] private LifeManager lifeManager;
    [SerializeField] private BallManager ballManager;
    [SerializeField] private GameObject ball;

    //[SerializeField] float ballcount;

    public ScoreManager ScoreManager => scoreManager;
    public TimeManager TimeManager => timeManager;
    public LifeManager LifeManager => lifeManager;
     public BallManager BallManager => ballManager;

    // Start is called before the first frame update
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);

        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    public void ResetGame()
    {
        scoreManager.ResetScore();
        timeManager.ResetTime();
        lifeManager.Resetlife();
        ballManager.ResetBallCount();


        SceneManager.LoadScene("InGame");
        Debug.Log("ボタンが押されました");

    }

    public void RestartGame()
    {
        //ボタンを感知する
        if (ballManager.BallCount > 0) return;

        ballManager.ResetBallCount();
        Instantiate(ball);
        //ボールを複製する


    }



    public void GameOver()
    {
        
    }

    
}
