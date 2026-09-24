using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    GameManager manager;
    PlayerBasic player;
    public InputActionReference pause;
    public InputActionReference kill;
    public InputActionReference attack1;
    public InputActionReference attack2;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //find game manager object
        manager = FindAnyObjectByType<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        pause.action.started += Pause;
        kill.action.started += Kill;
        attack1.action.started += Attack1;
        attack2.action.started += Attack2;
    }


    private void OnDisable()
    {
        pause.action.started -= Pause;
        kill.action.started -= Kill;
        attack1.action.started -= Attack1;
        attack2.action.started -= Attack2;
    }

    private void Pause(InputAction.CallbackContext context)
    {
        manager.Pause();
    }

    private void Kill(InputAction.CallbackContext context)
    {
        //Debug.Log("Action completed");
        manager.VillagerKilled(5);
    }


    private void Attack1(InputAction.CallbackContext context)
    {
        manager.PlayerAttackCall(1);
    }
    private void Attack2(InputAction.CallbackContext context)
    {
        manager.PlayerAttackCall(2);
    }

}
