using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}
