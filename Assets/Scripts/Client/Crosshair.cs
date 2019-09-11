using UnityEngine;

public class Crosshair : MonoBehaviour
{
    public GameObject Unit;
    public Vector2 Position;
    // Update is called once per frame
    void OnMouseDown()
    {
        var unitManager = Game.Get<UnitManager>();
        unitManager.Move(Unit, Position);
    }
}
