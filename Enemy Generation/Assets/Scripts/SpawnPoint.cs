using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Enemy _prefab;

    private ObjectPool<Enemy> _enemyPool;
    private int _poolSize = 10;

    private void Awake()
    {
        _enemyPool = new ObjectPool<Enemy>(_prefab, _poolSize, transform);
    }

    public void Spawn()
    {
        Enemy enemy = _enemyPool.Get();

        if (enemy != null)
        {
            enemy.transform.position = transform.position;
            enemy.SetTarget(target);
        }
    }
}
