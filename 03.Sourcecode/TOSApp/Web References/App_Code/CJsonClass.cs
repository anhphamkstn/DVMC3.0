using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using IP.Core.IPCommon;
using IPCOREDS.CDBNames;

namespace TOSApp.App_Code
{
    // JoinQueue và RemoveQueue
    public class CJoinRemoveQueue
    {
        public CJoinRemoveQueueData Action { get; set; }
    }
    public class CJoinRemoveQueueData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string AgentCode { get; set; }
        public string QueueName { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    // PauseQueue
    public class CPauseQueue
    {
        public CPauseQueueData Action { get; set; }
    }
    public class CPauseQueueData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string AgentCode { get; set; }
        public string PauseCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    // UnPauseQueue
    public class CUnPauseQueue
    {
        public CUnPauseQueueData Action { get; set; }
    }
    public class CUnPauseQueueData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string AgentCode { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    // GetQueueMembers
    public class CQueueMembers
    {
        public string Queue { get; set; }
        public string Name { get; set; }
        public string CallsTaken { get; set; }
        public string LastCall { get; set; }
        public string Status { get; set; }
    }

    // GetRealTimeList
    public class CRealTimeListMembers
    {
        public List<object> listSupIncomingCalls { get; set; }
        public List<ListSupQueue> listSupQueues { get; set; }
        public List<ListSupQueueMember> listSupQueueMembers { get; set; }
    }
    public class ListSupQueue
    {
        public string Queue { get; set; }
        public string Setting { get; set; }
        public int NumberCurrentCalls { get; set; }
        public int TotalHoldTime { get; set; }
        public int TotalTalkTime { get; set; }
        public int NumberCompleteCalls { get; set; }
        public int NumberAbandonCalls { get; set; }
    }
    public class ListSupQueueMember
    {
        public string Queue { get; set; }
        public string Name { get; set; }
        public string SIP { get; set; }
        public string Penalty { get; set; }
        public int CallsTaken { get; set; }
        public string LastCall { get; set; }
        public bool IsPause { get; set; }
        public string Status { get; set; }
    }

    // RegisterToQueue
    public class CRegisterQueue
    {
        public CRegisterQueueData Action { get; set; }
    }
    public class CRegisterQueueData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string IpAddress { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    // UnRegisterQueue
    public class CUnRegisterQueue
    {
        public CUnRegisterQueueData Action { get; set; }
    }
    public class CUnRegisterQueueData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    // Add to blacklist
    public class CAddRemoveBlackList
    {
        public CAddRemoveBlackListData Action { get; set; }
    }
    public class CAddRemoveBlackListData
    {
        public string Event { get; set; }
        public string PhoneNumber { get; set; }
        public string Status { get; set; }
    }

    // Get incomming call
    public class CGetIncomingCallData
    {
        public string Event { get; set; }
        public string Extension { get; set; }
        public string Data { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
    }

    public class CGetIncomingCall
    {
        public CGetIncomingCallData Action { get; set; }
    }
}