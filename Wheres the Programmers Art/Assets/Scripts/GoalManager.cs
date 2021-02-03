using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    [SerializeField] private GameObject fadeInImage;
    [SerializeField] private GameObject fadeOutImage;

    private bool isretry;

    // Start is called before the first frame update
    void Start()
    {
        fadeOutImage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeInImage.GetComponent<Image>().color.a == 0)
        {
            fadeInImage.SetActive(false);
        }

        if (fadeOutImage.GetComponent<Image>().color.a == 1 && isretry)
        {
            SceneManager.LoadScene(1);
        }
        else if(fadeOutImage.GetComponent<Image>().color.a == 1 && !isretry)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Retry()
    {
        fadeOutImage.SetActive(true);
        isretry = true;
    }

    public void QuitGame()
    {
        isretry = false;
        fadeOutImage.SetActive(true);
    }
}
