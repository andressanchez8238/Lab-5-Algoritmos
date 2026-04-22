using System;
using UnityEngine;
using Sirenix.OdinInspector;
using System.Collections.Generic;


public class GameManager : MonoBehaviour
{
    public UIturnos text;
    public static GameManager instance;

    public CustomDoubleLinkedList snapshotSystem = new();

    public Player player;
    public NodeEnemy GrupoEnemy;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }
    [Button]
    public void SaveTurn()
    {
        snapshotSystem.SaveTurn();
        Debug.Log("Saving turn: " + snapshotSystem.Count);
        text.ActText(snapshotSystem.Count);

        player.canMove = true;
        //enemy.OnMove();
        //enemy.canMove = true;
    }
    public void LoadTurn()
    {
        snapshotSystem.LoadTurn(player);
        player.canMove = true;
    }
    [Button]
    public void NextTurn()
    {
        snapshotSystem.MoveForward();
        LoadTurn();
    }
    [Button]
    public void PrevTurn()
    {
        snapshotSystem.MoveBackwards();
        LoadTurn();
    }


}
