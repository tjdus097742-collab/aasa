using UnityEngine;

public class SimpleTranslate : MonoBehaviour
{
    public float delta = 5.0f;

    private void Update()
    {
        Vector3 vec = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        transform.Translate(vec*Time.deltaTime);
    }
}
