using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minions : MonoBehaviour
{
    [SerializeField] GameObject _girl;
    [SerializeField] float speed=2f;
    Girl girlScript;
    public int _attack = 0;
    public int health;


    
    void Start()
    {
        girlScript=GameObject.Find("Girl").GetComponent<Girl>();
    }

    void Update()
    {    
        float step = speed * Time.deltaTime;
        this.transform.position = Vector2.MoveTowards(this.transform.position, _girl.transform.position, step);
        
    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
         
            if (collision2D.gameObject.tag == "Player")
            {
                girlScript.TakeDamage(_attack);

                GameObject.Destroy(this.gameObject, 0.1f);

            }
        
    }

}
