using UnityEngine;

public class PlayerBasic : MonoBehaviour
{
    //Variables
    GameManager manager;
    public int hoard_size = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get game manager object
        manager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HoardIncrease(int increase)
    {
        //increase scale of hoard and player sprites based on hoard_size
    }

}
