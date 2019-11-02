using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform player;
    public Text scoretext;
    // Update is called once per frame
    void Update()
    {
       scoretext.text=(player.position.z+85.586).ToString("0");
    }
}
