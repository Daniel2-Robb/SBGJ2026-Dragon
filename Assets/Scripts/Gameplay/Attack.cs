using UnityEngine;

public class Attack : MonoBehaviour
{
    BoxCollider2D hurt_box;

    [Range(5, 25)]
    [Tooltip("Damage of the attack")]
    [SerializeField] int damage;

    private void Awake()
    {
        hurt_box = GetComponent<BoxCollider2D>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Collided object: " +  collision.gameObject);

        EnemyBasic enemy = collision.GetComponent<EnemyBasic>();
        enemy.UpdateHealth(damage);
        gameObject.SetActive(false);
    }
}
