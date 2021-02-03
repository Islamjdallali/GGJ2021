using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPerson : MonoBehaviour
{
    [SerializeField] private PersonPicker personPickerScript;

    [SerializeField] private int boolValue;

    private void Awake()
    {
        personPickerScript = GameObject.FindGameObjectWithTag("RandomPersonPicker").GetComponent<PersonPicker>();

        boolValue = Random.Range(0, 2);

        if (boolValue == 1 && personPickerScript.personCounter < 3)
        {
            personPickerScript.person.Add(gameObject);
            personPickerScript.personCounter++;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        for (int i = 0; i < personPickerScript.person.ToArray().Length; i++)
        {
            if (gameObject == personPickerScript.person[i])
            {
                personPickerScript.findImage[i].GetComponent<Animator>().enabled = true;
                gameObject.SetActive(false);
            }
        }
    }
}
