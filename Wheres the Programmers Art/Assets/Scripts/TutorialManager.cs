using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] Behaviour[] toggledBehaviour;

    [SerializeField] Animator tutAnimator;

    [SerializeField] GameObject tutorialPage;

    [SerializeField] AudioSource tutorialSFX;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < toggledBehaviour.Length; i++)
        {
            toggledBehaviour[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            tutAnimator.SetBool("IsTutorialDone", true);
            tutorialSFX.Play();
        }

        if (tutorialPage.transform.position.y <= -500)
        {
            for (int i = 0; i < toggledBehaviour.Length; i++)
            {
                toggledBehaviour[i].enabled = true;
            }
            tutorialPage.SetActive(false);
            gameObject.GetComponent<TutorialManager>().enabled = false;
        }
    }
}
