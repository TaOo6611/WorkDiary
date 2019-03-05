using System;

namespace WorkDiary.Model
{
    [Serializable]
    public class RecordInfo
    {
        public RecordInfo() { }

        public RecordInfo(string recordid, string eventid, string record_content)
        {
            this.recordid = recordid;
            this.eventid = eventid;
            this.record_content = record_content;
        }

        public RecordInfo(string recordid, string eventid, string record_date, string record_content)
        {
            this.recordid = recordid;
            this.eventid = eventid;
            this.record_date = record_date;
            this.record_content = record_content;
        }

        public string recordid { get; set; }

        public string eventid { get; set; }

        public string record_date { get; set; }//格式：yyyyMMddHHmmss

        public string record_content { get; set; }
    }
}
