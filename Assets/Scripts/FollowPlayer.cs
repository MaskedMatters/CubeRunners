// Libraries
using UnityEngine;

// Script class | All script
public class FollowPlayer : MonoBehaviour
{

    public Transform playerT;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerT.position + offset;
    }

}
