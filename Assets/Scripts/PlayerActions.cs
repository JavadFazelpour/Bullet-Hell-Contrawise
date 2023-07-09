using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    private Camera mainCamera;
    public GameObject prefabCircle;
    public Vector3 mousePos;
    //public NoiseSettings camNoise;
    private Vector2 target;
    private Vector2 currentPosition;
    //[SerializeField] GameObject _pesky;
    //[SerializeField] GameObject _minionUnit;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera=GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        //_pesky=gameObject.GetComponent<GameObject>();
        //_minionUnit=gameObject.GetComponent<GameObject>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;
        if (Input.GetMouseButton(0))
        {
            Instantiate(prefabCircle, mousePos, Quaternion.identity);
        }
        

    }
}
