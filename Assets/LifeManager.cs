using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeManager : MonoBehaviour
{
    [SerializeField] private long lives;
    public long Lives => lives;

    // Start is called before the first frame update
    public event Action<long> OnlivesChange;


    void Start()
    {
        Resetlife();
    }

    public void Resetlife()
    {
        lives = 3;
        OnlivesChange?.Invoke(lives);
    }

    public void DropBall()
    {
        lives--;
        OnlivesChange?.Invoke(lives);
    }
    public void ChangeLife(int amount)
    {
        this.lives += amount;
        if (this.lives < 0)
        {
            GameManager.Instance.GameOver();
            return;
        }
        if (this.lives > 99)
        {
            this.lives = 99;
        }

    }
}
