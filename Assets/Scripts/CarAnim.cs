using UnityEngine;
using DG.Tweening;

public class CarAnim : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float duration = 2;
    public Ease ease = Ease.Linear;

    void Start()
        
    {
        // se mover até 6 na posição x na duração do Duration, usando ease EASE
        transform.DOMoveX(6, duration).SetEase(ease);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
