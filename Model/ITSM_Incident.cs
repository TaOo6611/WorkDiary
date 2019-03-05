using System;

namespace WorkDiary.Model
{
    [Serializable]
    public class ITSM_Incident
    {
        public ITSM_Incident() { }

        public ITSM_Incident(string IncidentNo, string CreateDate, string DepartmentTree, 
            string DepartmentName, string ItilServiceTree, string ItilServiceName,
            string IncidentTitle, string IncidentDescription, string Process,
            string CurrentState, string AccountName)
        {
            this.IncidentNo = IncidentNo;
            this.CreateDate = CreateDate;
            this.DepartmentTree = DepartmentTree;
            this.DepartmentName = DepartmentName;
            this.ItilServiceTree = ItilServiceTree;
            this.ItilServiceName = ItilServiceName;
            this.IncidentTitle = IncidentTitle;
            this.IncidentDescription = IncidentDescription;
            this.Process = Process;
            this.CurrentState = CurrentState;
            this.AccountName = AccountName;
        }

        public string IncidentNo { get; set; }

        public string CreateDate { get; set; }

        public string DepartmentTree { get; set; }

        public string DepartmentName { get; set; }

        public string ItilServiceTree { get; set; }

        public string ItilServiceName { get; set; }

        public string IncidentTitle { get; set; }

        public string IncidentDescription { get; set; }

        public string Process { get; set; }

        public string CurrentState { get; set; }

        public string AccountName { get; set; }

    }
}
