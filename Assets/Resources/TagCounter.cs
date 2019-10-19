using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TagCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI numberTags;
    public int Tags;
    public bool isTagged = false;

    // Start is called before the first frame update
    void Start()
    {
        numberTags = GetComponent<TextMeshProUGUI>();
        numberTags.text = Tags.ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
