using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Enemy _prefab;

    private ObjectPool<Enemy> _enemyPool;
    private int _poolSize = 10;

    private void Awake()
    {
        _enemyPool = new ObjectPool<Enemy>(_prefab, _poolSize, transform);
    }

    public void Spawn()
    {
        if (_enemyPool.TryGet(out Enemy enemy))
        {
            enemy.transform.position = transform.position;
            enemy.SetTarget(target);
        }
    }
}