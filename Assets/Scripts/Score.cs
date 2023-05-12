using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text text;
    // Update is called once per frame
    void Update()
    {
        Display();
    }

    void Display()
    {
        text.text = $"Score: {GameManager.Score}";
    }
}
