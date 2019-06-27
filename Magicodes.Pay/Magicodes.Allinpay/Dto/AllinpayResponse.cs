﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Magicodes.Allinpay.Dto
{
    [Serializable]
    public class AllinpayResponse
    {
        [JsonProperty("retcode")]
        public string RetCode { get; set; }

        [JsonProperty("retmsg")]
        public AllinpayResponseDetail RetMsg { get; set; }
    }

    public class AllinpayResponseDetail
    {
        [JsonProperty("cusid")] public string RetCode { get; set; }

        [JsonProperty("appid")] public string RetMsg { get; set; }

        [JsonProperty("trxid")] public string TrxId { get; set; }

        [JsonProperty("chnltrxid")] public string ChnltrxId { get; set; }

        [JsonProperty("reqsn")] public string ReqSn { get; set; }

        [JsonProperty("randomstr")] public string RandomStr { get; set; }

        [JsonProperty("trxstatus")] public string TrxStatus { get; set; }

        [JsonProperty("fintime")] public string FinTime { get; set; }

        [JsonProperty("errmsg")] public string ErrMsg { get; set; }

        [JsonProperty("payinfo")] public string PayInfo { get; set; }

        [JsonProperty("sign")] public string Sign { get; set; }
    }
}
