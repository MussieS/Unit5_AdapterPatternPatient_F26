namespace Unit5_AdapterPatternPatient_Blazor.InsuranceSystem
{
    public class OutNetworkAdapter : InsuranceInterface
    {
        private OutNetworkPatient patient;

        public OutNetworkAdapter(string name, int policyNumber)
        {
            patient = new OutNetworkPatient(name, policyNumber);
        }

        public string getPatientName()
        {
            return patient.getPatientName();
        }

        public string getPolicyNumber()
        {
            return patient.PolicyNumber.ToString();
        }
        public decimal CoverageAmount(int ProcedureID, decimal ProcedureCost)
        {
            decimal percent = patient.CoveragePercent(ProcedureCost);

            decimal coverageAmount = percent * ProcedureCost;

            return coverageAmount;
        }
        public bool IsCovered(string patientName, string policyNumber)
        {
            int policyNum = int.Parse(policyNumber);

            string result = patient.IsCovered(patientName, policyNum);

            return result == "yes";
        }
    }
}