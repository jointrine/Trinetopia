using UnityEngine;

public class StartUp : MonoBehaviour
{

  // Start is called before the first frame update
  void Start()
  {
    this.GetComponent<MapManager>().RenderMap();
    this.GetComponent<UnitManager>().RenderUnits();
  }

  // Update is called once per frame
  void Update()
  {

  }


}
