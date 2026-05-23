using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent < "GameManager" > ();

    private void OnTriggerEnter(Collider otherObject)
    {if(otherObject.transform.tag == "player")
        {
            gameManager.currentPickups += 1;
            Destroy(this.GameObject)
        }


    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
