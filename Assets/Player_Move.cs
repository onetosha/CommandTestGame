using UnityEngine;

public class Player_Move : MonoBehaviour
{
    

    public float speed_Move = 10;
    float x_Move;
    float z_Move;
    public CharacterController player;
    Vector3 move_Direction;


    void Start()
    {
        player = GetComponent<CharacterController>();

    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        
        
        if (player.isGrounded)
        {
            move_Direction = new Vector3(x_Move, 0f, z_Move);
            move_Direction = transform.TransformDirection(move_Direction);
        }
        move_Direction.y -= 1;
        player.Move(move_Direction * Time.deltaTime * speed_Move);
    }

}
