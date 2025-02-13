using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    private Mover _mover;
    private Vector3 _movementDirection;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void FixedUpdate()
    {
        _mover.Move(_movementDirection, _movementSpeed);
    }

    public void SetMovementDirection(Vector3 vector)
    {
        if (vector != Vector3.zero)
        {
            _movementDirection = vector;
        }
    }
}