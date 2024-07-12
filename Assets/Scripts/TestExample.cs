using UnityEngine;

public class TestExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ExcelReaderManager.Instance.GetTable<ChineseHistory>().dataDic[6].Time);
    }
}
