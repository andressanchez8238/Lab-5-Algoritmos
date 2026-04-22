using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIturnos : MonoBehaviour
{
    public TextMeshProUGUI Turno;
    private void Awake()
    {
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ActText(int turn)
    {
        Turno.text = "Turno: " + turn;
    }
}
