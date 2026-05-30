using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    
    public bool flag = true; 
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

      for (int Number = 1; Number <= 10; Number ++)
        {
            int Result = (int)Mathf.Pow(2, Number);
            Debug.Log($"The {Number} power of 2 is {Result}");  
          
        }
    
    if (flag)
    {
    Debug.Log("Boolean flag is set");
    }
    else 
    {
    Debug.Log("Boolean flag is not set");
    }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
