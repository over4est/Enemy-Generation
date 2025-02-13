using System.Collections.Generic;
using UnityEngine;

public class RandomPicker : MonoBehaviour
{
    public SpawnPoint GetElement(List<SpawnPoint> points)
    {
        int randomIndex = Random.Range(0, points.Count);
        SpawnPoint spawnPoint = points[randomIndex];

        return spawnPoint;
    }
}