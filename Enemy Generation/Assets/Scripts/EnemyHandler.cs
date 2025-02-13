using System.Collections.Generic;
using UnityEngine;

public class EnemyHandler : MonoBehaviour
{
    [SerializeField] private RandomPicker _randomPicker;
    [SerializeField] private List<SpawnPoint> _spawnPoints;

    [Header("Spawn Timer")]
    [SerializeField] private Timer _timer;
    [SerializeField] private float _spawnRate;

    private void OnEnable()
    {
        _timer.StartTimer(_spawnRate);
        _timer.TimerTicked += Spawn;
    }

    private void OnDisable()
    {
        _timer.TimerTicked -= Spawn;
    }

    private void Spawn()
    {
        SpawnPoint randomSpawnPoint = _randomPicker.GetElement(_spawnPoints);

        randomSpawnPoint.Spawn();
    }
}