using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
 
    // Start is called before the first frame update
   private void Awake()
    {
        
    }
   public void SceneChange()
    {
        SceneManager.LoadScene("snowball");
    }
}
