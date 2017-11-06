using System.Collections.Generic;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TravletAgence.Common.Word
{
    public static class JapanWordGenerator
    {
        public static int PlaceHolderNum
        {
            get { return 31; }
        }

        public static bool GetJinQiaoMingDan(List<Model.VisaInfo> list)
        {
            if (list.Count > PlaceHolderNum)
            {
                MessageBoxEx.Show("最多支持同时生成" + PlaceHolderNum + "个人的报表!");
                return false;
            }

            List<string> listWait4Replace = new List<string>();
            //生成需要替换的文本list
            for (int i = 0; i != list.Count; ++i)
            {
                listWait4Replace.Add(list[i].Name);
            }

            var doc = DocComHandler.OpenDocFile(GlobalInfo.AppPath + @"\Word\Templates\template_成都金桥大名单_添加占位符1-31.doc");
            if (doc == null)
            {
                MessageBoxEx.Show("打开模板文件失败，请检查文件路径！");
                return false;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word2003 Doc|*.doc";
            saveFileDialog1.Title = "保存到文件";
            saveFileDialog1.FileName = "金桥大名单";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                if (!DocComHandler.BatchReplaceStringByPlaceHolder(saveFileDialog1.FileName, doc, listWait4Replace))
                {
                    MessageBoxEx.Show("生成报表失败，请联系技术人员!");
                    return false;
                }
            }
            MessageBoxEx.Show("生成成功!");
            return true;
        }

    }
}