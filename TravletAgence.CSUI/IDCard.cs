using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using TravletAgence.Model;

namespace TravletAgence.CSUI
{
    class IDCard
    {
        private bool _kernelLoaded;
        public bool KernelLoaded
        {
            get
            {
                return _kernelLoaded;
            }
        }
        public int nDG { get; set; }
        public int nSaveImage { get; set; }
        public bool bVIZ { get; set; }
        public IDCard()
        {
            nDG = 2 + 4 + 8 + 16;
            nSaveImage = 1 + 2 + 4 + 8 + 16;
            bVIZ = true;
            _kernelLoaded = false;
        }

        public bool LoadKernel()
        {
            if (_kernelLoaded)
            {
                MessageBox.Show("kernel已经成功加载！");
                return true;
            }
            int nRet;
            nRet = IDCardDll.LoadLibrary("IDCard");
            if (nRet == 0)
            {
                MessageBox.Show("Failed to load IDCard.dll");

                //textBoxDisplayResult.Text = "Failed to load IDCard.dll";
                return false;
            }

            //Load engine
            string userID = "65205296201279543068";
            char[] arr = userID.ToCharArray();
            nRet = IDCardDll.InitIDCard(arr, 1, null);
            if (nRet != 0)
            {
                MessageBox.Show("Failed to initialize the recognition engine.\r\n");
                String strtmp = nRet.ToString();
                //textBoxDisplayResult.Text += "Return Value：" + strtmp;
                return false;
            }
            IDCardDll.SetSpecialAttribute(1, 1);
            _kernelLoaded = true;
            MessageBox.Show("The recognition engine is loaded successfully.");
            return true;
        }

        public bool FreeKernel()
        {
            if (_kernelLoaded)
            {
                IDCardDll.FreeIDCard();
                _kernelLoaded = false;
                MessageBox.Show("Free Kernel Successful");
                return true;
            }
            return true;
        }

        public TravletAgence.Model.VisaInfo RecogoInfo(string picPath)
        {
            //直接返回
            if (!_kernelLoaded)
            {
                MessageBox.Show("Please successful loading recognition engine");
                return null;
            }
            int nRet = 0;
            int nCardType = 13;
            if (nCardType <= 0)
            {
                MessageBox.Show("Invalid CardSizeType,please re-enter a valid.");
                return null;
            }

            int[] nSubID = new int[1];
            nSubID[0] = 0;
            nRet = IDCardDll.SetIDCardID(nCardType, nSubID, 1);

            int ncardType = 0;
            nRet = IDCardDll.ClassifyIDCard(ref ncardType);
            //get param
            //int nDG = 2 + 4 + 8 + 16; //DG1234
            //int nSaveImage = 1 + 2 + 4 + 8 + 16;
            //bool bVIZ = true;

            //ncardType = 1;
            if (ncardType == 1)
            {
                nRet = IDCardDll.RecogChipCard(nDG, bVIZ, nSaveImage);
            }

            if (ncardType == 2)
            {
                nRet = IDCardDll.RecogGeneralMRZCard(bVIZ, nSaveImage);
            }

            if (ncardType == 3)
            {
                nRet = IDCardDll.RecogCommonCard(nSaveImage);
            }
            StringBuilder sb = new StringBuilder();
            if (nRet < 0)
            {
                sb.Append("Return value:");
                sb.Append(nRet.ToString());
                sb.Append("\r\n");
                sb.Append("recognition failure");
                MessageBox.Show(sb.ToString());
                return null;
            }

            int MAX_CH_NUM = 128;
            char[] cArrFieldValue = new char[MAX_CH_NUM];
            char[] cArrFieldName = new char[MAX_CH_NUM];
            MessageBox.Show("recognition successful\r\n");

            //返回的model
            TravletAgence.Model.VisaInfo visaInfo = new VisaInfo();
            sb.Clear();
            string info = "";
            for (int i = 1; ; i++)
            {
                nRet = IDCardDll.GetRecogResult(i, cArrFieldValue, ref MAX_CH_NUM);
                if (nRet == 3)
                {
                    break;
                }
                IDCardDll.GetFieldName(i, cArrFieldName, ref MAX_CH_NUM);

                //对返回的model进行修改

                string strFiledValue = new string(cArrFieldValue);
                strFiledValue = strFiledValue.Substring(0, strFiledValue.IndexOf('\0'));
                string strFiledName = new string(cArrFieldName);
                strFiledName = strFiledName.Substring(0, strFiledName.IndexOf('\0'));

                //TODO:替换为StringBuilder
                info += strFiledName;
                info += ":";
                info += strFiledValue;
                info += "\n";
                //sb.Append(new String(cArrFieldName));
                //sb.Append(":");
                //sb.Append(new String(cArrFieldValue));
                //sb.Append("\r\n");
                //MessageBox.Show(sb.ToString());
            }
            //MessageBox.Show(info); //显示一下返回的信息
            Console.WriteLine(info);

            DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
            dtFormat.ShortDatePattern = "yyyy-MM-dd";
            string[] infos = info.Split('\n');

            try
            {
                visaInfo.Name = infos[1].Split(':')[1];
                visaInfo.EnglishName = infos[2].Split(':')[1];
                visaInfo.Sex = infos[3].Split(':')[1];
                visaInfo.Birthday = Convert.ToDateTime(infos[4].Split(':')[1], dtFormat);
                visaInfo.PassportNo = infos[0].Split(':')[1];
                visaInfo.LicenceTime = Convert.ToDateTime(infos[15].Split(':')[1], dtFormat);
                visaInfo.Birthplace = infos[13].Split(':')[1];
                visaInfo.IssuePlace = infos[14].Split(':')[1];
                visaInfo.ExpiryDate = Convert.ToDateTime(infos[5].Split(':')[1], dtFormat);
            }
            catch (Exception)
            {
                MessageBox.Show("解析信息出现错误，请放好签证后重新进行识别!");
                return null;
            }
            //save Image
            String strImgPath = picPath + "\\" + visaInfo.PassportNo + ".jpg";
            char[] carrImgPath = strImgPath.ToCharArray();
            nRet = IDCardDll.SaveImageEx(carrImgPath, nSaveImage);
            if (nRet != 0)
            {
                MessageBox.Show("SaveImage Failed！");
                return null;
            }
            return visaInfo;
        }


