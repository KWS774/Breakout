using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ResetButton : MonoBehaviour
{
    [SerializeField] private Button resetButton;
    // Start is called before the first frame update
    // Update is called once per frame

    private void Awake()
    {
        resetButton.onClick.AddListener(Onclick);
    }
    private void Onclick()
    {
        GameManager.Instance.Restart();
    }


}
