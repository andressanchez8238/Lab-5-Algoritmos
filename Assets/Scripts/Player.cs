using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public InputSystem_Actions inputs;
    private CharacterController controller;
    [SerializeField] private Vector2 moveInput;
    public bool canMove = true;
    public int fuerza=10;
    public int vida=100;
    private void Awake()
    {
        inputs = new();
        controller = GetComponent<CharacterController>();
    }
    private void OnEnable()
    {
        inputs.Enable();

        inputs.Player.Move.performed += ctx => OnMove(ctx.ReadValue<Vector2>());
    }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMove(Vector2 input)
    {
        if (!canMove)
        {
            return;
        }
        Vector3 move = new Vector3(input.x, 0, input.y);
        controller.Move(move);
        canMove=false;
    }
    public void MasFuerza()
    {
        fuerza = fuerza + 5;
    }
    public void MenosFuerza()
    {
        fuerza =fuerza - 5;
    }
    public void MasVida()
    {
        vida= vida + 5;
    }
    public void MenosVida()
    {
        vida = vida - 5;
    }
}
