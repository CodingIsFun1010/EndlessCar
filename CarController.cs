using UnityEngine;

public class CarController : MonoBehaviour
{
    public float speed = 30f;
    public Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            transform.position = startPos;
            ScoreManager.Instance.ResetScore();
        }
    }
}