        public TravletAgence.Model.VisaInfo AutoClassAndRecognize(string picPath)
        {
            if (!_kernelLoaded)
            {
                return null;
            }
            int nRet = IDCardDll.GetGrabSignalType();
            if (nRet == 1)
            {
                int[] nSubID = new int[1];
                nSubID[0] = 0;
                IDCardDll.SetIDCardID(2, nSubID, 1);
                IDCardDll.AddIDCardID(3, nSubID, 1);
                IDCardDll.AddIDCardID(4, nSubID, 1);
                IDCardDll.AddIDCardID(5, nSubID, 1);
                IDCardDll.AddIDCardID(6, nSubID, 1);
                IDCardDll.AddIDCardID(7, nSubID, 1);
                IDCardDll.AddIDCardID(9, nSubID, 1);
                IDCardDll.AddIDCardID(10, nSubID, 1);
                IDCardDll.AddIDCardID(11, nSubID, 1);
                IDCardDll.AddIDCardID(12, nSubID, 1);
                IDCardDll.AddIDCardID(13, nSubID, 1);
                IDCardDll.AddIDCardID(14, nSubID, 1);
                IDCardDll.AddIDCardID(15, nSubID, 1);
                IDCardDll.AddIDCardID(16, nSubID, 1);
                IDCardDll.AddIDCardID(22, nSubID, 1);
                IDCardDll.AddIDCardID(25, nSubID, 1);
                IDCardDll.AddIDCardID(26, nSubID, 1);

                int nCardType = 0;
                nRet = IDCardDll.ClassifyIDCard(ref nCardType);

                StringBuilder sb = new StringBuilder();

                if (nRet <= 0)
                {
                    MessageBox.Show("Return Value:" + nRet.ToString() + "\r\n" + "Classify failed");
                    return null;
                }

                //get param
                int nDG = 0;
                if (nCardType == 1)
                {
                    nRet = IDCardDll.RecogChipCard(nDG, bVIZ, nSaveImage);
                }

                if (nCardType == 2)
                {
                    nRet = IDCardDll.RecogGeneralMRZCard(bVIZ, nSaveImage);
                }

                if (nCardType == 3)
                {
                    nRet = IDCardDll.RecogCommonCard(nSaveImage);
                }

                if (nRet < 0)
                {
                    MessageBox.Show("Return Value:" + nRet.ToString() + "\r\n" + "recognition failure");
                    return null;
                }

                string info = "";
                int MAX_CH_NUM = 128;
                char[] cArrFieldValue = new char[MAX_CH_NUM];
                char[] cArrFieldName = new char[MAX_CH_NUM];
                MessageBox.Show("recognition Success\r\n");
                TravletAgence.Model.VisaInfo visaInfo = new TravletAgence.Model.VisaInfo();

                for (int i = 1; ; i++)
                {

                    nRet = IDCardDll.GetRecogResult(i, cArrFieldValue, ref MAX_CH_NUM);
                    if (nRet == 3)
                    {
                        break;
                    }
                    IDCardDll.GetFieldName(i, cArrFieldName, ref MAX_CH_NUM);
                    //TODO:赋值操作
                    string strFiledValue = new string(cArrFieldValue);
                    strFiledValue = strFiledValue.Substring(0, strFiledValue.IndexOf('\0'));
                    string strFiledName = new string(cArrFieldName);
                    strFiledName = strFiledName.Substring(0, strFiledName.IndexOf('\0'));

                    info += strFiledName;
                    info += ":";
                    info += strFiledValue;
                    info += "\n";

                }
                Console.WriteLine(info);

                DateTimeFormatInfo dtFormat = new DateTimeFormatInfo();
                dtFormat.ShortDatePattern = "yyyy-MM-dd";
                string[] infos = info.Split('\n');

                try
                {
                    visaInfo.Name = infos[1].Split(':')[1];
                    visaInfo.EnglishName = infos[2].Split(':')[1];
                    visaInfo.Sex = infos[3].Split(':')[1];
                    visaInfo.Birthday = Convert.ToDateTime(infos[4].Split(':')[1], dtFormat);
                    visaInfo.PassportNo = infos[0].Split(':')[1];
                    visaInfo.LicenceTime = Convert.ToDateTime(infos[15].Split(':')[1], dtFormat);
                    visaInfo.Birthplace = infos[13].Split(':')[1];
                    visaInfo.IssuePlace = infos[14].Split(':')[1];
                    visaInfo.ExpiryDate = Convert.ToDateTime(infos[5].Split(':')[1], dtFormat);
                }
                catch (Exception)
                {
                    MessageBox.Show("解析信息出现错误，请放好签证后重新进行识别!");
                    return null;
                }

                #region DGINFO
                //show DG info
                //int MAX_DG_NUM = 512;
                //Byte[] szDGBuffer = new Byte[MAX_DG_NUM];
                //int nBuffLen = MAX_DG_NUM * sizeof(Byte);
                ////textBoxDG.Clear();
                //ArrayList myArr = new ArrayList();
                //if (nCardType == 1)
                //{
                //    int nIndex = 0;
                //    foreach (Control c in groupBox4.Controls)
                //    {
                //        if (c is CheckBox)
                //        {
                //            CheckBox cb = (CheckBox)c;
                //            if (cb.Checked)
                //            {

                //                nIndex = int.Parse(cb.Tag.ToString());
                //                if (nIndex >= 0 && nIndex <= 17)
                //                {
                //                    myArr.Add(nIndex);
                //                }
                //            }
                //        }
                //    }
                //    for (int i = myArr.Count; i > 0; i--)
                //    {
                //        int nResu = IDCardDll.GetDataGroupContent((int)myArr[i - 1], false, szDGBuffer, ref MAX_DG_NUM);
                //        //MessageBox.Show(nResu.ToString());

                //        textBoxDG.Text += "DG" + myArr[i - 1].ToString();
                //        textBoxDG.Text += ":";
                //        textBoxDG.Text += System.Text.Encoding.UTF8.GetString(szDGBuffer);
                //        textBoxDG.Text += "\r\n";
                //    }
                //}
                //else
                //{
                //    textBoxDG.Text = "no any DG info";
                //}
                #endregion


                //SaveImage

                String strImgPath = picPath + "\\" + visaInfo.PassportNo + ".jpg";
                char[] carrImgPath = strImgPath.ToCharArray();
                nRet = IDCardDll.SaveImageEx(carrImgPath, nSaveImage);
                if (nRet != 0)
                {
                    MessageBox.Show("SaveImage Failed！");
                    return null;
                }
                return visaInfo;
            }
            return null;
        }

    }
}
