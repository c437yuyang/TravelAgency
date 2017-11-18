using System.Runtime.InteropServices;

namespace TravelAgency.Common.IDCard
{
    public static class IDCardDll
    {
        [DllImport("kernel32")]
        public static extern int LoadLibrary(string strDllName);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int InitIDCard(char[] cArrUserID, int nType, char[] cArrDirectory);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetRecogResult(int nIndex, char[] cArrBuffer, ref int nBufferLen);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogIDCard();

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetFieldName(int nIndex, char[] cArrBuffer, ref int nBufferLen);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int AcquireImage(int nCardType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int SaveImage(char[] cArrFileName);
        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int SaveHeadImage(char[] cArrFileName);


        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetCurrentDevice(char[] cArrDeviceName, int nLength);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern void GetVersionInfo(char[] cArrVersion, int nLength);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern bool CheckDeviceOnline();

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern bool SetAcquireImageType(int nLightType, int nImageType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern bool SetUserDefinedImageSize(int nWidth, int nHeight);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern bool SetAcquireImageResolution(int nResolutionX, int nResolutionY);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int SetIDCardID(int nMainID, int[] nSubID, int nSubIdCount);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int AddIDCardID(int nMainID, int[] nSubID, int nSubIdCount);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogIDCardEX(int nMainID, int nSubID);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetButtonDownType();

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetGrabSignalType();

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int SetSpecialAttribute(int nType, int nSet);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern void FreeIDCard();
        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetDeviceSN(char[] cArrSn, int nLength);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetBusinessCardResult(int nID, int nIndex, char[] cArrBuffer, ref int nBufferLen);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogBusinessCard(int nType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetBusinessCardFieldName(int nID, char[] cArrBuffer, ref int nBufferLen);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetBusinessCardResultCount(int nID);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int LoadImageToMemory(string path, int nType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int ClassifyIDCard(ref int nCardType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogChipCard(int nDGGroup, bool bRecogVIZ, int nSaveImageType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogGeneralMRZCard(bool bRecogVIZ, int nSaveImageType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int RecogCommonCard(int nSaveImageType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int SaveImageEx(char[] lpFileName, int nType);

        [DllImport("IDCard", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Winapi)]
        public static extern int GetDataGroupContent(int nDGIndex, bool bRawData, byte[] lpBuffer, ref int len);
    }
}
