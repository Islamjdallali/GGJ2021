using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject fadeInImage;
    [SerializeField] private GameObject fadeOutImage;

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

        if (fadeOutImage.GetComponent<Image>().color.a == 1)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void PlayGame()
    {
        fadeOutImage.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
