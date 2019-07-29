using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleShaderOnClick : MonoBehaviour
{
  Shader outlineShader;
  Shader defaultShader;
  // Start is called before the first frame update
  void Start()
  {
    outlineShader = Shader.Find("Outlined/UltimateOutline");
    defaultShader = GetComponent<Renderer>().material.shader;
  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnMouseDown()
  {
    var material = GetComponent<Renderer>().material;
    material.shader = material.shader == defaultShader ? outlineShader : defaultShader;
  }
}