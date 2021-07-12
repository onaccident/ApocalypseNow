using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmitterWWISE : MonoBehaviour
{
    public string EventNameWW = "default";
    public string StopEventWW = "default";
    private bool IsInCollider = false;
    // Start is called before the first frame update
    void Start()
    {
        AkSoundEngine.RegisterGameObj(gameObject);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player" || IsInCollider) { return; }
        IsInCollider = true;
        AkSoundEngine.PostEvent(EventNameWW, gameObject);
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player" || !IsInCollider) { return; }
        AkSoundEngine.PostEvent(StopEventWW, gameObject);
        IsInCollider = false;
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player" || IsInCollider) { return; }
        IsInCollider = true;
        AkSoundEngine.PostEvent(EventNameWW, gameObject);
    }
}
