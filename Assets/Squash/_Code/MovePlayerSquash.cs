using UnityEngine;

public class MovePlayerSquash : MonoBehaviour
{
    public float speed = 10f;
    public Vector2 moveForce;
    private Rigidbody2D _rb;
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>(); // on récupère une référence du rigidbody
    }
    void Update()
    {
        ReadInput(); // on lit les inputs
    }
    void FixedUpdate()
    {
        _rb.velocity = moveForce;  // on fait bouger le player
    }
    private void ReadInput()
    {
        var vert = Input.GetAxisRaw("Vertical"); // on récupère l'input vertical
        var hor = Input.GetAxisRaw("Horizontal"); // on récupère l'input horizontal
        moveForce = new Vector2(hor,vert) * speed; // on crée le vecteur de mouvement du player
    }
}