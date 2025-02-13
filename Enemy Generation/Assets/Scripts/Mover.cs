using UnityEngine;

public class Mover : MonoBehaviour
{
    public void Move(Vector3 vector, float speed)
    {
        if (vector != Vector3.zero)
        {
            transform.Translate(vector.normalized * speed);
        }
    }
}