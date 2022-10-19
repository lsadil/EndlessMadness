using UnityEngine;

public class BallMove : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Vector2 forceBall;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

   void Start()
   {
       _rb.AddForce(forceBall);
   }
}
