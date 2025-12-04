using UnityEngine;

public class FirstEx : MonoBehaviour
{
    public float position;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        position = PlayerPrefs.GetFloat("Position", 1);
        position++; // add 1 float                                     //Devolve 1 caso não tenha nada.
        // Aumentar uma posição
        PlayerPrefs.SetFloat("Position", 150);
    }

    // Update is called once per frame
    void Update()
    { 
        
    }
}
