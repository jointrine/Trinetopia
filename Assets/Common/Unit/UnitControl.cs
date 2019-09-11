using UnityEngine;

public class UnitControl : MonoBehaviour
{
    Shader defaultShader;
    Shader outlineShader;

    public Unit Unit { get; set; }

    // Start is called before the first frame update
    void Start()
    {
        defaultShader = gameObject.transform.Find("Shape").GetComponent<Renderer>().material.shader;
        outlineShader = Shader.Find("Outlined/UltimateOutline");
    }

    void OnChildMouseDown()
    {
        Select();
    }

    void Select()
    {
        var material = gameObject.transform.Find("Shape").GetComponent<Renderer>().material;
        material.shader = outlineShader;
        Game.Get<UnitManager>().UnitSelected(this);
    }

    public void Unselect()
    {
        var material = gameObject.transform.Find("Shape").GetComponent<Renderer>().material;
        material.shader = defaultShader;
    }
}