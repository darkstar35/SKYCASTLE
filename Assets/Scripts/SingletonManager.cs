using UnityEngine;

[DisallowMultipleComponent]
public class SingletonManager : MonoBehaviour {
  
    [SerializeField] private ProgressMessage progressMessage = null;

    void Awake() {
       
        ProgressMessage.instance = progressMessage;
     
    }
}
