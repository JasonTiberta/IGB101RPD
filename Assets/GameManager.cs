using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Leon;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Pickup and Level Completion Logic
        public int currentPickups = 0;
    public int maxPickups = 5;
    public bool levelComplete = false;

    private void levelCompleteCheck()
    {
        if (currentPickups >= maxPickups)
            levelComplete = true;
        else
            levelComplete = false;
    }
    }

    // Update is called once per frame
    void Update()
    {
    LevelCompleteCheck();
    }
}
