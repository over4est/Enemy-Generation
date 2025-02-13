using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _movementSpeed; 

    public void Move(Vector3 wayPoint)
    {
        float step = _movementSpeed * Time.deltaTime;

        transform.position = Vector3.MoveTowards(transform.position, wayPoint, step);
    }
}