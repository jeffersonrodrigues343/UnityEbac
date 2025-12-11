using UnityEditor.Rendering.Analytics;
using UnityEngine;
using UnityEngine.LightTransport;

public class CapInt : MonoBehaviour
{
    #region Vars
    [Header("V4rs")]

    public int doors = 4;

    public float life = 10f;
    public float damage = 0.5f;
    public bool canAcelerate = false;



    [Header ("Refers")]
    //public GameObject onmy;
    public Transform MyTransform;
    public Color color = Color.red;
    public CapInt onmy;


    [Header("Set Keys")] // forma de organização
    public  KeyCode keyCode = KeyCode.Space;

    #endregion EndVars


   // private void Awake()
   // {
   //    Debug.Log("Awake called");
     //   Debug.LogWarning("This is a warning message");
    //}
    public void ChangeColor(Color newColor)
    {
        color = newColor;
        life -= damage;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      //  Debug.Log("Start ");

    }


    // Update is called once per frame
    void Update()
    {

     if (Input.GetKeyUp(keyCode))
        {
            ChangeColor(Color.blue);

        }
        else if (Input.GetKeyDown(keyCode))
        {
            ChangeColor(Color.magenta);
        }

        else if (Input.GetKey(keyCode))

            ChangeColor(Color.black);




        // -- NEXT STAP


        /*    Debug.Log("Update ");
        }
        private void LateUpdate()
        {
            Debug.Log("Play LateUpdate");
        }

        private void FixedUpdate()
        {
            Debug.Log("Fixed");
        }

        private void OnEnable()
        {
            Debug.Log("Ligado");
        }
        private void OnDisable()
        {
            Debug.Log("Desligado");
        }

        private void OnDestroy()
        {
            Debug.Log("Destroy");
        */

        // -------------------------//


        // MouseButton and Joystick
        if (Input.GetMouseButton(0))
            {
            ChangeColor(Color.purple);
            Debug.Log("Mouse down");
            }
        if (Input.GetButton("Jump"))
        {
            
        }




    }
}
