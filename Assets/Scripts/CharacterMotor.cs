using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMotor : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rigidbody2D;

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void MoveToDirection(Vector2 direction)
    {
        Vector2 _nextPosition = transform.position;
        _nextPosition += direction * speed * Time.fixedDeltaTime;

        rigidbody2D.MovePosition(_nextPosition);
    }  
}
