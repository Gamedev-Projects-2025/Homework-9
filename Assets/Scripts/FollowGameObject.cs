using UnityEngine;

public class FollowGameObject : MonoBehaviour
{
    public Transform target;

    private void Start()
    {
        transform.position = target.position;
        transform.SetParent(target);
    }
}