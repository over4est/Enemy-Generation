using System.Collections.Generic;
using UnityEngine;

public class ObjectPool<T> where T : MonoBehaviour
{
    private T _prefab;
    private Transform _conteiner;
    private Stack<T> _pool;

    public ObjectPool(T prefab, int objectCount, Transform container)
    {
        _prefab = prefab;
        _conteiner = container;

        CreatePool(objectCount);
    }

    public bool TryGet(out T @object)
    {
        @object = null;

        if (HasFreeElement(out var element))
        {
            @object = element;
            element.gameObject.SetActive(true);

            return true;
        }

        return false;
    }

    private bool HasFreeElement(out T element)
    {
        if (_pool.TryPop(out element))
        {
            return true;
        }

        return false;
    }

    private void CreatePool(int count)
    {
        _pool = new Stack<T>();

        for (int i = 0; i < count; i++)
        {
            T obj = CreateObject();

            _pool.Push(obj);
        }
    }

    private T CreateObject(bool isActiveByDefault = false)
    {
        var newObject = Object.Instantiate(_prefab, _conteiner);

        newObject.gameObject.SetActive(isActiveByDefault);

        return newObject;
    }
}