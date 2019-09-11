using UnityEngine;

public static class Game
{
  public static T Get<T>() where T : MonoBehaviour
  {
    return GameObject.Find("GameControl").GetComponent<T>();
  }
}