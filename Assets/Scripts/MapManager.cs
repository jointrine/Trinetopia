using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
  public List<TileBehaviour> TilePrefabs;

  public void RenderMap()
  {
    var serverMap = new Server().GetMap();
    foreach (var tile in serverMap)
    {
      var prefab = TilePrefabs.Find(tp => tp.Type == tile.Type);
      Instantiate(prefab.gameObject, new Vector3(tile.X, 0, tile.Y), Quaternion.identity);
    }
  }
}