using UnityEngine;

public class ExternalClass : MonoBehaviour
{
    public StudyDelegate studyDelegate;
    
    void Start()
    {
        StudyAction2.action += OnLog;
    }

    private void OnLog()
    {
        Debug.Log("msg");
    }
}