using System;

namespace LearAttribute
{
    [AttributeUsage(AttributeTargets.All)]
    public class RemarkAttribute : Attribute
    {
        private string pri_remark;
        public string Supplement;
        public int Priority { get; set; }

        public RemarkAttribute(string comment)
        {
            pri_remark = comment;
            Supplement = "none";
            Priority = 1;
        }

        public string Remark
        {
            get
            {
                return pri_remark;
            }
        }
    }
}
