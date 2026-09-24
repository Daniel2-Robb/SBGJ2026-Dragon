using NUnit.Framework;
using UnityEngine;

public class Attack : MonoBehaviour
{
    BoxCollider2D hurt_box;

    [UnityEngine.Range(5, 25)]
    [Tooltip("Damage of the attack")]
    [SerializeField] int damage;

    float timer;
    bool timer_active = false;

    [UnityEngine.Range(0, 10)]
    [SerializeField] float attackLength;

    private void Awake()
    {
        hurt_box = GetComponent<BoxCollider2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnEnable()
    {
        timer = attackLength;
        timer_active = true;

    }

    // Update is called once per frame
    void Update()
    {
        if (timer_active) 
        {
            timer -= Time.deltaTime;
            //Debug.Log("Timer: " + timer);

            if(timer <= 0)
            {
                timer_active = false;
                gameObject.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided object: " +  collision.gameObject);

        EnemyBasic enemy = collision.GetComponent<EnemyBasic>();
        enemy.UpdateHealth(damage);
    }
}
