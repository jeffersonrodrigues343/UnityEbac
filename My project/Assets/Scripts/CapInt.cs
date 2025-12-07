using UnityEditor.Rendering.Analytics;
using UnityEngine;

public class CapInt : MonoBehaviour
{
    #region Vars

    public int doors = 4;

    public float life = 10f;
    public float damage = 0.5f;

    public bool canAcelerate = false;

    public GameObject MeuObject;
    public Transform MyTransform;
    public Color color = Color.red;
    public CapInt Capsule;

    #endregion EndVars

    public void ChangeColor()
    {
        color = Color.blue;
        life -= damage;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
