using UnityEngine;

public class AirplaneController : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        // Máy bay bay liên tục về phía trước
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}