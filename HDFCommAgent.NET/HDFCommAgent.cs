using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace HDFCommAgent.NET
{
    [ComImport]
    [Guid("7FAA7994-1808-46C4-9F2B-ADE5CF84B8BF")]
    [InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
    public interface _DHDFCommAgent
    {
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(-552)]
        void AboutBox();

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(1)]
        int CommInit(int nType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(2)]
        void CommTerminate(int bSocketClose);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(3)]
        int CommLogin([MarshalAs(UnmanagedType.BStr)] string sUserID, [MarshalAs(UnmanagedType.BStr)] string sPwd, [MarshalAs(UnmanagedType.BStr)] string sCertPwd);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(4)]
        int CommLogout([MarshalAs(UnmanagedType.BStr)] string sUserID);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(5)]
        int CommRqData([MarshalAs(UnmanagedType.BStr)] string sTrCode, [MarshalAs(UnmanagedType.BStr)] string sInputData, int nLength, [MarshalAs(UnmanagedType.BStr)] string sPrevOrNext);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(6)]
        int CommSetBroad([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(7)]
        int CommRemoveBroad([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(8)]
        int CommGetRepeatCnt([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType, [MarshalAs(UnmanagedType.BStr)] string sFieldName);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(9)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetData([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType, [MarshalAs(UnmanagedType.BStr)] string sFieldName, int nIndex, [MarshalAs(UnmanagedType.BStr)] string sInnerFieldName);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(10)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetDataDirect([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType, int nOffset, int nLength, int nPointLength, [MarshalAs(UnmanagedType.BStr)] string sDataType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(11)]
        int CommGetConnectState();

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(12)]
        int CommFIDRqData([MarshalAs(UnmanagedType.BStr)] string sFidCode, [MarshalAs(UnmanagedType.BStr)] string sInputData, [MarshalAs(UnmanagedType.BStr)] string sReqFidList, int nLength, [MarshalAs(UnmanagedType.BStr)] string sPrevOrNext);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(13)]
        int CommSetJumunChe([MarshalAs(UnmanagedType.BStr)] string sUserID, [MarshalAs(UnmanagedType.BStr)] string sAccNo);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(14)]
        int CommRemoveJumunChe([MarshalAs(UnmanagedType.BStr)] string sUserID, [MarshalAs(UnmanagedType.BStr)] string sAccNo);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(15)]
        int CommJumunSvr([MarshalAs(UnmanagedType.BStr)] string sTrCode, [MarshalAs(UnmanagedType.BStr)] string sInputData);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(16)]
        int CommAccInfo();

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(17)]
        int CommMiCheFoForAcc([MarshalAs(UnmanagedType.BStr)] string sAcctNo, [MarshalAs(UnmanagedType.BStr)] string sAcctPw);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(18)]
        int Transact(int hWnd, int nTRID, [MarshalAs(UnmanagedType.BStr)] string sTrCode, [MarshalAs(UnmanagedType.BStr)] string sInput, int nInput, int nHeadType, int nAccountIndex);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(19)]
        int Attach(int hWnd, [MarshalAs(UnmanagedType.BStr)] string szBCType, [MarshalAs(UnmanagedType.BStr)] string szInput, int nCodeLen, int nInputLen);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(20)]
        int Detach(int hWnd, [MarshalAs(UnmanagedType.BStr)] string szBCType, [MarshalAs(UnmanagedType.BStr)] string szInput, int nCodeLen, int nInputLen);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(21)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetDealNo([MarshalAs(UnmanagedType.BStr)] string sAcctNo);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(22)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetHWOrdPrice([MarshalAs(UnmanagedType.BStr)] string sSeries, [MarshalAs(UnmanagedType.BStr)] string sPrice, int nType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(23)]
        void CommSetOCXPath([MarshalAs(UnmanagedType.BStr)] string szOCXPath);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(24)]
        void CommReqMstInfo([MarshalAs(UnmanagedType.BStr)] string szExchCd);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(25)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetHWInfo([MarshalAs(UnmanagedType.BStr)] string sSeries, int nInfo);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(26)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetAccInfo();

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(27)]
        void CommReqMakeCod([MarshalAs(UnmanagedType.BStr)] string strParam, int nMstType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(28)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetNextKey(int nRqId, [MarshalAs(UnmanagedType.BStr)] string sReserved);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(29)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetBusinessDay(int nJangubun);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(30)]
        [return: MarshalAs(UnmanagedType.BStr)]
        string CommGetInfo([MarshalAs(UnmanagedType.BStr)] string sTag, [MarshalAs(UnmanagedType.BStr)] string sParam);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(31)]
        [return: MarshalAs(UnmanagedType.Struct)]
        object CommGetDataBinary([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType, int nOffset, int nLength, int nPointLength, [MarshalAs(UnmanagedType.BStr)] string sDataType);
    }


    [ComImport]
    [InterfaceType(2)]
    [Guid("84018D6A-BEEE-4719-8826-89D23825892F")]
    public interface _DHDFCommAgentEvents
    {
        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(1)]
        void OnGetData(int nType, int wParam, int lParam);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(2)]
        void OnRealData(int nType, int wParam, int lParam);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(3)]
        void OnDataRecv([MarshalAs(UnmanagedType.BStr)] string sTrCode, int nRqId);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(4)]
        void OnGetBroadData([MarshalAs(UnmanagedType.BStr)] string sJongmokCode, int nRealType);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(5)]
        void OnGetMsg([MarshalAs(UnmanagedType.BStr)] string sCode, [MarshalAs(UnmanagedType.BStr)] string sMsg);

        [MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
        [DispId(6)]
        void OnGetMsgWithRqId(int nRqId, [MarshalAs(UnmanagedType.BStr)] string sCode, [MarshalAs(UnmanagedType.BStr)] string sMsg);
    }

    public class _DHDFCommAgentEvents_OnDataRecvEvent(string sTrCode, int nRqId) : EventArgs
    {
        public string sTrCode = sTrCode;
        public int nRqId = nRqId;
    }
    public class _DHDFCommAgentEvents_OnGetBroadDataEvent(string sJongmokCode, int nRealType) : EventArgs
    {
        public string sJongmokCode = sJongmokCode;
        public int nRealType = nRealType;
    }
    public class _DHDFCommAgentEvents_OnGetDataEvent(int nType, int wParam, int lParam) : EventArgs
    {
        public int nType = nType;
        public int wParam = wParam;
        public int lParam = lParam;
    }
    public class _DHDFCommAgentEvents_OnGetMsgEvent(string sCode, string sMsg) : EventArgs
    {
        public string sCode = sCode;
        public string sMsg = sMsg;
    }
    public class _DHDFCommAgentEvents_OnGetMsgWithRqIdEvent(int nRqId, string sCode, string sMsg) : EventArgs
    {
        public int nRqId = nRqId;
        public string sCode = sCode;
        public string sMsg = sMsg;
    }
    public class _DHDFCommAgentEvents_OnRealDataEvent(int nType, int wParam, int lParam) : EventArgs
    {
        public int nType = nType;
        public int wParam = wParam;
        public int lParam = lParam;
    }

    public delegate void _DHDFCommAgentEvents_OnDataRecvEventHandler(object sender, _DHDFCommAgentEvents_OnDataRecvEvent e);
    public delegate void _DHDFCommAgentEvents_OnGetBroadDataEventHandler(object sender, _DHDFCommAgentEvents_OnGetBroadDataEvent e);
    public delegate void _DHDFCommAgentEvents_OnGetDataEventHandler(object sender, _DHDFCommAgentEvents_OnGetDataEvent e);
    public delegate void _DHDFCommAgentEvents_OnGetMsgEventHandler(object sender, _DHDFCommAgentEvents_OnGetMsgEvent e);
    public delegate void _DHDFCommAgentEvents_OnGetMsgWithRqIdEventHandler(object sender, _DHDFCommAgentEvents_OnGetMsgWithRqIdEvent e);
    public delegate void _DHDFCommAgentEvents_OnRealDataEventHandler(object sender, _DHDFCommAgentEvents_OnRealDataEvent e);


    [ClassInterface(ClassInterfaceType.None)]
    public class AxHDFCommAgentEventMulticaster(AxHDFCommAgent parent) : _DHDFCommAgentEvents
    {
        private readonly AxHDFCommAgent parent = parent;

        public virtual void OnGetData(int nType, int wParam, int lParam) => parent.RaiseOnOnGetData(parent, new(nType, wParam, lParam));

        public virtual void OnRealData(int nType, int wParam, int lParam) => parent.RaiseOnOnRealData(parent, new(nType, wParam, lParam));

        public virtual void OnDataRecv(string sTrCode, int nRqId) => parent.RaiseOnOnDataRecv(parent, new(sTrCode, nRqId));

        public virtual void OnGetBroadData(string sJongmokCode, int nRealType) => parent.RaiseOnOnGetBroadData(parent, new(sJongmokCode, nRealType));

        public virtual void OnGetMsg(string sCode, string sMsg) => parent.RaiseOnOnGetMsg(parent, new(sCode, sMsg));

        public virtual void OnGetMsgWithRqId(int nRqId, string sCode, string sMsg) => parent.RaiseOnOnGetMsgWithRqId(parent, new(nRqId, sCode, sMsg));
    }


    public class AxHDFCommAgent
    {
        public event _DHDFCommAgentEvents_OnGetDataEventHandler OnGetData;

        public event _DHDFCommAgentEvents_OnRealDataEventHandler OnRealData;

        public event _DHDFCommAgentEvents_OnDataRecvEventHandler OnDataRecv;

        public event _DHDFCommAgentEvents_OnGetBroadDataEventHandler OnGetBroadData;

        public event _DHDFCommAgentEvents_OnGetMsgEventHandler OnGetMsg;

        public event _DHDFCommAgentEvents_OnGetMsgWithRqIdEventHandler OnGetMsgWithRqId;

        internal void RaiseOnOnGetData(object sender, _DHDFCommAgentEvents_OnGetDataEvent e) => OnGetData?.Invoke(this, e);

        internal void RaiseOnOnRealData(object sender, _DHDFCommAgentEvents_OnRealDataEvent e) => OnRealData?.Invoke(this, e);

        internal void RaiseOnOnDataRecv(object sender, _DHDFCommAgentEvents_OnDataRecvEvent e) => OnDataRecv?.Invoke(this, e);

        internal void RaiseOnOnGetBroadData(object sender, _DHDFCommAgentEvents_OnGetBroadDataEvent e) => OnGetBroadData?.Invoke(this, e);

        internal void RaiseOnOnGetMsg(object sender, _DHDFCommAgentEvents_OnGetMsgEvent e) => OnGetMsg?.Invoke(this, e);

        internal void RaiseOnOnGetMsgWithRqId(object sender, _DHDFCommAgentEvents_OnGetMsgWithRqIdEvent e) => OnGetMsgWithRqId?.Invoke(this, e);

        //public virtual void AboutBox()
        //{
        //    if (ocx == null)
        //    {
        //        throw new InvalidActiveXStateException("AboutBox", ActiveXInvokeKind.MethodInvoke);
        //    }
        //    ocx.AboutBox();
        //}

        public virtual int CommInit(int nType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommInit", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommInit(nType);
        }

        public virtual void CommTerminate(int bSocketClose)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommTerminate", ActiveXInvokeKind.MethodInvoke);
            }
            ocx.CommTerminate(bSocketClose);
        }

        public virtual int CommLogin(string sUserID, string sPwd, string sCertPwd)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommLogin", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommLogin(sUserID, sPwd, sCertPwd);
        }

        public virtual int CommLogout(string sUserID)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommLogout", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommLogout(sUserID);
        }

        public virtual int CommRqData(string sTrCode, string sInputData, int nLength, string sPrevOrNext)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommRqData", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommRqData(sTrCode, sInputData, nLength, sPrevOrNext);
        }

        public virtual int CommSetBroad(string sJongmokCode, int nRealType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommSetBroad", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommSetBroad(sJongmokCode, nRealType);
        }

        public virtual int CommRemoveBroad(string sJongmokCode, int nRealType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommRemoveBroad", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommRemoveBroad(sJongmokCode, nRealType);
        }

        public virtual int CommGetRepeatCnt(string sJongmokCode, int nRealType, string sFieldName)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetRepeatCnt", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetRepeatCnt(sJongmokCode, nRealType, sFieldName);
        }

        public virtual string CommGetData(string sJongmokCode, int nRealType, string sFieldName, int nIndex, string sInnerFieldName)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetData", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetData(sJongmokCode, nRealType, sFieldName, nIndex, sInnerFieldName);
        }

        public virtual string CommGetDataDirect(string sJongmokCode, int nRealType, int nOffset, int nLength, int nPointLength, string sDataType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetDataDirect", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetDataDirect(sJongmokCode, nRealType, nOffset, nLength, nPointLength, sDataType);
        }

        public virtual int CommGetConnectState()
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetConnectState", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetConnectState();
        }

        public virtual int CommFIDRqData(string sFidCode, string sInputData, string sReqFidList, int nLength, string sPrevOrNext)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommFIDRqData", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommFIDRqData(sFidCode, sInputData, sReqFidList, nLength, sPrevOrNext);
        }

        public virtual int CommSetJumunChe(string sUserID, string sAccNo)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommSetJumunChe", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommSetJumunChe(sUserID, sAccNo);
        }

        public virtual int CommRemoveJumunChe(string sUserID, string sAccNo)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommRemoveJumunChe", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommRemoveJumunChe(sUserID, sAccNo);
        }

        public virtual int CommJumunSvr(string sTrCode, string sInputData)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommJumunSvr", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommJumunSvr(sTrCode, sInputData);
        }

        public virtual int CommAccInfo()
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommAccInfo", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommAccInfo();
        }

        public virtual int CommMiCheFoForAcc(string sAcctNo, string sAcctPw)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommMiCheFoForAcc", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommMiCheFoForAcc(sAcctNo, sAcctPw);
        }

        //public virtual int Transact(int hWnd, int nTRID, string sTrCode, string sInput, int nInput, int nHeadType, int nAccountIndex)
        //{
        //    if (ocx == null)
        //    {
        //        throw new InvalidActiveXStateException("Transact", ActiveXInvokeKind.MethodInvoke);
        //    }
        //    return ocx.Transact(hWnd, nTRID, sTrCode, sInput, nInput, nHeadType, nAccountIndex);
        //}

        //public virtual int Attach(int hWnd, string szBCType, string szInput, int nCodeLen, int nInputLen)
        //{
        //    if (ocx == null)
        //    {
        //        throw new InvalidActiveXStateException("Attach", ActiveXInvokeKind.MethodInvoke);
        //    }
        //    return ocx.Attach(hWnd, szBCType, szInput, nCodeLen, nInputLen);
        //}

        //public virtual int Detach(int hWnd, string szBCType, string szInput, int nCodeLen, int nInputLen)
        //{
        //    if (ocx == null)
        //    {
        //        throw new InvalidActiveXStateException("Detach", ActiveXInvokeKind.MethodInvoke);
        //    }
        //    return ocx.Detach(hWnd, szBCType, szInput, nCodeLen, nInputLen);
        //}

        public virtual string CommGetDealNo(string sAcctNo)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetDealNo", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetDealNo(sAcctNo);
        }

        public virtual string CommGetHWOrdPrice(string sSeries, string sPrice, int nType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetHWOrdPrice", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetHWOrdPrice(sSeries, sPrice, nType);
        }

        public virtual void CommSetOCXPath(string szOCXPath)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommSetOCXPath", ActiveXInvokeKind.MethodInvoke);
            }
            ocx.CommSetOCXPath(szOCXPath);
        }

        public virtual void CommReqMstInfo(string szExchCd)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommReqMstInfo", ActiveXInvokeKind.MethodInvoke);
            }
            ocx.CommReqMstInfo(szExchCd);
        }

        public virtual string CommGetHWInfo(string sSeries, int nInfo)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetHWInfo", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetHWInfo(sSeries, nInfo);
        }

        public virtual string CommGetAccInfo()
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetAccInfo", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetAccInfo();
        }

        public virtual void CommReqMakeCod(string strParam, int nMstType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommReqMakeCod", ActiveXInvokeKind.MethodInvoke);
            }
            ocx.CommReqMakeCod(strParam, nMstType);
        }

        public virtual string CommGetNextKey(int nRqId, string sReserved)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetNextKey", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetNextKey(nRqId, sReserved);
        }

        public virtual string CommGetBusinessDay(int nJangubun)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetBusinessDay", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetBusinessDay(nJangubun);
        }

        public virtual string CommGetInfo(string sTag, string sParam)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetInfo", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetInfo(sTag, sParam);
        }

        public virtual object CommGetDataBinary(string sJongmokCode, int nRealType, int nOffset, int nLength, int nPointLength, string sDataType)
        {
            if (ocx == null)
            {
                throw new InvalidActiveXStateException("CommGetDataBinary", ActiveXInvokeKind.MethodInvoke);
            }
            return ocx.CommGetDataBinary(sJongmokCode, nRealType, nOffset, nLength, nPointLength, sDataType);
        }

        public enum ActiveXInvokeKind
        {
            MethodInvoke,
            PropertyGet,
            PropertySet,
        }
        public class InvalidActiveXStateException(string name, ActiveXInvokeKind kind) : Exception
        {
            private readonly string name = name;
            private readonly ActiveXInvokeKind kind = kind;

            public override string ToString()
            {
                return kind switch
                {
                    ActiveXInvokeKind.MethodInvoke => string.Format("AXInvalidMethodInvoke {0}", name),
                    ActiveXInvokeKind.PropertyGet => string.Format("AXInvalidPropertyGet {0}", name),
                    ActiveXInvokeKind.PropertySet => string.Format("AXInvalidPropertySet {0}", name),
                    _ => base.ToString(),
                };
            }
        }

        [DllImport("Atl.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool AtlAxWinInit();
        [DllImport("Atl.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern int AtlAxGetControl(IntPtr h, [MarshalAs(UnmanagedType.IUnknown)] out object pp);
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern IntPtr CreateWindowEx(int dwExStyle, string lpClassName, string lpWindowName, int dwStyle, int x, int y, int nWidth, int nHeight, IntPtr hWndParent, IntPtr hMenu, IntPtr hInstance, IntPtr lpParam);
        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        private static extern bool DestroyWindow(IntPtr hWnd);
        [DllImport("kernel32.dll")]
        private static extern IntPtr GetConsoleWindow();

        private const int WS_VISIBLE = 0x10000000;
        private const int WS_CHILD = 0x40000000;

        private readonly IntPtr hWndContainer = IntPtr.Zero;

        private readonly _DHDFCommAgent ocx;
        private readonly System.Runtime.InteropServices.ComTypes.IConnectionPoint _pConnectionPoint;
        private readonly bool bInitialized = false;

        public bool Created => bInitialized;

        public AxHDFCommAgent(nint hWndParent = 0)
        {
            if (hWndParent == IntPtr.Zero)
            {
                hWndParent = Process.GetCurrentProcess().MainWindowHandle;
                if (hWndParent == IntPtr.Zero)
                {
                    hWndParent = GetConsoleWindow();
                }
            }

            string clsid = "{2a7b5bef-49ee-4219-9833-db04d07876cf}";

            if (AtlAxWinInit())
            {
                hWndContainer = CreateWindowEx(0, "AtlAxWin", clsid, WS_VISIBLE | WS_CHILD, -100, -100, 0, 0, hWndParent, (IntPtr)9003, IntPtr.Zero, IntPtr.Zero);
                if (hWndContainer != IntPtr.Zero)
                {
                    try
                    {
                        AtlAxGetControl(hWndContainer, out object pUnknown);
                        if (pUnknown != null)
                        {
                            ocx = (_DHDFCommAgent)pUnknown;
                            if (ocx != null)
                            {
                                Guid guidEvents = typeof(_DHDFCommAgentEvents).GUID;
                                System.Runtime.InteropServices.ComTypes.IConnectionPointContainer pConnectionPointContainer;
                                pConnectionPointContainer = (System.Runtime.InteropServices.ComTypes.IConnectionPointContainer)pUnknown;
                                pConnectionPointContainer.FindConnectionPoint(ref guidEvents, out _pConnectionPoint);
                                if (_pConnectionPoint != null)
                                {
                                    AxHDFCommAgentEventMulticaster pEventSink = new(this);
                                    _pConnectionPoint.Advise(pEventSink, out int nCookie);
                                    bInitialized = true;
                                }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        DestroyWindow(hWndContainer);
                        hWndContainer = IntPtr.Zero;
                    }
                }
            }
        }
    }
}
