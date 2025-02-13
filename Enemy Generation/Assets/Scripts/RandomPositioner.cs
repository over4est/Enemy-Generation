using System.Collections.Generic;
using UnityEngine;

public class RandomPositioner : MonoBehaviour
{
    public Vector3 GetPositon(List<Transform> points)
    {
        int randomIndex = Random.Range(0, points.Count);
        Vector3 position = points[randomIndex].position;

        return position;
    }
}