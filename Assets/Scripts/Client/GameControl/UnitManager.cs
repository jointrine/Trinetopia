using System;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{
    public GameObject UnitPrefab;
    public GameObject CrosshairPrefab;
    private UnitControl SelectedUnit;
    private List<Crosshair> Crosshairs;

    internal void RenderUnits()
    {
        var serverUnits = new Server().GetUnits();
        foreach (var unit in serverUnits)
        {
            var gameObject = Instantiate(UnitPrefab.gameObject, new Vector3(unit.X, 0, unit.Y), Quaternion.identity);
            gameObject.GetComponent<UnitControl>().Unit = unit;
        }
    }

    internal void Move(GameObject unit, Vector2 position)
    {
        unit.transform.position = new Vector3(position.x, 0, position.y);
        SelectedUnit.Unselect();
        SelectedUnit = null;
        Crosshairs.ForEach(c => Destroy(c.gameObject));
    }

    internal void UnitSelected(UnitControl unitControl)
    {
        SelectedUnit = unitControl;
        var allDirections = new List<Vector2>() {
          new Vector2(-1,0),
          new Vector2(-1,-1),
          new Vector2(-1,1),
          new Vector2(1,0),
          new Vector2(1,-1),
          new Vector2(1,1),
          new Vector2(0,1),
          new Vector2(0,-1)
        };
        Crosshairs = new List<Crosshair>();
        foreach (var pos in allDirections)
        {
            for (int i = 1; i <= unitControl.Unit.Range; i++)
            {
                var position = new Vector2(unitControl.Unit.X + (pos.x * i), unitControl.Unit.Y + (pos.y * i));
                var gameObject = Instantiate(CrosshairPrefab.gameObject, new Vector3(position.x, 0, position.y), Quaternion.Euler(90f, 0f, 0f));
                var crosshair = gameObject.GetComponent<Crosshair>();
                crosshair.Position = position;
                crosshair.Unit = unitControl.gameObject;
                Crosshairs.Add(crosshair);
            }
        }
    }
}
