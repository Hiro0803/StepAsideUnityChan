using UnityEngine;
using System.Collections;

public class ItemDelete : MonoBehaviour
{
    // トリガーとの接触時に呼ばれるコールバック
    void OnTriggerEnter(Collider hit)
    {

        Debug.Log("OnTriggerEnter");
        // 接触対象はPlayerタグですか？
        if (hit.CompareTag("Delete"))
        {

            // このコンポーネントを持つGameObjectを破棄する
            Destroy(gameObject);
        }
    }
}
