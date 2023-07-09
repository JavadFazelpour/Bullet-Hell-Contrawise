using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girl : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] GameObject _circle;
    [SerializeField] GameObject _greenGelly;
    Minions _minions;
    GreenGelly _gGelly;
    public float attack;
    // Start is called before the first frame update
    private void Awake()
    {
        _minions = GameObject.Find("Circle").GetComponent<Minions>();
        _gGelly = GameObject.Find("Green Gelly").GetComponent<GreenGelly>();
    }
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

   public  void TakeDamage(int amount)
    {
        _health -= amount;
        if (this!=null)
        {
        if (_health <= 0)
            Destroy(this.gameObject);            
        }
    }

}
   
