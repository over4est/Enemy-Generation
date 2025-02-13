using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Vector3 _enemiesMovementDirection;
    [SerializeField] private RandomPositioner _positioner;
    [SerializeField] private List<Transform> _spawnPoints;

    [Header("Spawn Timer")]
    [SerializeField] private SpawnTimer _spawnTimer;
    [SerializeField] private float _spawnRate;

    [Header("Pool Settings")]
    [SerializeField] private int _poolSize;
    [SerializeField] private Transform _container;
    [SerializeField] private Enemy _enemyPrefab;

    private ObjectPool<Enemy> _enemyPool;

    private void Awake()
    {
        _enemyPool = new ObjectPool<Enemy>(_enemyPrefab, _poolSize, _container);
    }

    private void OnEnable()
    {
        _spawnTimer.StartTimer(_spawnRate);
        _spawnTimer.TimerTicked += Spawn;
    }

    private void OnDisable()
    {
        _spawnTimer.TimerTicked -= Spawn;
    }

    private void Spawn()
    {
        Enemy enemy = _enemyPool.Get();

        if (enemy != null)
        {
            enemy.transform.position = _positioner.GetPositon(_spawnPoints);
            enemy.SetMovementDirection(_enemiesMovementDirection);
        }
    }
}