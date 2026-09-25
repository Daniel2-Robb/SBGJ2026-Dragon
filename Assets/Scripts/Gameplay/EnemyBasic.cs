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

    bool escaping = false;


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

        if (!GetComponent<Renderer>().isVisible && escaping)
        {
            manager.VillagerKilled(0);
            Destroy(gameObject);
        }
    }

    public void UpdateHealth(int damage)
    {
        health -= damage;

        Debug.Log("Taken " + damage + " damage");


        if (health <= 0)
        {
            manager.VillagerKilled(loot);
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
                escaping = true;
                break;
            case ("Left"):
                direction = "Right";
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                escaping = false;
                break;
        }
    }
}
