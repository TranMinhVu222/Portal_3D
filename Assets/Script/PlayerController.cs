using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour,IAgentInput
{
    public Vector2 MovementVector { get;set};

    public event Action OnAttack;
    public event Action OnJumpPressed;
    public event Action OnJumpreleased;
    public event Action<Vector2> OnMovement;
    public event Action OnWeaponChange;
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
