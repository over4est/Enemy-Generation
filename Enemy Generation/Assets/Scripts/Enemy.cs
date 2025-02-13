using UnityEngine;

[RequireComponent(typeof(Chaser))]
public class Enemy : MonoBehaviour
{
    private Transform _target;
    private Chaser _mover;

    private void Awake()
    {
        _mover = GetComponent<Chaser>();
    }

    private void Update()
    {
        _mover.Chase(_target.position);
    }

    public void SetTarget(Transform target)
    {
        _target = target;
    }
}