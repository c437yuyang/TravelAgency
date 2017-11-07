using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace TravletAgence.Common.Word.Japan
{
    public class DocGenerator
    {
        public enum DocType
        {
            Type01JinQiaoList,
            Type02WaiLingDanBaohan
        }

        /// <summary>
        /// 占位符数量
        /// </summary>
        public static int PlaceHolderNum { get; set; }

        /// <summary>
        /// 默认保存文件名
        /// </summary>
        public static string DefaultName { get; set; }

        /// <summary>
        /// 模板文件名
        /// </summary>
        public static string TemplaceDocFileName { get; set; }

        public DocGenerator(DocType type)
        {
            if (type == DocType.Type01JinQiaoList)
            {
                PlaceHolderNum = 31;
                DefaultName = "金桥大名单";
                TemplaceDocFileName = "template_成都金桥大名单_添加占位符1-31.doc";
            }
            if (type == DocType.Type02WaiLingDanBaohan)
            {
                PlaceHolderNum = 4;
                DefaultName = "外领区人员特别担保函 （国旅四川）";
                TemplaceDocFileName = "template_外领区人员特别担保函 （国旅四川）_添加占位符1-4.doc";
            }
        }

        public void Generate(List<string> listWait4Replace)
        {
            if (listWait4Replace.Count > PlaceHolderNum)
            {
                MessageBoxEx.Show("数据量多余所选模板占位符数量:" + PlaceHolderNum);
                return;
            }

            var doc = DocComHandler.OpenDocFile(GlobalInfo.AppPath + @"\Word\Templates\" + TemplaceDocFileName);
            if (doc == null)
            {
                MessageBoxEx.Show("打开模板文件失败，请检查文件路径！");
                return;
            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Word2003 Doc|*.doc";
            saveFileDialog1.Title = "保存到文件";
            saveFileDialog1.FileName = DefaultName;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                if (!DocComHandler.BatchReplaceStringByPlaceHolder(saveFileDialog1.FileName, doc, listWait4Replace, true, PlaceHolderNum))
                {
                    MessageBoxEx.Show("生成报表失败，请联系技术人员!");
                    return;
                }
            }
            Process.Start(saveFileDialog1.FileName);
        }


        public void GenerateBatch(List<List<string>> listListWait4Replace, string outFolder)
        {
            int success = 0;
            for (int i = 0; i < listListWait4Replace.Count; i++)
            {
                List<string> listWait4Replace = listListWait4Replace[i];
                if (listWait4Replace.Count > PlaceHolderNum)
                {
                    MessageBoxEx.Show("数据量多余所选模板占位符数量:" + PlaceHolderNum + "\n,将跳过当前文档.");
                    continue;
                }

                var doc = DocComHandler.OpenDocFile(GlobalInfo.AppPath + @"\Word\Templates\" + TemplaceDocFileName);
                if (doc == null)
                {
                    MessageBoxEx.Show("打开模板文件失败，请检查文件路径！");
                    continue;
                }


                if (!DocComHandler.BatchReplaceStringByPlaceHolder(outFolder + @"\" + DefaultName + "_" + listWait4Replace[0] + ".doc", doc, listWait4Replace, true, PlaceHolderNum))
                {
                    MessageBoxEx.Show("生成报表失败，请联系技术人员!");
                    continue;
                }
                ++success;
            }
            if (
                MessageBoxEx.Show("成功保存报表:" + success + "份，失败:" + (listListWait4Replace.Count - success) + "份.\n是否打开所在文件夹?", "提示",
                    MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            Process.Start(outFolder);
        }

    }
}
