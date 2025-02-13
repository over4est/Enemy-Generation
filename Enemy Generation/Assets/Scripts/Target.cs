using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Mover))]
public class Target : MonoBehaviour
{
    [SerializeField] private List<Transform> _wayPoints;

    private Mover _mover;
    private int _currentWayPoint = 0;

    private void Awake()
    {
        _mover = GetComponent<Mover>();
    }

    private void Update()
    {
        if (transform.position == _wayPoints[_currentWayPoint].position)
        {
            _currentWayPoint = (_currentWayPoint + 1) % _wayPoints.Count;
        }

        Vector3 wayPointPosition = _wayPoints[_currentWayPoint].position;

        _mover.Move(wayPointPosition);
    }
}
