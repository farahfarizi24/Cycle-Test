using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GetSaveDataLocation : MonoBehaviour
{
    public TextMeshProUGUI Location;
    public string locationAddress=null;
    public DataCollection CollectionScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CollectionScript.GetAddress();
        Location.text = CollectionScript.RefAddress;
    }
}
