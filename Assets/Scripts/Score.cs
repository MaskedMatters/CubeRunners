// Libraries
using UnityEngine;
using UnityEngine.UI;

// Script class | All script
public class Score : MonoBehaviour
{
    // Public Variables
    public Transform playerT;
    public Text scoreText;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = playerT.position.z.ToString("0");
    }
}
