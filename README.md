# Unity-Read-Excel-Tool
基于Unity读取Excel表格数据工具
# 1.将工具导入Unity项目中后，Unity编辑器的顶部选项卡应该出现“Tool”选项，如果没有，请重新下载和导入项目



# 2.新建的Excel或者存入已有的Excel表格，应当把表格文件存入到：

Assets/Editor/Excel/ExcelFile

文件夹路径下，例如，

Assets/Editor/Excel/ExcelFile/History.xlsx



# 3.表格中数据填写规则：

表格中的第一行应该填写数据的键值，例如，

Id、Name、Sex、Attack或Def等等

表格中的第二行应该填写数据的键值对应的数据类型，例如，

int、string、int、int或int等等

表格中的第三行可以空着什么都不填，工具读取表格数据是从第四行开始(这里可以去脚本里自定义规则，但是通常没必要)

注意！！！表格的第一列一定要是int类型的Id，工具脚本是通过第一列的Id来读取存储每一行的数据的

可以查看项目中的示例表格，看一眼就明白，十分简单！



# 4.确保Excel文件存放路径存放正确和Excel表格数据按规则填写，然后就可以点击选项卡中“Tool”---->“CreateExeclInfo”

开始生成Excel文件数据文件，生成成功之后就可以利用表格控制器脚本来读取数据文件中的数据了

例如，

using UnityEngine;

public class TestExample : MonoBehaviour
{
    void Start()
    {
        Debug.Log(ExcelReaderManager.Instance.GetTable<ChineseHistory>().dataDic[6].Time);
    }
}

其中，GetTable<ChineseHistory>().dataDic[6].Time的含义是：GetTable<表名>().dataDic[表中的Id(表示哪一行数据)].自定义的键值

GetTable<ChineseHistory>().dataDic[6].Time就是得到名为ChineseHistory的表格中的Id为6，键值为Time处的格子中的数据


# 5.注意事项：

表格名称不是表格文件的名字，而是打开表格后位于左下角的选项卡的名称才是真正的表格名称！

此工具未添加删除表格相关逻辑，如果你需要删除一个表格，删除之后需要手动清除对应生成的数据文件，避免影响内存空间(如果不在乎的话也可以不管)

每一次更改表格数据都需要点击选项卡中“Tool”---->“CreateExeclInfo”，来更新数据

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

# Unity-Read-Excel-Tool
Unity-based tool for reading Excel spreadsheet data
# 1. After importing the Tool into the Unity project, the "Tool" option should appear in the top TAB of the Unity Editor, if not, please re-download and import the project



# 2. A new Excel file or an existing Excel file should be saved to:

Assets/Editor/Excel/ExcelFile

Folder path, for example,

Assets/Editor/Excel/ExcelFile/History.xlsx



# 3. Data filling rules in the form:

The first row of the table should fill in the key value of the data, for example,

Id, Name, Sex, Attack, Def, and so on

The second row of the table should fill in the data type corresponding to the key value of the data, for example,

int, string, int, int, or int, and so on

The third row of the table can be left blank, and the tool begins to read the table data from the fourth row (here you can customize the rules in the script, but it is usually not necessary).

Attention!! The first column of the table must be an Id of type int. The tool script uses the Id of the first column to read the data stored in each row

You can view the sample table in the project and understand at a glance, it is very simple!



# 4. Ensure that the Excel file is stored in the correct path and the Excel data is filled according to the rules. Then click "Tool" ----> "CreateExeclInfo" in the TAB.

Start generating the Excel file data file, and once it is successfully generated, you can use the Table controller script to read the data in the data file

For example,

using UnityEngine;

public class TestExample : MonoBehaviour
{
void Start()
{
Debug.Log(ExcelReaderManager.Instance.GetTable<ChineseHistory>().dataDic[6].Time);
}
}

GetTable<ChineseHistory>().datadic [6].Time indicates that GetTable< name of the table >().datadic [Id of the table (which row of data)]. Custom key values

GetTable<ChineseHistory>().dataDic[6].Time gets the data in the grid with Id 6 and key Time in the table named ChineseHistory


# 5. Precautions:

The table name is not the name of the table file, but the name of the TAB in the bottom left corner after opening the table is the real table name!

This tool does not add the related logic of deleting a table. If you need to delete a table, you need to manually clear the corresponding data file after deleting it to avoid affecting the memory space (if you do not care about it, you can also ignore it).

Every time you change the table data, you need to click the "Tool" ----> "CreateExeclInfo" TAB to update the data
