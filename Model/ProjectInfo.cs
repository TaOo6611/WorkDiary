using System;

namespace WorkDiary.Model
{
    [Serializable]
    public class ProjectInfo
    {
        public ProjectInfo() { }

        public ProjectInfo(string projectid, string projectname, string projectnamepy, string projectdesc, string projectleader, string projectstatus)
        {
            this.projectid = projectid;
            this.projectname = projectname;
            this.projectnamepy = projectnamepy;
            this.projectdesc = projectdesc;
            this.projectleader = projectleader;
            this.projectstatus = projectstatus;
        }

        public string projectid { get; set; }

        public string projectname { get; set; }

        public string projectnamepy { get; set; }

        public string projectdesc { get; set; }

        public string projectleader { get; set; }

        public string projectstatus { get; set; }//立项；设计；执行；结束
    }
}
