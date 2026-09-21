using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    //variables
    GameManager manager;
    int health = 10;
    int loot = 10;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            manager.VillagerKilled(loot);
        }
    }

}
