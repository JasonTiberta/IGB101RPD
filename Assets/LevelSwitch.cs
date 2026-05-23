using UnityEngine;
using UnityEngine.SceneManagement

public class LevelSwitch : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = GameObject.FindGameOjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void unTriggerEnter(collider otherObject)
    // Update is called once per frame
    void Update()
    {
        
    }
}
