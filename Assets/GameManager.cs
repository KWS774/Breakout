using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

//‚µ‚½‚¢‚±‚Æ
//ballcountŽü‚è‚Ìˆµ‚¢
//block‚Ìcount
//


public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;
    [SerializeField] private ScoreManager scoreManager;
    [SerializeField] private TimeManager timeManager;
    [SerializeField] private BallManager ballManager;
    
    //[SerializeField] float ballcount;

    public ScoreManager ScoreManager => scoreManager;
    public TimeManager TimeManager => timeManager;
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

    public void Restart()
    {
        scoreManager.ResetScore();
        timeManager.ResetTime();

        SceneManager.LoadScene("InGame");
        Debug.Log("ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚Ü‚µ‚½");


    }


    public void GameOver()
    {

    }

    
}
