using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    [SerializeField] public CircleCollider2D circleCollider;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Attach(Collider2D collision)
    {
        if (circleCollider != null) return;

        gameObject.transform.SetParent(collision.gameObject.transform.Find("Attachment"), false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Attach(collision);
    }
}
