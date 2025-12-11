using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private int ballCount = 1;
    public int BallCount => ballCount;
    public void ChangeBallCount(int n)
    {
        ballCount += n;
        if (ballCount <= 0)
        {
            GameManager.Instance.LifeManager.ChangeLife(-1);

            GameManager.Instance.RestartGame();
        }
    }

    public void ResetBallCount()
    {
        ballCount = 1;
    }

}
