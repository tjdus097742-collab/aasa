using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public Vector3 offset = new Vector3(0, 5, -7);

    //LateUpdate 에서 하는게 좋음
    void LateUpdate()
    {
        if (target == null)
            return;
        transform.position = target.position = offset;
    }
}
