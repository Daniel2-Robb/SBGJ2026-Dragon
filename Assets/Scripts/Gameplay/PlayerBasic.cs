using UnityEngine;

public class PlayerBasic : MonoBehaviour
{
    //Variables
    GameManager manager;
    int hoard_size = 0;
    [SerializeField] BoxCollider2D a1_hurt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get game manager object
        manager = FindAnyObjectByType<GameManager>();
        manager.UIUpdate("Hoard", hoard_size);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoardIncrease(int increase)
    {
        //increase scale of hoard and player sprites based on hoard_size
        hoard_size += increase;
        manager.UIUpdate("Hoard", hoard_size);
    }

    public void Attack(int attackIndex)
    {
        switch (attackIndex)
        {
            case (1):
                //Attack 1 - Swipe
                a1_hurt.gameObject.SetActive(true);
                //After X time, disable a1_hurt

                break;
            case (2):
                //Attack 2 - Fire Breath
                break;
        }

    }
}
