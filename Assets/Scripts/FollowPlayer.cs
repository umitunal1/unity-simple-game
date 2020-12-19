using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
        offset = new Vector3();
        offset.x = 0;
        offset.y = 2;
        offset.z = -3;
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
