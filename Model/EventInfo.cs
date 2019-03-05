using System;

namespace WorkDiary.Model
{
    [Serializable]
    public class EventInfo
    {
        public EventInfo() { }

        public EventInfo(string eventid, string eventcontent, string eventstatus, string eventtype)
        {
            this.eventid = eventid;
            this.eventcontent = eventcontent;
            this.eventstatus = eventstatus;
            this.eventtype = eventtype;
        }

        public EventInfo(string eventid, string eventcontent, string eventstatus, string eventproject, string eventtype)
        {
            this.eventid = eventid;
            this.eventcontent = eventcontent;
            this.eventstatus = eventstatus;
            this.eventproject = eventproject;
            this.eventtype = eventtype;
        }

        public string eventid { get; set; }

        public string eventcontent { get; set; }

        public string eventstatus { get; set; }//计划；进行；终止；完成

        public string eventproject { get; set; }

        public string eventtype { get; set; }
    }
}
