using UnityEngine;

public class Chaser : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;

    public void Chase(Vector3 target)
    {
        Vector3 direction = (target - transform.position).normalized;

        transform.Translate(direction * _movementSpeed * Time.deltaTime, Space.World);
    }
}