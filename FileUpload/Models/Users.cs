using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FileUpload.Models
{
    public class Users
    {
        private string fullName;
        private string employeeId;
        private string benefitCode;

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string EmployeeId
        {
            get
            {
                return employeeId;
            }

            set
            {
                employeeId = value;
            }
        }

        public string BenefitCode
        {
            get
            {
                return benefitCode;
            }

            set
            {
                benefitCode = value;
            }
        }
    }
}