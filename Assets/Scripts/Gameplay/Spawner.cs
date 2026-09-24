using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //variables
    GameManager manager;
    [SerializeField] GameObject EnemyPrefab;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();
        spawn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawn()
    {
        Instantiate(EnemyPrefab, transform.position, Quaternion.identity);
    }

    public void AddEnemy()
    {

    }
}
