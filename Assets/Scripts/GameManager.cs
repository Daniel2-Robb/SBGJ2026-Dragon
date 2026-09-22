using UnityEngine;

public enum GameState
{
    GAMEPLAY, PAUSE
};

public class GameManager : MonoBehaviour
{
    //variables
    public GameState state;
    private bool gameStateChanged = false;
    [SerializeField] GameObject player_ui;
    [SerializeField] GameObject pause_menu;
    PlayerBasic player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //get player object
        player = FindAnyObjectByType<PlayerBasic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        //Changing states between gameplay and paused if needed
        if(gameStateChanged)
        {
            gameStateChanged = false;

            switch(state)
            {
                case GameState.GAMEPLAY:
                    //Set timescale so that physics interctions occur
                    Time.timeScale = 1.0f;

                    //Turn off pause menu, turn on main UI
                    //pause_menu.SetActive(false);
                    //player_ui.SetActive(true);

                    break;

                case GameState.PAUSE:
                    //Set timescale so that physics interctions don't occur
                    Time.timeScale = 0.0f;

                    //Turn off pause menu, turn on main UI
                    //pause_menu.SetActive(true);
                    //player_ui.SetActive(false);
                    break;
            }
        }
    }

    public void Pause()
    {
        switch (state)
        {
            case GameState.GAMEPLAY:
                state = GameState.PAUSE;
                gameStateChanged = true;

                Debug.Log("Paused");

                break;

            case GameState.PAUSE:
                state = GameState.GAMEPLAY;
                gameStateChanged = true;

                Debug.Log("Unpaused");

                break;


        }
    }

    public void VillagerKilled (int loot) 
    {
        player.HoardIncrease(loot);
        Debug.Log("Enemy Killed");
    }

    public void PlayerAttackCall(int attackIndex)
    {
        player.Attack(attackIndex);
    }
}
