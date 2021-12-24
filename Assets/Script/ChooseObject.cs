using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseObject : MonoBehaviour
{
    // Start is called before the first frame update

    private ProgrammManager programmManagerScript;
    private Button button;
    public GameObject ChoosedObject;

    void Start()
    {
        programmManagerScript = FindObjectOfType<ProgrammManager>();

        button = GetComponent<Button>();
        button.onClick.AddListener(ChooseObjectFunction); 
    }

    void ChooseObjectFunction()
    {
        programmManagerScript.ObjectToSpawn = ChoosedObject;
    }
}
