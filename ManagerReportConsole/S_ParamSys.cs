//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ManagerReportConsole
{
    using System;
    using System.Collections.Generic;
    
    public partial class S_ParamSys
    {
        public S_ParamSys()
        {
            this.L_FilesReportFormat = new HashSet<L_FilesReport>();
            this.L_FilesReportPlaceSaveSp = new HashSet<L_FilesReport>();
            this.L_ParamReportsType = new HashSet<L_ParamReports>();
            this.L_ParamReportsValueExp = new HashSet<L_ParamReports>();
            this.L_ParamReportsValueFormat = new HashSet<L_ParamReports>();
            this.L_ScheduleTypePeriod = new HashSet<L_Schedule>();
            this.L_ScheduleTypeSchedule = new HashSet<L_Schedule>();
            this.S_ParamSysParent = new HashSet<S_ParamSys>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_parent { get; set; }
        public string name { get; set; }
        public string sysname { get; set; }
        public Nullable<int> sort { get; set; }
        public string description { get; set; }
    
        public virtual ICollection<L_FilesReport> L_FilesReportFormat { get; set; }
        public virtual ICollection<L_FilesReport> L_FilesReportPlaceSaveSp { get; set; }
        public virtual ICollection<L_ParamReports> L_ParamReportsType { get; set; }
        public virtual ICollection<L_ParamReports> L_ParamReportsValueExp { get; set; }
        public virtual ICollection<L_ParamReports> L_ParamReportsValueFormat { get; set; }
        public virtual ICollection<L_Schedule> L_ScheduleTypePeriod { get; set; }
        public virtual ICollection<L_Schedule> L_ScheduleTypeSchedule { get; set; }
        public virtual ICollection<S_ParamSys> S_ParamSysParent { get; set; }
        public virtual S_ParamSys S_ParamSysParent2 { get; set; }
    }
}
