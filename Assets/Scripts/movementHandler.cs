using UnityEngine;

public class movementHandler : MonoBehaviour
{
    playerInput playerInput;
    [SerializeField]float movementSpeed = 3;
    bool isWalking;

    void Awake()
    {
        playerInput = GetComponent<playerInput>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerInput.GetPlayerMovementDir() != Vector3.zero)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        transform.position += playerInput.GetPlayerMovementDir() * Time.deltaTime * movementSpeed;
        transform.forward = Vector3.Slerp(transform.forward,playerInput.GetPlayerMovementDir(),Time.deltaTime * movementSpeed);
    }

    public bool GetIsWalking() => isWalking;
}
