using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using NPOI.SS.Formula.Functions;

namespace TravletAgence.Common.Word.Japan
{
    public class DocDocxGenerator
    {
        public enum DocType
        {
            Type01JinQiaoList,
            Type02WaiLingDanBaohan,
            Type03JiPiao
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

        public DocDocxGenerator()
        {

        }

        public DocDocxGenerator(DocDocxGenerator.DocType type)
        {
            if (type == DocDocxGenerator.DocType.Type01JinQiaoList)
            {
                PlaceHolderNum = 31;
                DefaultName = "金桥大名单.docx";
                TemplaceDocFileName = "template_成都金桥大名单_添加占位符1-31.docx";
            }
            if (type == DocDocxGenerator.DocType.Type02WaiLingDanBaohan)
            {
                PlaceHolderNum = 4;
                DefaultName = "外领区人员特别担保函 （国旅四川）.docx";
                TemplaceDocFileName = "template_外领区人员特别担保函 （国旅四川）_添加占位符1-4.docx";
            }
            if (type == DocDocxGenerator.DocType.Type03JiPiao)
            {
                PlaceHolderNum = 17;
                DefaultName = "机票（表7）.docx";
                TemplaceDocFileName = "template_机票（表7）.docx";
            }
        }

        public void SetDocType(DocDocxGenerator.DocType type)
        {
            if (type == DocDocxGenerator.DocType.Type01JinQiaoList)
            {
                PlaceHolderNum = 31;
                DefaultName = "金桥大名单.docx";
                TemplaceDocFileName = "template_成都金桥大名单_添加占位符1-31.docx";
            }
            if (type == DocDocxGenerator.DocType.Type02WaiLingDanBaohan)
            {
                PlaceHolderNum = 4;
                DefaultName = "外领区人员特别担保函 （国旅四川）.docx";
                TemplaceDocFileName = "template_外领区人员特别担保函 （国旅四川）_添加占位符1-4.docx";
            }
            if (type == DocDocxGenerator.DocType.Type03JiPiao)
            {
                PlaceHolderNum = 17;
                DefaultName = "机票（表7）.docx";
                TemplaceDocFileName = "template_机票（表7）.docx";
            }
        }

        public void Generate(List<string> listWait4Replace)
        {
            if (listWait4Replace.Count > PlaceHolderNum)
            {
                MessageBoxEx.Show("数据量多余所选模板占位符数量:" + PlaceHolderNum);
                return;
            }


            string dstName = GlobalUtils.OpenSaveFileDlg(DefaultName, "Word文档|*.docx");

            // If the file name is not an empty string open it for saving.
            if (!string.IsNullOrEmpty(dstName))
            {
                if (!DocXHandler.BatchReplaceStringByPlaceHolder(GlobalUtils.AppPath + @"\Word\Templates\" + TemplaceDocFileName, dstName, listWait4Replace, true, PlaceHolderNum))
                {
                    MessageBoxEx.Show("生成报表失败，请联系技术人员!");
                    return;
                }
                Process.Start(dstName);
            }
            
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


                if (!DocXHandler.BatchReplaceStringByPlaceHolder(GlobalUtils.AppPath + @"\Word\Templates\" + TemplaceDocFileName, outFolder + @"\" + DefaultName + "_" + listWait4Replace[0] + ".docx", listWait4Replace, true, PlaceHolderNum))
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
