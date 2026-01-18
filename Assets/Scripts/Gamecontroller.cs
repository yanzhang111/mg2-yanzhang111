using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static GameController instance;

    public TMP_Text pointsText;
    public GameObject coinPrefab;

    private int points = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        pointsText.text = "points: 0";
        InvokeRepeating("SpawnCoin", 1f, 1.2f);
    }

    public void AddPoint()
    {
        points++;
        pointsText.text = "points: " + points;
    }

    void SpawnCoin()
    {
        float randomY = Random.Range(11.8f, 14f);

        Vector3 spawnPos = new Vector3(10f, randomY, 0);
        Instantiate(coinPrefab, spawnPos, Quaternion.identity);
    }
}