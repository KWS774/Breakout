using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        Broken();
        Instantiate(collision.gameObject);
        GameManager.Instance.BallManager.ChangeBallCount(1);
    }

    public void Broken()
    {
        GameManager.Instance.ScoreManager.AddScore(300);
    }

}
