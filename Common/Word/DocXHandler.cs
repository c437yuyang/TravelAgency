using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace TravelAgency.Common.Word
{
    public class DocXHandler
    {

        public static bool BatchReplaceStringByPlaceHolder(string tempFileName,string outFileName,
            List<string> wait4ReplaceList, bool removeRedundantPlaceHolder, int placeholdernum)
        {
            using (DocX document = DocX.Load(tempFileName))
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

                    document.ReplaceText(src, dst);

                }
                document.SaveAs(outFileName);
                return true;
            }
        }
    }
}
