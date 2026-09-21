using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    GameManager manager;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Dead()
    {

    }
}
