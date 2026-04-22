using UnityEngine;
using UnityEngine.Rendering;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    GameObject Player;
    Transform ubicacion_player;
    int vida = 10;
    int fuerza = 5;
    public bool canMove=true;
    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        ubicacion_player = Player.transform;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMove()
    {
        if (!canMove)
        {
            return;
        }
        Vector3 direccion = ubicacion_player.position - transform.position;
        if (Mathf.Abs(direccion.x) > Mathf.Abs(direccion.z))
        {
            float stepX = direccion.x > 0 ? 1f : -1f;
            transform.position += new Vector3(stepX, 0, 0);
            //transform.forward = new Vector3(stepX, 0, 0);
        }
        else
        {
            float stepZ = direccion.z > 0 ? 1f : -1f;
            transform.position += new Vector3(0, 0, stepZ);
            //transform.forward = new Vector3(0, 0, stepZ);
        }
        canMove = false;
    }
}
