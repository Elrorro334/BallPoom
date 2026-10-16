using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] float speed;
    float bounds = 9.7f;
    void Start()
    {
    }

    void Update()
    {
        float xinput = Input.GetAxisRaw("Horizontal");
        float newpositionx = transform.position.x + speed * xinput * Time.deltaTime;
        if (newpositionx < bounds && newpositionx > -bounds)
        {
            transform.position += new Vector3(speed * xinput * Time.deltaTime, 0f, 0f);

        }

    }
}