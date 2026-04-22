using UnityEngine;

public class SnapshotNode
{
    public int Turn;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public int fuerza;
    public int vida;
    public NodeEnemy GrupoEnemy;

    public SnapshotNode(Player player, int turn, NodeEnemy grupoEnemy)
    {
        Turn = turn;
        playerPosition = player.transform.position;
        playerRotation = player.transform.rotation.eulerAngles;
        fuerza = player.fuerza;
        vida = player.vida;
        GrupoEnemy = grupoEnemy;
    }
}
