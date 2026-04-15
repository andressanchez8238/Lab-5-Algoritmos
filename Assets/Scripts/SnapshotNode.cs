using UnityEngine;

public class SnapshotNode
{
    public int Turn;
    public Vector3 playerPosition;
    public Vector3 playerRotation;
    public float str;
    public float dtx;
    public float spd;

    public SnapshotNode(Player player, int turn)
    {
        Turn = turn;
        playerPosition= player.transform.position;
        playerRotation = player.transform.rotation.eulerAngles;
        str = player.str;
        dtx = player.dtx;
        spd = player.spd;

    }
}
