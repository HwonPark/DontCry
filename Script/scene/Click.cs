using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Click : MonoBehaviour
{
    public void SceneChange_jumploop()
    {
        SceneManager.LoadScene("jumploop");
    }
    public void SceneChange_snowball()
    {
        SceneManager.LoadScene("snowball");
    }
}
