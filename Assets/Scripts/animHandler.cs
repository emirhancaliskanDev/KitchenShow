using UnityEngine;
using System;

public class animHandler : MonoBehaviour
{
    Animator playerAnimator;
    [SerializeField]movementHandler movementHandler;
    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
    }
    
    void Update()
    {
        playerAnimator.SetBool("IsWalking",movementHandler.GetIsWalking());
    }
}
