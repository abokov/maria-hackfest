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
    
    public partial class S_ParamDirectory
    {
        public S_ParamDirectory()
        {
            this.L_ParamReportsValueDirectory = new HashSet<L_ParamReports>();
            this.S_ParamDirectoryParent = new HashSet<S_ParamDirectory>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_parent { get; set; }
        public int id_direct { get; set; }
        public string name { get; set; }
        public string sysname { get; set; }
        public string email { get; set; }
        public Nullable<int> sort { get; set; }
        public string description { get; set; }
        public bool active { get; set; }
        public Nullable<System.DateTime> date_create { get; set; }
        public string who_create { get; set; }
    
        public virtual ICollection<L_ParamReports> L_ParamReportsValueDirectory { get; set; }
        public virtual ICollection<S_ParamDirectory> S_ParamDirectoryParent { get; set; }
        public virtual S_ParamDirectory S_ParamDirectoryParent2 { get; set; }
    }
}
