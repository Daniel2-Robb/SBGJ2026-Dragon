using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputManager : MonoBehaviour
{
    GameManager manager;
    //[SerializeField] private InputActionAsset playerInput;
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
        kill.action.started += Kill;
        attack1.action.started += Attack(1);
        attack2.action.started += Attack(2);
    }

    private void OnDisable()
    {
        kill.action.started -= Kill;
        attack1.action.started -= Attack(1);
        attack2.action.started -= Attack(2);
    }

    private void Kill(InputAction.CallbackContext context)
    {
        //Debug.Log("Action completed");
        manager.VillagerKilled(5);
    }

    private Action<InputAction.CallbackContext> Attack(int attackIndex)
    {
        manager.PlayerAttackCall(attackIndex);

        //throw new NotImplementedException();
        return null;
    }

}
