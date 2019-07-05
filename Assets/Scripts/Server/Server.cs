using System.Collections.Generic;

public class Server
{
  public List<Tile> GetMap()
  {
    return new List<Tile>()
    {
      new Tile() { Y = 0, X = 0, Type = TileType.Forest, Resource = ResourceType.Tree },
      new Tile() { Y = 0, X = 1, Type = TileType.Grass, Resource = ResourceType.Empty },
      new Tile() { Y = 0, X = 2, Type = TileType.Grass, Resource = ResourceType.Empty },

      new Tile() { Y = 1, X = 0, Type = TileType.Grass, Resource = ResourceType.Empty },
      new Tile() { Y = 1, X = 1, Type = TileType.Forest, Resource = ResourceType.Tree },
      new Tile() { Y = 1, X = 2, Type = TileType.Grass, Resource = ResourceType.Empty },

      new Tile() { Y = 2, X = 0, Type = TileType.Forest, Resource = ResourceType.Tree },
      new Tile() { Y = 2, X = 1, Type = TileType.Grass, Resource = ResourceType.Empty },
      new Tile() { Y = 2, X = 2, Type = TileType.Grass, Resource = ResourceType.Empty }
    };
  }
}