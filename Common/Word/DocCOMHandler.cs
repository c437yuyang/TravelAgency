using System;
using System.Collections.Generic;
using System.IO;
using word = Microsoft.Office.Interop.Word;

namespace TravelAgency.Common.Word
{
    public static class DocComHandler
    {
        //TODO:这里其实后面的replaceString里面doc不应该暴露给用户，应该弄成成员变量就行了
        //TODO:替换placeholder的接口应该修改一下，来适应不同placeholder的数目
        static word.ApplicationClass _application = null;
        /// <summary>
        /// 打开指定路径，返回doc对象
        /// </summary>
        /// <param name="docName"></param>
        /// <returns></returns>
        public static word.Document OpenDocFile(string docName)
        {
            object oMissing = System.Reflection.Missing.Value;  //一个编程时需要经常使用的一个参数
            //word.ApplicationClass _application = null;   //这是WORD程序，在这个程序下，可以同时打开多个文档，尽量不要同时打开多个Word程序，否则会出错的。
            word.Document doc = null;  //第一个需要打开的WORD文档

            _application = new word.ApplicationClass();
            _application.Visible = false; //所打开的WORD程序，是否是可见的。

            object docObject = docName;  //由于COM操作中，都是使用的 object ,所以，需要做一些转变                       
            if (File.Exists(docName))   // 如果要打开的文件名存在，那就使用doc来打开 
            {
                doc = _application.Documents.Add(ref docObject, ref oMissing, ref oMissing, ref oMissing);
                doc.Activate();   //将当前文件设定为活动文档
                int ParagraphsCount = doc.Content.Paragraphs.Count;   //此文档中，段落的数量，也就是这个文档中，有几个段落。
                //Console.WriteLine("文档共有:" + ParagraphsCount + "段");
                return doc;
            }
            return null;
        }

        /// <summary>
        /// 替换指定文本在word中，doc和docx都支持
        /// </summary>
        /// <param name="outFileName"></param>
        /// <param name="doc"></param>
        /// <param name="origialString"></param>
        /// <param name="destinationString"></param>
        /// <returns></returns>
        public static bool ReplaceString(string outFileName, word.Document doc, string origialString, string destinationString)
        {
            bool result = false;
            Object missing = System.Reflection.Missing.Value;
            try
            {
                object replaceAll = word.WdReplace.wdReplaceAll;

                _application.Selection.Find.ClearFormatting();
                _application.Selection.Find.Text = origialString;

                _application.Selection.Find.Replacement.ClearFormatting();
                _application.Selection.Find.Replacement.Text = destinationString; //设置替换的待替换的文本目标文本

                _application.Selection.Find.Execute(
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref missing, ref missing, ref missing, ref missing, ref missing,
                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                //  
                //替换在文本框中的文字  
                //  
                word.StoryRanges ranges = _application.ActiveDocument.StoryRanges;
                foreach (word.Range item in ranges)
                {
                    if (word.WdStoryType.wdTextFrameStory == item.StoryType)
                    {
                        word.Range range = item;
                        while (range != null)
                        {
                            range.Find.ClearFormatting();
                            range.Find.Text = origialString;
                            range.Find.Replacement.Text = destinationString;
                            range.Find.Execute(
                                ref missing, ref missing, ref missing, ref missing, ref missing,
                                ref missing, ref missing, ref missing, ref missing, ref missing,
                                ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                            range = range.NextStoryRange;
                        }
                        break;
                    }
                }
                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                if (doc != null)
                {
                    doc.SaveAs2(outFileName);
                    doc.Close(true);
                    doc = null;
                }
                if (_application != null)
                {
                    _application.Quit(ref missing, ref missing, ref missing);
                    _application = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            return result;
        }


        /// <summary>
        /// 根据{1},{2}这种的占位符替换文本并保存到outFileName文件
        /// </summary>
        /// <param name="outFileName"></param>
        /// <param name="doc"></param>
        /// <param name="origialString"></param>
        /// <param name="destinationString"></param>
        /// <param name="wait4ReplaceList"></param>
        /// <param name="removeRedundantPlaceHolder">是否去掉多余的placeholder</param>
        /// <param name="placeholdernum">placeholder的数量</param>
        /// <returns></returns>
        public static bool BatchReplaceStringByPlaceHolder(string outFileName, word.Document doc, List<string> wait4ReplaceList, bool removeRedundantPlaceHolder, int placeholdernum)
        {
            bool result = false;
            Object missing = System.Reflection.Missing.Value;
            object replaceAll = word.WdReplace.wdReplaceAll;
            try
            {
                for (int i = 0; i < placeholdernum; i++)
                {
                    string src = "{" + (i + 1) + "}";
                    string dst;

                    if (i >= wait4ReplaceList.Count && !removeRedundantPlaceHolder)
                        break;

                    if (i >= wait4ReplaceList.Count && removeRedundantPlaceHolder)
                        dst = "";
                    else
                        dst = wait4ReplaceList[i];
                    _application.Selection.Find.ClearFormatting();
                    _application.Selection.Find.Text = src;
                    _application.Selection.Find.Replacement.ClearFormatting();
                    _application.Selection.Find.Replacement.Text = dst; //设置替换的待替换的文本目标文本

                    _application.Selection.Find.Execute(
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref missing, ref missing, ref missing, ref missing, ref missing,
                        ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                    //  
                    //替换在文本框中的文字  
                    //  
                    word.StoryRanges ranges = _application.ActiveDocument.StoryRanges;
                    foreach (word.Range item in ranges)
                    {
                        if (word.WdStoryType.wdTextFrameStory == item.StoryType)
                        {
                            word.Range range = item;
                            while (range != null)
                            {
                                range.Find.ClearFormatting();
                                range.Find.Text = src;
                                range.Find.Replacement.Text = dst;
                                range.Find.Execute(
                                    ref missing, ref missing, ref missing, ref missing, ref missing,
                                    ref missing, ref missing, ref missing, ref missing, ref missing,
                                    ref replaceAll, ref missing, ref missing, ref missing, ref missing);
                                range = range.NextStoryRange;
                            }
                            break;
                        }
                    }
                    result = true;

                }


            }
            catch
            {
                result = false;
            }
            finally
            {
                if (doc != null)
                {
                    doc.SaveAs2(outFileName);
                    doc.Close(true);
                    doc = null;
                }
                if (_application != null)
                {
                    _application.Quit(ref missing, ref missing, ref missing);
                    _application = null;
                }
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }

            return result;
        }

    }
}
