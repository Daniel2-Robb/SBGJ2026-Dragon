using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    //variables
    GameManager manager;
    int health = 10;
    int loot = 5;

    public Rigidbody2D rb;
    public float moveSpeed;
    public string direction = "Right";


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();
    }

    private void OnEnable()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "Right")
        {
            rb.linearVelocity = new Vector2(1 * moveSpeed, 0);
        }
        else if (direction == "Left")
        {
            rb.linearVelocity = new Vector2(-1 * moveSpeed, 0);
        }
    }

    public void UpdateHealth(int damage)
    {
        health -= damage;

        Debug.Log("Taken " + damage + " damage");


        if (health <= 0)
        {
            manager.VillagerKilled(loot);
            //gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    public void UpdateLoot(int money)
    {
        loot += money;
    }

    public void ChangeDirection()
    {
        switch (direction)
        {
            case ("Right"):
                direction = "Left";
                gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
                break;
            case ("Left"):
                direction = "Right";
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
        }
    }
}
