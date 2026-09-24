using UnityEngine;

public class EnemyBasic : MonoBehaviour
{
    //variables
    GameManager manager;
    int health = 10;
    int loot = 10;

    public Rigidbody2D rb;
    public float moveSpeed;
    //private Vector2 moveDirection; //find out what default value needs to be for right


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();

        gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    private void OnEnable()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = new Vector2(1 *  moveSpeed, 0);
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
}
