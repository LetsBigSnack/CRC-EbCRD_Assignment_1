using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int health = 100;
    [SerializeField] private int coins = 0;
    public static GameManager Instance;

    public int GetHealth()
    {
        return health;
    }

    public void DecreaseHealth(int amount)
    {
        health -= amount;
    }
    
    public void IncreaseHealth(int amount)
    {
        health += amount;
    }
    
    public void DecreaseCoins(int amount)
    {
        coins -= amount;
    }
    
    public void IncreaseCoins(int amount)
    {
        coins += amount;
    }

    
    // Start is called before the first frame update
    void Awake()
    {
        if (Instance != null)
        {
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Collected Coins:" + coins);
        Debug.Log("Player Health:" + health);
    }
}
