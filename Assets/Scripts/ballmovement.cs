using UnityEngine;

public class ballmovement : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Vector2 launchForce;
    bool isBallLaunched;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
      if (Input.GetButtonDown("Launch") && !isBallLaunched)
        {
            isBallLaunched = true;
            rb.AddForce(launchForce);
            transform.parent = null;
        }
    }
}
