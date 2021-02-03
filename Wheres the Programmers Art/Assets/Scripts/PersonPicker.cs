using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class PersonPicker : MonoBehaviour
{
    public List<GameObject> person;

    public Image[] findImage;

    public int personCounter = 0;

    [SerializeField] private TextMeshProUGUI timerText;

    [SerializeField] private GameObject loseObject;

    [SerializeField] private GameObject winObject;

    private float timer;

    bool isFound;

    // Start is called before the first frame update
    void Start()
    {
        timer = 30;

        isFound = false;

        loseObject.SetActive(false);
        winObject.SetActive(false);

        findImage[0].sprite = person[0].GetComponent<SpriteRenderer>().sprite;
        findImage[1].sprite = person[1].GetComponent<SpriteRenderer>().sprite;
        findImage[2].sprite = person[2].GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < findImage.Length; i++)
        {
            if (findImage[0].GetComponent<Animator>().enabled == true 
                && findImage[1].GetComponent<Animator>().enabled == true
                && findImage[2].GetComponent<Animator>().enabled == true)
            {
                winObject.SetActive(true);
                isFound = true;
            }
        }

        if (!isFound)
        {
            timer -= Time.deltaTime;
            timerText.text = "Time : " + timer.ToString("F2");
        }

        if (timer <= 0)
        {
            timer = 0;
            loseObject.SetActive(true);
        }
    }
}
