using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenGelly : MonoBehaviour
{
    [SerializeField] GameObject _girl;
    [SerializeField] float speed = 2f;
    public int _attack;
    public int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, _girl.transform.position, step);
    }
}
