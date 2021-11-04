using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterMotor))]
[RequireComponent(typeof(PlayerInteraction))]
public class PlayerController : MonoBehaviour
{
    private Vector2 playerDirection;
    public Vector2 mousePosition;

    private CharacterMotor characterMotor;
    private PlayerInteraction PlayerInteraction;

    void Start()
    {
        characterMotor = GetComponent<CharacterMotor>();
        PlayerInteraction = GetComponent<PlayerInteraction>();
    }

    void FixedUpdate()
    {
        if(playerDirection != Vector2.zero)
        {
            characterMotor.MoveToDirection(playerDirection);
        }
    }

    private void ChangeDirection(Vector2 _newDirection)
    {
        if (_newDirection != Vector2.zero)
        {
            if (playerDirection != _newDirection)
            {
                /* TODO: 
                   - Change the direction the player is facing
                    - Play walking animation
                */
            }
        }
        else
        {
            /* TODO: 
               - Play iddle animation
            */
        }

        playerDirection = _newDirection;
    }

    #region Inputs

    public void OnMoveInput(InputValue value) => ChangeDirection(value.Get<Vector2>());


    public void OnMouseChangePosition(InputValue value)
    {
        Vector2 _newPosition = value.Get<Vector2>();

        mousePosition = Camera.main.ScreenToWorldPoint(_newPosition);
    }

    public void OnInteractionInput()=> PlayerInteraction.CheckForInteractable(mousePosition);
    

    #endregion
}
